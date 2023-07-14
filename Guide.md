# Brief dotnet guide for simple server

### Create a database new migration

In the command prompt or terminal, navigate to your project directory that contains the AppDbContext.cs file. Run the following command to create a new migration

```.sh

dotnet ef migrations add InitialCreate


```

The command creates a new migration named "InitialCreate" based on the current state of your AppDbContext and model classes

To undo migrations use

```.sh

dotnet ef migrations remove

```

### Generate the SQL script

After creating the migration, run the following command to generate the SQL script for the migration

```.sh

dotnet ef migrations script

```

This command will output the SQL script that represents the changes required to create the Student table based on the migration. You can redirect the output to a file if needed.

```.sh

dotnet ef migrations script > migration.sql

```

### Apply migrations to the database

```.sh

dotnet ef database update

```

### Note

Format of database connection string dotnet

```.sh

string connectionString = "Server=localhost;Port=5432;Database=mydb;User Id=myuser;Password=mypassword;";

```
