//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    public delegate T PrimalBinOp<T>(T lhs, T rhs)
        where T : struct, IEquatable<T>;

    public delegate T PrimalUnaryOp<T>(T src)
        where T : struct, IEquatable<T>;

    public delegate Index<T> IndexBinOp<T>(Index<T> lhs, Index<T> rhs)
        where T : struct, IEquatable<T>;

    public delegate T IndexAggregateOp<T>(in Index<T> src)
        where T : struct, IEquatable<T>;

    public static class PrimOpDelegates
    {
        #region add

        [MethodImpl(Inline)]
        static byte add(byte lhs, byte rhs)
            => (byte)(lhs + rhs);

        [MethodImpl(Inline)]
        static sbyte add(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs + rhs);

        [MethodImpl(Inline)]
        static ushort add(ushort lhs, ushort rhs)
            => (ushort)(lhs + rhs);

        [MethodImpl(Inline)]
        static short add(short lhs, short rhs)
            => (short)(lhs + rhs);

        [MethodImpl(Inline)]
        static int add(int lhs, int rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static uint add(uint lhs, uint rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static ulong add(ulong lhs, ulong rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static long add(long lhs, long rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static float add(float lhs, float rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static double add(double lhs, double rhs)
            => lhs + rhs;


        [MethodImpl(Inline)]
        static decimal add(decimal lhs, decimal rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        static BigInteger add(BigInteger lhs, BigInteger rhs)
            => lhs + rhs;


        static readonly PrimalIndex AddDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(add),
                @byte : new PrimalBinOp<byte>(add),
                @short : new PrimalBinOp<short>(add),
                @ushort : new PrimalBinOp<ushort>(add),
                @int : new PrimalBinOp<int>(add),
                @uint : new PrimalBinOp<uint>(add),
                @long : new PrimalBinOp<long>(add),
                @ulong : new PrimalBinOp<ulong>(add),
                @float : new PrimalBinOp<float>(add),
                @double : new PrimalBinOp<double>(add),
                @decimal : new PrimalBinOp<decimal>(add),
                bigint : new PrimalBinOp<BigInteger>(add)
            );

        readonly struct Add<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = AddDelegates.lookup<T,PrimalBinOp<T>>();
        }
        #endregion

        #region sub

        [MethodImpl(Inline)]
        static byte sub(byte lhs, byte rhs)
            => (byte)(lhs - rhs);

        [MethodImpl(Inline)]
        static sbyte sub(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs - rhs);

        [MethodImpl(Inline)]
        static ushort sub(ushort lhs, ushort rhs)
            => (ushort)(lhs - rhs);

        [MethodImpl(Inline)]
        static short sub(short lhs, short rhs)
            => (short)(lhs - rhs);

        [MethodImpl(Inline)]
        static int sub(int lhs, int rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static uint sub(uint lhs, uint rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static ulong sub(ulong lhs, ulong rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static long sub(long lhs, long rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static float sub(float lhs, float rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static double sub(double lhs, double rhs)
            => lhs - rhs;


        [MethodImpl(Inline)]
        static decimal sub(decimal lhs, decimal rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        static BigInteger sub(BigInteger lhs, BigInteger rhs)
            => lhs - rhs;


       static readonly PrimalIndex SubDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(sub),
                @byte : new PrimalBinOp<byte>(sub),
                @short : new PrimalBinOp<short>(sub),
                @ushort : new PrimalBinOp<ushort>(sub),
                @int : new PrimalBinOp<int>(sub),
                @uint : new PrimalBinOp<uint>(sub),
                @long : new PrimalBinOp<long>(sub),
                @ulong : new PrimalBinOp<ulong>(sub),
                @float : new PrimalBinOp<float>(sub),
                @double : new PrimalBinOp<double>(sub),
                @decimal : new PrimalBinOp<decimal>(sub),
                bigint : new PrimalBinOp<BigInteger>(sub)
            );

        readonly struct Sub<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = SubDelegates.lookup<T,PrimalBinOp<T>>();
        }

        #endregion        

        #region abs

        [MethodImpl(Inline)]
        static byte abs(byte x)
            => x;

        [MethodImpl(Inline)]
        static sbyte abs(sbyte x)
            => (sbyte)(x >= 0 ? x : -x);

        [MethodImpl(Inline)]
        static short abs(short x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static ushort abs(ushort x)
            => x;

        [MethodImpl(Inline)]
        static int abs(int x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static uint abs(uint x)
            => x;

        [MethodImpl(Inline)]
        static long abs(long x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static ulong abs(ulong x)
            => x;

        [MethodImpl(Inline)]
        static float abs(float x)
            => MathF.Abs(x);

        [MethodImpl(Inline)]
        static double abs(double x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static decimal abs(decimal x)
            => Math.Abs(x);

        [MethodImpl(Inline)]
        static BigInteger abs(BigInteger x)
            => BigInteger.Abs(x);


       static readonly PrimalIndex AbsDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalUnaryOp<sbyte>(abs),
                @byte : new PrimalUnaryOp<byte>(abs),
                @short : new PrimalUnaryOp<short>(abs),
                @ushort : new PrimalUnaryOp<ushort>(abs),
                @int : new PrimalUnaryOp<int>(abs),
                @uint : new PrimalUnaryOp<uint>(abs),
                @long : new PrimalUnaryOp<long>(abs),
                @ulong : new PrimalUnaryOp<ulong>(abs),
                @float : new PrimalUnaryOp<float>(abs),
                @double : new PrimalUnaryOp<double>(abs),
                @decimal : new PrimalUnaryOp<decimal>(abs),
                bigint : new PrimalUnaryOp<BigInteger>(abs)
            );

        readonly struct Abs<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalUnaryOp<T> Op 
                = AbsDelegates.lookup<T,PrimalUnaryOp<T>>();
        }
 
        #endregion

        #region div

        [MethodImpl(Inline)]
        static byte div(byte lhs, byte rhs)
            => (byte)(lhs / rhs);

        [MethodImpl(Inline)]
        static sbyte div(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs / rhs);

        [MethodImpl(Inline)]
        static ushort div(ushort lhs, ushort rhs)
            => (ushort)(lhs / rhs);

        [MethodImpl(Inline)]
        static short div(short lhs, short rhs)
            => (short)(lhs / rhs);

        [MethodImpl(Inline)]
        static int div(int lhs, int rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static uint div(uint lhs, uint rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static ulong div(ulong lhs, ulong rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static decimal div(decimal lhs, decimal rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static double div(double lhs, double rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static float div(float lhs, float rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static BigInteger div(BigInteger lhs, BigInteger rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        static long div(long lhs, long rhs)
            => lhs / rhs;

        static readonly PrimalIndex DivDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(div),
                @byte : new PrimalBinOp<byte>(div),
                @short : new PrimalBinOp<short>(div),
                @ushort : new PrimalBinOp<ushort>(div),
                @int : new PrimalBinOp<int>(div),
                @uint : new PrimalBinOp<uint>(div),
                @long : new PrimalBinOp<long>(div),
                @ulong : new PrimalBinOp<ulong>(div),
                @float : new PrimalBinOp<float>(div),
                @double : new PrimalBinOp<double>(div),
                @decimal : new PrimalBinOp<decimal>(div),
                bigint : new PrimalBinOp<BigInteger>(div)
            );

        readonly struct Div<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = DivDelegates.lookup<T,PrimalBinOp<T>>();
        }

        #endregion

        #region mod

        [MethodImpl(Inline)]
        static byte mod(byte lhs, byte rhs)
            => (byte)(lhs % rhs);

        [MethodImpl(Inline)]
        static sbyte mod(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs % rhs);

        [MethodImpl(Inline)]
        static ushort mod(ushort lhs, ushort rhs)
            => (ushort)(lhs % rhs);

        [MethodImpl(Inline)]
        static short mod(short lhs, short rhs)
            => (short)(lhs % rhs);

        [MethodImpl(Inline)]
        static int mod(int lhs, int rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static uint mod(uint lhs, uint rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static ulong mod(ulong lhs, ulong rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static decimal mod(decimal lhs, decimal rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static double mod(double lhs, double rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static float mod(float lhs, float rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static BigInteger mod(BigInteger lhs, BigInteger rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        static long mod(long lhs, long rhs)
            => lhs % rhs;

        static readonly PrimalIndex ModDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(mod),
                @byte : new PrimalBinOp<byte>(mod),
                @short : new PrimalBinOp<short>(mod),
                @ushort : new PrimalBinOp<ushort>(mod),
                @int : new PrimalBinOp<int>(mod),
                @uint : new PrimalBinOp<uint>(mod),
                @long : new PrimalBinOp<long>(mod),
                @ulong : new PrimalBinOp<ulong>(mod),
                @float : new PrimalBinOp<float>(mod),
                @double : new PrimalBinOp<double>(mod),
                @decimal : new PrimalBinOp<decimal>(mod),
                bigint : new PrimalBinOp<BigInteger>(mod)
            );

        readonly struct Mod<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = ModDelegates.lookup<T,PrimalBinOp<T>>();
        }

        #endregion     
   
        #region and

        [MethodImpl(Inline)]
        static byte and(byte lhs, byte rhs)
            => (byte)(lhs & rhs);

        [MethodImpl(Inline)]
        static sbyte and(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs & rhs);

        [MethodImpl(Inline)]
        static ushort and(ushort lhs, ushort rhs)
            => (ushort)(lhs & rhs);

        [MethodImpl(Inline)]
        static short and(short lhs, short rhs)
            => (short)(lhs & rhs);

        [MethodImpl(Inline)]
        static int and(int lhs, int rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        static uint and(uint lhs, uint rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        static ulong and(ulong lhs, ulong rhs)
            => lhs & rhs;


        [MethodImpl(Inline)]
        static double and(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(lhs) & BitConverter.DoubleToInt64Bits(rhs));

        [MethodImpl(Inline)]
        static float and(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(lhs) & BitConverter.SingleToInt32Bits(rhs));

        [MethodImpl(Inline)]
        static BigInteger and(BigInteger lhs, BigInteger rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        static long and(long lhs, long rhs)
            => lhs & rhs;

        static readonly PrimalIndex AndDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(and),
                @byte : new PrimalBinOp<byte>(and),
                @short : new PrimalBinOp<short>(and),
                @ushort : new PrimalBinOp<ushort>(and),
                @int : new PrimalBinOp<int>(and),
                @uint : new PrimalBinOp<uint>(and),
                @long : new PrimalBinOp<long>(and),
                @ulong : new PrimalBinOp<ulong>(and),
                @float : new PrimalBinOp<float>(and),
                @double : new PrimalBinOp<double>(and),
                bigint : new PrimalBinOp<BigInteger>(and)
            );

        readonly struct And<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = AndDelegates.lookup<T,PrimalBinOp<T>>();
        }

        #endregion     
  
        #region or

        [MethodImpl(Inline)]
        static byte or(byte lhs, byte rhs)
            => (byte)(lhs | rhs);

        [MethodImpl(Inline)]
        static sbyte or(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs | rhs);

        [MethodImpl(Inline)]
        static ushort or(ushort lhs, ushort rhs)
            => (ushort)(lhs | rhs);

        [MethodImpl(Inline)]
        static short or(short lhs, short rhs)
            => (short)(lhs | rhs);

        [MethodImpl(Inline)]
        static int or(int lhs, int rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        static uint or(uint lhs, uint rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        static ulong or(ulong lhs, ulong rhs)
            => lhs | rhs;


        [MethodImpl(Inline)]
        static double or(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(lhs) & BitConverter.DoubleToInt64Bits(rhs));

        [MethodImpl(Inline)]
        static float or(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(lhs) & BitConverter.SingleToInt32Bits(rhs));

        [MethodImpl(Inline)]
        static BigInteger or(BigInteger lhs, BigInteger rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        static long or(long lhs, long rhs)
            => lhs | rhs;

        static readonly PrimalIndex OrDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalBinOp<sbyte>(or),
                @byte : new PrimalBinOp<byte>(or),
                @short : new PrimalBinOp<short>(or),
                @ushort : new PrimalBinOp<ushort>(or),
                @int : new PrimalBinOp<int>(or),
                @uint : new PrimalBinOp<uint>(or),
                @long : new PrimalBinOp<long>(or),
                @ulong : new PrimalBinOp<ulong>(or),
                @float : new PrimalBinOp<float>(or),
                @double : new PrimalBinOp<double>(or),
                bigint : new PrimalBinOp<BigInteger>(or)
            );

        readonly struct Or<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalBinOp<T> Op 
                = OrDelegates.lookup<T,PrimalBinOp<T>>();
        }

        #endregion     
  



        [MethodImpl(Inline)]
        public static PrimalBinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Add<T>.Op;

        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
                => Add<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalBinOp<T> sub<T>()
            where T : struct, IEquatable<T>
                => Sub<T>.Op;

        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
                => Sub<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalUnaryOp<T> abs<T>()
            where T : struct, IEquatable<T>
                => Abs<T>.Op;

        [MethodImpl(Inline)]
        public static T abs<T>(T src)
            where T : struct, IEquatable<T>
                => Abs<T>.Op(src);

        [MethodImpl(Inline)]
        public static PrimalBinOp<T> div<T>()
            where T : struct, IEquatable<T>
                => Div<T>.Op;

        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
                => Div<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalBinOp<T> mod<T>()
            where T : struct, IEquatable<T>
                => Mod<T>.Op;

        [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
                => Mod<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
                => And<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalBinOp<T> and<T>()
            where T : struct, IEquatable<T>
                => And<T>.Op;

       [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
                => Or<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalBinOp<T> or<T>()
            where T : struct, IEquatable<T>
                => Or<T>.Op;

    }

}