using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository.DatabaseModels
{
    public class Job
    {   
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ServerName { get; set; }
        [Required]
        public string Path { get; set; }
        [Required]
        public string Databases { get; set; }
        [Required]
        public Schedule schedule { get; set; }
    }
}
