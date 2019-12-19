using System;
using System.Collections.Generic;
using System.Text;

namespace NewAndOverrideAnotherExample
{

    // Define the base class, Car. The defines two methods,
    // DescribeCar and ShowDetails. DescribeCar calls ShowDeatils, and each derived
    // class also defines a ShowDetails method. The example tests which version of
    // ShowDetails is selected, the base class method or the derived class method.
    class Car
    {
        public void DescribeCar()
        {
            Console.WriteLine("Four wheels and an engine...");
            ShowDetails();
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Standard transportation.");
        }
    }
}
