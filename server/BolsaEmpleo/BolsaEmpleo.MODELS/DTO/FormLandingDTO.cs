using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.MODELS.DTO
{
    public class FormLandingDTO
    {
        public int area { get;set; }
        public string knowledge { get;set; }
        public int public_sector { get; set; }
        public int private_sector { get; set; }
        public string identification { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string first_surname { get; set; }
        public string second_surname { get;set; }
        public string phone { get; set; }   
        public string mobile { get; set; }
        public int status_civil { get;set; }
        public int number_children { get; set; } 
        public DateTime date_birth { get; set; }
        public int province { get; set; }
        public int canton { get; set; }
        public string address { get; set; }
        public int disability { get;set; }
        public string email { get; set; }
        [NotMapped]
        public IFormFile photo { get; set; }
        public IFormFile cv { get; set; }
    }
}
