using System;
using System.Collections.Generic;
using System.Text;
using O_Correct.Domain;

namespace O_Correct.Repository
{
    public class UserRepository : IRepository<User>
    {
        public void Create(User value)
        {
            Console.WriteLine($"Adding {value.Username} to database");
            return;
        }

        public bool CheckIfExists(string username)
        {
            Console.WriteLine($"Verifying if {username} exists in database..");
            return false;
        }
    }
}
