## Database connection 

Add your database connection string to your secure creadentials on with ASP.net

For example:

```bash
dotnet user-secrets set "DatabaseConnection" "Host=localhost;Port=5432;Database=db_name;Username=usuario;Password=pass"
```

Be sure that the key name is DatabaseConnection because thats how is in the source code.
