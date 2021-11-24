using System;
using Factory.Base;
using Factory.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Repository
{
    public class EmployeeRepository:BaseRepository<Employee>, IEmployeeRepository
    {

    }
}
