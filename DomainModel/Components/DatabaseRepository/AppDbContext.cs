using DomainModel.Components.DatabaseRepository.DatabaseModels;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository
{
    public class AppDbContext : DbContext
    {
        static AppDbContext() 
        {
            //TODO - Если у пользователя уже была создана база, это не получится сделать.
            //плюс к тому же, необходимо обновлять схему базы данных у пользователя, если она поменялась.
            //Кастомный инициализатор
            Database.SetInitializer(new CustomInitializer());
        }
        public AppDbContext() : base("name = dbfile")
        {
            
        }
        
        public DbSet<Job> Tasks { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<BackupPath> Paths { get; set; }
        public DbSet<EMail> EMails { get; set; }


    }
}
