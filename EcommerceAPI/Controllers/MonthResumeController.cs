using EcommerceAPI.Context;
using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MonthResumeController : ControllerBase
    {
        readonly private AppDbContext _context;

        public MonthResumeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("Orders")]
        public ActionResult<IEnumerable<MonthResume>> GetMonthResumeOrders(int year)
        {
            return _context.MonthsResume.Include(x => x.MonthOrders).AsNoTracking().Where(x => x.Year == year).ToList();
        }

        [HttpGet("DayResumes")]
        public ActionResult<IEnumerable<MonthResume>> GetMonthResumeDays()
        {
            return _context.MonthsResume.Include(x => x.MonthDaysResume).AsNoTracking().ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<MonthResume>> Get()
        {
            var monthResumes = _context.MonthsResume.AsNoTracking().ToList();
            if (monthResumes is null)
            {
                return NotFound("MonthResumes not found!");
            }

            return monthResumes;
        }

        [HttpGet("{id:int}", Name = "FindMonthResume")]
        public ActionResult<MonthResume> Get(int id)
        {
            var monthResume = _context.MonthsResume.AsNoTracking().FirstOrDefault(x => x.MonthResumeId == id);
            if (monthResume is null)
            {
                return NotFound("MonthResume not found!");
            }

            return monthResume;
        }

        //----------------------------------------------------------------------

        [HttpPost]
        public ActionResult Post(MonthResume monthResume)
        {
            if (monthResume is null)
                return BadRequest();

            _context.MonthsResume.Add(monthResume);
            _context.SaveChanges();

            return new CreatedAtRouteResult("FindMonthResume", new { id = monthResume.MonthResumeId }, monthResume);
        }

        //----------------------------------------------------------------------


        [HttpPut("{id:int}")]
        public ActionResult Put(int id, MonthResume monthResume)
        {
            if (id != monthResume.MonthResumeId)
            {
                return BadRequest("The Id intered is different from the MonthResume Id!");
            }

            _context.Entry(monthResume).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok($"The Month Resume of ID:{id} was successfully modified! " + monthResume);
        }

        //----------------------------------------------------------------------

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var monthResume = _context.MonthsResume.FirstOrDefault(x => x.MonthResumeId == id);

            if (monthResume is null)
            {
                return NotFound("MonthResume not found!");
            }

            _context.MonthsResume.Remove(monthResume);
            _context.SaveChanges();

            return Ok("The MonthResume has been deleted: " + monthResume);
        }
    }
}
