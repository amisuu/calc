using calc.Operators.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace calc
{
    public class Program
    {
        static Parser parser;
        static IUserInterface userInterface;
        static IKernel kernel;

        public static void Main(string[] args)
        {
            kernel = new StandardKernel(new Binding());
            parser = new Parser();
            Stack<object> objectStack = new Stack<object>();
            string input = "";

            userInterface = kernel.Get<IUserInterface>();

            AddOperators();

            userInterface.WriteStack(objectStack);
            while ((input = Console.ReadLine()) != "quit")
            {
                try
                {
                    parser.ParseDo(input, objectStack);
                    userInterface.WriteStack(objectStack);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

        private static void AddOperators()
        {
            parser.Operators = new List<IOperator>();

            var operators = from typ in Assembly.GetExecutingAssembly().GetTypes()
                            where typ.GetInterfaces().Contains(typeof(IOperator)) 
                                || typ.GetInterfaces().Contains(typeof(IOperatorPlus))
                            select Activator.CreateInstance(typ) as IOperator;

            var operatorList = operators.ToList<IOperator>();

            foreach (var operatorItem in operatorList)
            {
                parser.Operators.Add(operatorItem);
            }
        }
    }
}

