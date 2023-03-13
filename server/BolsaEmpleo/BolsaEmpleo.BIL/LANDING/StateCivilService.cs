using BolsaEmpleo.DAL.LANDING;
using BolsaEmpleo.MODELS.LANDING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.BIL.LANDING
{
    public class StateCivilService
    {
        private readonly StateCivilRepository repository;

        public StateCivilService(StateCivilRepository repository)
        {
            this.repository = repository;
        }

        public List<StateCivilModel> GetAllActive()
            => this.repository.GetAllActive();

    }
}
