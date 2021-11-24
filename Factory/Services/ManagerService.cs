using Factory.Repository;
using Factory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Services
{
    public class ManagerService:IManagerService
    {
        private readonly ManagerRepository _managerRepository;
        public ManagerService(ManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }

        public void Add(Manager manager)
        {
            _managerRepository.Add(manager);
        }

        public Manager Get(Guid id)
        {
            return _managerRepository.Get(id);
        }

        public List<Manager> GetAll()
        {
            return _managerRepository.GetAll();
        }

        public void Remove(Manager manager)
        {
            _managerRepository.Remove(manager);
        }

        public void Update(Manager manager, int index)
        {
            var oldManager = _managerRepository.Get(manager._id);
            index = _managerRepository.IndexOf(oldManager);
            _managerRepository.Update(manager, index);

        }
        
    }
}
