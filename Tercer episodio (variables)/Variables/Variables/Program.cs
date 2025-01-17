using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x+3;
            Console.WriteLine(y);
            Console.ReadLine();
            */
            Console.WriteLine("Cual es tu nombre?");
            Console.WriteLine("Tu primer nombre");
            string myfristname;
            myfristname= Console.ReadLine();

            string mylastname;
            Console.WriteLine("Tu apellido");
            mylastname= Console.ReadLine();

            Console.WriteLine("Hello " + myfristname+ " " + mylastname);
            Console.ReadLine();

        }
    }
}
