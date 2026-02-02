using FlatFinder.Api.Models;
using FlatFinder.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlatFinder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly SearchParserService _parser = new();
        private readonly SearchLinkBuilder _builder = new();

        [HttpPost]
        public IActionResult Search([FromBody] SearchRequest request)
        {
            var parsed = _parser.Parse(request.Text);
            parsed.Links = _builder.Build(parsed);

            return Ok(parsed);
        }
    }
}
