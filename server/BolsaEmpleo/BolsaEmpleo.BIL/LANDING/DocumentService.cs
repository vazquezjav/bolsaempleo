using BolsaEmpleo.DAL.LANDING;
using BolsaEmpleo.MODELS.LANDING;
using BolsaEmpleo.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace BolsaEmpleo.BIL.LANDING
{
    public class DocumentService
    {

        public readonly DocumentRepository repository;
        private readonly IConfiguration configuration;
        private readonly IHostEnvironment hostingEnvironment;

        public DocumentService(DocumentRepository repository, IConfiguration configuration, IHostEnvironment hostingEnvironment)
        {
            this.repository = repository;
            this.configuration = configuration;
            this.hostingEnvironment = hostingEnvironment;
        }

        public DocumentModel save(DocumentModel model, UsuarioModel user)
            => this.repository.save(model, user);  
        
        public void ProcessSave()
        {

        }
        public async Task<DocumentModel> saveDirectory(IFormFile file, string folder, UsuarioModel user)
        {
            string webRootPath = this.hostingEnvironment.ContentRootPath;
            string extension = System.IO.Path.GetExtension(file.FileName).Substring(1);
            string name = file.FileName + $"_{Guid.NewGuid().ToString("n").Substring(24)}";
            name = name.Replace("." + extension, "");
            name = name + "." + extension;
            string path = Path.Combine(webRootPath, "wwwroot", folder);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string pathComplete = Path.Combine(path, name);
            using (var stream = new FileStream(pathComplete, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            string url = this.configuration["server"] + $"{folder}/{name}";
            DocumentModel document = new DocumentModel();
            document.doc_nombre = name;
            document.doc_tipo_archivo = extension;
            document.doc_path = pathComplete;
            document.doc_url = url;
            document = this.save(document, user);
            return document; ;
        }
    }
}
