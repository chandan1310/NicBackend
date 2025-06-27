# 📦 NIC Service Request Backend API

### 🔑 Login Page Username & Password

```
Username: admin
Password: admin
```


## 🔧 Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT (JSON Web Tokens) Authentication
- Swagger (OpenAPI)
- CORS Policy Support


## 📁 Project Files Created

```
NicBackend/
├── Controllers/
│   ├── AuthController.cs
│   └── ServiceRequestController.cs
├── Data/
│   └── AppDbContext.cs
├── Models/
│   ├── LoginModel.cs
│   └── ServiceRequest.cs
├── appsettings.json
├── Program.cs
├── README.md
```

---

## 🚀 How to Set Up the Project

- [.NET 8 SDK or later](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- IDE: [Visual Studio 2022+](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- Optional: [Postman](https://www.postman.com/) for API testing

## Install Microsoft.EntityFramewor

01. Microsoft.EntityFrameworkCore

02. Microsoft.EntityFrameworkCore.SqlServer

03. Microsoft.AspNetCore.Authentication.JwtBearer

04. Microsoft.AspNetCore.Authentication.JwtBearer

---

### ⚙️ Step-by-Step Setup


1. **Update the database connection string**

Open `appsettings.json` and make sure the `DBConnection` string matches your SQL Server setup:

```json
"ConnectionStrings": {
  "DBConnection": "Server=DESKTOP-MSEGO92\\SQLEXPRESS;Database=ServiceRequestDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

2. **Restore and build the project**

```bash
dotnet restore
dotnet build
```

3. **Run the application**

```bash
dotnet run
```

The API will start on:

- `https://localhost:5001`
- `http://localhost:5000`

---

### 📄 API Documentation (Swagger)

Visit:

```
https://localhost:5001/swagger
```

You can test API endpoints directly.

---

### 🔑 Login Credentials (Demo)

```
Username: admin
Password: admin
```

Use the returned JWT token as:

```
Authorization: Bearer <your_token_here>
```
