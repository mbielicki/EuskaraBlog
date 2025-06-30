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
