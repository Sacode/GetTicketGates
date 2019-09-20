namespace GetTicket.Gates.UniGate.GateInterfaces.Booking
{
    public class GateCustomer : GateEntityBase<GateCustomer>
    {
        public GateCustomer(ICompositeKey<GateCustomer> id, string name, ExtraData extraData = null) : base(id, name,
            extraData)
        {
        }
    }
}