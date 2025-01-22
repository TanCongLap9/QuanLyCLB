using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands
{
    public abstract class AsyncIterCommand<T> : AsyncCommand<IEnumerable<T>>
    {
        protected Func<T, Task> OnNextAsync;
        protected Action<T> OnNextSync;

        public AsyncIterCommand<T> OnNext(Func<T, Task> onResult)
        {
            OnNextAsync = onResult;
            OnNextSync = null;
            return this;
        }

        public AsyncIterCommand<T> OnNext(Action<T> onResult)
        {
            OnNextSync = onResult;
            OnNextAsync = null;
            return this;
        }

        protected async Task InvokeNext(T value)
        {
            if (OnNextSync != null) OnNextSync.Invoke(value);
            if (OnNextAsync != null) await OnNextAsync.Invoke(value);
        }
    }
}
