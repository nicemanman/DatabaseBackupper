﻿using System.Threading.Tasks;

namespace Presentation.Common
{
    public interface IPresenter
    {
        void Run();
    }

    public interface IPresenter<in TArg>
    {
        Task Run(TArg argument);
    }
}