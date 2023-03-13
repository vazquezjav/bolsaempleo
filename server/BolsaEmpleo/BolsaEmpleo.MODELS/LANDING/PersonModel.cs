using BolsaEmpleo.MODELS.AUDITORIA;
using BolsaEmpleo.MODELS.DTO;
using BolsaEmpleo.MODELS.ENUMS;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.MODELS.LANDING
{
    public class PersonModel:AuditoriaModel
    {
        public string usr_cedula { get; set; }
        public string usr_primer_nombre { get; set; }
        public string usr_segundo_nombre { get; set; }
        public string usr_primer_apellido { get;set; }
        public string usr_segundo_apellido { get; set; }
        public string usr_telefono { get; set; }    
        public string usr_celular { get; set; } 
        public int usr_estado_civil { get;set; }
        public DateTime usr_fecha_nacimiento { get; set; }
        public string usr_direccion { get; set; }
        public int usr_discapacidad { get; set; } = (int)StateEnum.INACTIVE;
        public int usr_numero_hijo { get; set; } = 0;
        public int usr_provincia { get; set; }
        public int usr_canton { get; set; }
        public string usr_mail { get; set; }
        public int usr_foto { get; set; }
        public int usr_cv { get; set; }

        public PersonModel MapperLandingDTO(FormLandingDTO dto)
        {
            usr_cedula = dto.identification;
            usr_primer_nombre = dto.first_name;
            usr_segundo_nombre = dto.second_name;
            usr_primer_apellido = dto.first_surname;
            usr_segundo_apellido = dto.second_surname;
            usr_telefono = dto.phone;
            usr_celular = dto.mobile;
            usr_estado_civil = dto.status_civil;
            usr_fecha_nacimiento = dto.date_birth;
            usr_direccion = dto.address;
            usr_discapacidad = dto.disability;
            usr_numero_hijo = dto.number_children;
            usr_provincia = dto.province;
            usr_canton= dto.canton;
            usr_mail = dto.email;
            return this;
        }
    }
}
