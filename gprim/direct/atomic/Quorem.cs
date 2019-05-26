namespace Z0
{

    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Numerics;
    
    using static zfunc;    
    

    partial class math
    {
        [MethodImpl(Inline)]
        public static Quorem<sbyte> quorem(in sbyte lhs, in  sbyte rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            var quo = div(x, y);
            var rem = (sbyte)(x - quo*y);            
            return Quorem.define(quo, rem);                               
        }

        [MethodImpl(Inline)]
        public static Quorem<byte> quorem(in byte lhs, in byte rhs)
        {
            var quo = div(lhs, rhs);
            var rem = (byte)(lhs - quo*rhs);
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<short> quorem(in short lhs, in short rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            var quo = div(x, y);
            var rem = (short)(x - quo*y);
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<ushort> quorem(in ushort lhs, in ushort rhs)
        {
            var quo = div(lhs, rhs);
            var rem = (ushort)(lhs - quo*rhs);
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<int> quorem(in int lhs, in int rhs)
            => (Math.DivRem(lhs,rhs, out int rem), rem);

        [MethodImpl(Inline)]
        public static Quorem<uint> quorem(in uint lhs, in uint rhs)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<long> quorem(in long lhs, in long rhs)
            => (Math.DivRem(lhs,rhs, out long rem), rem);

        [MethodImpl(Inline)]
        public static Quorem<ulong> quorem(in ulong lhs, in ulong rhs)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<float> quorem(in float lhs, in float rhs)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<double> quorem(in double lhs, in double rhs)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<decimal> quorem(in decimal lhs, in decimal rhs)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<BigInteger> quorem(in BigInteger lhs, in BigInteger rhs)
        {
            var rem = BigInteger.Zero;
            var div = BigInteger.DivRem(lhs, rhs, out rem);  
            return Quorem.define(div,rem);                  
        }

        [MethodImpl(Inline)]
        public static ref Quorem<sbyte> quorem(in sbyte lhs, in sbyte rhs, out Quorem<sbyte> dst)
        {
            abs(in lhs, out sbyte x);
            abs(in rhs, out sbyte y);
            var quo = (sbyte)(x / y);
            var rem = (sbyte)(x - quo*y);
            dst = Quorem.define(in quo, in rem);                   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Quorem<byte> quorem(in byte lhs, in byte rhs, out Quorem<byte> dst)
        {
            var quo = (byte)(lhs / rhs);
            var rem = (byte)(lhs - quo*rhs);
            dst = Quorem.define(in quo, in rem);                   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Quorem<short> quorem(in short lhs, in short rhs, out Quorem<short> dst)
        {
            abs(in lhs, out short x);
            abs(in rhs, out short y);
            var quo = (short)(x / y);
            var rem = (short)(x - quo*y);
            dst = Quorem.define(in quo, in rem);                   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Quorem<ushort> quorem(in ushort lhs, in ushort rhs, out Quorem<ushort> dst)
        {
            var quo = (ushort)(lhs / rhs);
            var rem = (ushort)(lhs - quo*rhs);
            dst = Quorem.define(in quo, in rem);                   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Quorem<int> quorem(in int lhs, in int rhs, out Quorem<int> dst)
        {
            abs(in lhs, out int x);
            abs(in rhs, out int y);
            var quo = x / y;
            var rem = x - quo*y;
            dst = Quorem.define(in quo, in rem);                   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Quorem<uint> quorem(in uint lhs, in uint rhs, out Quorem<uint> dst)
        {
            var quo = lhs / rhs;
            var rem = lhs - quo*rhs;
            dst = Quorem.define(in quo, in rem);                   
            return ref dst;
        }

       [MethodImpl(Inline)]
        public static ref Quorem<long> quorem(in long lhs, in long rhs, out Quorem<long> dst)
        {
            abs(in lhs, out long x);
            abs(in rhs, out long y);
            var quo = x / y;
            var rem = x - quo*y;
            dst = Quorem.define(in quo, in rem);                   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Quorem<ulong> quorem(in ulong lhs, in ulong rhs, out Quorem<ulong> dst)
        {
            var quo = lhs/rhs;
            var rem = lhs - quo*rhs;
            dst = Quorem.define(in quo, in rem);                   
            return ref dst;
        }
    }
}