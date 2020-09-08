using System;
using System.Collections.Generic;
using System.Text;

namespace O_Correct.Repository
{
    public interface IRepository<T>
    {
        public abstract void Create(T value);
        bool CheckIfExists(string username);
    }
}
