using System.Collections.Generic;
using System.Linq;
using api.Models.EntityModel.Searches;
using api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : Controller
    {
        private readonly ISearchRepository _searchRepository;


        public SearchController(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }

        // GET api/Search/List
        [HttpGet, Route("list")]
        public IEnumerable<Search> Get()
        {
            return _searchRepository.GetAll().ToList();
        }

        // GET api/Search/List/5
        [HttpGet, Route("list/{id}")]
        public IActionResult Get(int id)
        {
            var searches = _searchRepository.GetAllPesquisas(id);

            if(searches == null)   
                return NotFound();


            return new ObjectResult(searches);
        }

        // GET api/Search/Create
        [HttpPost, Route("create")]
        public IActionResult Create([FromBody] Search search)
        {

            if (search == null)
                return BadRequest();

            _searchRepository.Add(search);

            return CreatedAtRoute("list", new {UserId = search.UserId}, search);
        }


    }
}