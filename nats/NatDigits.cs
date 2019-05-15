//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;
    
    public static class NatDigits
    {
        /// <summary>
        /// Defines a generic digit based on a digit enumeration value
        /// in the context of a natural base
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The digit's enumeration type</typeparam>
        /// <typeparam name="N">The natural base type</typeparam>
        public static Digit<N,T> Define<N,T>(T src)
            where N : ITypeNat, new()
            where T : Enum
                => new Digit<N,T>(src);

        /// <summary>
        /// Defines a generic digit based on a digit enumeration value
        /// in the context of a natural base
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The digit's enumeration type</typeparam>
        /// <typeparam name="N">The natural base type</typeparam>
        public static Digit<N,T> Define<N,T>(T src, N b)
            where N : ITypeNat, new()
            where T : Enum
                => new Digit<N,T>(src);
    }



    public interface IDigit<N,S,T>
        where N : ITypeNat, new()
        where S : IDigit<N,S,T>
        where T : Enum
    {

    }

    /// <summary>
    /// Defines a generic digit representation realtive to a natural base
    /// </summary>
    /// <typeparam name="N">The natural base type</typeparam>
    /// <typeparam name="T">The digit's enumeration type</typeparam>
    public readonly struct Digit<N,T> : IDigit<N,Digit<N,T>,T>
        where T : Enum
        where N : ITypeNat, new()
    {
        /// <summary>
        /// Specifies the value of the structurel digit corresponding to 0
        /// </summary>
        public static readonly Digit<N,T> Zero = default;

        /// <summary>
        /// Specifies the integral value value of the natural base
        /// </summary>
        public static readonly uint Base = natui<N>();

        [MethodImpl(Inline)]
        public static bool operator ==(Digit<N,T> lhs, Digit<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Digit<N,T> lhs, Digit<N,T> rhs)
            => not(lhs.Equals(rhs));

        [MethodImpl(Inline)]
        public static implicit operator uint(Digit<N,T> src)
            => src.ToUInt();

        [MethodImpl(Inline)]
        public static implicit operator T(Digit<N,T> src)
            => src.value;


        readonly T value;

        [MethodImpl(Inline)]
        public Digit(T src)
            => value = src;
        
        public uint ToUInt()
            => (uint)Convert.ChangeType(value, typeof(uint));

        public uint @base
        {
            [MethodImpl(Inline)]
            get => Base;
        }
        
        [MethodImpl(Inline)]
        public string format()
            => ToUInt().ToString();

        [MethodImpl(Inline)]
        public bool Equals(Digit<N,T> rhs)
            => value.Equals(rhs);

        [MethodImpl(Inline)]        
        public override bool Equals(object rhs)
            => rhs is Digit<N,T> ? Equals((Digit<N,T>)rhs) : false;
        
        [MethodImpl(Inline)]        
        public override int GetHashCode()
            => value.GetHashCode();
        
        public override string ToString()
            => format();
    }


}