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
    public class PersonAplicationService
    {
        private readonly PersonAplicationRepository repository;

        public PersonAplicationService(PersonAplicationRepository repository)
        {
            this.repository = repository;
        }
        public void Save(PersonAplicationModel model, UsuarioModel user)
            =>this.repository.Save(model, user);
    }
}
