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

    
    using static zfunc;
    using static nfunc;

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
            where T : struct
                => cast<IPow2G<N,T>>(Pow2G<T>.TheOne).Value;

        /// <summary>
        /// Computes 2^0:T = 1:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<T>(N0 exp)
            where T : struct
                => value<N0,T>();

        /// <summary>
        /// Computes 2^1:T = 2:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T  value<T>(N1 exp)
            where T : struct
                => value<N1,T>();

        /// <summary>
        /// Computes 2^2:T = 4:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T  value<T>(N2 exp)
            where T : struct
                => value<N2,T>();

        /// <summary>
        /// Computes 2^3:T = 8:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T  value<T>(N3 exp)
            where T : struct
                => value<N3,T>();

        /// <summary>
        /// Computes 2^4:T = 16:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T  value<T>(N4 exp)
            where T : struct
                => value<N4,T>();

        /// <summary>
        /// Computes 2^5:T = 32:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T  value<T>(N5 exp)
            where T : struct
                => value<N5,T>();

        /// <summary>
        /// Computes 2^6:T = 64:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<T>(N6 exp)
            where T : struct
                => value<N6,T>();

        /// <summary>
        /// Computes 2^7:T = 128:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<T>(N7 exp)
            where T : struct
                => value<N7,T>();

        /// <summary>
        /// Computes 2^8:T = 256:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<T>(N8 exp)
            where T : struct
                => value<N8,T>();

        /// <summary>
        /// Computes 2^9:T = 512:T
        /// </summary>
        /// <param name="exp">The natural exponent value</param>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<T>(N9 exp)
            where T : struct
                => value<N9,T>();

        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        [MethodImpl(Inline)]
        public static uint mul(int exp, uint factor)
            => (uint)Pow2.pow(exp)*factor;

        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        [MethodImpl(Inline)]
        public static int mul(int exp, int factor)
            => (int)Pow2.pow(exp)*factor;

        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        [MethodImpl(Inline)]
        public static ulong mul(int exp, ulong factor)
            => Pow2.pow(exp)*factor;

    }

    public interface IPow2G<N,T>
        where N : ITypeNat, new()
        where T : struct
    {
        T Value {get;}

    }

    readonly struct Pow2G<T> : 
        IPow2G<N0,T>, 
        IPow2G<N1,T>, 
        IPow2G<N2,T>, 
        IPow2G<N3,T>, 
        IPow2G<N4,T>, 
        IPow2G<N5,T>, 
        IPow2G<N6,T>, 
        IPow2G<N7,T>, 
        IPow2G<N8,T>, 
        IPow2G<N9,T>, 
        IPow2G<N10,T>, 
        IPow2G<N11,T>, 
        IPow2G<N12,T>, 
        IPow2G<N13,T>, 
        IPow2G<N14,T>, 
        IPow2G<N15,T>, 
        IPow2G<N16,T>,
        IPow2G<N17,T>,
        IPow2G<N18,T>,
        IPow2G<N19,T>,
        IPow2G<N20,T>,
        IPow2G<N32,T>,
        IPow2G<N64,T>
            where T : struct
    {
        public static readonly Pow2G<T> TheOne = default;

        T IPow2G<N0, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<byte,T>(Pow2.T00);
        }

        T IPow2G<N1, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<byte,T>(Pow2.T01);
        }

        T IPow2G<N2, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<byte,T>(Pow2.T02);
        }

        T IPow2G<N3, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<byte,T>(Pow2.T03);
        }

        T IPow2G<N4, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<byte,T>(Pow2.T04);
        }

        T IPow2G<N5, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T05);
        }

        T IPow2G<N6, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T06);
        }

        T IPow2G<N7, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T07);
        }

        T IPow2G<N8, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T08);
        }

        T IPow2G<N9, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T09);
        }

        T IPow2G<N10, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T10);
        }

        T IPow2G<N11, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T11);
        }

        T IPow2G<N12, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T12);
        }

        T IPow2G<N13, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T13);
        }

        T IPow2G<N14, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T14);
        }

        T IPow2G<N15, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ushort,T>(Pow2.T15);
        }

        T IPow2G<N16, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<uint,T>(Pow2.T16);
        }

        T IPow2G<N17, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<uint,T>(Pow2.T17);
        }

        T IPow2G<N18, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<uint,T>(Pow2.T18);
        }

        T IPow2G<N19, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<uint,T>(Pow2.T19);
        }

        T IPow2G<N20, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<uint,T>(Pow2.T20);
        }

        T IPow2G<N32, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ulong,T>(Pow2.T32);
        }

        T IPow2G<N64, T>.Value 
        {
            [MethodImpl(Inline)]
            get => convert<ulong,T>(Pow2.T32);
        }
    }
}