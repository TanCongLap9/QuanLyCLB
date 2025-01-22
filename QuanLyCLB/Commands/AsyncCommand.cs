using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands
{
    public abstract class AsyncCommand
    {
        public abstract Task Execute(CancellationToken tok);
    }
}
