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
        //public static void CoffeeTaste(int multiplier)
        //{
        //    string[] arrayTaste = { "плохой вкус", "Нормальный вкус", "отличный вкус", "изысканный вкус", "неизвестный вкус" };
        //    switch (multiplier)
        //    {
        //        case 1: Console.Write(arrayTaste[0]);
        //            break;
        //        case 2: Console.Write(arrayTaste[0]);
        //            break;
        //        case 3: Console.Write(arrayTaste[0]);
        //            break;
        //        case 4: Console.Write(arrayTaste[1]);
        //            break;   
        //        case 5: Console.Write(arrayTaste[1]);
        //            break;
        //        case 6: Console.Write(arrayTaste[1]);
        //            break;
        //        case 7: Console.Write(arrayTaste[2]);
        //            break;
        //        case 8: Console.Write(arrayTaste[2]);
        //            break;
        //        case 9: Console.Write(arrayTaste[3]);
        //            break;
        //        case 10: Console.Write(arrayTaste[3]);
        //            break;
        //        default: Console.Write(arrayTaste[4]);
        //            break;
        //    }
        //}
    }
}
