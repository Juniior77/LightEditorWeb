using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LightEditorWeb.Models;

namespace LightEditorWeb.Controllers
{
    public class CreateController : Controller
    {
        InfoFixture myInfoFix = new InfoFixture();
        InfoChannel myInfoCha = new InfoChannel();

        // GET: Create
        public ActionResult Index()
        {
            return View(myInfoFix);
        }
        public ActionResult InformationChannel(InfoFixture dataInfoFixture)
        {
            myInfoFix = dataInfoFixture;
            return View(myInfoCha);
        }
        public ActionResult InformationValue()
        {
            return View();
        }
    }
}