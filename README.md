# LoginApp

A simple ASP.NET Core MVC Login Application built using .NET 10.

## Features

- User Login Page
- Username & Password Validation
- Welcome Page after Successful Login
- Bootstrap UI
- ASP.NET Core MVC Architecture

## Technologies Used

- ASP.NET Core MVC
- .NET 10 SDK
- C#
- Bootstrap 5
- HTML5
- CSS3

## Project Structure

```
LoginApp
│
├── Controllers
│   └── HomeController.cs
│
├── Models
│   └── LoginModel.cs
│
├── Views
│   ├── Home
│   │   ├── Index.cshtml
│   │   └── Welcome.cshtml
│   │
│   └── Shared
│
├── wwwroot
│
├── Program.cs
├── LoginApp.csproj
└── README.md
```

---

## Installation

### Clone Repository

```bash
git clone https://github.com/NishantYadav9602/LoginApp.git
```

Move into the project

```bash
cd LoginApp
```

Restore packages

```bash
dotnet restore
```

Run the application

```bash
dotnet run --urls=http://0.0.0.0:5000
```

Open your browser

```
http://localhost:5000
```

or

```
http://<YOUR_SERVER_IP>:5000
```

---

## Demo Credentials

```
Username : admin
Password : 1234
```

---

## Application Flow

```
Login Page
     │
     ▼
Enter Username & Password
     │
     ├── Invalid Credentials
     │        │
     │        ▼
     │   Show Error Message
     │
     ▼
Valid Credentials
     │
     ▼
Welcome Page
```

---

## Future Enhancements

- SQL Server Integration
- Entity Framework Core
- ASP.NET Core Identity
- Registration Page
- Forgot Password
- Session Authentication
- Role-Based Authorization
- Dashboard
- Logout Functionality

---

## Author

**Nishant Yadav**

GitHub:
https://github.com/NishantYadav9602

LinkedIn:
https://www.linkedin.com/

---

## License

This project is licensed under the MIT License.
