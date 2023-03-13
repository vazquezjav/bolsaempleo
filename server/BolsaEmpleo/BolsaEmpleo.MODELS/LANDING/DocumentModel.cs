using BolsaEmpleo.MODELS.AUDITORIA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.MODELS.LANDING
{
    [Table("documento")]
    public class DocumentModel:AuditoriaModel
    {
        public int doc_codigo { get; set; }
        public string doc_url { get; set; }
        public string doc_nombre { get; set; }
        public string doc_tipo_archivo { get; set; }
        public string doc_path { get; set; }
    }
}
