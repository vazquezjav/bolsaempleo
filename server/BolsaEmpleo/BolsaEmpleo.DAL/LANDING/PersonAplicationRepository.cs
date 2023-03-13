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
    public class PersonAplicationRepository
    {
        private readonly IDbContext dbContext;

        public PersonAplicationRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Save(PersonAplicationModel model, UsuarioModel user)
        {
            if (user != null) model.setAuditCreate(user);
            string sql = "INSERT INTO public.usr_aplicacion (usr_area, usr_persona, usr_conocimiento, usr_sector_publico, usr_sector_privado, usr_cv, crea_fecha, crea_usr, crea_ip, mod_fecha, mod_ip, mod_usr)" +
                "VALUES(@usr_area, @usr_persona, @usr_conocimiento, @usr_sector_publico, @usr_sector_privado, @usr_cv, @crea_fecha, @crea_usr, @crea_ip, @mod_fecha, @mod_ip, @mod_usr);";
            this.dbContext.excecuteQuery(sql, model);
        }
    }
}
