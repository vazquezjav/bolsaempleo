using BolsaEmpleo.MODELS.AUDITORIA;
using BolsaEmpleo.MODELS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.MODELS.LANDING
{
    [Table("usr_aplicacion")]
    public class PersonAplicationModel : AuditoriaModel
    {
        public int usr_area { get; set; }
        public string usr_persona { get; set; }
        public string usr_conocimiento { get; set; }
        public int usr_sector_publico { get; set; }
        public int usr_sector_privado { get; set; }
        public int usr_cv { get; set; }
        public int usr_codigo { get; set; }

        public PersonAplicationModel MapperLandingDTO(FormLandingDTO dto)
        {
            usr_area = dto.area;
            usr_persona = dto.identification;
            usr_conocimiento = dto.knowledge;
            usr_sector_privado = dto.private_sector;
            usr_sector_publico = dto.public_sector;
            return this;
        }
    }
}
