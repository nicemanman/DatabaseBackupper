﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public interface ILoginService
    {
        List<string> GetSqlServers(bool localOnly);
        List<Enum> GetLoginTypes();
        
    }
}
