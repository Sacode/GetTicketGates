namespace GetTicket.Gates.UniGate.GateInterfaces.HallSchemes
{
    public class GateVenue : GateEntityBase<GateVenue>
    {
        public GateVenue(CompositeKey<GateVenue> id, string name, string address, ExtraData extraData = null) : base(id,
            name, extraData)
        {
            Address = address;
        }

        public string Address { get; }
    }
}