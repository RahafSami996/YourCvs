using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
    public interface IPermessionRepository
    {
        bool CreatePermession(Permession Permession);
        bool UpdatePermession(Permession Permession);
        bool DeletePermession(int id);
        List<Permession> GetPermessionByName(Permession Permession);
        List<Permession> GetPermessionById(int id);
        List<Permession> GetAllPermession();
    }
}
