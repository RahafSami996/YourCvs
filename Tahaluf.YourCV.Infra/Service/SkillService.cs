using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository skillRepository;

        public SkillService(ISkillRepository _skillRepository)
        {
            skillRepository = _skillRepository;
        }

        public bool CreateSkill(Skill skill)
        {
            return skillRepository.CreateSkill(skill);
        }

        public bool DeleteSkill(int id)
        {
            return skillRepository.DeleteSkill(id);
        }

        public List<Skill> GetAllSkill()
        {
            return skillRepository.GetAllSkill();
        }

        public List<Skill> GetSkilltById(Skill skill)
        {
            return skillRepository.GetSkilltById(skill);
        }

        public bool UpdateSkill(Skill skill)
        {
            return skillRepository.UpdateSkill(skill);
        }
    }
}
