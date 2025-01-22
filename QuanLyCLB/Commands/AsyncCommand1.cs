using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands
{
    public abstract class AsyncCommand<T>
    {
        public abstract Task<T> Execute(CancellationToken tok);
    }
}
