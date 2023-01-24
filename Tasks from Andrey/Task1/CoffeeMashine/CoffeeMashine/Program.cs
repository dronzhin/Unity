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
            string name = Methods.GetString("Введите ваше Имя");
            Console.WriteLine();
            Console.WriteLine($"Добрый день {name}! Вас приветствует - Механический Баристо!!!");
            Console.WriteLine();
            int coffeeMashine = 0;
            CoffeeMashine mashine = null;
            Coffee userCoffee = null;
            string[] additivesArray = null;
            while (coffeeMashine == 0)
            {
                while (coffeeMashine != 1 && coffeeMashine != 2)
                {
                    try
                    {
                        coffeeMashine = Methods.GetValue("Выберите кофемашину, введите цифру " +
                            "\n1 - Капсульная" +
                            "\n2 - Рожкова" +
                            "\nВаш ответ");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Вы ввели не число 1 или 2");
                    }
                }
                Console.WriteLine($"Вы выбрали - " + Methods.TypeOfCoffeeMashine(coffeeMashine));
                Console.WriteLine();
                int coffee = 0;
                while (coffee != 1 && coffee != 2 && coffee != 3)
                {
                    try
                    {
                        coffee = Methods.GetValue("Выберите кофе, которое вы хотите выпить " +
                            "\n1 - Американо" +
                            "\n2 - Капучино" +
                            "\n3 - Латте" +
                            "\nВаш ответ");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Вы ввели не число 1 или 2 или 3");
                    }
                }
                switch (coffee)
                {
                    case 1:
                        userCoffee = new Americano();
                        break;
                    case 2:
                        userCoffee = new Cappuccino();
                        break;
                    case 3:
                        userCoffee = new Latte();
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Вы выбрали - " + Methods.TypeOfCoffee(coffee));
                Console.WriteLine();
                additivesArray = Methods.createAdditivesArray();
                Console.WriteLine();
                if (coffeeMashine == 1)
                {
                    mashine = new CapsuleMashine();
                }
                else
                {
                    mashine = new CarobCoffeeMachine();
                }
                if (additivesArray.Length > 1 && !mashine.CheckUseFewAdditives)
                {
                    Console.WriteLine($"Вы выбрали {Methods.TypeOfCoffeeMashine(coffeeMashine)}" +
                        $" и она к сожалению не может сделать несколько добавок, \nвыберете другую кофемашину или измените величину добавок");
                    coffeeMashine = 0;
                }
            }
            Human dima = new Human();
            dima.MakeCoffee(mashine, userCoffee);
            Console.WriteLine();
            dima.MakeCoffeeWithAdditives(mashine, userCoffee, additivesArray);

        }
    }
}
