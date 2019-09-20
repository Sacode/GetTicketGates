using System;

namespace GetTicket.Gates.UniGate.GateInterfaces.Booking
{
    public class GatePayment : GateEntityBase<GatePayment>
    {
        public GatePayment(ICompositeKey<GatePayment> id, string name, decimal amount,
            DateTimeOffset paidDateTime, ExtraData extraData = null) : base(id, name, extraData)
        {
            Amount = amount;
            PaidDateTime = paidDateTime;
        }

        public decimal Amount { get; }

        public DateTimeOffset PaidDateTime { get; }
    }
}