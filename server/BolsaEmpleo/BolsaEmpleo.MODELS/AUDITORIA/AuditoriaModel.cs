using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BolsaEmpleo.MODELS.AUDITORIA
{
    public abstract class AuditoriaModel
    {
        [Column("crea_usr")]
        public string? crea_usr { get; set; }
        [Column("crea_fecha", TypeName = "timestamp")]
        public DateTime? crea_fecha { get; set; }
        [Column("mod_usr")]
        public string? mod_usr { get; set; }
        [Column("mod_fecha", TypeName = "timestamp")]
        public DateTime? mod_fecha { get; set; }
        [Column("crea_ip")]
        public string? crea_ip { get; set; }
        [Column("mod_ip")]
        public string? mod_ip { get; set; }
        public AuditoriaModel()
        {
        }

        public void setAuditCreate(UsuarioModel user)
        {
            crea_fecha = DateTime.Now.ToLocalTime();
            crea_usr = user.id;
            crea_ip = user.crea_ip;
        }

        public void setAuditUpdate(UsuarioModel user)
        {
            mod_fecha = DateTime.Now.ToLocalTime();
            mod_usr = user.id;
            mod_ip = user.mod_ip;
        }

    }


}
