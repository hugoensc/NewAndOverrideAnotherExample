using System;

namespace NewAndOverrideAnotherExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlClass objectControl = new ControlClass();

            // Declare objects of the derived classes and test which version
            // of ShowDetails is run, base or derived.
            objectControl.TestCars1();

            // Declare object of the base class, instantiated with the
            // derived classes, and repeat the tests.
            objectControl.TestCars2();

            // Declare objects of the derived classes and call ShowDetails
            // directly
            objectControl.TestCars3();

            // Declare objects of the base class, instantiated with the
            // derived classes, and repeat the tests.
            objectControl.TestCars4();
        }
    }
} 
