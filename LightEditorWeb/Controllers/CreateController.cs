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
        static InfoFixture myInfoFix = new InfoFixture();
        InfoChannel myInfoCha = new InfoChannel();
        static bool first = true;
        // GET: Create
        public ActionResult Index()
        {

            return View(myInfoFix);
        }
        
        public ActionResult InformationChannel(InfoFixture dataInfoFixture)
        {
            if (first == true)
            {
                myInfoFix = dataInfoFixture;
                first = false;
            }
            
            return View(myInfoFix);
            
        }

  
        public ActionResult InformationValue()
        {
            return View();
        }
        public PartialViewResult rgb()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "RGB", image = "/Content/images/icon/RGB.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult cym()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "CYM", image = "/Content/images/icon/CYM.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult extraColor()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Extra Color", image = "/Content/images/icon/ExtraColor.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult dimmer()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Dimmer", image = "/Content/images/icon/Dimmer.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult panTilt()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Pan / Tilt", image = "/Content/images/icon/PanTilt.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult goboWheel()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Gobo Wheel", image = "/Content/images/icon/GoboWheel.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult goboWheelRotation()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Gobo Wheel Rotation", image = "/Content/images/icon/GoboWheelTurn.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult colorWheel()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Color Wheel", image = "/Content/images/icon/GoboColor.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult colorWheelRotation()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Color Wheel Rotation", image = "/Content/images/icon/GoboColorTurn.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult shutter()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Shutter", image = "/Content/images/icon/Shutter.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult goboRotation()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Gobo Rotation", image = "/Content/images/icon/GoboRot.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult goboIndex()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Gobo Index", image = "/Content/images/icon/GoboIndex.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult goboShake()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Gobo Shake", image = "/Content/images/icon/GoboShake.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult goboBounce()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Gobo Bounce", image = "/Content/images/icon/GoboBounce.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult iris()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Iris", image = "/Content/images/icon/Iris.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult zoom()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Zoom", image = "/Content/images/icon/Zoom.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult mfocus()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Focus", image = "/Content/images/icon/Focus.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult frost()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Frost", image = "/Content/images/icon/Frost.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult speed()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Speed", image = "/Content/images/icon/Speed.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult lamp()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Lamp", image = "/Content/images/icon/Lampe.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult prism()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Prism", image = "/Content/images/icon/Prism.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult prismRotation()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Prism Rotation", image = "/Content/images/icon/PrismRot.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult prismIndex()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Prism Index", image = "/Content/images/icon/PrismIndex.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult filtre()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Filter", image = "/Content/images/icon/Filtre.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult barrelRoll()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Barrel Roll", image = "/Content/images/icon/BarrelRol.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult barrelPan()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Barrel Pan", image = "/Content/images/icon/BarrelPan.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult fog()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Fog", image = "/Content/images/icon/Fog.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult framingBladeWheel()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Framing Blade Wheel", image = "/Content/images/icon/FramingBladeWheel.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult framingBladeRotation()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Framing Blade Rotation", image = "/Content/images/icon/FramingBladeWheelRot.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult framingBladeMovement()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Framing Blade Movement", image = "/Content/images/icon/FramingBladeMovement.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult animationWheel()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Animation Wheel", image = "/Content/images/icon/AnimationWheel.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult other()
        {
            myInfoFix.listFonction.Add(new itemFonctionFixture { fonction = "Other", image = "/Content/images/icon/Other.png" });
            return PartialView("InformationChannelPartial", myInfoFix);
        }
        public PartialViewResult deleteFonction(int fonction)
        {
            myInfoFix.listFonction.RemoveAt(fonction);
            return PartialView("InformationChannelPartial", myInfoFix);
        }
    }
}