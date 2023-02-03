namespace Homework3;
class Homework3
{
    static void Main(string[] args)
    {
        int N;
        Console.Clear();

        // Q1 Prime Numbers
        Console.Write("Please enter a number: ");
        N = Convert.ToInt32(Console.ReadLine());
        for (int X = 2; X <= N; ++X) {
            if (X == N) {
                Console.WriteLine(N + " is a prime number");
                Console.WriteLine();
            }
            if (X != N) {
                if (N%X == 0) {
                Console.WriteLine(N + " is a non-prime number");
                Console.WriteLine();
                break;
            }
            }
        }

        // Cleaning up for next question
        Console.Write("Press <Enter> to continue...");
        while (true) {
            if (Console.ReadKey().Key == ConsoleKey.Enter) {
                Console.Clear();
                break;
            }
        }
        
        //Q2 Square Pattern
        Console.Write("Please enter a number: ");
        N = Convert.ToInt32(Console.ReadLine());
        for (int X = 1; X <= N; ++X) {
            for (int Y = 1; Y <= N; ++Y) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Cleaning up for next question
        Console.Write("Press <Enter> to continue...");
        while (true) {
            if (Console.ReadKey().Key == ConsoleKey.Enter) {
                Console.Clear();
                break;
            }
        }

        //Q3 Rows
        Console.Write("Please enter a number: ");
        N = Convert.ToInt32(Console.ReadLine());
        for (int X = 1; X <= N; ++X) {
            for (int Y = 1; Y <= N; ++Y) {
                if (X >= Y) {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Cleaning up for next question
        Console.Write("Press <Enter> to continue...");
        while (true) {
            if (Console.ReadKey().Key == ConsoleKey.Enter) {
                Console.Clear();
                break;
            }
        }

        // Bonus Question
        Console.Write("Please enter a number: ");
        N = Convert.ToInt32(Console.ReadLine());
        for (int X = 1; X <= N; ++X) {
            for (int Y = N; Y >= 1; --Y) {
                if (Y <= X) {
                    Console.Write(X);
                } else if (Y > X) {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }


    }
}
