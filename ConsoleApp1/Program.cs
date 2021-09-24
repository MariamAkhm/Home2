using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Мин.значение byte "+byte.MinValue);
            byte democration = 10;
            byte agression = 2;
            democration = checked((byte)(agression - democration));
            Console.WriteLine(democration);

        }
    }
}
