using O_Correct.Domain;
using O_Correct.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace O_Correct.Services
{
    public class RegistrationServiceUsername : IRegistrationServiceUsername
    {
        private List<string> blocked_usernames;
        private IRepository<User> repository => new UserRepository();

        public RegistrationServiceUsername()
        {
            this.blocked_usernames = new List<string>();

            this.blocked_usernames.Add("admin");
            this.blocked_usernames.Add("root");
        }

        private bool VerifyIfAllowed(string username)
        {
            return !this.blocked_usernames.Contains(username);
        }

        private bool CheckIfExists(string username)
        {
            return repository.CheckIfExists(username);
        }

        public bool Check(string username)
        {
            if (!VerifyIfAllowed(username))
            {
                Console.WriteLine($"The username '{username}' is not allowed to use.");
                return false;
            }

            if (CheckIfExists(username))
            {
                Console.WriteLine("This user already exists in database.");
                return false;
            }

            return true;
        }
    }
}
