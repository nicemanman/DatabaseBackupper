using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository.DatabaseModels
{
    public class Schedule
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Cron { get; set; }
        public List<Job> tasks { get; set; }
        public int Minutes { get; set; }
        public int Hours { get; set; }
        public string Days { get; set; }
        public int CronTypeExpressionId { get; set; }
    }
}
