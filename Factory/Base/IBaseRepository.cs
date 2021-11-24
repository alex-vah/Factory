using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Base
{
    public interface IBaseRepository<T>
    {
        void Add(T employee);
        T Get(Guid id);
        List<T> GetAll();
        void Update(T employee, int index);
        void Remove(T employee);
        int IndexOf(T employee);
    }
}
