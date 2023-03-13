using BolsaEmpleo.MODELS;
using BolsaEmpleo.MODELS.DTO;
using BolsaEmpleo.MODELS.LANDING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.BIL.LANDING
{
    public class LandingService
    {
        private readonly DocumentService documentService;
        private readonly PersonService personService;
        private readonly PersonAplicationService aplicationService;

        public LandingService(DocumentService documentService, PersonService personService)
        {
            this.documentService = documentService;
            this.personService = personService;
        }

        public void PorcessLanding(FormLandingDTO dto)
        {
            if (String.IsNullOrEmpty(dto.identification))
                throw new Exception("Se debe ingresar una cedula");

            if (dto.cv is null)
                throw new Exception("Debe cargar su curriculum.");

            DocumentModel documentCv = this.documentService.saveDirectory(dto.cv, "cv", new UsuarioModel()).Result;
            PersonModel person = new PersonModel().MapperLandingDTO(dto);
            person.usr_cv = documentCv.doc_codigo;
            if(dto.cv is not null)
            {
                DocumentModel documentPhoto = this.documentService.saveDirectory(dto.photo, "photo", new UsuarioModel()).Result;
                person.usr_foto = documentPhoto.doc_codigo;
            }

            this.personService.Save(person, new UsuarioModel());

            PersonAplicationModel aplication = new PersonAplicationModel().MapperLandingDTO(dto);
            aplication.usr_cv = documentCv.doc_codigo;
            this.aplicationService.Save(aplication, new UsuarioModel());
        }
    }
}
