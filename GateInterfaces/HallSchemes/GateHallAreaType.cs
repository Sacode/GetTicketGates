using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GetTicket.Gates.UniGate.GateInterfaces.HallSchemes
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GateHallAreaType
    {
        Zone,
        Sector,
        Row
    }
}