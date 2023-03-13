using BolsaEmpleo.MODELS.AUDITORIA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.MODELS.LANDING
{
    [Table("usr_persona_instruccion")]
    public class PersonInstructionModel:AuditoriaModel
    {
        public int usr_instruccion { get; set; }
        public string usr_persona { get; set; } 
        public string usr_nombre_titulo { get; set; }   
        public int usr_codigo { get; set; }
    }
}
