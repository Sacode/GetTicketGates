using GetTicket.Gates.UniGate.GateInterfaces.HallSchemes;
using GetTicket.Gates.UniGate.GateInterfaces.Tickets;

namespace GetTicket.Gates.UniGate.GateInterfaces.Booking
{
    public class GateOrderTicket : GateEntityBase<GateOrderTicket>
    {
        public GateOrderTicket(ICompositeKey<GateOrderTicket> id, string name,
            GateEntityReference<GateTicket> ticketReference,
            GateEntityReference<GateHallSeat> seatReference, GateEntityReference<GateTariff> tariffReference,
            decimal price,
            GateEntityReference<GateTicketType> ticketTypeReference,
            string barcode = null,
            ExtraData extraData = null) : base(id,
            name, extraData)
        {
            TicketReference = ticketReference;
            SeatReference = seatReference;
            TariffReference = tariffReference;
            Price = price;
            Barcode = barcode;
            TicketTypeReference = ticketTypeReference;
        }

        public GateEntityReference<GateTicket> TicketReference { get; }

        public GateEntityReference<GateHallSeat> SeatReference { get; }

        public GateEntityReference<GateTariff> TariffReference { get; }

        public decimal Price { get; }

        public string Barcode { get; }

        public GateEntityReference<GateTicketType> TicketTypeReference { get; }
    }
}
