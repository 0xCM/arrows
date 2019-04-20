//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zcore;

    partial class Structures
    {
        public interface Digit<T> : Formattable
            where T : Enum
        {

        }

        public interface Digit<S,T> : Digit<T>, IEquatable<S>
            where S : Digit<S,T>
            where T : Enum
        {

        }

        public interface Digit<N,S,T> : Digit<S,T>, IEquatable<S>
            where N : TypeNat, new()
            where S : Digit<N,S,T>
            where T : Enum
        {

        }

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


        /// <summary>
        /// Defines a generic digit based on a digit enumeration value
        /// in the context of a natural base
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The digit's enumeration type</typeparam>
        /// <typeparam name="N">The natural base type</typeparam>
        public static Digit<N,T> define<N,T>(T src)
            where N : TypeNat, new()
            where T : Enum
                => new Digit<N,T>(src);

        /// <summary>
        /// Defines a generic digit based on a digit enumeration value
        /// in the context of a natural base
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The digit's enumeration type</typeparam>
        /// <typeparam name="N">The natural base type</typeparam>
        public static Digit<N,T> define<N,T>(T src, N b)
            where N : TypeNat, new()
            where T : Enum
                => new Digit<N,T>(src);

    }

    /// <summary>
    /// Defines a generic digit representation parametrized by a
    /// defining enumeration
    /// </summary>
    /// <typeparam name="T">The digit's enumeration type</typeparam>
    public readonly struct Digit<T> : Structures.Digit<Digit<T>,T> 
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
            => src.value.ToIntG<uint>();

        public static implicit operator T(Digit<T> src)
            => src.value;

        public Digit(T src)
            => value = src;
        
        readonly T value;

        public string format()
            => value.ToString();

        public bool Equals(Digit<T> rhs)
            => value.Equals(rhs);

        /// <summary>
        /// Expresses the digit in a natural base
        /// </summary>
        /// <param name="b">The natural base value</param>
        /// <typeparam name="N">The natural base type</typeparam>
        public Digit<N,T> InBase<N>(N b = default)
            where N : TypeNat, new() => new Digit<N,T>(value);


        [MethodImpl(Inline)]        
        public override bool Equals(object rhs)
            => rhs is Digit<T> ? Equals((Digit<T>)rhs) : false;
        
        [MethodImpl(Inline)]        
        public override int GetHashCode()
            => value.GetHashCode();

    }

    /// <summary>
    /// Defines a generic digit representation realtive to a natural base
    /// </summary>
    /// <typeparam name="N">The natural base type</typeparam>
    /// <typeparam name="T">The digit's enumeration type</typeparam>
    public readonly struct Digit<N,T> : Structures.Digit<N,Digit<N,T>,T>
        where T : Enum
        where N : TypeNat, new()
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
            => src.value.ToIntG<uint>();

        [MethodImpl(Inline)]
        public static implicit operator T(Digit<N,T> src)
            => src.value;

        [MethodImpl(Inline)]
        public static implicit operator Digit<T>(Digit<N,T> src)
            => new Digit<T>(src);

        readonly T value;

        [MethodImpl(Inline)]
        public Digit(T src)
            => value = src;
        
        public uint ToUInt()
            => value.ToIntG<uint>();

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
