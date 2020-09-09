﻿using L_Correct.Domains;
using System;

namespace L_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            Primate chimpanzee = new Chimpanzee();
            Console.WriteLine(chimpanzee.ToString());

            Primate monkey = new Monkey();
            Console.WriteLine(monkey.ToString());

            Monkey monkey2 = new Monkey();
            monkey2.ShowTail();

            Console.ReadLine();
        }
    }
}
