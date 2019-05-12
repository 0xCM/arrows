//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    
    using static zcore;
    using static zfunc;
    using static mfunc;

    public static class Pow2N
    {
        /// <summary>
        /// Computes 2^i:T where i:N
        /// </summary>
        /// <typeparam name="N">The natural exponent value</typeparam>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<N,T>()
            where N : ITypeNat, new()
            where T : struct, IEquatable<T>
                => cast<Pow2<N,T>>(Pow2G<T>.TheOne).Value;

        /// <summary>
        /// Computes 2^0:T = 1:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<T>(N0 exp)
            where T : struct, IEquatable<T>
                => value<N0,T>();

        /// <summary>
        /// Computes 2^1:T = 2:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T  value<T>(N1 exp)
            where T : struct, IEquatable<T>
                => value<N1,T>();

        /// <summary>
        /// Computes 2^2:T = 4:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T  value<T>(N2 exp)
            where T : struct, IEquatable<T>
                => value<N2,T>();

        /// <summary>
        /// Computes 2^3:T = 8:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T  value<T>(N3 exp)
            where T : struct, IEquatable<T>
                => value<N3,T>();

        /// <summary>
        /// Computes 2^4:T = 16:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T  value<T>(N4 exp)
            where T : struct, IEquatable<T>
                => value<N4,T>();

        /// <summary>
        /// Computes 2^5:T = 32:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T  value<T>(N5 exp)
            where T : struct, IEquatable<T>
                => value<N5,T>();

        /// <summary>
        /// Computes 2^6:T = 64:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<T>(N6 exp)
            where T : struct, IEquatable<T>
                => value<N6,T>();

        /// <summary>
        /// Computes 2^7:T = 128:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<T>(N7 exp)
            where T : struct, IEquatable<T>
                => value<N7,T>();

        /// <summary>
        /// Computes 2^8:T = 256:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<T>(N8 exp)
            where T : struct, IEquatable<T>
                => value<N8,T>();

        /// <summary>
        /// Computes 2^9:T = 512:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<T>(N9 exp)
            where T : struct, IEquatable<T>
                => value<N9,T>();

        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static uint mul(int exp, uint factor)
            => (uint)Pow2.pow(exp)*factor;

        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static int mul(int exp, int factor)
            => (int)Pow2.pow(exp)*factor;

        public static intg<T> mul<T>(int exp, intg<T> factor)
            where T : struct, IEquatable<T>
                => 2.ToIntG<T>().pow(exp) * factor;

        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static ulong mul(int exp, ulong factor)
            => Pow2.pow(exp)*factor;

    }



    public interface Pow2<N,T>
        where N : ITypeNat, new()
        where T : struct, IEquatable<T>
    {
        T Value {get;}

    }

    readonly struct Pow2G<T> : 
        Pow2<N0,T>, 
        Pow2<N1,T>, 
        Pow2<N2,T>, 
        Pow2<N3,T>, 
        Pow2<N4,T>, 
        Pow2<N5,T>, 
        Pow2<N6,T>, 
        Pow2<N7,T>, 
        Pow2<N8,T>, 
        Pow2<N9,T>, 
        Pow2<N10,T>, 
        Pow2<N11,T>, 
        Pow2<N12,T>, 
        Pow2<N13,T>, 
        Pow2<N14,T>, 
        Pow2<N15,T>, 
        Pow2<N16,T>,
        Pow2<N17,T>,
        Pow2<N18,T>,
        Pow2<N19,T>,
        Pow2<N20,T>,
        Pow2<N32,T>,
        Pow2<N64,T>
            where T : struct, IEquatable<T>
    {
        public static readonly Pow2G<T> TheOne = default;

        T Pow2<N0, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<byte,T>(Pow2.T00);
        }

        T Pow2<N1, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<byte,T>(Pow2.T01);
        }

        T Pow2<N2, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<byte,T>(Pow2.T02);
        }

        T Pow2<N3, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<byte,T>(Pow2.T03);
        }

        T Pow2<N4, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<byte,T>(Pow2.T04);
        }

        T Pow2<N5, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T05);
        }

        T Pow2<N6, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T06);
        }

        T Pow2<N7, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T07);
        }

        T Pow2<N8, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T08);
        }

        T Pow2<N9, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T09);
        }

        T Pow2<N10, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T10);
        }

        T Pow2<N11, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T11);
        }

        T Pow2<N12, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T12);
        }

        T Pow2<N13, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T13);
        }

        T Pow2<N14, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T14);
        }

        T Pow2<N15, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T15);
        }

        T Pow2<N16, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<uint,T>(Pow2.T16);
        }

        T Pow2<N17, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<uint,T>(Pow2.T17);
        }

        T Pow2<N18, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<uint,T>(Pow2.T18);
        }

        T Pow2<N19, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<uint,T>(Pow2.T19);
        }

        T Pow2<N20, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<uint,T>(Pow2.T20);
        }

        T Pow2<N32, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ulong,T>(Pow2.T32);
        }

        T Pow2<N64, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ulong,T>(Pow2.T32);
        }
    }
}