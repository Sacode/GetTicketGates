using System.Linq;

namespace GetTicket.Gates.UniGate.GateInterfaces
{
    public interface IGateEntity : IReferenceable, IExtraData
    {
        object Id { get; }
        string Name { get; }
    }

    public abstract class GateEntityBase<TEntity> : IGateEntity, IExtraData<TEntity>
    {
        public GateEntityBase(ICompositeKey<TEntity> id, string name, ExtraData extraData = null)
        {
            Id = id;
            Name = name;
            ExtraData = extraData ?? new ExtraData();
        }

        public ICompositeKey<TEntity> Id { get; }

        public string Name { get; }

        public ExtraData ExtraData { get; }

        object IGateEntity.Id => Id;

        IGateEntityReference IReferenceable.GetReference()
        {
            return this.GetReference();
        }

        public GateEntityReference<TEntity> GetReference()
        {
            return new GateEntityReference<TEntity>(Id, Name, ExtraData);
        }

        public bool ShouldSerializeExtraData()
        {
            return ExtraData.Any();
        }

        public static implicit operator GateEntityReference<TEntity>(GateEntityBase<TEntity> entity)
        {
            return entity.GetReference();
        }
    }
}