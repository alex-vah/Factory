using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Model
{
    public class Manager
    {
        public Guid _id = Guid.NewGuid();
        public string _name { get; set; }
        public int _age { get; }
        public string _position { get; set; }
    }
}
