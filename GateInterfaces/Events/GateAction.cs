using System;
using GetTicket.Gates.UniGate.GateInterfaces.HallSchemes;

namespace GetTicket.Gates.UniGate.GateInterfaces.Events
{
    public class GateAction : GateEntityBase<GateAction>
    {
        public GateAction(ICompositeKey<GateAction> id, string name, DateTimeOffset beginDateTime,
            GateEntityReference<GateHallScheme> hallSchemeReference,
            ExtraData extraData = null) : base(id, name, extraData)
        {
            BeginDateTime = beginDateTime;
            HallSchemeReference = hallSchemeReference;
        }

        public DateTimeOffset BeginDateTime { get; }

        public GateEntityReference<GateHallScheme> HallSchemeReference { get; }
    }
}