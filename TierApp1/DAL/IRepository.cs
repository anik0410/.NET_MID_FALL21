using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T,ID>
    {
        void Add(T e);
        List<T> Get();
        T Get(ID id);
    }
}
