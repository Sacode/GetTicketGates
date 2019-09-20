using GetTicket.Gates.UniGate.GateInterfaces.HallSchemes;

namespace GetTicket.Gates.UniGate.GateInterfaces.Tickets
{
    public class GateTicket : GateEntityBase<GateTicket>
    {
        public GateTicket(ICompositeKey<GateTicket> id, string name,
            GateEntityReference<GateHallArea> hallAreaReference,
            GateEntityReference<GateHallSeat> seatReference, GateEntityReference<GateTariff> tariffReference,
            decimal price, GateEntityReference<GateTicketType> ticketTypeReference, GateTicketState state,
            ExtraData extraData = null) : base(id, name, extraData)
        {
            SeatReference = seatReference;
            TariffReference = tariffReference;
            Price = price;
            TicketTypeReference = ticketTypeReference;
            State = state;
            HallAreaReference = hallAreaReference;
        }

        public GateEntityReference<GateHallSeat> SeatReference { get; }

        public GateEntityReference<GateHallArea> HallAreaReference { get; }

        public GateEntityReference<GateTariff> TariffReference { get; }

        public decimal Price { get; }

        public GateEntityReference<GateTicketType> TicketTypeReference { get; }

        public GateTicketState State { get; }
    }
}