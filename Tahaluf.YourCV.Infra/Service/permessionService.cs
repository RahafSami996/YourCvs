using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
   public class PermessionService: IPermessionService
    {
        private readonly IPermessionRepository PermessionRepository;

        public PermessionService(IPermessionRepository _PermessionRepository)
        {
            PermessionRepository = _PermessionRepository;
        }
       public bool CreatePermession(Permession Permession)
        {
            return PermessionRepository.CreatePermession(Permession);
        }
        public bool UpdatePermession(Permession Permession)
        {
            return PermessionRepository.UpdatePermession(Permession);

        }
        public bool DeletePermession(int id)
        {
            return PermessionRepository.DeletePermession(id);
        }
        public List<Permession> GetPermessionByName(Permession Permession)
        {
            return PermessionRepository.GetPermessionByName(Permession);
        }
        public List<Permession> GetPermessionById(int id)
        {
            return PermessionRepository.GetPermessionById(id);
        }
        public List<Permession> GetAllPermession()
        {
            return PermessionRepository.GetAllPermession();
        }
    }
}
