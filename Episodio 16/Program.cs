using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace episodio16
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Car car1 = new Car() { Make = "BMW", Modle = "750li", VIN = "C3" };
            Car car2 = new Car() { Make = "Toyota", Modle = "4Runner", VIN = "D4" };


            List<Car> myList = new List<Car>
            {
                new Car {Make = "Oldsmobile", Modle = "Cutless Supreme", VIN = "A1" },
                new Car {Make = "Nisan" , Modle = "Altima", VIN = "F6" }
            };

            Console.ReadLine();

        }

        class Car
        {
            public string Make { get; set; }
            public string Modle { get; set; }
            public string VIN { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }
}
