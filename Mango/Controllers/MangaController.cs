using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mango.Controllers
{
    public class MangaController : Controller
    {
        // GET: Manga
        public ActionResult MangaDetails()
        {
            return View();
        }

        public ActionResult ReadManga()
        {
            return View();
        }
    }
}