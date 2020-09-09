using L_Correct.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace L_Correct.Domains
{
    public class Monkey : Primate, TailBehavor
    {
        public void ShowTail()
        {
            Console.WriteLine($"This is my tail!!");
        }

        public override string ToString()
        {
            return "I am a monkey.";
        }
    }
}
