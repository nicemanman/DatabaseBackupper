using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository.DatabaseModels
{
    public class BackupPath
    {
        public int Id { get; set; }
        [Required]
        public string PathString { get; set; }
        [Required]
        public DateTime dateTime { get; set; }
    }
}
