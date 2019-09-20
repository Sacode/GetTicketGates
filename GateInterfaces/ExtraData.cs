using GetTicket.Common.PayloadContainer;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GetTicket.Gates.UniGate.GateInterfaces
{
    public class ExtraData : JsonPayloadContainer
    {
        public static readonly JsonSerializerSettings JsonSerializerSettings = CreateJsonSerializerSettings();

        public ExtraData() : base(JsonSerializerSettings)
        {
        }

        private static JsonSerializerSettings CreateJsonSerializerSettings()
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = null, // new DefaultContractResolver()
                DateParseHandling = DateParseHandling.None,
                TypeNameHandling = TypeNameHandling.Auto
            };
            settings.Converters.Add(new StringEnumConverter());
            return settings;
        }
    }
}