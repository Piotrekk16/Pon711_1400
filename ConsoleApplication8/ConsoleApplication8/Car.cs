using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Car : Vehicle, IRideable, IComparable<Car>
    {
        public void Ride()
        {
            Console.WriteLine("Jadę samochodem");
        }

        private int year;
        private string brand;

        public Car(int year, string brand)
        {
            this.year = year;
            this.brand = brand;
        }

        public int GetYear()
        {
            return year;
        }

        public string GetBrand()
        {
            return brand;
        }

        public int CompareTo(Car other)
        {
            if (this.year == other.year)
            {
                return this.brand.CompareTo(other.brand);
            }
            return other.year.CompareTo(this.year);
        }
    }
}
