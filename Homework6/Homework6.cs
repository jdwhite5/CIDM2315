namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Professor Alice = new Professor();
        Professor Bob = new Professor();

        Alice.profName = "Alice";
        Alice.classTeach = "Java";
        Alice.SetSalary(9000);

        Bob.profName = "Bob";
        Bob.classTeach = "Math";
        Bob.SetSalary(8000);

        Student Lisa = new Student();
        Student Tom = new Student();

        Lisa.studentName = "Lisa";
        Lisa.classEnroll = "Java";
        Lisa.SetGrade(90);

        Tom.studentName = "Tom";
        Tom.classEnroll = "Math";
        Tom.SetGrade(80);

        Console.WriteLine($"Professor {Alice.profName} teaches {Alice.classTeach}, and the salary is: {Alice.GetSalary()}.");
        Console.WriteLine($"Professor {Bob.profName} teaches {Bob.classTeach}, and the salary is: {Bob.GetSalary()}.");
        Console.WriteLine($"Student {Lisa.studentName} enrolls {Lisa.classEnroll}, and the grade is: {Lisa.GetGrade()}.");
        Console.WriteLine($"Student {Tom.studentName} enrolls {Tom.classEnroll}, and the grade is: {Tom.GetGrade()}.");
    }

}

public class Professor {
    public string profName = "";
    public string classTeach = "";
    private double salary;

    public void SetSalary(double salary_amount) {
        salary = salary_amount;
    }

    public double GetSalary() {
        return salary;
    }

}

public class Student {
    public string studentName = "";
    public string classEnroll = "";
    private double studentGrade;

    public void SetGrade(double newGrade) {
        studentGrade = newGrade;
    }

    public double GetGrade() {
        return studentGrade;
    }
}
