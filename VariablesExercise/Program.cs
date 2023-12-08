namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int model = 6;
            char bundle = 'A';
            bool isBundled = true;
            double discount = 20.00;
            decimal msrp = 799.99m;
            string name;
            name = "Playstation";

            Console.WriteLine($"Lemme get ah {name} {model}\n");
            Console.WriteLine($"Cashier: Which one?\n");
            Console.WriteLine($"Does bundle {bundle} get the {discount} percent off?\n");
            Console.WriteLine($"Cashier: Yes! Its {isBundled} so that we can offer more extras for lower prices.\n");
            Console.WriteLine($"Great! I'll take the one for msrp {msrp}. Bag it up my boy"); //will use \n when appropiate from now on 
        }
    }
}
