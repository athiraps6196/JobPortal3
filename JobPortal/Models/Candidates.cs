using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Models
{
    public class Candidates
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Job { get; set; }
        public string Number { get; set; }
        public string About { get; set; }
        public string Experience { get; set; }
        public string Skill { get; set; }
        public string Work { get; set; }
        public Boolean Certified { get; set; }

        [NotMapped]
        public IFormFile FileToUpload { get; set; }
        public string FileName { get; set; }



    }
}
