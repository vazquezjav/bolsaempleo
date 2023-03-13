using BolsaEmpleo.DAL.DBContext;
using BolsaEmpleo.MODELS.ENUMS;
using BolsaEmpleo.MODELS.LANDING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.DAL.LANDING
{
    public class StateCivilRepository
    {
        private readonly IDbContext dbContext;

        public StateCivilRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<StateCivilModel> GetAllActive()
            => this.dbContext.getList<StateCivilModel>($"select a.* from estadocivil a where a.esc_estado ={(int)StateEnum.ACTIVE}");
    }
}
