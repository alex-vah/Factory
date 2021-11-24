using System;
using System.Collections.Generic;
using System.Linq;
using Factory.Model;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Services
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        Employee Get(Guid id);
        List<Employee> GetAll();
        void Remove(Employee employee);
        void Update(Employee employee, int index);
    }
}
