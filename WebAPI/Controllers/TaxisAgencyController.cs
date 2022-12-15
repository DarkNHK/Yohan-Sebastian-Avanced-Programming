using Microsoft.AspNetCore.Mvc;
using Lab_1;
using Repository;
using System.Net;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxisAgencyController : ControllerBase
    {
        private readonly ILogger<TaxisAgencyController> _logger;

        private readonly ITaxiRepository _taxiRepository;

        public TaxisAgencyController(ILogger<TaxisAgencyController> logger, ITaxiRepository taxiRepository)
        {
            _logger = logger;
            _taxiRepository = taxiRepository;
        }

        [HttpPost("PostTaxi/{entry},{rate},{kilometers},{name},{Id}", Name = "PostTaxi")]
        public ActionResult<Taxi> PostTaxi(string name, int entry, float rate, float kilometers, int Id)
        {
            _taxiRepository.BeginTransaction();
            var taxi = _taxiRepository.CreateTaxi( rate, kilometers, entry, name, Id);
            _taxiRepository.CommitTransaction();
            if (taxi == null)
            {
                _logger.LogError($"{nameof(TaxisAgencyController.PostTaxi)} -> cannot create taxi");
                return NotFound();
            }
            return taxi;
        }

        [HttpGet("GetTaxis", Name = "GetTaxis")]
        public ActionResult<IEnumerable<Taxi>> GetTaxi()
        {
            _taxiRepository.BeginTransaction();
            var taxi = _taxiRepository.GetTaxis();
            _taxiRepository.CommitTransaction();
            if (taxi == null)
            {
                _logger.LogError($"{nameof(TaxisAgencyController.GetTaxi)} -> taxi not found");
                return NotFound();
            }
            return taxi;
        }

        [HttpGet("GetTaxi/{Id}", Name = "GetTaxi")]
        public ActionResult<Taxi> GetWorker(int id)
        {
            _taxiRepository.BeginTransaction();
            var taxi = _taxiRepository.GetTaxi(id);
            _taxiRepository.CommitTransaction();
            if (taxi == null)
            {
                _logger.LogError($"{nameof(TaxisAgencyController.GetWorker)} -> taxi not found");
                return NotFound();
            }
            return taxi;
        }

    }
}