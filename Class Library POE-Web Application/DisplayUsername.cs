using System;

namespace Class_Library_POE_Web_Application
{
    //Class to keep track of what user is logged in(see How To Display User Name in Asp.net MVC 2019,2019)
    public class DisplayUsername
    {
        public static string passUsername;
        public static void getUserName(string username)
        {
            passUsername = username;
        }
    }
}
