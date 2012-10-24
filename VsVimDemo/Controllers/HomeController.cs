using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VsVimDemo.Controllers
{
    public class HomeController : Controller
    {
        // text mode and insert mode
        //  * insert for typing, 
        //  * normal for commands
        //  * a or i to enter insert mode
        //  * ESC to get back
        //  * It WILL DRIVE YOU NUTS.

       // First, here is how to turn it off. :)  Ctrl+Shift+F12
        
        // Second, print out this cheet sheet: http://bit.ly/77Xh  (just google vim cheat sheet)

        public ActionResult Index()
        {
            // Common scenarios that text editors do not handle well

            // you're inside *something*, and you want to change it.

            // inside a name
            var foo = DateTime.Now.ToShortDateString(); // ciw

            // inside a string
            if (true)
            {
                ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application."; // ci"

                // inside an indexer ci[
                ViewBag["stuffkey"] = Stuff(1,3,"stuff"); // or param list ci(

            } // or the whole block  ci{

            return View();
        }

        public ActionResult About()
        {
            // Moving around

            // You're done, but the cursor is in the middle of a line   o (and Shift o)
            ViewBag.Message = "Your app <cursor>description page.";

            // Navigate 'words' effectively  w e b
            ModelState.AddModelError("", "The user name or password provided is incorrect.");

            return View();
        }

        public ActionResult Contact()
        {
            // Repeating your self - automate repetition
            // Auto records all activity up until exiting insert mode
            ViewBag.BlargMessage = "Your contact page.";
            ViewBag.BlargType= "Your contact page.";
            ViewBag.BlargZip = "Your contact page.";
            ViewBag.BlargPhone = "Your contact page.";

            return View();
        }

        private object Stuff(int i, int i1, string stuff)
        {
            return new object();    
        }
    }
}
