namespace GetTicket.Gates.UniGate.GateInterfaces.HallSchemes
{
    public class GateHallSeatsArea : GateHallArea
    {
        public GateHallSeatsArea(ICompositeKey<GateHallArea> id, string name, GateHallAreaType areaType,
            GateHallSeat[] seats, ExtraData extraData = null) : base(id, name, areaType, extraData)
        {
            Seats = seats;
        }

        public GateHallSeat[] Seats { get; }
    }
}