namespace GetTicket.Gates.UniGate.GateInterfaces.HallSchemes
{
    public class GateHallScheme : GateEntityBase<GateHallScheme>
    {
        public GateHallScheme(ICompositeKey<GateHallScheme> id, string name,
            GateHall hall,
            GateHallArea[] areas,
            ExtraData extraData = null) : base(id, name, extraData)
        {
            Hall = hall;
            Areas = areas;
        }

        public GateHall Hall { get; }

        public GateHallArea[] Areas { get; }
    }
}