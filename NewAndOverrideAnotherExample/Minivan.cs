using System;
using System.Collections.Generic;
using System.Text;

namespace NewAndOverrideAnotherExample
{
    // Class Minivan uses the override modifier to specify that ShowDetails
    // extends the base class method.
    class Minivan : Car
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Carries seven people ...");
        }
    }
}
