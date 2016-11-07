using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {

            //Car car1 = new Car();
            //car1.Ride();
            //Bicycle bicycle1 = new Bicycle();
            //bicycle1.Ride();
            //bicycle1.PlayMelody();
            //Skateboard deska1 = new Skateboard();
            //deska1.Ride();


            //List<int> lista1 = new List<int>();
            //lista1.Add(3);
            //lista1.Add(4);
            //lista1.Add(5);
            //lista1.Add(-1);

            //foreach (var element in lista1)
            //{
            //    Console.WriteLine(element);
            //}

            //lista1.Sort();

            //Console.WriteLine("Po sortowaniu");
            //foreach (var element in lista1)
            //{
            //    Console.WriteLine(element);
            //}

            //for (int i = 0; i < lista1.Count; i++)
            //{
            //    Console.WriteLine(lista1[i]);
            //}
            List<Car> cars = new List<Car>();
            cars.Add(new Car(2010, "Ford"));
            cars.Add(new Car(2016, "Fiat"));
            cars.Add(new Car(2012, "Skoda"));
            cars.Add(new Car(2010, "BMW"));

            foreach (var element in cars)
            {
                Console.WriteLine(element.GetYear() + ", " +element.GetBrand());
            }

            cars.Sort();
            Console.WriteLine("Po sortowaniu");
            foreach (var element in cars)
            {
                Console.WriteLine(element.GetYear() + ", " + element.GetBrand());
            }

            Console.ReadKey();
        }
    }
}
