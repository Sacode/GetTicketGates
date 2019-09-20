using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GetTicket.Gates.UniGate.GateInterfaces.Booking
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GateOrderState
    {
        Initiated,
        Booked,
        Paid,
        Canceled,
        Deleted
    }
}