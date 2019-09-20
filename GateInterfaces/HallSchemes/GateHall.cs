namespace GetTicket.Gates.UniGate.GateInterfaces.HallSchemes
{
    public class GateHall : GateEntityBase<GateHall>
    {
        public GateHall(ICompositeKey<GateHall> id, string name, GateEntityReference<GateVenue> venueReference,
            ExtraData extraData = null) : base(id, name, extraData)
        {
            VenueReference = venueReference;
        }

        public GateEntityReference<GateVenue> VenueReference { get; }
    }
}