using System.Threading.Tasks;

namespace GetTicket.Gates.UniGate.GateInterfaces.Events
{
    public interface IEventsProvider : IGate
    {
        Task<GateEvent[]> GetEventsAsync();

        Task<GateAction[]> GetActionsAsync(GateEntityReference<GateEvent> gateEventReference);
    }
}