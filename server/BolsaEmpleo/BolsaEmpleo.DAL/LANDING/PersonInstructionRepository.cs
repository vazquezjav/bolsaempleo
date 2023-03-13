using BolsaEmpleo.DAL.DBContext;
using BolsaEmpleo.MODELS;
using BolsaEmpleo.MODELS.LANDING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.DAL.LANDING
{
    public class PersonInstructionRepository
    {
        private readonly IDbContext dbcontext;

        public PersonInstructionRepository(IDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public void Save(PersonInstructionModel model, UsuarioModel user)
        {
            if (user != null) model.setAuditCreate(user);
            string sql = "INSERT INTO public.usr_persona_instruccion (usr_instruccion, usr_persona, usr_nombre_titulo, crea_usr, crea_fecha, crea_ip, mod_usr, mod_ip, mod_fecha)" +
                " VALUES(@usr_instruccion, @usr_persona, @usr_nombre_titulo, @crea_usr, @crea_fecha, @crea_ip, @mod_usr, @mod_ip, @mod_fecha);";
            this.dbcontext.excecuteQuery(sql, model);
        }
    }
}
