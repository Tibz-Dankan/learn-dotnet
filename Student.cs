public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Age { get; set; }

    public Student()
    {
        Name = string.Empty; 
        Email = string.Empty; 

    }
}
