using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumber
{
    public class SwapComplete
    {
       public static void NumberSwapOrNot()
        {
            int a = 5, b = 10;
            Console.WriteLine("values before Wapping a:{a} and b:{b}");
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("after swaping the value a:{a} and b:{b}");
        }
    }
}
