using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoolStore.Protobuf.Inventory.V1;

namespace CoolStore.ShoppingCartApi.Domain
{
    public interface IInventoryGateway
    {
        Task<IReadOnlyDictionary<Guid, StoreDto>> GetStoresAsync(
            IReadOnlyCollection<Guid> storeIds,
            CancellationToken cancellationToken);
    }
}
