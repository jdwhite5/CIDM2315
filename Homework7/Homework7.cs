namespace Homework7;

class Customer 
{

    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int new_cus_id, string new_cus_name, int new_cus_age) {
        cus_id = new_cus_id;
        cus_name = new_cus_name;
        cus_age = new_cus_age;
    }

    public void ChangeID(int new_id) {
        cus_id = new_id;
    }

    public void PrintCusInfo() {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer) {
        if (this.cus_age > objCustomer.cus_age) {
            Console.WriteLine($"{this.cus_name} is older");
        } else {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Customer Alice = new Customer(110, "Alice", 28);
        Customer Bob = new Customer(111, "Bob", 30);

        Alice.PrintCusInfo();
        Bob.PrintCusInfo();

        Alice.ChangeID(220);
        Bob.ChangeID(221);

        Alice.PrintCusInfo();
        Bob.PrintCusInfo();

        Alice.CompareAge(Bob);
    }
}
