using Microsoft.AspNetCore.Mvc;
using SemanticVersioningMinor.Repositories;

namespace SemanticVersioningMinor.Controllers
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

        [HttpGet]
        [Route("NewName")]
        public IActionResult GetNewCatName()
        {
            return Ok(_catsRepository.GetNewName());
        }
    }
}
