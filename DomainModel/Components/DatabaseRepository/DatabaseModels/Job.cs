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
        
        public string Name { get; set; }
        public string ServerName { get; set; }
        public string Path { get; set; }
        public string Databases { get; set; }
        public bool NotifyAboutFinish { get; set; }
        public string EmailToNotify { get; set; }
        public bool IsEnabled { get; set; }
        public Schedule Schedule { get; set; }
    }
}
