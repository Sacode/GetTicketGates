using System.Threading.Tasks;

namespace GetTicket.Gates.UniGate.GateInterfaces.HallSchemes
{
    public interface IHallSchemesProvider : IGate
    {
        Task<GateHallScheme[]> GetHallSchemesAsync();
    }
}