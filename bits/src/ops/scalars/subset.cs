//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class Bits
    {
        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(byte test, byte set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(byte test, sbyte set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(byte test, short set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(byte test, ushort set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(byte test, int set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(byte test, uint set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(byte test, long set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(byte test, ulong set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(byte test, float set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(byte test, double set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(sbyte test, byte set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(sbyte test, sbyte set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(sbyte test, short set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(sbyte test, ushort set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(sbyte test, int set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(sbyte test, uint set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(sbyte test, long set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(sbyte test, ulong set)
            => ((byte)set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(sbyte test, float set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(sbyte test, double set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(ushort test, short set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(ushort test, ushort set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(ushort test, int set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(ushort test, uint set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(ushort test, long set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(ushort test, ulong set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(ushort test, float set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(short test, short set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(short test, ushort set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(short test, int set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(short test, uint set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(short test, long set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(short test, ulong set)
            => ((ushort)set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(short test, float set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(uint test, int set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(uint test, uint set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(uint test, long set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(uint test, ulong set)
            => ((ushort)set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(uint test, float set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(uint test, double set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(int test, int set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(int test, uint set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(int test, long set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(int test, ulong set)
            => ((ushort)set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(int test, float set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(int test, double set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(long test, long set)
            => (set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(long test, ulong set)
            => ((ushort)set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(long test, float set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(long test, double set)
            => (set.ToBits() & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(ulong test, long set)
            => ((ulong)set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(ulong test, ulong set)
            => ((ushort)set & test) == test;

        /// <summary>
        /// Determines whether the left bitsource is a subset of the right bitsource
        /// </summary>
        /// <param name="test">The left bits</param>
        /// <param name="set">The right bits</param>
        [MethodImpl(Inline)]
        public static bool subset(ulong test, double set)
            => ((ulong)set.ToBits() & test) == test;

    }

}