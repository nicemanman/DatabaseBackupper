using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Common
{
    public class LongOperation : IDisposable
    {
        private readonly IView view;

        public LongOperation(IView view)
        {
            this.view = view;
            view.Wait();
        }
        public void Dispose()
        {
            view.StopWaiting();
        }
    }
}
