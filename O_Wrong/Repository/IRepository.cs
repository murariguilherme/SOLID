using System;
using System.Collections.Generic;
using System.Text;

namespace O_Wrong.Repository
{
    public abstract class IRepository<T>
    {
        public abstract void Create(T value);
    }
}
