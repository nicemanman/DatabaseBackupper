namespace Presentation.Common
{
    public interface IView
    {
        void Wait();
        void StopWaiting();
        void Show();
        void Close();
    }
}