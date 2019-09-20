namespace GetTicket.Gates.UniGate.GateInterfaces.Events
{
    public class GateEvent : GateEntityBase<GateEvent>
    {
        public GateEvent(ICompositeKey<GateEvent> id, string name, ExtraData extraData = null) : base(id, name,
            extraData)
        {
        }
    }
}