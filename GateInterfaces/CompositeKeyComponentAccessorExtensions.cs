using System;
using System.Collections.Generic;

namespace GetTicket.Gates.UniGate.GateInterfaces
{
    public static class CompositeKeyComponentAccessorExtensions
    {
        //public static string Mandatory(this ICompositeKeyComponentAccessor accessor)
        //{
        //    return accessor.TryGet(out string value) ? value : throw new KeyNotFoundException();
        //}

        //public static string OrDefault(this ICompositeKeyComponentAccessor accessor,
        //    Func<string> getDefault = null)
        //{
        //    return accessor.TryGet(out string value) ? value : getDefault?.Invoke();
        //}

        public static T Mandatory<T>(this ICompositeKeyComponentAccessor<T> accessor)
        {
            return accessor.TryGet(out T value) ? value : throw new KeyNotFoundException();
        }

        public static T OrDefault<T>(this ICompositeKeyComponentAccessor<T> accessor,
            Func<T> getDefault = null)
        {
            return accessor.TryGet(out T value) ? value : getDefault != null ? getDefault() : default(T);
        }
    }
}