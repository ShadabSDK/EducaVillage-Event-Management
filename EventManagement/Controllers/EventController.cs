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
        public string Index()
        {
            return "Hello I am in Event.Index()";
            //return Content("Hello I am in Event.Index() ","JSON");
        }

        //Get Event/Details
        public string Details(int eventID)
        {
            string message = HttpUtility.HtmlEncode("Hello I am in Event.Details() " + eventID);
            return message;
            //return Content("Hello I am in Event.Details() ","JSON");
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