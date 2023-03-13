using BolsaEmpleo.MODELS.AUDITORIA;
using BolsaEmpleo.MODELS.ENUMS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.MODELS.LANDING
{
    [Table("instruccion")]
    public class InstructionModel: AuditoriaModel
    {
        public int ins_codigo { get; set; }
        public string ins_id { get; set; }
        public string ins_nombre { get; set; }      
        public int ins_nivel { get; set; }
        public int ins_estado { get; set; } = (int)StateEnum.ACTIVE;
    }
}
