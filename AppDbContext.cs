using Microsoft.EntityFrameworkCore;
using Npgsql;
// using System;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string? connectionString = Environment.GetEnvironmentVariable("POSTGRES_URL");
        Console.WriteLine("*********postgresConnectionString*********");
        Console.WriteLine(connectionString);

        if (connectionString != null)
        {
            var conn = new NpgsqlConnection(connectionString);
            optionsBuilder.UseNpgsql(conn);
        }
    }
}
