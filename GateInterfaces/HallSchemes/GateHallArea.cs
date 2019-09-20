namespace GetTicket.Gates.UniGate.GateInterfaces.HallSchemes
{
    public abstract class GateHallArea : GateEntityBase<GateHallArea>
    {
        public GateHallArea(ICompositeKey<GateHallArea> id, string name, GateHallAreaType areaType,
            ExtraData extraData = null) : base(id, name, extraData)
        {
            AreaType = areaType;
        }

        public GateHallAreaType AreaType { get; }
    }
}