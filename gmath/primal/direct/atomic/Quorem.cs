namespace Z0
{

    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Numerics;
    
    using static mfunc;

    partial class math
    {
        [MethodImpl(Inline)]
        public static Quorem<sbyte> quorem(sbyte lhs, sbyte rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            var quo = div(x, y);
            var rem = (sbyte)(x - quo*y);            
            return Quorem.define(quo, rem);                               
        }

        [MethodImpl(Inline)]
        public static Quorem<byte> quorem(byte lhs, byte rhs)
        {
            var quo = div(lhs, rhs);
            var rem = (byte)(lhs - quo*rhs);
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<short> quorem(short lhs, short rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            var quo = div(x, y);
            var rem = (short)(x - quo*y);
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<ushort> quorem(ushort lhs, ushort rhs)
        {
            var quo = div(lhs, rhs);
            var rem = (ushort)(lhs - quo*rhs);
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<int> quorem(int lhs, int rhs)
            => (Math.DivRem(lhs,rhs, out int rem), rem);

        [MethodImpl(Inline)]
        public static Quorem<uint> quorem(uint lhs, uint rhs)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<long> quorem(long lhs, long rhs)
            => (Math.DivRem(lhs,rhs, out long rem), rem);

        [MethodImpl(Inline)]
        public static Quorem<ulong> quorem(ulong lhs, ulong rhs)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<float> quorem(float lhs, float rhs)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<double> quorem(double lhs, double rhs)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<decimal> quorem(decimal lhs, decimal rhs)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            return Quorem.define(quo, rem);                   
        }

        [MethodImpl(Inline)]
        public static Quorem<BigInteger> quorem(BigInteger lhs, BigInteger rhs)
        {
            var rem = BigInteger.Zero;
            var div = BigInteger.DivRem(lhs, rhs, out rem);  
            return Quorem.define(div,rem);                  
        }

        [MethodImpl(Inline)]
        public static ref Quorem<sbyte> quorem(sbyte lhs, sbyte rhs, out Quorem<sbyte> dst)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            var quo = div(x, y);
            var rem = (sbyte)(x - quo*y);
            dst = Quorem.define(quo, rem);                   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Quorem<byte> quorem(byte lhs, byte rhs, out Quorem<byte> dst)
        {
            var quo = div(lhs, rhs);
            var rem = (byte)(lhs - quo*rhs);
            dst = Quorem.define(quo, rem);                   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Quorem<int> quorem(int lhs, int rhs, out Quorem<int> dst)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            var quo = div(x, y);
            var rem = x - quo*y;
            dst = Quorem.define(quo, rem);                   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Quorem<uint> quorem(uint lhs, uint rhs, out Quorem<uint> dst)
        {
            var quo = div(lhs, rhs);
            var rem = lhs - quo*rhs;
            dst = Quorem.define(quo, rem);                   
            return ref dst;
        }
    }
}