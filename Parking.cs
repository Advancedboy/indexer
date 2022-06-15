using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_yield
{
    internal class Parking : IEnumerable
    {
        private List<Car> Cars = new List<Car>();
        private const int MAX_CARS = 100;

        //public тип this[тип индекс]
        //{
        //get {}
        //set {}
        //}

        public Car this[string number]
        {
            get
            {
                var car = Cars.First(c => c.Number == number);
                return car;
            }
        }

        public Car this[int position]
        {
            get
            {
                if (position < MAX_CARS)
                {
                    return Cars[position];
                }
                return null;
            }
            set
            {
                if (position < MAX_CARS)
                {
                    Cars[position] = value;
                }
            }
        }

        public int Count => Cars.Count;
        public string Name { get; set; }
        
        public int Add(Car car)
        {
            if(car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car is null:(");
            }
            if (car is Car)
            {
                if (Cars.Count < MAX_CARS) {
                    Cars.Add(car);
                    return Cars.Count - 1;
                }
            }
            return -1;
        }
        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "Number is null or white space.");
            }

            var car = Cars.First(c => c.Number == number);
            if(car != null)
            {
                Cars.Remove(car);
            }
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        public IEnumerator<int> GetNumbers(int max)
        {
            var current = 0;
            for (int i = 0; i < max; i++)
            {
                current += i;
                yield return current;
            }
        }

    }

    public class ParkingEnumerator : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
