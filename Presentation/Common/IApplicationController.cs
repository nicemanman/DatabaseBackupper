using System.Threading.Tasks;

namespace Presentation.Common
{
    public interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;

        IApplicationController RegisterInstance<TArgument>(TArgument instance);
        
        IApplicationController RegisterService<TService, TImplementation>()
            where TImplementation : class, TService;

        void Run<TPresenter>()
            where TPresenter : class, IPresenter;

        Task Run<TPresenter, TArgument>(TArgument argumnent)
            where TPresenter : class, IPresenter<TArgument>;
    }
}