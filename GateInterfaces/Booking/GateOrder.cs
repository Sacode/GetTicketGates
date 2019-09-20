using System;

namespace GetTicket.Gates.UniGate.GateInterfaces.Booking
{
    public class GateOrder : GateEntityBase<GateOrder>
    {
        public GateOrder(ICompositeKey<GateOrder> id, string name,
            GateEntityReference<GateCustomer> customerReference, DateTimeOffset? expires,
            GateOrderTicket[] orderTickets, GateEntityReference<GatePayment> paymentReference, GateOrderState state,
            ExtraData extraData = null) : base(id, name,
            extraData)
        {
            CustomerReference = customerReference;
            Expires = expires;
            OrderTickets = orderTickets;
            PaymentReference = paymentReference;
            State = state;
        }

        public GateEntityReference<GateCustomer> CustomerReference { get; }

        public DateTimeOffset? Expires { get; }

        public GateOrderTicket[] OrderTickets { get; }

        public GateEntityReference<GatePayment> PaymentReference { get; }

        public GateOrderState State { get; }
    }
}