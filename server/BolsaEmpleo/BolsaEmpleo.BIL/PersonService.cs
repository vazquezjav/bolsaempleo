using BolsaEmpleo.DAL.LANDING;
using BolsaEmpleo.MODELS.LANDING;
using BolsaEmpleo.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.BIL
{
    public class PersonService
    {
        private readonly PersonRepository repository;

        public PersonService(PersonRepository repository)
        {
            this.repository = repository;
        }
        public void Save(PersonModel model, UsuarioModel user)
            => this.repository.Save(model, user);
    }
}
