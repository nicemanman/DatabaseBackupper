using DomainModel.Components.DatabaseRepository.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Components.DatabaseRepository
{
    public class PathRepository : GenericRepository<BackupPath>, IPathRepository
    {
        public PathRepository(DbContext Context) : base(Context)
        {
        }
    }
}
