using BolsaEmpleo.DAL.LANDING;
using BolsaEmpleo.MODELS.LANDING;
using BolsaEmpleo.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.BIL.LANDING
{
    public class PersonInstructionService
    {
        private readonly PersonInstructionRepository repository;

        public PersonInstructionService(PersonInstructionRepository repository)
        {
            this.repository = repository;
        }
        public void Save(PersonInstructionModel model, UsuarioModel user)
            => this.repository.Save(model, user);
    }
}
