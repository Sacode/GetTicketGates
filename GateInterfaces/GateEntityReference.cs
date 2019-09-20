using System;
using System.Linq;

namespace GetTicket.Gates.UniGate.GateInterfaces
{
    public interface IGateEntityReference : IReferenceable, IExtraData
    {
        ICompositeKey Key { get; }

        string Name { get; }

        Type EntityType { get; }
    }

    public sealed class GateEntityReference<TEntity> : IGateEntityReference, IExtraData<TEntity>
    {
        public GateEntityReference(ICompositeKey<TEntity> key, string name, ExtraData extraData = null)
        {
            Key = key;
            Name = name;
            ExtraData = extraData ?? new ExtraData();
        }

        public ICompositeKey<TEntity> Key { get; }

        public ExtraData ExtraData { get; }

        public string Name { get; }

        Type IGateEntityReference.EntityType => typeof(TEntity);

        ICompositeKey IGateEntityReference.Key => Key;

        public IGateEntityReference GetReference()
        {
            return this;
        }

        public bool ShouldSerializeExtraData()
        {
            return ExtraData.Any();
        }
    }
}