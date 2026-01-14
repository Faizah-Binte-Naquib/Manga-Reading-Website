# Manga Reading Website

A full-stack ASP.NET MVC web application for exploring, reading, rating, and managing a collection of manga. Features user authentication, personalized libraries, reading progress tracking, and comprehensive manga information with summaries, genres, and ratings.

## 📋 Overview

The **Manga Library** is a web-based platform that allows users to explore, read, and manage manga collections. It provides different access levels for registered and unregistered users, with features like rating, reading, categorizing, and personal library management.

## 🚀 Features

### For All Users
- **Browse Manga**: View detailed information including summaries, genres, ratings, and completion status
- **Search Functionality**: Multi-purpose search by name, author, genre, or keywords
- **Category Browsing**: Explore manga by genre
- **Top Manga Display**: Homepage showcases top mangas based on popularity and ratings

### For Registered Users
- **User Authentication**: Secure registration and login system
- **Rate Manga**: Rate and review manga titles
- **Read Online**: Read manga chapters directly on the platform
- **Personal Library**: Add manga to your personal library for easy access
- **Reading Progress**: Track your reading progress across different manga

## 🛠️ Tech Stack

- **ASP.NET MVC 5.2.4** - Web application framework
- **Entity Framework 6.2.0** - ORM for database access
- **SQL Server LocalDB** - Database management (LocalDB)
- **C#** - Backend programming language
- **HTML/CSS/JavaScript** - Frontend technologies
- **Bootstrap 3.3.7** - Responsive design framework
- **jQuery 3.3.1** - JavaScript library
- **Microsoft OWIN** - Authentication middleware

## 📦 Installation

### Prerequisites

- **Visual Studio** 2015 or later (recommended: Visual Studio 2017+)
- **SQL Server LocalDB** (included with Visual Studio)
- **.NET Framework 4.6.1** or higher

### Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/Faizah-Binte-Naquib/Manga-Reading-Website.git
   cd Manga-Reading-Website
   ```

2. **Open in Visual Studio**
   - Open `Mango.sln` in Visual Studio
   - The solution contains the `Mango` project

3. **Configure Database**
   - The project uses SQL Server LocalDB
   - Connection string is configured in `Mango/Web.config`:
     ```xml
     <connectionStrings>
       <add name="DefaultConnection" 
            connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-Mango-20190905071552.mdf;Initial Catalog=aspnet-Mango-20190905071552;Integrated Security=True"
            providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```
   - The database will be created automatically on first run

4. **Restore NuGet Packages**
   - Right-click the solution → "Restore NuGet Packages"
   - Or run: `nuget restore Mango.sln`

5. **Build and Run**
   - Press `F5` or click "Run" to start the application
   - The application will open in your default browser

## 📁 Project Structure

```
Manga-Reading-Website/
├── Mango/                    # Main ASP.NET MVC project
│   ├── App_Start/           # Application startup configuration
│   │   ├── BundleConfig.cs  # CSS/JS bundling
│   │   ├── RouteConfig.cs   # URL routing
│   │   └── Startup.Auth.cs  # Authentication setup
│   ├── Controllers/         # MVC Controllers
│   │   ├── AccountController.cs
│   │   ├── HomeController.cs
│   │   ├── HomePageController.cs
│   │   ├── MangaController.cs
│   │   ├── RegisterController.cs
│   │   └── UserController.cs
│   ├── Models/              # Data models
│   │   ├── Manga.cs         # Manga model (Name, Author, Genre, Summary, Rating)
│   │   ├── UserModel.cs
│   │   └── IdentityModels.cs
│   ├── Views/               # Razor views
│   ├── Content/             # CSS files (Bootstrap)
│   ├── css/                 # Custom CSS files
│   ├── Scripts/             # JavaScript files
│   ├── images/              # Image assets
│   ├── manga/               # Manga content files
│   ├── Web.config           # Application configuration
│   └── packages.config      # NuGet package references
├── Mango.sln                # Visual Studio solution file
└── README.md
```

## 💻 Usage

### For Users

1. **Browse Manga**: Navigate through the homepage to see top manga or browse by category
2. **Search**: Use the search box to find specific manga by name, author, or genre
3. **Register/Login**: Create an account to access additional features
4. **Rate Manga**: Click on a manga to view details and rate it (registered users only)
5. **Add to Library**: Save manga to your personal library for quick access
6. **Read Manga**: Access and read manga chapters online (registered users only)

### For Developers

- The application follows MVC architecture
- Controllers handle user requests and business logic
- Models represent data structures (Manga, User, etc.)
- Views render the user interface using Razor syntax
- Entity Framework handles database interactions

## 🗄️ Database

The application uses **SQL Server LocalDB** with Entity Framework Code First approach. The database is automatically created on first run with the following key entities:

- **Users**: User accounts and authentication
- **Manga**: Manga information (Name, Author, Genre, Summary, Rating)
- **User Libraries**: Personal manga collections
- **Ratings**: User ratings for manga

## 🔒 Security

- User authentication using ASP.NET Identity
- OWIN middleware for secure authentication
- Password hashing and secure session management
- SQL injection prevention through Entity Framework

## 🎨 UI/UX Features

- Responsive design using Bootstrap 3.3.7
- Custom CSS for manga-specific styling
- jQuery for interactive elements
- Image galleries and manga wallpapers
- Intuitive navigation and user interface

## 🧪 Development

### Key Dependencies (from packages.config)

- Microsoft.AspNet.Mvc 5.2.4
- EntityFramework 6.2.0
- Microsoft.AspNet.Identity.Core 2.2.2
- Microsoft.Owin 4.0.0
- Bootstrap 3.3.7
- jQuery 3.3.1

## 🚀 Deployment

### Production Deployment

1. **Configure Production Database**: Update connection string in `Web.config` for production SQL Server
2. **Update Configuration**: Set `debug="false"` in `Web.config`
3. **Publish**: Right-click project → "Publish" → Configure for your hosting provider
4. **Deploy to IIS**: Publish to IIS server with .NET Framework 4.6.1+

## 🤝 Contributing

Contributions, issues, and feature requests are welcome! Feel free to check the [issues page](https://github.com/Faizah-Binte-Naquib/Manga-Reading-Website/issues).

## 👤 Author

**Faizah Binte Naquib**

- GitHub: [@Faizah-Binte-Naquib](https://github.com/Faizah-Binte-Naquib)
- LinkedIn: [fbnaquib-a07932174](https://www.linkedin.com/in/fbnaquib-a07932174/)
- Email: faizahbintenaquib@gmail.com

## 📄 License

This project is open source and available under the MIT License.

---

⭐ If you found this project helpful, please consider giving it a star!
