using System.Text.Json;
using System.Text.RegularExpressions;
using FlatFinder.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlatFinder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private static readonly object _lock = new();
        private static readonly string DataDir =
            Path.Combine(AppContext.BaseDirectory, "data");

        private static readonly string FilePath =
            Path.Combine(DataDir, "visits.log");

        [HttpPost]
        public IActionResult Track([FromBody] TrackRequest req)
        {
            try
            {

                var ua = Request.Headers["User-Agent"].ToString();
                var ip = HttpContext.Connection.RemoteIpAddress?.ToString();

                // ❌ не считаем localhost
                if (ip == "127.0.0.1" || ip == "::1")
                    return Ok();

                var visit = new VisitLog
                {
                    Time = DateTime.UtcNow,
                    Ip = ip,
                    UserAgent = ua,
                    Device = ua.Contains("Mobile") ? "Mobile" : "Desktop",
                    DeviceModel = DetectDeviceModel(ua), // 👈 ВОТ СЮДА
                    Browser =
                    ua.Contains("Chrome") ? "Chrome" :
                    ua.Contains("Firefox") ? "Firefox" :
                    ua.Contains("Safari") ? "Safari" : "Other",
                    Path = req.Path,
                    Referrer = req.Referrer,
                    Screen = req.Screen,
                    Language = req.Language
                };


                var json = JsonSerializer.Serialize(visit);

                lock (_lock)
                {
                    Directory.CreateDirectory(DataDir);
                    System.IO.File.AppendAllText(
                        FilePath,
                        json + Environment.NewLine
                    );
                }

                return Ok();
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(
      Path.Combine(Path.GetTempPath(), "track_error.log"),
      ex.ToString() + "\n\n"
  );
                return Ok();
              
            }
        }

        // 📊 простая статистика
        [HttpGet("stats")]
        public IActionResult Stats()
        {
            if (!System.IO.File.Exists(FilePath))
                return Ok(new { total = 0 });

            var lines = System.IO.File.ReadAllLines(FilePath);

            var visits = lines
                .Select(l => JsonSerializer.Deserialize<VisitLog>(l))
                .Where(v => v != null)
                .ToList();

            var today = DateTime.UtcNow.Date;

            return Ok(new
            {
                total = visits.Count,
                today = visits.Count(v => v.Time.Date == today),
                mobile = visits.Count(v => v.Device == "Mobile"),
                desktop = visits.Count(v => v.Device == "Desktop"),
                topPages = visits
                    .GroupBy(v => v.Path)
                    .OrderByDescending(g => g.Count())
                    .Take(5)
                    .Select(g => new
                    {
                        page = g.Key,
                        count = g.Count()
                    })
            });
        }
        [HttpGet("logs")]
        public IActionResult GetLogs(int take = 50)
        {
            if (!System.IO.File.Exists(FilePath))
                return Ok(Array.Empty<object>());

            var lines = System.IO.File
                .ReadAllLines(FilePath)
                .Reverse()
                .Take(take)
                .Select(l => JsonSerializer.Deserialize<VisitLog>(l))
                .Where(v => v != null);

            return Ok(lines);
        }
        private static string DetectDeviceModel(string ua)
        {
            if (string.IsNullOrEmpty(ua))
                return "Unknown";

            // iPhone
            if (ua.Contains("iPhone"))
                return "iPhone";

            // Samsung
            var samsung = Regex.Match(ua, @"SM-[A-Z0-9]+");
            if (samsung.Success)
                return samsung.Value;

            // Xiaomi / Redmi
            var xiaomi = Regex.Match(ua, @"Redmi\s?[A-Z0-9\s]+|Mi\s?[A-Z0-9\s]+");
            if (xiaomi.Success)
                return xiaomi.Value.Trim();

            // Huawei
            var huawei = Regex.Match(ua, @"HUAWEI\s?[A-Z0-9\-]+");
            if (huawei.Success)
                return huawei.Value;

            return "Unknown";
        }
    }
}
