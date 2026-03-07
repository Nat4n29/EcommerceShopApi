using EcommerceAPI.Context;
using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace EcommerceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DayResumeController : ControllerBase
    {
        readonly private AppDbContext _context;

        public DayResumeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DayResume>> Get(int year)
        {
            var dayResumes = _context.DaysResume.AsNoTracking().Where(x => x.DayMonthResume.Year == year).ToList();
            if (dayResumes is null)
            {
                return NotFound("DayResumes not found!");
            }

            return dayResumes;
        }

        [HttpGet("{id:int}", Name = "FindDayResume")]
        public ActionResult<DayResume> GetDayResume(int id)
        {
            var dayResume = _context.DaysResume.AsNoTracking().FirstOrDefault(x => x.DayResumeId == id);
            if (dayResume is null)
            {
                return NotFound("MonthResume not found!");
            }

            return dayResume;
        }

        //----------------------------------------------------------------------

        [HttpPost]
        public ActionResult Post(DayResume dayResume)
        {
            if (dayResume is null)
                return BadRequest();

            _context.DaysResume.Add(dayResume);
            _context.SaveChanges();

            return new CreatedAtRouteResult("FindDayResume", new { id = dayResume.DayResumeId }, dayResume);
        }

        //----------------------------------------------------------------------

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, DayResume dayResume)
        {
            if (id != dayResume.DayResumeId)
            {
                return BadRequest("The Id intered is different from the DayResume Id!");
            }

            _context.Entry(dayResume).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok($"The DayResume of ID:{id} was successfully modified!" + dayResume);
        }

        //----------------------------------------------------------------------

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var dayResume = _context.DaysResume.FirstOrDefault(x => x.DayResumeId == id);

            if (dayResume is null)
            {
                return NotFound("DayResume not found!");
            }

            _context.DaysResume.Remove(dayResume);
            _context.SaveChanges();

            return Ok("The DayResume has been deleted: " + dayResume);
        }
    }
}
