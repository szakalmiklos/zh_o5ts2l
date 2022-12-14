using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_app.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        [Route("day/all")]
        public IActionResult Dayall()
        {
            Models.StudiesContext context = new Models.StudiesContext();
            var napok = from x in context.Day
                        select x;
            return Ok(napok);
        }

        [HttpGet]
        [Route("day/{id}")]
        public IActionResult Dayid(int id)
        {
            Models.StudiesContext context = new Models.StudiesContext();
            var napok = ( from x in context.Day
                         where x.DayId == id
                        select x).FirstOrDefault();
            return Ok(napok);
        }

        [HttpGet]
        [Route("room/{id}")]
        public IActionResult Roomid(int id)
        {
            Models.StudiesContext context = new Models.StudiesContext();
            var termek = (from x in context.Room
                         where x.RoomSk == id
                         select x).FirstOrDefault();
            return Ok(termek);
        }

        [HttpPost]
        [Route("day/add")]
        public void Post([FromBody] Models.Day újnap)
        {
            Models.StudiesContext context = new Models.StudiesContext();
            context.Day.Add(újnap);
            context.SaveChanges();
        }

        [HttpDelete]
        [Route("day/delete/{id}")]
        public void Delete(int id)
        {
            Models.StudiesContext context = new Models.StudiesContext();
            var törlendő = (from x in context.Day
                           where x.DayId == id
                           select x).FirstOrDefault();

            context.Day.Remove(törlendő);
            context.SaveChanges();
        }
    }
}
