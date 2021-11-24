using System;
using System.Collections.Generic;
using Factory.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Services
{
    public interface IManagerService
    {
        void Add(Manager manager);
        Manager Get(Guid id);
        List<Manager> GetAll();
        void Remove(Manager manager);
        void Update(Manager manager, int index);
    }
}
