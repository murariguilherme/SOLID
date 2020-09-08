using O_Wrong.Domain;
using O_Wrong.Services;
using System;

namespace O_Wrong
{
    class Program
    {
        //Open closed principle
        //Should be open for extension, but closed for modification
        //Robert C. Martin considered this principle as the “the most important principle of object-oriented design”
        //Every new user we want to reject the creation, we must add the username in the method UserService.CreateUser(), 
        //isn't sounds good.
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
