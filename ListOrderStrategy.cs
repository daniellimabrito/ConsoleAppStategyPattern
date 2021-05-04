using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStategyPattern
{
    class ListOrderStrategy
    {
    }

    public class Context
    {
        private IStrategy _strategy;

        public Context()
        { }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteListOrder()
        {
            Console.WriteLine("Context: Sorting data using the strategy.");

            var result = _strategy.Execute(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;

            foreach (var item in result as List<string>)
            {
                resultStr += item + " ";
            }

            Console.WriteLine(resultStr);
        }

    }

    public interface IStrategy
    {
        object Execute(object data);
    }

    public class ConcreteStrategyRegularOrder : IStrategy
    {
        public object Execute(object data)
        {
            var obj = data as List<string>;
            obj.Sort();
            return obj ;
        }
    }

    public class ConcreteStrategyReverseOrder : IStrategy
    {
        public object Execute(object data)
        {
            var obj = data as List<string>;
            obj.Sort();
            obj.Reverse();
            return obj;
        }
    }
}
