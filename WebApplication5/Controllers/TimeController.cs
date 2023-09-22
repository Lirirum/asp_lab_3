using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [Controller]
    public class TimeController : Controller
    {
        private readonly TimeOfDayService _timeOfDayService;

        public TimeController(TimeOfDayService timeOfDayService)
        {
            _timeOfDayService = timeOfDayService;
        }

        [HttpGet("get_time")]
        public ActionResult<string> GetCurrentTimeOfDay()
        {
            var timeOfDay = _timeOfDayService.GetTimeOfDay() ;
            return Ok(timeOfDay);
        }
    }
}
