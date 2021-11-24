using Factory.Base;
using Factory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Repository
{
    public class ManagerRepository:BaseRepository<Manager>, IManagerRepository
    {
        public override Manager Get(Guid id)
        {
            return _employees.FirstOrDefault(x => x._id == id);
        }
    }
}
