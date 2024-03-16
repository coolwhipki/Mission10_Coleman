using LetsBowl.BowlingLeague;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LetsBowl.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _repo;

        public BowlerController(IBowlerRepository temp) 
        {
            _repo = temp;            
        }
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var allYouNeed = _repo.GetAllBowlersWithTeams();
            return allYouNeed;
        }
    }

}

