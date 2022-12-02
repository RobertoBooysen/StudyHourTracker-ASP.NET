using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PROG6212_POE_Web_Application.Models;
using System.Linq;
using Class_Library_POE_Web_Application;

namespace PROG6212_POE_Web_Application.Controllers
{
    public class ChartsController : Controller
    {
        //Connection to database(Troeslen & Japikse, 2021)
        PROG6212_POE_PART_TWOContext db = new PROG6212_POE_PART_TWOContext();
        //Chart to display the self study hours to the users to visually show what modules require more study time(CanvaJS, 2017)
        public ActionResult ChartOfSelfStudyHours()
        {
            try
            {
                //Viewbag with LINQ statement so users only see their own data on the chart and not the data of other users(Troeslen & Japikse, 2021)
                ViewBag.DataPoints = JsonConvert.SerializeObject(db.TblModules.Where(ur => ur.Username.Equals(DisplayUsername.passUsername)).ToList(), _jsonSetting);

                return View();
            }
            catch
            {
                return View("Error in displaying data!");
            }
        }
        //Chart to display the number of study hours to the users to visually show what on what module they've worked the longest(CanvaJS, 2017)
        public ActionResult ChartOfRemainingSelfStudyHours()
        {
            try
            {
                //Viewbag with LINQ statement so users only see their own data on the chart and not the data of other users(Troeslen & Japikse, 2021)
                ViewBag.DataPoints2 = JsonConvert.SerializeObject(db.TblRemainingStudyHours.Where(ur => ur.Username.Equals(DisplayUsername.passUsername)).ToList(), _jsonSetting);

                return View();
            }
            catch
            {
                return View("Error in displaying data!");
            }
        }
        JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
    }
}
