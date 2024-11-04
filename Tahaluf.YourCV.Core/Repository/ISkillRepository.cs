using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
   public interface ISkillRepository
    {
        bool CreateSkill(Skill skill);
        List<Skill> GetAllSkill();
        bool UpdateSkill(Skill skill);
        bool DeleteSkill(int id);
        List<Skill> GetSkilltById(Skill skill);
    }
}
