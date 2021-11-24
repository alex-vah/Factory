using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Base
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        public List<T> _employees;
        public BaseRepository()
        {
            _employees = new List<T>();
        }
        public virtual void Add(T employee)
        {
            _employees.Add(employee);  
        }
        public virtual T Get(Guid id)
        {
            throw new NotImplementedException();
        }
        public virtual List<T> GetAll()
        {
            return _employees;
        }
        public virtual void Remove(T employee)
        {
             _employees.Remove(employee);
        }
        public virtual void Update(T employee, int index)
        {
            _employees[index] = employee;
        }
        public virtual int IndexOf(T employee)
        {
            return _employees.IndexOf(employee);
        }
     
    }
}
