using System;
using System.Linq;

partial class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            // Create
            var newStudent = new Student
            {
                Name = "John Doe",
                Email = "johndoe@example.com",
                DateOfBirth = new DateTime(2000, 1, 1),
                Age = 21
            };
            context.Students.Add(newStudent);
            context.SaveChanges();

            // Read
            var students = context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Email: {student.Email}, DOB: {student.DateOfBirth.ToShortDateString()}, Age: {student.Age}");
            }

            // Update
            var studentToUpdate = context.Students.FirstOrDefault();
            if (studentToUpdate != null)
            {
                studentToUpdate.Name = "Jane Smith";
                context.SaveChanges();
            }

            // Delete
            var studentToDelete = context.Students.FirstOrDefault();
            if (studentToDelete != null)
            {
                context.Students.Remove(studentToDelete);
                context.SaveChanges();
            }
        }
    }
}
