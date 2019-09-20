using System;
using System.Threading.Tasks;
using GetTicket.Gates.UniGate.GateInterfaces.Tickets;

namespace GetTicket.Gates.UniGate.GateInterfaces.Booking
{
    public interface IBookingProvider : IGate
    {
        BarcodeType[] SupportedBarcodeTypes { get; }

        Task<BookingResponse> CreateOrderAsync();

        Task<BookingResponse<GateEntityReference<GateOrderTicket>>> AddTicketToOrderAsync(
            GateEntityReference<GateOrder> orderReference,
            GateEntityReference<GateTicket> ticketReference);

        Task<BookingResponse> RemoveTicketFromOrderAsync(GateEntityReference<GateOrder> orderReference,
            GateEntityReference<GateOrderTicket> orderTicketReference);

        Task<BookingResponse<GateEntityReference<GateCustomer>>> SetOrderCustomerAsync(
            GateEntityReference<GateOrder> orderReference,
            GateCustomerInfo customerInfo);

        Task<GateOrder> GetOrderAsync(GateEntityReference<GateOrder> orderReference);

        Task<BookingResponse<GateEntityReference<GatePayment>>> PayOrderAsync(
            GateEntityReference<GateOrder> orderReference, decimal amount, DateTimeOffset paidDateTime,
            GateOrderTicketAgentDataCollection agentData);

        Task<BookingResponse> DeleteOrderAsync(GateEntityReference<GateOrder> orderReference);
    }
}