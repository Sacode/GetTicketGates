using System;

namespace GetTicket.Gates.UniGate.GateInterfaces
{
    public interface ICompositeKeyComponentAccessor
    {
        bool TryGet(out string value);
        void Set(string value);
    }

    public interface ICompositeKeyComponentAccessor<T> : ICompositeKeyComponentAccessor
    {
        bool TryGet(out T value);
        void Set(T value);
    }

    public class CompositeKeyComponentAccessor : ICompositeKeyComponentAccessor<string>
    {
        public CompositeKeyComponentAccessor(ICompositeKey compositeKey, string componentName)
        {
            CompositeKey = compositeKey;
            ComponentName = componentName;
        }

        public string ComponentName { get; }

        public ICompositeKey CompositeKey { get; }

        public bool TryGet(out string value)
        {
            return CompositeKey.TryGetValue(ComponentName, out value);
        }

        public void Set(string value)
        {
            CompositeKey.SetComponent(ComponentName, value);
        }

        public static implicit operator string(CompositeKeyComponentAccessor accessor)
        {
            return accessor.TryGet(out string value) ? value : null;
        }
    }

    public class CompositeKeyComponentAccessor<T> : CompositeKeyComponentAccessor, ICompositeKeyComponentAccessor<T>
    {
        public CompositeKeyComponentAccessor(ICompositeKey compositeKey, string componentName,
            Func<string, T> fromString = null, Func<T, string> toString = null) : base(compositeKey, componentName)
        {
            ConvertStringToValue = fromString ?? (s => (T) Convert.ChangeType(s, typeof(T)));
            ConvertValueToString = toString ?? (o => (string) Convert.ChangeType(o, typeof(string)));
        }

        public Func<string, T> ConvertStringToValue { get; }
        public Func<T, string> ConvertValueToString { get; }


        public bool TryGet(out T value)
        {
            if (base.TryGet(out string s))
            {
                value = ConvertStringToValue(s);
                return true;
            }
            value = default(T);
            return false;
        }

        public void Set(T value)
        {
            base.Set(ConvertValueToString(value));
        }

        public static implicit operator T(CompositeKeyComponentAccessor<T> accessor)
        {
            return accessor.TryGet(out T value) ? value : default(T);
        }
    }
}