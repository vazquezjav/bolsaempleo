using BolsaEmpleo.MODELS.AUDITORIA;
using BolsaEmpleo.MODELS.ENUMS;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BolsaEmpleo.MODELS
{
    [Table("g_usuario")]
    public class UsuarioModel : AuditoriaModel
    {
        
        [Key]
        [Column("usr_codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 codigo { get; set; }
        [Column("usr_id"), Required]
        public String id { get; set; }

        [NotMapped]
        public String? nombre_completo
        {
            get { return nombre + " " + apellido;
            }
            set{}
        }
        [Column("usr_nombre")]
        public String nombre { get; set; }
        [Column("usr_apellido")]
        public String apellido { get; set; }
        [Column("usr_telefono")]
        public String telefono { get; set; }
        [Column("usr_mail")]
        public String mail { get; set; }
        [Column("usr_cedula")]
        public String cedula { get; set; }
        [Column("usr_permiso"), Required]
        [ForeignKey("permiso")]
        public int permisoCodigo { get; set; }
        [Column("usr_clave"), Required]
        public String clave { get; set; }
        [Column("usr_estado")]
        public int? estado { get; set; } = (int)StateEnum.ACTIVE;

        
        public UsuarioModel(){
           
        }

    }

}
