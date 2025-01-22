using System;

namespace QuanLyCLB.Commands
{
    public abstract class AsyncProgressCommand<T> : AsyncCommand
    {
        protected readonly Progress<T> Progress = new Progress<T>();
        protected readonly Progress<T> PostProgress = new Progress<T>();
        protected readonly IProgress<T> IProgress;
        protected readonly IProgress<T> IPostProgress;

        protected AsyncProgressCommand()
        {
            IProgress = Progress;
            IPostProgress = PostProgress;
        }

        public AsyncProgressCommand<T> OnProgress(EventHandler<T> eventHandler)
        {
            Progress.ProgressChanged += eventHandler;
            return this;
        }

        public AsyncProgressCommand<T> OnPost(EventHandler<T> eventHandler)
        {
            PostProgress.ProgressChanged += eventHandler;
            return this;
        }
    }
}
