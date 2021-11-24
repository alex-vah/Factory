using System;
using Factory.Repository;
using Factory.Services;
using Factory.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            ManagerRepository managerRepository = new ManagerRepository();

            Manager manager1 = new Manager() { _name = "a", _position = "CEO" };
            Manager manager2 = new Manager() { _name = "b", _position = "CFO" };
            Employee employee1 = new Employee() { _name = "as" , _position="intern"};
            Employee employee2 = new Employee() { _name = "as", _position = "intern" };
            Employee employee3 = new Employee() { _name = "as", _position = "intern" };
            Employee employee4 = new Employee() { _name = "as", _position = "intern" };
            Employee employee5 = new Employee() { _name = "as", _position = "intern" };

            EmployeeService employeeService = new EmployeeService(employeeRepository);
            ManagerService managerService = new ManagerService(managerRepository);

            employeeService.Add(employee1);
            employeeService.Add(employee2);
            employeeService.Add(employee3);
            employeeService.Add(employee4);
            employeeService.Add(employee5);
            managerService.Add(manager1);
            managerService.Add(manager2);
            foreach(var item in employeeService.GetAll())
            {
                Console.WriteLine(item);
            }
            foreach(var item in managerService.GetAll())
            {
                Console.WriteLine(item);
            }
            employeeService.Remove(employee5);
            foreach (var item in employeeService.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
