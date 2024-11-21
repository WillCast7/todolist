# TodoList
This is a basic Todo List API built for a challenge using ASP.NET Core.



## Instructions

1. Clone the repository:

2. Restore the dependencies:
   ```bash
   dotnet restore
   ```
3.Configure the database connection:

   Open the appsettings.json file and update the ConnectionStrings section with your database connection details. Example:
   ```csharp
      "ConnectionStrings": {
        "Connection": "Server=.\\SQLEXPRESS;you_database_here=TodoList;Trusted_Connection=true;TrustServerCertificate=true;"
      }
   ```

4. Apply the migrations:
   ```bash
   dotnet ef database update
   ```

5. Run the api:
   ```bash
   dotnet run
   ```

You can see the api documentation in `https://localhost:7169/swagger/index.html`.
