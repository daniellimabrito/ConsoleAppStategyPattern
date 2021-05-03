using System;

namespace ConsoleAppStategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Strategy Pattern ===");

            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting");
            context.SetStrategy(new ConcreteStrategyRegular());
            context.ExecuteListOrder();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting");
            context.SetStrategy(new ConcreteStrategyReverse());
            context.ExecuteListOrder();

        }
    }
}
