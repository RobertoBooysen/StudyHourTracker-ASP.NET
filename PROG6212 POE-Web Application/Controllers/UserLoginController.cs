using Microsoft.AspNetCore.Mvc;
using PROG6212_POE_Web_Application.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Class_Library_POE_Web_Application;

namespace PROG6212_POE_Web_Application.Controllers
{
    public class UserLoginController : Controller
    {
        //Connection to database(Troeslen & Japikse, 2021)
        PROG6212_POE_PART_TWOContext Poe = new PROG6212_POE_PART_TWOContext();
        //Method to hash or encrypt the password in the database(Chand, 2020)
        public string Hash_Password(string input)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        //Register button to add a user
        public IActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterUser(TblUser user)
        {
            try
            {
                //Error checking to ensure all fields are filled in and not left emptied(Troeslen & Japikse, 2021)
                if (user.Password == null || user.Username == null)
                {
                    ViewBag.Error = "Please enter all fields";
                    return View();
                }
                else
                {
                    TblUser u = new TblUser
                    {
                        Username = user.Username,
                        Password = Hash_Password(user.Password)
                    };
                    Poe.TblUsers.Add(u);
                    Poe.SaveChanges();
                    return RedirectToAction("LoginUser");//Redirect user to the login page after registering(Troeslen & Japikse, 2021)
                }
            }
            catch
            {
                ViewBag.Error = "User already in the database!";
                return View();
            }
        }
        //Login button so that a user login to the website
        [HttpGet]
        public IActionResult LoginUser()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginUser(TblUser user)
        {
            try
            {
                //LINQ statement to see if the information that the user entered matches the information in the database(Troeslen & Japikse, 2021)
                var detail = Poe.TblUsers.Where(ur => ur.Username.Equals(user.Username)
                     && ur.Password.Equals(Hash_Password(user.Password))).FirstOrDefault();
                DisplayUsername.getUserName(user.Username);
                if (detail != null)
                {
                    return RedirectToAction("Index", "Home");//Redirect user to the home page after a successful login(Troeslen & Japikse, 2021)
                }
                else
                {
                    ViewBag.Error = "Details doesn't match!";//Displaying details doesn't match when entering the incorrect credentials
                }
            }
            catch
            {
                ViewBag.Error = "User already in the database!";
            }
            return View();
        }
    }
}
