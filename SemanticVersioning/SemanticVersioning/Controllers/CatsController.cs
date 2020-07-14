using Microsoft.AspNetCore.Mvc;
using SemanticVersioning.Repositories;

namespace SemanticVersioning.Controllers
{
    [ApiController]
    [Route("cats")]
    public class CatsController : ControllerBase
    {
        private readonly CatsRepository _catsRepository;

        public CatsController()
        {
            _catsRepository = new CatsRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_catsRepository.GetCats());
        }

        [HttpGet]
        [Route("{catName}")]
        public IActionResult GetNamedCat(string catName)
        {
            return Ok(_catsRepository.GetCat(catName));
        }
    }
}
