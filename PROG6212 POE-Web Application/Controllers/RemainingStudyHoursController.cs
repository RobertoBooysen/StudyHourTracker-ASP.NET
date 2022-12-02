using Class_Library_POE_Web_Application;
using Microsoft.AspNetCore.Mvc;
using PROG6212_POE_Web_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG6212_POE_Web_Application.Controllers
{
    public class RemainingStudyHoursController : Controller
    {
        // Connection to database(Troeslen & Japikse, 2021)
        PROG6212_POE_PART_TWOContext Poe = new PROG6212_POE_PART_TWOContext();
        //Method to record number of study hours and calculating remaining self-study hourss
        public IActionResult AddRemainingStudyHours()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRemainingStudyHours(TblRemainingStudyHour remaining)
        {
            try
            {
                //Using the class library calculations class to calculate the remaining self study hours per week(Troeslen & Japikse, 2021)
                ClassLibraryCalculations c = new ClassLibraryCalculations();
                TblRemainingStudyHour r = new TblRemainingStudyHour
                {
                    ModuleName = remaining.ModuleName,
                    SelfStudyHours = remaining.SelfStudyHours,
                    NumberOfHours = remaining.NumberOfHours,
                    DayOfStudy = remaining.DayOfStudy,
                    RemainingStudyHours = c.calculateRecordedStudy(remaining.SelfStudyHours, remaining.NumberOfHours),
                    Username = DisplayUsername.passUsername
                };
                Poe.TblRemainingStudyHours.Add(r);
                Poe.SaveChanges();
                return RedirectToAction("ViewRemainingStudyHours", "RemainingStudyHours");//Redirect user to view remaining study hours page after the create button is clicked in the calculate remaining self-study hours page(Troeslen & Japikse, 2021)
            }
            catch
            {
                ViewBag.Error = "Error in calculating remaining study hours";
                return View();
            }
        }
        //Method so users can view their remaining study hours for their modules
        public IActionResult ViewRemainingStudyHours()
        {
            //LINQ statement so users only see their own data and not the data of other users(Troeslen & Japikse, 2021)
            List<TblRemainingStudyHour> temp = Poe.TblRemainingStudyHours.Where(ur => ur.Username.Equals(DisplayUsername.passUsername)).ToList();
            return View(temp);
        }
        //Edit button for users to edit a information of remaining study hours
        public IActionResult EditRemainingStudyHours(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            TblRemainingStudyHour tblRemainingStudyHour = POE.TblRemainingStudyHours.Where(e => e.RemainingModulesHoursId == id).Single();//Single returns only that object(Troeslen & Japikse, 2021)
            return View(tblRemainingStudyHour);
        }
        [HttpPost]
        public IActionResult EditRemainingStudyHours(TblRemainingStudyHour remaining)
        {
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            //Making use of the class library calculaton so that the remaining self study hours also update based on what fields the user updates(Troeslen & Japikse, 2021)
            ClassLibraryCalculations c = new ClassLibraryCalculations();
            remaining.RemainingStudyHours = c.calculateRecordedStudy(remaining.SelfStudyHours, remaining.NumberOfHours);
            remaining.Username = DisplayUsername.passUsername;
            POE.Update(remaining);
            POE.SaveChanges();
            return RedirectToAction("ViewRemainingStudyHours", "RemainingStudyHours");//Redirect user to view remaining study hours page after the save button is clicked in the edit remaining self-study hours page(Troeslen & Japikse, 2021)
        }
        //Details button so users view information of their remaining study hours
        public IActionResult DetailsRemainingStudyHours(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            TblRemainingStudyHour tblRemainingStudy = POE.TblRemainingStudyHours.Where(e => e.RemainingModulesHoursId == id).Single();//Single returns only that object(Troeslen & Japikse, 2021)
            return View(tblRemainingStudy);
        }
        [HttpPost]
        public IActionResult DetailsRemainingStudyHours(TblRemainingStudyHour remaining)
        {
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            POE.Remove(remaining);
            POE.SaveChanges();
            return RedirectToAction("ViewRemainingStudyHours", "RemainingStudyHours");//Redirect user to view remaining study hours page after the back to list button is clicked in the view remaining self-study hours details page(Troeslen & Japikse, 2021)
        }
        //Delete button so that users can remove or delete a module
        public IActionResult DeleteRemainingStudyHours(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            TblRemainingStudyHour tblRemainingStudy = POE.TblRemainingStudyHours.Where(e => e.RemainingModulesHoursId == id).Single();//Single returns only that object(Troeslen & Japikse, 2021)
            return View(tblRemainingStudy);
        }
        [HttpPost]
        public IActionResult DeleteRemainingStudyHours(TblRemainingStudyHour remaining)
        {
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            POE.Remove(remaining);
            POE.SaveChanges();
            return RedirectToAction("ViewRemainingStudyHours", "RemainingStudyHours");//Redirect user to view remaining study hours page after the delete button is clicked in the delete remaining self-study hours page(Troeslen & Japikse, 2021)
        }
    }
}
