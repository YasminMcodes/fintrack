# FinTrack

FinTrack is a full-stack personal finance management application for tracking income and expenses, organizing transactions by category, and gaining insights into personal spending.

The project is being developed incrementally as a production-style full-stack application using ASP.NET Core, Angular, and PostgreSQL.

## Current Features

- Create financial transactions through a REST API
- Retrieve all transactions
- Track transaction details including:
  - Description
  - Amount
  - Category
  - Transaction type
  - Date
- JSON-based API communication

## Tech Stack

### Backend
- C#
- .NET 10
- ASP.NET Core Web API

### Frontend
- Angular
- TypeScript

### Database
- PostgreSQL
- Entity Framework Core

### Development Tools
- Git
- GitHub
- REST API testing with curl

## API Endpoints

| Method | Endpoint | Description |
| --- | --- | --- |
| GET | `/api/transactions` | Retrieve all transactions |
| POST | `/api/transactions` | Create a new transaction |

## Project Structure

```text
fintrack/
├── backend/
│   └── FinTrack.Api/
│       ├── Controllers/
│       ├── Models/
│       ├── Program.cs
│       └── FinTrack.Api.csproj
├── .gitignore
└── README.md
```

## Development Roadmap

- [x] Initialize ASP.NET Core Web API
- [x] Create transaction model
- [x] Implement GET transactions endpoint
- [x] Implement POST transaction endpoint
- [ ] Integrate PostgreSQL with Entity Framework Core
- [ ] Implement full transaction CRUD
- [ ] Add transaction validation
- [ ] Build Angular frontend
- [ ] Add dashboard and financial summaries
- [ ] Add user authentication and authorization
- [ ] Add automated tests
- [ ] Configure CI/CD and deployment

## Project Status

FinTrack is currently under active development. The initial REST API foundation is complete, and database persistence is the next development milestone.