using BolsaEmpleo.DAL.LANDING;
using BolsaEmpleo.MODELS.LANDING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.BIL.LANDING
{
    public class InstructionService
    {
        private readonly InstructionRepository repository;

        public InstructionService(InstructionRepository repository)
        {
            this.repository = repository;
        }
        public List<InstructionModel> GetActive()
            => this.repository.GetActive();
    }
}
