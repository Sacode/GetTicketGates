namespace GetTicket.Gates.UniGate.GateInterfaces.Tickets
{
    public class GateTicketType : GateEntityBase<GateTicketType>
    {
        public GateTicketType(CompositeKey<GateTicketType> id, string name, ExtraData extraData = null) : base(id, name,
            extraData)
        {
        }
    }
}