namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        int c;
        int d;
        int max;
        int max1;
        int max2;

        //Q1 Larger of Two
        Console.Write("Input the first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        max = larger(a, b);
        Console.WriteLine("The largest number is : " + max);
        Console.WriteLine();

        // Larger of Four
        Console.Write("Input the first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a third number: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a forth number: ");
        d = Convert.ToInt32(Console.ReadLine());
        max1 = larger(a, b);
        max2 = larger(c, d);
        max = larger(max1, max2);
        Console.WriteLine("The larget number is : " + max);
        Console.WriteLine();

        //Q3
        createAccount(); 

    }

    static int larger(int a, int b) {
        if (a > b) {
            return a;
        } else {
            return b;
        }
    }

    static bool checkAge(int birthYear) {
        int Year = 2023; 
        int age = Year - birthYear;
        if (age >=18) {
            return true;
        } else {
            return false;
        }
    }

    static void createAccount() {
        Console.Write("Enter Your Username: ");
        string username = Console.ReadLine()!;
        Console.Write("Enter Your Password: ");
        string password = Console.ReadLine()!;
        Console.Write("Enter Password Again: ");
        string password2 = Console.ReadLine()!;
        Console.Write("Enter Birth Year: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());
        if (checkAge(birthYear) == true) {
            if (password == password2) {
                Console.WriteLine("Account is created successfully");
            } else {
                Console.WriteLine("Wrong Password");
            }
        } else {
            Console.WriteLine("Could not create an account");
        }
    }
}
