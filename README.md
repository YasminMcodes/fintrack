# FinTrack

FinTrack is a full-stack personal finance management application for tracking income and expenses, organizing transactions by category, and providing insights into personal spending.

The project is being developed incrementally, with a focus on building a production-style application using the .NET and Angular ecosystem.

## Current Features

- RESTful API built with ASP.NET Core
- Create financial transactions
- Retrieve all transactions
- PostgreSQL database integration
- Persistent transaction storage
- Entity Framework Core for database access
- EF Core migrations for database schema management
- Automatic transaction ID generation
- Automatic transaction timestamps

## Tech Stack

### Backend
- C#
- ASP.NET Core Web API
- Entity Framework Core
- Npgsql

### Database
- PostgreSQL

### Frontend
- Angular
- TypeScript

Frontend development is planned for a later milestone.

### Development Tools
- Git
- GitHub
- .NET CLI
- PostgreSQL CLI (`psql`)

## Current API Endpoints

### Get all transactions

```http
GET /api/transactions
```

Returns all transactions stored in the PostgreSQL database.

### Create a transaction

```http
POST /api/transactions
```

Example request:

```json
{
  "description": "Groceries",
  "amount": 45.50,
  "category": "Food",
  "type": "Expense"
}
```

Example response:

```json
{
  "id": 1,
  "description": "Groceries",
  "amount": 45.50,
  "category": "Food",
  "type": "Expense",
  "date": "2026-11-16T11:31:29.714034Z"
}
```

## Database

FinTrack currently uses PostgreSQL for persistent data storage.

Entity Framework Core is used as the ORM between the ASP.NET Core application and PostgreSQL. Database schema changes are managed through EF Core migrations.

The current `Transaction` entity contains:

- `Id`
- `Description`
- `Amount`
- `Category`
- `Type`
- `Date`

## Project Structure

```text
fintrack/
├── backend/
│   └── FinTrack.Api/
│       ├── Controllers/
│       ├── Data/
│       ├── Migrations/
│       ├── Models/
│       └── Program.cs
└── README.md
```

## Development Roadmap

### Completed

- [x] Initialize ASP.NET Core Web API
- [x] Create transaction model
- [x] Implement GET and POST transaction endpoints
- [x] Set up PostgreSQL
- [x] Integrate Entity Framework Core
- [x] Create initial database migration
- [x] Persist transactions in PostgreSQL

### Next

- [ ] Complete transaction CRUD operations
- [ ] Add transaction filtering
- [ ] Improve transaction categories and validation
- [ ] Build Angular frontend
- [ ] Create financial dashboard
- [ ] Add user authentication and authorization
- [ ] Add customer and invoice functionality
- [ ] Add automated tests
- [ ] Add Docker support
- [ ] Add CI/CD with GitHub Actions
- [ ] Deploy the application

## Status

FinTrack is currently under active development. The backend supports creating and retrieving transactions with persistent PostgreSQL storage. Additional CRUD functionality and transaction management features are the next development milestone.