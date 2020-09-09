using System;
using System.Collections.Generic;
using System.Text;

namespace L_Wrong.Domains
{
    public class Chimpanzee: Monkey
    {
        override public void ShowTail()
        {
            Console.WriteLine($"I don't have a tail!!");
        }
    }
}
