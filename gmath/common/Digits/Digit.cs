//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    
    using static zfunc;
    using static mfunc;

    public interface IDigit<T> 
        where T : Enum
    {

    }

    public interface IDigit<S,T> : IDigit<T>, IEquatable<S>
        where S : IDigit<S,T>
        where T : Enum
    {

    }

    public static class Digit
    {
        /// <summary>
        /// Defines a generic digit based on a digit enumeration value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The digit's enumeration type</typeparam>
        public static Digit<T> define<T>(T src)
            where T : Enum
                => new Digit<T>(src);


    }

    /// <summary>
    /// Defines a generic digit representation parametrized by a
    /// defining enumeration
    /// </summary>
    /// <typeparam name="T">The digit's enumeration type</typeparam>
    public readonly struct Digit<T> : IDigit<Digit<T>,T> 
        where T : Enum
    {
        public static Digit<T> Zero = default;

        [MethodImpl(Inline)]
        public static bool operator ==(Digit<T> lhs, Digit<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Digit<T> lhs, Digit<T> rhs)
            => not(lhs.Equals(rhs));

        public static implicit operator uint(Digit<T> src)
            => ClrConverter.convert<T,uint>(src.value);

        public static implicit operator T(Digit<T> src)
            => src.value;

        public Digit(T src)
            => value = src;
        
        readonly T value;

        public string format()
            => value.ToString();

        public bool Equals(Digit<T> rhs)
            => value.Equals(rhs);

        public T Unwrap()
            => value;

        [MethodImpl(Inline)]        
        public override bool Equals(object rhs)
            => rhs is Digit<T> ? Equals((Digit<T>)rhs) : false;
        
        [MethodImpl(Inline)]        
        public override int GetHashCode()
            => value.GetHashCode();

    }


}
