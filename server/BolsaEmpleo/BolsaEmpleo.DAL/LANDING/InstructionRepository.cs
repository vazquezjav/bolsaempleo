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
    public class InstructionRepository
    {
        private readonly IDbContext dbcontext;

        public InstructionRepository(IDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public List<InstructionModel> GetActive()
            => this.dbcontext.getList<InstructionModel>($"select a.* from instruccion a where a.ins_estado ={(int)StateEnum.ACTIVE}");
    }
}
