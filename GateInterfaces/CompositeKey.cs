using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.WebUtilities;

namespace GetTicket.Gates.UniGate.GateInterfaces
{
    public interface ICompositeKey : IDictionary<string, string>
    {
    }

    public class CompositeKey : Dictionary<string, string>, ICompositeKey, IEquatable<CompositeKey>
    {
        public CompositeKey()
        {
        }

        public CompositeKey(IDictionary<string, string> dictionary) : base(dictionary)
        {
        }

        public bool Equals(CompositeKey other)
        {
            var same = from t in this
                join o in other on t.Key equals o.Key
                where t.Value == o.Value
                select (t, o);

            var e = same.Count() == Count;

            return e;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            var other = obj as CompositeKey;
            return other != null && this.Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 19;
                foreach (var pair in this)
                {
                    hash = hash * 31 + pair.Key.GetHashCode();
                    hash = hash * 31 + pair.Value.GetHashCode();
                }
                return hash;
            }
        }

        public static bool operator ==(CompositeKey left, CompositeKey right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CompositeKey left, CompositeKey right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            var s = new QueryBuilder(this.Where(x => x.Value != null).OrderBy(_ => _.Key).ThenBy(_ => _.Value))
                .ToString()
                .TrimStart('?');

            return s;
        }

        public static CompositeKey Parse(string s)
        {
            var result = new CompositeKey(ParseToDictionary(s));
            return result;
        }

        protected static Dictionary<string, string> ParseToDictionary(string s)
        {
            return QueryHelpers.ParseQuery(s).ToDictionary(_ => _.Key, _ => _.Value.Single());
        }

        //public static implicit operator CompositeKey(string s)
        //{
        //    return Parse(s);
        //}

        public static implicit operator string(CompositeKey compositeKey)
        {
            return compositeKey.ToString();
        }
    }

    public interface ICompositeKey<out TGateEntity> : ICompositeKey
    {
    }


    public class CompositeKey<TGateEntity> : CompositeKey, ICompositeKey<TGateEntity>
    {
        public CompositeKey()
        {
        }

        public CompositeKey(IDictionary<string, string> dictionary) : base(dictionary)
        {
        }

        public new static CompositeKey<TGateEntity> Parse(string s)
        {
            var result = new CompositeKey<TGateEntity>(ParseToDictionary(s));
            return result;
        }

        //public static implicit operator CompositeKey<TGateEntity>(string s)
        //{
        //    return Parse(s);
        //}

        public static implicit operator string(CompositeKey<TGateEntity> compositeKey)
        {
            return compositeKey.ToString();
        }
    }
}