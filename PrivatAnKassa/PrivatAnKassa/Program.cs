using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using PrivatAnKassa;

namespace PrivatAnKassa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Buchungssatz bs = new Buchungssatz(Console.ReadLine());
			bs.DisplayStats();
			Console.ReadKey();
        }
    }
}
