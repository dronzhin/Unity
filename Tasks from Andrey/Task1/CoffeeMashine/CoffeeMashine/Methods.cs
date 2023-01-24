using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoffeeMashine
{
    public class Methods
    {
        public static string CoffeeTaste(int multiplier)
        {
            string[] arrayTaste = { "плохой вкус", "Нормальный вкус", "отличный вкус", "изысканный вкус", "неизвестный вкус" };
            switch (multiplier)
            {
                case 1:
                     return arrayTaste[0];
                case 2:
                    return arrayTaste[0];
                case 3:
                    return arrayTaste[0];
                case 4:
                    return arrayTaste[1];
                case 5:
                    return arrayTaste[1];
                case 6:
                    return arrayTaste[1];
                case 7:
                    return arrayTaste[2];
                case 8:
                    return arrayTaste[2];
                case 9:
                    return arrayTaste[3];
                case 10:
                    return arrayTaste[3];
                default:
                    return arrayTaste[4];
            }
        }
        public static string GetString(string request)
        {
            Console.Write(request + " - ");
            return Console.ReadLine();
        }
        public static int GetValue(string request)
        {
            Console.Write(request + " - ");
            return int.Parse(Console.ReadLine());
        }
        public static string TypeOfCoffeeMashine(int multiplier)
        {
            string[] arrayTaste = { "Капсульная кофемашина", "Рожковая кофемашина", "Неизвестная кофемашина" };
            switch (multiplier)
            {
                case 1:
                    return arrayTaste[0];
                case 2:
                    return arrayTaste[1];
                default:
                    return arrayTaste[2];
            }
        }
        public static string TypeOfCoffee(int multiplier)
        {
            string[] arrayTaste = { "Американо", "Капучино", "Латте", "Неизвестное кофе" };
            switch (multiplier)
            {
                case 1:
                    return arrayTaste[0];
                case 2:
                    return arrayTaste[1];
                case 3:
                    return arrayTaste[2];
                default:
                    return arrayTaste[3];
            }
        }
        public static string[] createAdditivesArray()
        {
            string[] arrayTaste = { "Корица", "Ваниль", "Гвоздика", "Мускатный орех", "Апельсиновая корка", "Неизвестный ингредиент" };
            string[] array = new string[arrayTaste.Length];
            for (int i = 0; i < arrayTaste.Length; i++)
            {
                try
                {
                    int answer = GetValue("\nВведите добавки к вашему кофе, выберите цифру " +
                        "\n1 - Корица" +
                        "\n2 - Ваниль" +
                        "\n3 - Гвоздика" +
                        "\n4 - Мускатный орех" +
                        "\n5 - Апельсиновая корка" +
                        "\n6 - Закончить выбор ингридиентов" +
                        "\nВаш ответ");
                    if (answer == 6)
                    {
                        Array.Resize(ref array, i);
                        Console.WriteLine("Вы выбрали ингридиенты \n" + string.Join(" ", array));
                        return array;

                    }
                    if (answer > 0 && answer <= array.Length)
                    {
                        array[i] = arrayTaste[answer - 1];
                        
                    }
                    else
                    {
                        Console.WriteLine($"Вы ввели не число от 1 до {array.Length}");
                        i -= 1;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Вы ввели не число от 1 до {array.Length}");
                }   
            }
            Console.WriteLine("Вы выбрали ингридиенты \n" + string.Join(" ", array));
            return array;
        }
    }
}
