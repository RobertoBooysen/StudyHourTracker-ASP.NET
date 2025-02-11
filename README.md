<h1 align="center">👋 Welcome to Study Hour Tracker </h1>

## 🌐 Application Overview
This ASP.NET web application tracks self-study hours for various modules, allowing users to register, log in, manage their modules, and view their study hour statistics. The application includes a class library for calculations and controllers to manage user authentication, module data, and charts displaying study progress.

### 🧑‍💻 Core Features

#### 1. **📝 User Registration & Login**
   - Allows users to register with a username and password.
   - Passwords are hashed for security.
   - Users can log in to the application with their credentials.
   - Invalid login attempts display an error message.

#### 2. **📚 Module Management**
   - Users can add, edit, and delete modules.
   - Calculates self-study hours per week based on user input.
   - Displays a list of user-specific modules with their self-study hour calculations.

#### 3. **⏳ Remaining Study Hours**
   - Users can calculate and manage the remaining self-study hours for each module.
   - Remaining study hours are calculated dynamically based on user input.
   - Users can view and update their remaining study hours for each module.

#### 4. **📊 Charts & Visualizations**
   - Displays two charts:
     - One for self-study hours.
     - One for remaining study hours.
   - Charts show user-specific data, preventing access to other users' information.

---

## 🔒 Application Features

### 🔧 Controllers
1. **🏠 HomeController**
   - Displays the home page of the application.

2. **🔑 UserLoginController**
   - Handles user registration and login functionality.
   - Uses LINQ to validate user credentials.

3. **📘 ModuleController**
   - Manages the creation, updating, and deletion of modules.
   - Calculates self-study hours using the ClassLibraryCalculations class.

4. **⏳ RemainingStudyHoursController**
   - Calculates and manages remaining self-study hours for modules.
   - Allows users to update and delete remaining study hours data.

5. **📊 ChartsController**
   - Displays charts for self-study hours and remaining study hours.
   - Uses LINQ to filter data based on the logged-in user.

### 🏷️ Models & Views
   - Models define the structure of the data tables in the database.
   - Error handling is implemented for user inputs and database interactions.
   - Views provide the user interface, with separate folders for modules, charts, and user login.

---

## ✨ Additional Features

- **📊 Data Handling:** Uses LINQ queries to filter data based on user-specific input, ensuring that users only see their own data.
- **🔒 Secure Login:** Passwords are securely hashed using SHA256 to protect user credentials.
- **🖥️ User-Friendly Interface:** Features multiple views for modules, remaining study hours, and user login management.

---
