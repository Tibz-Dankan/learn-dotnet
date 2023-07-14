using System;
using System.Linq;

partial class Program
{
    static void Main(string[] args)
    {
        using var context = new AppDbContext();
        // Create
        var newStudent = new Student
        {
            Name = "John Doe",
            Email = "johndoe@example.com",
            DateOfBirth = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            Age = 21
        };
        Console.WriteLine("*******Adding new student ...********");
        context.Students.Add(newStudent);
        context.SaveChanges();
        Console.WriteLine("*******Finished adding new student ...********");


        // Read
        var students = context.Students.ToList();
        foreach (var student in students)
        {
            Console.WriteLine("*******Reading student ... ********");
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Email: {student.Email}, DOB: {student.DateOfBirth.ToShortDateString()}, Age: {student.Age}");
            Console.WriteLine("*******Finished Reading student ... ********");
        }

        // Update
        var studentToUpdate = context.Students.FirstOrDefault();
        if (studentToUpdate != null)
        {
            Console.WriteLine("*******Updating student ... ********");
            studentToUpdate.Name = "Jane Smith";
            studentToUpdate.Email = "janesmith@gmail.com";
            context.SaveChanges();
            Console.WriteLine("*******Finished updating student ... ********");

        }

        // Read updated student
        var updatedStudents = context.Students.ToList();
        foreach (var student in updatedStudents)
        {
            Console.WriteLine("*******Reading updated student ... ********");
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Email: {student.Email}, DOB: {student.DateOfBirth.ToShortDateString()}, Age: {student.Age}");
            Console.WriteLine("*******Finished Reading updated student ... ********");
        }

        // Delete
        var studentToDelete = context.Students.FirstOrDefault();
        if (studentToDelete != null)
        {
            Console.WriteLine("*******Deleting student ... ********");
            context.Students.Remove(studentToDelete);
            context.SaveChanges();
            Console.WriteLine("*******Finished deleting student ... ********");
        }
    }
}
