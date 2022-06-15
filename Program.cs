using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_yield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _cars = new List<Car>()
            {
                new Car {Name = "Porsche", Number = "7777XX-7"},
                new Car {Name = "Mercedes", Number = "7124KA-7"},
                new Car {Name = "Skoda", Number = "9491KA-5"},
                new Car {Name = "BMW", Number = "1208XV-6"},
                new Car {Name = "Tesla", Number = "5632EC-1"},
            };

            

            var parking = new Parking();

            //foreach (var car in _cars)
            //{
            //    parking.Add(car);
            //}

            //foreach (var car in parking)
            //{
            //    Console.WriteLine(car);
            //}

            var i = parking.GetNumbers(10);
            

            //Console.WriteLine(parking["7777XX-7"]?.Name);

            //Console.WriteLine(parking[1].Name);

            //Console.WriteLine("Введите номер нового автомобиля: ");
            //var num = Console.ReadLine();
            //parking[1] = new Car() { Name = "Toyota", Number = num };
            //Console.WriteLine(parking[1]);


            Console.ReadLine();
        }
        
    }
}
