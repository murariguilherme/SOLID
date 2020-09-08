using L_Wrong.Domains;
using System;

namespace L_Wrong
{
    class Program
    {
        //People think that monkeys and apes are the same thing. Isn't!
        //While monkeys have tails and don't have appendix, the apes are the opposite.
        //So.. we've a problem with de Liskov principle, if a chimpanzee is not a monkey, the chimpanzee class cannot be substituted 
        //by monkey class
        static void Main(string[] args)
        {
            Monkey chimpanzee = new Monkey();
            Console.WriteLine(chimpanzee.ToString());
            Console.ReadLine();
        }
    }
}
