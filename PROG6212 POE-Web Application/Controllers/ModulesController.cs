using Class_Library_POE_Web_Application;
using Microsoft.AspNetCore.Mvc;
using PROG6212_POE_Web_Application.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace PROG6212_POE_Web_Application.Controllers
{
    public class ModulesController : Controller
    {
        //Connection to database(Troeslen & Japikse, 2021)
        PROG6212_POE_PART_TWOContext Poe = new PROG6212_POE_PART_TWOContext();
        //Add button to add modules
        public IActionResult AddModules()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddModules(TblModule module)
        {
            try
            {
                //Using the class library calculations class to calculate the self study hours per week(Troeslen & Japikse, 2021)
                ClassLibraryCalculations c = new ClassLibraryCalculations();
                int self = c.selfStudyHoursPerWeek_calculation(Convert.ToInt32(module.ModuleNumberOfCredits), Convert.ToInt32(module.NumberOfWeeks), Convert.ToInt32(module.ModuleClassHoursPerWeek));
                TblModule m = new TblModule
                {
                    ModuleCode = module.ModuleCode,
                    ModuleName = module.ModuleName,
                    ModuleNumberOfCredits = module.ModuleNumberOfCredits,
                    ModuleClassHoursPerWeek = module.ModuleClassHoursPerWeek,
                    NumberOfWeeks = module.NumberOfWeeks,
                    StartDate = module.StartDate,
                    SelfStudyHours = self,
                    Username = DisplayUsername.passUsername
                };
                Poe.TblModules.Add(m);
                Poe.SaveChanges();
                return RedirectToAction("ViewModules", "Modules"); //Redirect to the view modules page after create button is clicked(Troeslen & Japikse, 2021)
            }
            catch
            {
                ViewBag.Error = "Error in adding the module";
                return View();
            }
        }
        //Method so users can view their added modules
        public IActionResult ViewModules()
        {
            //LINQ statement so users only see their own data and not the data of other users(Troeslen & Japikse, 2021)
            List<TblModule> temp = Poe.TblModules.Where(ur => ur.Username.Equals(DisplayUsername.passUsername)).ToList();
            return View(temp);
        }
        //Edit button for users to edit a module
        public IActionResult EditModules(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            TblModule tblModule = POE.TblModules.Where(e => e.ModulesId == id).Single();//Single returns only that object(Troeslen & Japikse, 2021)
            return View(tblModule);
        }
        [HttpPost]
        public IActionResult EditModules(TblModule tblModule)
        {
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            //Making use of the class library calculaton so that the self study hours also update based on what fields the user updates(Troeslen & Japikse, 2021)
            ClassLibraryCalculations c = new ClassLibraryCalculations();
            tblModule.SelfStudyHours = c.selfStudyHoursPerWeek_calculation(Convert.ToInt32(tblModule.ModuleNumberOfCredits), Convert.ToInt32(tblModule.NumberOfWeeks), Convert.ToInt32(tblModule.ModuleClassHoursPerWeek));
            tblModule.Username = DisplayUsername.passUsername;
            POE.Update(tblModule);
            POE.SaveChanges();
            return RedirectToAction("ViewModules", "Modules"); //Redirect user to view modules page after clicking the save button on the edit page(Troeslen & Japikse, 2021)
        }
        //Details button so users view information of an added module
        public IActionResult DetailsModules(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            TblModule tblModule = POE.TblModules.Where(e => e.ModulesId == id).Single();//Single returns only that object(Troeslen & Japikse, 2021)
            return View(tblModule);
        }
        [HttpPost]
        public IActionResult DetailsModules(TblModule module)
        {
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            POE.Remove(module);
            POE.SaveChanges();
            return RedirectToAction("ViewModules", "Modules"); //Redirect user to view modules page after clicking the back to list button on the details page(Troeslen & Japikse, 2021)
        }
        //Delete button so that users can remove or delete a module
        public IActionResult DeleteModules(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            TblModule tblModule = POE.TblModules.Where(e => e.ModulesId == id).Single();//Single returns only that object(Troeslen & Japikse, 2021)
            return View(tblModule);
        }
        [HttpPost]
        public IActionResult DeleteModules(TblModule module)
        {
            PROG6212_POE_PART_TWOContext POE = new PROG6212_POE_PART_TWOContext();
            POE.Remove(module);
            POE.SaveChanges();
            return RedirectToAction("ViewModules", "Modules"); //Redirect user to view modules page after clicking the delete button on the delete page(Troeslen & Japikse, 2021)
        }
    }
}
