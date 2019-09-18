//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;
    
    /// <summary>
    /// Represents the collection of enumeration literals defined by an enum
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    public readonly struct EnumValues<E>
        where E : Enum
    {
        internal static readonly EnumValues<E> TheOnly = default;

        static readonly E[] Cache
            = typeof(E).GetEnumValues().AsQueryable().Cast<E>().ToArray();

        static readonly Dictionary<E,int> PositionIndex
            = Cache.Mapi((i,v) => (v,i)).ToDictionary();

        static readonly Dictionary<string, E> NameIndex
            = Cache.Select(e => (e.ToString(), e)).ToDictionary();

        static readonly Dictionary<string,NamedValue<E>> NameValueCache 
            = NameIndex.Select(x => (x.Key,new NamedValue<E>(x.Key, x.Value))).ToDictionary();


        [MethodImpl(Inline)]
        internal E[] ToArray()
            => Cache;

        [MethodImpl(Inline)]
        public Option<E> Parse(string src)
        {
            if(NameIndex.TryGetValue(src, out E dst))
                return dst;

            if(Enum.TryParse(typeof(E), src, true, out object result))
                return (E)result;
            return default;
        }
        
        /// <summary>
        /// The index at which a specified value is positioned
        /// </summary>
        [MethodImpl(Inline)]
        public int ToIndex(E value)
        {
            if(PositionIndex.TryGetValue(value, out int index))
                return index;
            else 
                return - 1;
        }

        [MethodImpl(Inline)]
        public T ToScalar<T>(E src)
            where T : unmanaged
                => EnumValues<E,T>.TheOnly.ToScalar(src);

        [MethodImpl(Inline)]
        public ReadOnlySpan<E> ToSpan()
            => Cache;

        [MethodImpl(Inline)]
        public IReadOnlyDictionary<string,NamedValue<E>> NamedValues()
            => NameValueCache;
        
        public IEnumerable<E> Enumerate()
            => new EnumValueEnumerator<E>();         
    }

    /// <summary>
    /// Represents the collection of enumeration literals defined by 
    /// an enum of specified scalar
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    /// <typeparam name="T">The scalar type</typeparam>
    public readonly struct EnumValues<E,T>
        where E : Enum
        where T : unmanaged

    {
        internal static readonly EnumValues<E,T> TheOnly = default;

        static readonly EnumValues<E> Values = EnumValues<E>.TheOnly;

        static readonly Dictionary<E,T> ScalarIndex
            = Values.ToArray().Select(e => (e, (T)Convert.ChangeType(e,typeof(T)))).ToDictionary();

        static readonly T[] ScalarCache = ScalarIndex.Values.ToArray();
        
        static readonly NamedValue<T>[] NamedScalarCache 
            = ScalarIndex.Select(x => new NamedValue<T>(x.Key.ToString(), x.Value)).ToArray();

        [MethodImpl(Inline)]
        public static implicit operator EnumValues<E>(EnumValues<E,T> src)
            => Values;

        [MethodImpl(Inline)]
        public ReadOnlySpan<E> ToSpan()
            => Values.ToSpan();

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> ToScalarSpan()
            => ScalarCache;
    
        [MethodImpl(Inline)]
        public Option<E> Parse(string src)
            => EnumValues<E>.TheOnly.Parse(src);

        [MethodImpl(Inline)]
        public T ToScalar(E src)
        {
            if(ScalarIndex.TryGetValue(src, out T dst))
                return dst;
            else
                return (T)Convert.ChangeType(src,typeof(T));
        }

        /// <summary>
        /// The index at which a specified value is positioned
        /// </summary>
        [MethodImpl(Inline)]
        public int ToIndex(E value)
            => Values.ToIndex(value);

        [MethodImpl(Inline)]
        public IReadOnlyDictionary<string,NamedValue<E>> NamedValues()
            => Values.NamedValues();

        [MethodImpl(Inline)]
        public ReadOnlySpan<NamedValue<T>> NamedScalars()
            => NamedScalarCache;

        public IEnumerable<E> EnumerateValues()
            => Values.Enumerate();
    }
}