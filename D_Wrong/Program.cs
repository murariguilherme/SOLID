using System;

namespace D_Wrong
{
    class Program
    {
        //Let's use the I_Correct project as a DIP wrong implementation
        //The DIP principle says that we don't have to create dependencies by classes (high coupling).
        //So.. we need to use interfaces.
        //This is my favorite principle, this going to help a write a good code and easy testing as well, because you could just create
        //a mock with MOQ package.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
