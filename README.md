# prog6212-poe-RobertoBooysen
prog6212-poe-RobertoBooysen created by GitHub Classroom

Roberto Booysen-ST10085125 
YouTube link: https://youtu.be/FHpSLQOiE_I

In the class library I have two classes named ClassLibraryCalculations which consist of two calculations which is to calculate the self- hours study per week of modules
and to calculate the remaining self-study hours for a module and DisplayUsername class which consist of one method getUserName to keep track of what user is logged on 
the website. In the asp.net application I have multiple controllers in a controller folder which consist of HomeController, UserLoginController, ModuleController, 
RemainingStudyHoursController and ChartsController. In the HomeController it has the information of the index view page which is the home page of the web application.
In the UserLoginController it has methods for a user to register with a username and password, the password will be hashed in the database if they have successfully 
registered they will be redirected to the login page for them to login,in the loginUser methods there is a LINQ statement to check if the details the user have entered 
matches the details in the database if it does they will be redirected to the home page if it doesn’t match there will be a red message that pops up to the screen that
will state that details doesn’t match.In the ModuleController there is methods for a user to add modules where I made use of the class library calculations class to 
calculate the number of self-study hours per week, edit modules methods so users can update the modules I also made use of the class libraries calculations class for when
the user update fields that has to do with the self-study hours per week so that the self-study hours is also updated based on what the user entered, delete modules methods
which give the users the ability to delete a module, modules details methods to view details of an added module with the calculated self-study hours and also a view modules 
method which is a list of the added modules where the users will only see their own data and not the data of other users. In the RemainingStudyHoursController
there is methods for a user to calculate the remaining self-study hours of modules where I made use of the class library calculations class to calculate the remaining
number of self-study hours for the week, edit remaining study hours methods so users can update the information of the remaining self-study hours of a module I also made
use of the class libraries calculations class here for when the user update fields that has to do with the remaining self-study hours per week so that the remaining self-
study hours is also updated based on what the user entered, delete remaining self-study hours methods which give the users the ability to delete a module with the remaining 
self-study hours, details remaining study hours method to view the details of the calculated remaining self-study hours of a module with the calculated remaining self-study 
hours and a view remaining study hours method which is a list of the modules with the calculated remaining study-hours where the users only to see their own data and not 
the data of other users. In the ChartsController there is two views or method for two graphs or charts one for the display of the self-study hours and the other one for the display
of the remaining self-study hours and number of study hours where there is a ViewBag and a LINQ statement in each of them to only display the user’s own data and not the 
data of other users. In the models folder it has the information of the different tables in the database where I have error handling for each of the fields or textboxes.
The views folder consists of a few folders named Charts, Home, Modules, RemainingStudyHours and UserLogin where there’s multiple views in each of the folders.


References List:
CanvaJS .,2017. ASP.NET MVC Chart Data from Database, CanvaJS.[Online]. Available at: https://canvasjs.com/asp-net-mvc-charts/chart-data-from-database/ [Accessed: 30 November 2022].
Chand, M.,2020. Compute SHA256 Hash In C#, C# Corner. [Online]. Available at: https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/ [Accessed: 30 November 2022].
CodeWithAwa.,2022. Complete user registration system using PHP and MySQL database, CodeWithAwa.[Online] Available at: https://codewithawa.com/posts/complete-user-registration-system-using-php-and-mysql-database [Accessed: 30 May 2022].
Troeslen, A. & Japikse, P., 2021. Pro C# 9 with .NET 5 Foundational Principles and Practices in Programming. 10th ed. New York: Apress.
W3Schools, 2022. W3Schools. [Online] Available at: https://www.w3schools.com/ [Accessed 30 May 2022].
