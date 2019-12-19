using System;
using System.Collections.Generic;
using System.Text;

namespace NewAndOverrideAnotherExample
{
    // Define the derived class 

    // Class ConvertibleCar uses the new modifier to acknowledge that ShowDetails
    // hides the base class method
    class ConvertibleCar : Car
    {
        public new void ShowDetails()
        {
            Console.WriteLine("A roof that opens up...");
        }
    }
}
