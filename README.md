# ASP.NET Web API - Book Management

A simple CRUD API for managing books.  
Built with ASP.NET Core 8 + Entity Framework Core + SQL Server LocalDB.

## Current Features
- GET /api/books — Get all books
- GET /api/books/{id} — Get book by ID
- POST /api/books — Create new book
- PUT /api/books/{id} — Update book
- DELETE /api/books/{id} — Delete book

## Setup
1. Verify connection string in `appsettings.json`
2. Run `dotnet ef database update`
3. Run `dotnet run`

## Future Plans (will evolve as course progresses)
- [ ] JWT Authentication
- [ ] Pagination & filtering
- [ ] FluentValidation
- [ ] Enhanced Swagger docs
- [ ] Unit tests (xUnit)
- [ ] Docker support
- [ ] Additional entities (Author, Category)

Project will be developed further throughout the course.
