namespace GetTicket.Gates.UniGate.GateInterfaces.HallSchemes
{
    public class GateHallSeat : GateEntityBase<GateHallSeat>
    {
        public GateHallSeat(ICompositeKey<GateHallSeat> id, string name, ExtraData extraData = null) : base(id, name,
            extraData)
        {
        }
    }
}