using System;

namespace ConsoleAppStategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Strategy Pattern === Test1");

            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting");
            context.SetStrategy(new ConcreteStrategyRegularOrder());
            context.ExecuteListOrder();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting");
            context.SetStrategy(new ConcreteStrategyReverseOrder());
            context.ExecuteListOrder();

        }
    }
}
