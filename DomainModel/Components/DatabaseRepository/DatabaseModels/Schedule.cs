﻿using System;
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
    }
}
