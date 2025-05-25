# BlockedCountriesApi

This is a simple .NET Core Web API that manages blocked countries and checks IP addresses using an external geolocation API.

## 🚀 Features

- Add/remove blocked countries in-memory
- Check if an IP address belongs to a blocked country
- Swagger UI for API testing
- RESTful endpoints
- Easy to extend with a real database

## 🛠 Technologies Used

- ASP.NET Core Web API
- C#
- Swagger (Swashbuckle)
- REST APIs
- IP Geolocation API (e.g., ip-api.com)

## 📂 Project Structure
BlockedCountriesApi/
├── Controllers/
│ └── BlockedCountriesController.cs
├── Models/
│ └── BlockedCountry.cs
├── Services/
│ └── BlockedCountryService.cs
├── Program.cs
├── Startup.cs (if .NET 5 or earlier)
└── BlockedCountriesApi.csproj
## 🧑‍💻 Getting Started

1. Clone the repository:
```bash
git clone https://github.com/Ahmoooos/Atechnologies-task.git
cd Atechnologies-task/BlockedCountriesApi
dotnet run
https://localhost:<port>/swagger


---

### 6. **Endpoints**

Give examples of how to use the API:

```markdown
## 📦 API Endpoints

### Get blocked countries
`GET /api/blocked`

### Add a blocked country
`POST /api/blocked`
```json
{ "countryName": "Russia" }

Remove a blocked country
DELETE /api/blocked/Russia
