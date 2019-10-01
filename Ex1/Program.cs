using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cr1 = new CashRegister();

            Console.WriteLine($"Adding an item worth 2.70 to Cash register 1 ");
            Console.WriteLine($"Adding an item worth 3.45 to Cash register 1 ");
            Console.WriteLine($"Adding an item worth 5.97 to Cash register 1 ");

            cr1.AddItem(2.70);
            cr1.AddItem(3.45);
            cr1.AddItem(5.97);

        }
    }
}
