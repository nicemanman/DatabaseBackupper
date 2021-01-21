using System;

namespace Presentation.Common
{
    public interface IView
    {
        void Wait();
        void Wait(Progress<string> progres);
        void StopWaiting();
        void Show();
        void Close();
    }
}