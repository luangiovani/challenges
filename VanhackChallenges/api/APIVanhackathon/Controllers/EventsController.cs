using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace APIVanhackathon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        [HttpGet]
        [Route("list")]
        public ActionResult Get()
        {
            var listEvents = new ListEvents().Events;
            return Ok(new { events = listEvents, highs = listEvents.Where(e => e.promoted == true).ToList() });
        }
    }
}