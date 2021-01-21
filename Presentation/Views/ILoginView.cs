﻿using DomainModel;
using DomainModel.Services;
using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface ILoginView : IView
    {
        List<string> SqlServers{ get; set; }
        string ServerName { get; }
        List<string> LoginTypes { get; set; }
        string LoginType { get; }
        string Username { get; }
        string Password { get; }
        event Action Login;
        event Action LoginTypeChanged;
        void ShowError(string text);
        void SetMSSQLAuth();
        void SetWindowsAuth();
    }
}
