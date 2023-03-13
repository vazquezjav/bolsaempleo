using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BolsaEmpleo.MODELS.AUDITORIA;
using BolsaEmpleo.MODELS.ENUMS;

namespace BolsaEmpleo.MODELS.LANDING
{
    [Table("estadocivil")]
    public class StateCivilModel : AuditoriaModel
    {
        public int esc_codigo { get; set; }
        public string esc_id { get; set; }
        public string esc_nombre { get; set; }
        public int esc_estado { get; set; } = (int)StateEnum.ACTIVE;
    }
}
