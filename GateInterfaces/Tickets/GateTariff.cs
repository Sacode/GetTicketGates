namespace GetTicket.Gates.UniGate.GateInterfaces.Tickets
{
    public class GateTariff : GateEntityBase<GateTariff>
    {
        public GateTariff(CompositeKey<GateTariff> id, string name, ExtraData extraData = null) : base(id, name,
            extraData)
        {
        }
    }
}