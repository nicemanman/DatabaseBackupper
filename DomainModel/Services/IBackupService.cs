﻿using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public interface IBackupService
    {
        bool BackupDatabases(BackupModel backupModel);
        void DisconnectFromCurrentSqlServer();
    }
}
