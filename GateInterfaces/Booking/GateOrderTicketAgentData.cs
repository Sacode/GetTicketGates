using System.Collections.Generic;
using GetTicket.Common.Collections;
using GetTicket.Gates.UniGate.GateInterfaces.Tickets;

namespace GetTicket.Gates.UniGate.GateInterfaces.Booking
{
    public class GateOrderTicketAgentData
    {
        public GateOrderTicketAgentData(ICompositeKey<GateTicket> gateTicketKey, string number,
            string barcode, BarcodeType barcodeType)
        {
            Number = number;
            Barcode = barcode;
            BarcodeType = barcodeType;
            GateTicketKey = gateTicketKey;
        }

        public ICompositeKey<GateTicket> GateTicketKey { get; }

        public string Number { get; }

        public string Barcode { get; }

        public BarcodeType BarcodeType { get; }
    }

    public class GateOrderTicketAgentDataCollection
        : KeyedCollectionBase<ICompositeKey<GateTicket>, GateOrderTicketAgentData>
    {
        public GateOrderTicketAgentDataCollection()
        {
        }

        public GateOrderTicketAgentDataCollection(IEqualityComparer<ICompositeKey<GateTicket>> comparer) :
            base(comparer)
        {
        }

        public GateOrderTicketAgentDataCollection(IEnumerable<GateOrderTicketAgentData> items,
            IEqualityComparer<ICompositeKey<GateTicket>> comparer = null) : base(items, comparer)
        {
        }

        protected override ICompositeKey<GateTicket> GetKeyForItem(GateOrderTicketAgentData item)
        {
            return item.GateTicketKey;
        }
    }
}