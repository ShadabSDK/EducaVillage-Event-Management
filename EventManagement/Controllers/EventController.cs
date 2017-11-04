using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EventManagement.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            var events = GetEvents();
            return View(events);
        }

        //Get Event/Details
        public ActionResult Details(int id)
        {
            var eventData = GetEvents().SingleOrDefault(e => e.Id == id);
            
            if (eventData == null)
                return HttpNotFound();
            return View(eventData);
        }

        private IEnumerable<Event> GetEvents()
        {
            return new List<Event>
            {
                new Event { Id=1,Name="Introduction to C#",EventDate= DateTime.UtcNow },
                new Event { Id=2,Name="Get Started Mobility",EventDate= DateTime.UtcNow }
            };
        }

        //Redirect to URL
        public RedirectResult RedirectToOtherSite()
        {
            return Redirect("http://google.com");
        }

        //Why its not working
        //public RedirectToRouteResult RedirectRoute()
        //{
        //   // return RedirectToRoute("Default")

        //}


        public RedirectToRouteResult RedirecToAction()
        {
            //return RedirectToAction("Index");
            return RedirectToAction("Details");
            //return RedirectToAction("Details", new { eventID=10 });
        }

        public FileResult ViewFile()
        {
            return File(Url.Content("~/Files/testfile.txt"), "text/plain");
        }

        public FileResult FileBytes()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Files/testfile.txt"));
            return File(fileBytes, "text/plain");
        }

        public FileResult DownloadFile()
        {
            return File(Url.Content("~/Files/testfile.txt"), "text/plain", "testFile.txt");
        }

        public ContentResult Content()
        {
            //return Content("<h3>Here's a custom content header</h3>", "text/html");
            return Content("<h3>Here's a custom content header</h3>", "text/plain");
            //return "<h3>Here's a custom content header</h3>";
        }

        //Status Result...
        //HttpStatusCodeResult
        public HttpStatusCodeResult UnauthorizedStatusCode()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized, "You are not authorized to access this controller action.");
        }

        public HttpStatusCodeResult BadGateway()
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "I have no idea what this error means.");
        }

        public HttpStatusCodeResult UnauthorizedResult()
        {
            return new HttpUnauthorizedResult("You are not authorized to access this controller action.");
        }

        public HttpNotFoundResult NotFound()
        {
            return HttpNotFound("We didn't find that action, sorry!");
        }

    }
}