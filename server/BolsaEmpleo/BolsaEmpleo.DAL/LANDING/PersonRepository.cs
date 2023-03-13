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
    public class PersonRepository
    {
        private readonly IDbContext dbContext;

        public PersonRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Save(PersonModel model, UsuarioModel user)
        {
            if (user != null) model.setAuditCreate(user);
            string sql = "INSERT INTO public.usr_persona (usr_cedula, usr_primer_nombre, usr_segundo_nombre, usr_primer_apellido, usr_segundo_apellido, usr_telefono, usr_celular, usr_estado_civil, usr_fecha_nacimiento, usr_direccion, usr_discapacidad, usr_numero_hijo, usr_provincia, usr_canton, usr_mail, usr_foto, crea_usr, crea_fecha, crea_ip, mod_usr, mod_ip, mod_fecha,usr_cv)" +
                "VALUES( @usr_cedula, @usr_primer_nombre, @usr_segundo_nombre, @usr_primer_apellido, @usr_segundo_apellido, @usr_telefono, @usr_celular, @usr_estado_civil, @usr_fecha_nacimiento, @usr_direccion, @usr_discapacidad, @usr_numero_hijo, @usr_provincia, @usr_canton, @usr_mail, @usr_foto, @crea_usr, @crea_fecha, @crea_ip, @mod_usr, @mod_ip, @mod_fecha,@usr_cv);";
            this.dbContext.excecuteQuery(sql, model);
        }
    }
}
