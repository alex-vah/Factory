using System;
using Factory.Repository;
using Factory.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository employeeRepository;
        public EmployeeService(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public void Add(Employee employee)
        {
            employeeRepository.Add(employee);
        }

        public Employee Get(Guid id)
        {
            return employeeRepository.Get(id);
        }

        public List<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

        public void Remove(Employee employee)
        {
            employeeRepository.Remove(employee);
        }

        public void Update(Employee employee, int index)
        {
            var oldEmployee = employeeRepository.Get(employee._id);
            index = employeeRepository.IndexOf(oldEmployee);
           
        }
    }
}
