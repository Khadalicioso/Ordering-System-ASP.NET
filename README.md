# Online Ordering System 🛒

A simple online ordering system developed as an academic project for IPT (Integration Programming and Technologies). This project demonstrates the implementation of basic e-commerce functionalities using ASP.NET Core MVC.

## 🚀 Features

- User-friendly interface for placing and managing orders
- Secure authentication and authorization
- Order tracking and management
- Product catalog management
- Responsive design for all devices

## 🛠️ Technologies Used

- **Framework:** ASP.NET Core MVC
- **Language:** C#
- **Database:** SQL Server
- **Front-end:** HTML5, CSS3, JavaScript
- **Authentication:** ASP.NET Core Identity

## 📋 Prerequisites

- .NET 6.0 SDK or later
- SQL Server
- Visual Studio 2022 (recommended) or VS Code

## ⚙️ Installation

1. Clone the repository
   ```bash
   git clone [your-repository-url]
   ```

2. Navigate to the project directory
   ```bash
   cd online_ordering_system
   ```

3. Restore dependencies
   ```bash
   dotnet restore
   ```

4. Update the connection string in `appsettings.json` with your database details

5. Run database migrations
   ```bash
   dotnet ef database update
   ```

6. Run the application
   ```bash
   dotnet run
   ```

## 🏗️ Project Structure

```
IPT_OrderingSystem/
├── Controllers/         # MVC Controllers
├── Models/             # Data models and view models
├── Views/              # Razor views
├── Data/              # Database context and migrations
└── wwwroot/           # Static files (CSS, JS, images)
```

## 🔒 Security

- Implements secure authentication
- Uses secure password hashing
- Input validation and sanitization
- CSRF protection

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👥 Authors

- Khadalicioso

---

⭐ If you find this project helpful, please consider giving it a star!
