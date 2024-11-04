using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.YourCV.Core.Common;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;

namespace Tahaluf.YourCV.Infra.Repository
{
    public class SkillRepository: ISkillRepository
    {
        private readonly IDbContext dbContext;

        public SkillRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool CreateSkill(Skill skill)
        {
            var p = new DynamicParameters();
            p.Add("@Name", skill.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ResumeId", skill.ResumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            return dbContext.Connection.ExecuteAsync("CreateSkill", p, commandType: CommandType.StoredProcedure).Result>0;
        }

        public List<Skill> GetAllSkill()
        {
            IEnumerable<Skill> result = dbContext.Connection.Query<Skill>("GetAllSkill", CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateSkill(Skill skill)
        {
            var p = new DynamicParameters();
            p.Add("@Id", skill.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", skill.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ResumeId", skill.ResumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            return dbContext.Connection.ExecuteAsync("UpdateSkill", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public bool DeleteSkill(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbContext.Connection.ExecuteAsync("DeleteSkill", p, commandType: CommandType.StoredProcedure).Result>0;
        }


        public List<Skill> GetSkilltById(Skill skill)
        {
            var p = new DynamicParameters();
            p.Add("@Id", skill.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Skill> result = dbContext.Connection.Query<Skill>("GetSkillById", CommandType.StoredProcedure);
            return result.ToList();

        }

    }
}
