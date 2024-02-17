using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using EventManagement.Models.NewFolder;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EventManagement.Entities;
using System.Data.Entity;
namespace EventManagement.Controllers
{
    public class EventController : Controller
    {

        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;

        public EventController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
            var events = _databaseContext.events.ToList();
            return View(events);
        }


        [HttpPost]
        public async Task<IActionResult> EventCreate(EventModel model)
        {
            var existingEvent = await _databaseContext.model.FirstOrDefaultAsync(e =>
                e.Caption == model.Caption &&
                e.Description == model.Description &&
                e.Location == model.Location &&
                e.Date == model.Date &&
                e.EventImg == model.EventImg
            );

            if (existingEvent != null)
            {
                //
            }
            else
            {
                _databaseContext.EventModel.Add(model);
                await _databaseContext.SaveChangesAsync();
            }

            return RedirectToAction("Index"); // Index sayfasına yönlendir
        }

        public async Task<IActionResult> EventList()
        {
            List<Event> events = await context.Events.ToListAsync();
            return View(events);
        }
        

        public IActionResult EventCreate()
        {
            return View();
        }


    }


}
