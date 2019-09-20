namespace GetTicket.Gates.UniGate.GateInterfaces.Booking
{
    public interface IBookingResponse
    {
        GateEntityReference<GateOrder> GateOrderReference { get; }
    }

    public class BookingResponse : IBookingResponse
    {
        public BookingResponse(GateEntityReference<GateOrder> gateOrderReference)
        {
            GateOrderReference = gateOrderReference;
        }

        public GateEntityReference<GateOrder> GateOrderReference { get; }
    }

    public interface IBookingResponseWithValue : IBookingResponse
    {
        object Value { get; }
    }

    public class BookingResponse<TResult> : BookingResponse, IBookingResponseWithValue
    {
        public BookingResponse(GateEntityReference<GateOrder> gateOrderReference, TResult result) :
            base(gateOrderReference)
        {
            Value = result;
        }

        public TResult Value { get; }

        object IBookingResponseWithValue.Value => Value;
    }
}