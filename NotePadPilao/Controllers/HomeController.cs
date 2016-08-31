using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;

namespace NotePadPilao.Controllers
{
    public class NotepadResult
    {
        public string Content { get; set; }
    }
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var content = System.IO.File.ReadAllText(GlobalVariables.Path);
            return View(new NotepadResult() { Content = content });
        }
        public ActionResult Write()
        {
            var content = System.IO.File.ReadAllText(GlobalVariables.Path);
            return View(new NotepadResult() { Content = content });
        }

    }
}
