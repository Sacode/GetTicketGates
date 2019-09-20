using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GetTicket.Gates.UniGate.GateInterfaces.Tickets
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GateTicketState
    {
        Available,
        Locked,
        Unavailable
    }
}