using System;
using System.Linq;

namespace GetTicket.Gates.UniGate.GateInterfaces
{
    public static class CompositeKeyFluent
    {
        public static TCompositeKey SetComponent<TCompositeKey>(
            this TCompositeKey compositeKey,
            string componentName,
            string value) where TCompositeKey : ICompositeKey
        {
            compositeKey[componentName] = value;
            return compositeKey;
        }

        public static ICompositeKey<TGateEntity> SetComponent<TGateEntity, TValue>(
            this ICompositeKey<TGateEntity> compositeKey,
            Func<ICompositeKey<TGateEntity>, ICompositeKeyComponentAccessor<TValue>> getAccessor,
            TValue value)
            where TGateEntity : IGateEntity
        {
            getAccessor(compositeKey).Set(value);
            return compositeKey;
        }

        public static TCompositeKey SetComponent<TCompositeKey, TValue>(
            this TCompositeKey compositeKey,
            Func<ICompositeKey, ICompositeKeyComponentAccessor<TValue>> getAccessor,
            TValue value)
            where TCompositeKey : ICompositeKey
        {
            getAccessor(compositeKey).Set(value);
            return compositeKey;
        }

        public static TCompositeKey Merge<TCompositeKey>(
            this TCompositeKey compositeKey, ICompositeKey otherKey,
            string namePrefix = null) where TCompositeKey : ICompositeKey
        {
            otherKey.ForEach(_ => compositeKey.Add($"{namePrefix}{_.Key}", _.Value));
            return compositeKey;
        }
    }
}