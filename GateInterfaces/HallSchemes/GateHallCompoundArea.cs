namespace GetTicket.Gates.UniGate.GateInterfaces.HallSchemes
{
    public class GateHallCompoundArea : GateHallArea
    {
        public GateHallCompoundArea(ICompositeKey<GateHallArea> id, string name, GateHallAreaType areaType,
            GateHallArea[] subAreas,
            ExtraData extraData = null) : base(id, name, areaType, extraData)
        {
            SubAreas = subAreas;
        }

        public GateHallArea[] SubAreas { get; }
    }
}