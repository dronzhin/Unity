using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoffeeMashine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human dima = new Human();
            dima.MakeCoffee(new CapsuleMashine(), new Latte());
            Console.WriteLine();
            dima.MakeCoffee(new CarobCoffeeMachine(), new Cappuccino());
            Console.WriteLine();

        }
    }
}
