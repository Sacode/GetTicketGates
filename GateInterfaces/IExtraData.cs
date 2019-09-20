namespace GetTicket.Gates.UniGate.GateInterfaces
{
    public interface IExtraData
    {
        ExtraData ExtraData { get; }
    }

    public interface IExtraData<TTarget> : IExtraData
    {
    }
}