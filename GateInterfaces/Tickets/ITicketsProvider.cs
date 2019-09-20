using System.Threading.Tasks;
using GetTicket.Gates.UniGate.GateInterfaces.Events;

namespace GetTicket.Gates.UniGate.GateInterfaces.Tickets
{
    public interface ITicketsProvider : IGate
    {
        // TODO: Нужно сделать метод, возвращающий Inventory (GetInventory): InventoryItem со всеми возможными вариантами продажи. Данный контракт или удалить, или переделать на список доступных билетов (как обертка над GetInventory).
        Task<GateTicket[]> GetTicketsAsync(GateEntityReference<GateAction> gateActionReference);
    }
}