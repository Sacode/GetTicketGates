namespace GetTicket.Gates.UniGate.GateInterfaces.Booking
{
    public class GateCustomerInfo
    {
        public GateCustomerInfo(string firstName, string lastName, string phone, string email,
            GateEntityReference<GateCustomer> customerReference = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            CustomerReference = customerReference;
        }

        public GateEntityReference<GateCustomer> CustomerReference { get; set; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Phone { get; }
        public string Email { get; }
    }
}