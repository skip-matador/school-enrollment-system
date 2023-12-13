// Course.cs

using System;

public class Course {
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string Instructor { get; set; }

    public void DisplayInfo() {
        Console.WriteLine($"Course ID: {CourseId}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Instructor: {Instructor}");
    }
}
