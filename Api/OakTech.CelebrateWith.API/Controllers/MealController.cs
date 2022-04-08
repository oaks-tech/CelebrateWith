using Microsoft.AspNetCore.Mvc;
using OakTech.CelebrateWith.Data.Entities.Food;
using OakTech.CelebrateWith.Data.Repositories;

namespace OakTech.CelebrateWith.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MealController : ControllerBase
    {
        private readonly ILogger<MealController> _logger;
        private readonly IRepository<Starter> _starterRepository;
        private readonly IRepository<Main> _mainRepository;
        private readonly IRepository<Desert> _desertRepository;

        public MealController(
            ILogger<MealController> logger,
            IRepository<Starter> starterRepository,
            IRepository<Main> mainRepository,
            IRepository<Desert> desertRepository)
        {
            _logger = logger;
            _starterRepository = starterRepository;
            _mainRepository = mainRepository;
            _desertRepository = desertRepository;
        }

        [HttpGet(Name = "Starters")]
        public IEnumerable<Starter> GetStarters() =>  _starterRepository.GetAll();

        [HttpGet(Name = "Mains")]
        public IEnumerable<Main> GetMains() => _mainRepository.GetAll();
        
        [HttpGet(Name = "Deserts")]
        public IEnumerable<Desert> GetDeserts() => _desertRepository.GetAll();
    }
}
