// Enrollment.cs

public class Enrollment {
    public int EnrollmentId { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }

    public void DisplayInfo() {
        Console.WriteLine($"Enrollment ID: {EnrollmentId}");
        Student.DisplayInfo();
        Course.DisplayInfo();
    }
}
