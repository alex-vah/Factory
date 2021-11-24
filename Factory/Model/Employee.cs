using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Model
{
    public class Employee
    {
        public Guid _id = Guid.NewGuid();
        public string _name { get; set; }
        public int age { get; }
        public string _position { get; set; }
    }
}
