// SchoolSystem.cs

class SchoolSystem {
    static void Main() {
        // Create students
        Student student1 = new Student { StudentId = 1, Name = "Alice", Email = "alice@example.com" };
        Student student2 = new Student { StudentId = 2, Name = "Bob", Email = "bob@example.com" };

        // Create courses
        Course course1 = new Course { CourseId = 101, Title = "Introduction to C#", Instructor = "Dr. Smith" };
        Course course2 = new Course { CourseId = 102, Title = "Advanced C# Programming", Instructor = "Prof. Johnson" };

        // Create enrollments
        Enrollment enrollment1 = new Enrollment { EnrollmentId = 1001, Student = student1, Course = course1 };
        Enrollment enrollment2 = new Enrollment { EnrollmentId = 1002, Student = student2, Course = course2 };

        // Display information
        System.Console.WriteLine("Enrollment Information:");
        enrollment1.DisplayInfo();
        System.Console.WriteLine();
        enrollment2.DisplayInfo();
    }
}
