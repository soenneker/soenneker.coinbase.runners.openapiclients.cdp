using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Coinbase.Runners.OpenApiClients.Cdp.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
