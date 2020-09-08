using O_Correct.Domain;
using O_Correct.Services;
using System;

namespace O_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new UserService();

            var user = new User() { Username = "Paolo Facchini", Password = "Testing" };
            service.CreateUser(user);

            var anotheruser = new User() { Username = "root", Password = "Testing" };
            service.CreateUser(anotheruser);
            Console.ReadLine();
        }
    }
}
