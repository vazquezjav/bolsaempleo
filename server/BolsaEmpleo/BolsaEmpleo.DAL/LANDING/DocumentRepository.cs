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
    public class DocumentRepository
    {
        private readonly IDbContext dbContext;

        public DocumentRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public DocumentModel save(DocumentModel model, UsuarioModel user)
        {
            if (user != null) model.setAuditCreate(user);
            string sql = "INSERT INTO public.documento (doc_url, doc_nombre, doc_tipo_archivo, doc_path, crea_usr, crea_ip, crea_fecha, mod_fecha, mod_usr, mod_ip)" +
                " VALUES (@doc_url, @doc_nombre, @doc_tipo_archivo, @doc_path, @crea_usr, @crea_ip, @crea_fecha, @mod_fecha, @mod_usr, @mod_ip) returning *";
            return this.dbContext.getObject<DocumentModel>(sql, model);
        }
    }
}
