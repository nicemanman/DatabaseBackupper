using DomainModel.Components.DatabaseRepository;
using DomainModel.Components.DatabaseRepository.DatabaseModels;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public class PathService : IPathService
    {
        IDatabaseController databaseController;
        public PathService(IDatabaseController databaseController)
        {
            this.databaseController = databaseController;
        }
        public List<string> GetBackupPaths()
        {
            
            var paths = databaseController.pathRepository.GetAll().OrderByDescending(x => x.dateTime).Select(x => x.PathString).ToList<string>();
            return paths;
        }


        public async Task SaveBackupPath(string pathToSave)
        {
            await RemoveAllBut_N_NewestPaths();
            var path = databaseController.pathRepository.Find(x => x.PathString == pathToSave).FirstOrDefault();
            if (path == null)
            {
                databaseController.pathRepository.Add(new BackupPath() { PathString = pathToSave, dateTime = DateTime.Now });
            }
            else
            {
                path.dateTime = DateTime.Now;
            }
            await databaseController.CompleteAsync();
        }

        public void RemoveBackupPaths()
        {
            databaseController.pathRepository.RemoveRange(databaseController.pathRepository.GetAll());
            databaseController.CompleteAsync();
        }

        private async Task RemoveAllBut_N_NewestPaths()
        {
            var count = databaseController.pathRepository.GetAll().Count();
            if (count > Constants.PathsCountRememberValue)
            {
                var theOldestPath = databaseController.pathRepository.GetAll().OrderBy(x => x.dateTime).FirstOrDefault();
                databaseController.pathRepository.Remove(theOldestPath);
                await databaseController.CompleteAsync();
            }
        }
    }
}
