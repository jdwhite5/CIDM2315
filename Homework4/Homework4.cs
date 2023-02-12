namespace Homework4;
class Program
{

    static void Main(string[] args)
    {
        int a = 3;
        int b = 5;
        int z = greater(3, 5);
        Console.WriteLine("a = " + a  + " b = " + b);
        Console.WriteLine("The greater number is: " + z);

        shape(5, "left");
        shape(5, "right");        
    }

    static int greater(int x, int y) {
        if (x > y) {
            return x;
        } else {
            return y;
        }
    }

    static void shape(int x, string shape) {
        if (x == 5 && shape == "left") {
            Console.WriteLine("N is: " + x  + ". Shape is: " + shape);
            for (int X = 1; X <= 5; ++X) {
                for (int Y = 1; Y <= 5; ++Y) {
                    if (X >= Y) {
                     Console.Write("*");   
                    }
                }
                Console.WriteLine();
            }
        } else if (x == 5 && shape == "right") {
            Console.WriteLine("N is: " + x  + ". Shape is: " + shape);
            for (int X = 1; X <= 5; ++X) {
                for (int Y = 5; Y >= 1; --Y) {
                    if (Y <= X) {
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}