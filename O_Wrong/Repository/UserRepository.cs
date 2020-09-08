using System;
using System.Collections.Generic;
using System.Text;
using O_Wrong.Domain;

namespace O_Wrong.Repository
{
    public class UserRepository : IRepository<User>
    {
        public override void Create(User value)
        {
            Console.WriteLine($"Adding {value.Username} to database");
            return;
        }
    }
}
