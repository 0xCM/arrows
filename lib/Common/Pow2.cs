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

    public static class Pow2
    {
        /// <summary>
        /// Computes 2^i:T where i:N
        /// </summary>
        /// <typeparam name="N">The natural exponent value</typeparam>
        /// <typeparam name="T">The base value type</typeparam>
        [MethodImpl(Inline)]
        public static T value<N,T>()
            where N : TypeNat, new()
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
        public static ulong mul(int exp, ulong factor)
            => pow(exp)*factor;

        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static uint mul(int exp, uint factor)
            => (uint)pow(exp)*factor;

        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static int mul(int exp, int factor)
            => (int)pow(exp)*factor;

        public static intg<T> mul<T>(int exp, intg<T> factor)
            where T : struct, IEquatable<T>
                => 2.ToIntG<T>().pow(exp) * factor;

        /// <summary>
        /// Computes 2^i 
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static ulong pow(int exp)
            => exp switch {
                0 => T00,
                1 => T01,
                2 => T02,
                3 => T03,
                4 => T04,
                5 => T05,
                6 => T06,
                7 => T07,
                8 => T08,
                9 => T09,
                10 => T10,
                11 => T11,
                12 => T12,
                13 => T13,
                14 => T14,
                15 => T15,
                16 => T16,
                17 => T17,
                18 => T18,
                19 => T19,
                20 => T20,
                21 => T21,
                22 => T22,
                23 => T23,
                24 => T24,
                25 => T25,
                26 => T26,
                27 => T27,
                28 => T28,
                29 => T29,
                30 => T30,
                31 => T31,
                32 => T32,
                33 => T33,
                34 => T34,
                35 => T35,
                _ => 0UL,
            };


        /// <summary>
        /// 2^0 = 1
        /// </summary>
        public const byte T00 = 0;

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        public const byte T01 = 2;

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        public const byte T02 = 2*2;

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        public const byte T03 = 2*T02;

        /// <summary>
        /// 2^4 = 16
        /// </summary>
        public const byte T04 = 2*T03;

        /// <summary>
        /// 2^5 = 32
        /// </summary>
        public const byte T05 = 2*T04;

        /// <summary>
        /// 2^6 = 64
        /// </summary>
        public const byte T06 = 2*T05;

        /// <summary>
        /// 2^7 = 128
        /// </summary>
        public const byte T07 = 2*T06;

        /// <summary>
        /// 2^8 = 256
        /// </summary>
        public const ushort T08 = 2*T07;

        /// <summary>
        /// 2^9 = 512
        /// </summary>
        public const ushort T09 = 2*T08;

        /// <summary>
        /// 2^10 = 1024
        /// </summary>
        public const ushort T10 = 2*T09;
        
        /// <summary>
        /// 2^11 = 2048
        /// </summary>
        public const ushort T11 = 2*T10;
        
        /// <summary>
        /// 2^12 = 4096
        /// </summary>
        public const ushort T12 = 2*T11;

        /// <summary>
        /// 2^13 = 8192
        /// </summary>
        public const ushort T13 = 2*T12;

        /// <summary>
        /// 2^14 = 16,384
        /// </summary>
        public const ushort T14 = 2*T13;
        
        /// <summary>
        /// 2^15 = 32,768
        /// </summary>
        public const ushort T15 = 2*T14;

        /// <summary>
        /// 2^16 = 65,536
        /// </summary>
        public const uint T16 = 2*T15;
        
        /// <summary>
        /// 2^17 = 131,072
        /// </summary>
        public const uint T17 = 2*T16;

        /// <summary>
        /// 2^18 = 262,144
        /// </summary>
        public const uint T18 = 2*T17;

        /// <summary>
        /// 2^19 = 524,288
        /// </summary>
        public const uint T19 = 2*T18;

        /// <summary>
        /// 2^20 = 1,048,576
        /// </summary>
        public const uint T20 = 2*T19;
        
        /// <summary>
        /// 2^21 = 2,097,152
        /// </summary>
        public const uint T21 = 2*T20;

        /// <summary>
        /// 2^22 = 4,194,304
        /// </summary>
        public const uint T22 = 2*T21;

        /// <summary>
        /// 2^23 = 8,388,608
        /// </summary>
        public const uint T23 = 2*T22;
        
        /// <summary>
        /// 2^24 = 16,777,216
        /// </summary>
        public const uint T24 = 2*T23;

        public const uint T25 = 2*T24;
        public const ulong T26 = 2*T25;
        public const ulong T27 = 2*T26;
        public const ulong T28 = 2*T27;
        public const ulong T29 = 2*T28;
        public const ulong T30 = 2*T29;
        public const ulong T31 = 2*T30;
        public const ulong T32 = 2*T31;
        public const ulong T33 = 2*T32;
        public const ulong T34 = 2*T33;
        public const ulong T35 = 2*T34;
        public const ulong T36 = 2*T35;
        public const ulong T37 = 2*T36;
        public const ulong T38 = 2*T37;
        public const ulong T39 = 2*T38;
        public const ulong T40 = 2*T39;
        public const ulong T41 = 2*T40;
        public const ulong T42 = 2*T41;
        public const ulong T43 = 2*T42;
        public const ulong T44 = 2*T43;
        public const ulong T45 = 2*T44;
        public const ulong T46 = 2*T45;

    }


    public interface Pow2<N,T>
        where N : TypeNat, new()
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