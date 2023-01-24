namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        // Q1 Letter Grades

        bool exit = false;
        while (exit == false) {
            Console.Write("Please input a letter grade:");
            var grade = Console.ReadLine();
            if (grade != null) {
                grade = grade.ToUpper();
            } else if (string.IsNullOrEmpty(grade)) {
                break;
            }

            switch (grade) {
                case "A":
                    Console.WriteLine("Letter Grade: " + grade);
                    Console.WriteLine("GPA Point: 4");
                    exit = true;
                    break;
                case "B":
                    Console.WriteLine("Letter Grade: " + grade);
                    Console.WriteLine("GPA Point: 3");
                    exit = true;
                    break;
                case "C":
                    Console.WriteLine("Letter Grade: " + grade);
                    Console.WriteLine("GPA Point: 2");
                    exit = true;
                    break;
                case "D":
                    Console.WriteLine("Letter Grade: " + grade);
                    Console.WriteLine("GPA Point: 1");
                    exit = true;
                    break;
                case "F":
                    Console.WriteLine("Letter Grade: " + grade);
                    Console.WriteLine("GPA Point: 0");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    break;
            } 
        }

        // Q2 Smallest Value

        int one;
        int two;
        int three;
        string smallest = "The smallest value is: ";
        string oneAndThree = "The First and Thrid values are the lowest. ";
        string oneAndTwo = "The First and Second values are the lowest. ";
        string twoAndThree = "The Second and third values are the lowest. ";
        string allEqual = "All values are equal. ";
        
        Console.WriteLine("Please enter three numbers");
        Console.Write("Please input number 1: ");
        one = Convert.ToInt16(Console.ReadLine());
        Console.Write("Please input number 2: ");
        two = Convert.ToInt16(Console.ReadLine());
        Console.Write("Please input number 3: ");
        three = Convert.ToInt16(Console.ReadLine());

        if (one == two && one == three) {
            Console.WriteLine(allEqual + one);
        } else if (one == two) {
            Console.WriteLine(oneAndTwo + one);
        } else if (one == three) {
            Console.WriteLine(oneAndThree + one);
        } else if (two == three) {
            Console.WriteLine(twoAndThree + two);
        } else if (one < two) {
            if (one < three) {
                Console.WriteLine(smallest + one);
            } else {
                Console.WriteLine(smallest + three);
            }
        } else if (one > two) {
            if (two < three) {
                Console.WriteLine(smallest + two);
            } else {
                Console.WriteLine(smallest + three);
            }
        }

        // Bonus Question Leap Year

        int year;
        string isLeap = " IS a leap year";
        string notLeap = " IS NOT a leap year"; 
        
        Console.Write("Please input a year: ");
        year = Convert.ToInt16(Console.ReadLine());
        if (year % 4 == 0) {
            if (year % 100 == 0) {
                if (year % 400 == 0) {
                    Console.WriteLine(year + isLeap);
                } else {
                    Console.WriteLine(year + notLeap);
                }
            } else {
                Console.WriteLine(year + isLeap);
            }
        } else Console.WriteLine(year + notLeap);

    }
}
