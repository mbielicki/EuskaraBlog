# Euskara Blog

Euskara Blog is a modern web application built with Blazor (.NET 9) that enables authenticated users to read and, for authorized users, write articles. The project leverages a clean architecture with separate Domain, Application, and Infrastructure layers, and uses Azure AD authentication with role-based access control.

## Features

- **Blazor Server UI**: Interactive, real-time web interface using Razor Components.
- **Authentication & Authorization**: Azure AD (OpenID Connect) integration with role-based access (admin users can write articles).
- **Article Management**: 
  - View articles (all authenticated users).
  - Write new articles (admin users only).
- **MediatR**: Decoupled request/response and command/query handling.
- **Entity Framework Core**: SQL Server-backed data persistence.
- **Clean Architecture**: Separation of concerns across Domain, Application, and Infrastructure projects.

## Project Structure

- `EuskaraBlog.Domain`: Core domain models and logic.
- `EuskaraBlog.Application`: Application logic, MediatR commands/queries, and service interfaces.
- `EuskaraBlog.Infrastructure`: Data access (EF Core), service implementations.
- `WebUI.Server`: Blazor Server UI, authentication, and API endpoints.

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- SQL Server (local or remote)
- Azure AD tenant (for authentication)

### Configuration

1. **Clone the repository**:
```bash
git clone <repository-url> cd EuskaraBlog
```

2. **Configure appsettings**:

   - Update `WebUI.Server/appsettings.json` and `appsettings.Development.json` with your Azure AD and database settings.

3. **Apply database migrations**:
```bash
dotnet ef database update --project EuskaraBlog.Infrastructure
```

4. **Run the application**:
```bash
dotnet run --project WebUI.Server
```

5. **Access the app**:

Open [https://localhost:5001](https://localhost:5001) in your browser.

## Usage

- **View Articles**: Navigate to the "Articles" page from the navigation menu.
- **Write Article**: 
- Sign in with an admin account.
- Click "Write" in the navigation menu.
- Fill out the article form and submit.

## Key Technologies

- **Blazor Server** (.NET 9)
- **Entity Framework Core** (SQL Server)
- **Azure AD / OpenID Connect**
- **MediatR**
- **Clean Architecture**

## Development

- Visual Studio 2022 or later is recommended.
- The solution is organized for maintainability and testability.

## License

This project is licensed under the [GNU AFFERO GENERAL PUBLIC LICENSE](LICENSE.txt).

---

*For questions or contributions, please open an issue or submit a pull request.*