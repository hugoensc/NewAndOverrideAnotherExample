using System;
using System.Collections.Generic;
using System.Text;

namespace NewAndOverrideAnotherExample
{
    class ControlClass
    {
        public void TestCars1()
        {
            Console.WriteLine("\nTestCars1");
            Console.WriteLine("----------");

            Car car1 = new Car();
            car1.DescribeCar();

            Console.WriteLine("----------");

            // Notice the output from this test case. The new modifier is 
            // used in the definition of ShowDetails in the ConvertibleCar
            // class.

            ConvertibleCar car2 = new ConvertibleCar();
            car2.DescribeCar();
            Console.WriteLine("----------");

            Minivan car3 = new Minivan();
            car3.DescribeCar();
            Console.WriteLine("----------");
        }

        public void TestCars2()
        {
            Console.WriteLine("\nTestCar2");
            Console.WriteLine("----------");

            var cars = new List<Car> { new Car(), new ConvertibleCar(), new Minivan() };

            foreach (var car in cars)
            {
                car.DescribeCar();
                Console.WriteLine("----------");
            }
        }

        public void TestCars3()
        {
            Console.WriteLine("\nTestCars3");
            Console.WriteLine("----------");

            ConvertibleCar car2 = new ConvertibleCar();
            Minivan car3 = new Minivan();

            car2.ShowDetails();
            car3.ShowDetails();
        }

        public void TestCars4()
        {
            Console.WriteLine("\nTestCars4");
            Console.WriteLine("----------");
            
            Car car2 = new ConvertibleCar();
            Car car3 = new Minivan();

            car2.ShowDetails();
            car3.ShowDetails();
        }
    }
}
