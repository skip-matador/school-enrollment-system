// Student.cs

using System;

public class Student {
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public void DisplayInfo() {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
    }
}
