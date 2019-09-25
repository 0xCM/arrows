//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zfunc;

    class PrimalScenarios : Deconstructable<PrimalScenarios>
    {
        public PrimalScenarios()
            : base(callerfile())
        {

        }

        
        
        public static byte add_8u(byte x, byte y)
            => (byte)(x + y);

        public static byte add_g8u(byte x, byte y)
            => gmath.add(x,y);
        
        public static ulong mul_64u(ulong x, ulong y)
            => x * y;

        public static ulong mul_g64u(ulong x, ulong y)
            => gmath.mul(x,y);

        public static byte mul_8u(byte x, byte y)
            => (byte)(x * y);

        public static byte mul_g8u(byte x, byte y)
            => gmath.mul(x,y);

        public static ulong and_64u(ulong x, ulong y)
            => x & y;

        public static ulong and_g64u(ulong x, ulong y)
            => gmath.and(x,y);

        public static ulong mod_64u(ulong x, ulong y)
            => x % y;

        public static ulong mod_g64u(ulong x, ulong y)
            => gmath.mod(x,y);

        public static long abs_64i(long x)
            => math.abs(x);

        public static long abs_g64i(long x)
            => gmath.abs(x);

        public static ulong or_64u(ulong x, ulong y)
            => x | y;

        public static ulong or_g64u(ulong x, ulong y)
            => gmath.or(x,y);

        public static ulong xor_64u(ulong x, ulong y)
            => x ^ y;

        public static ulong xor_g64u(ulong x, ulong y)
            => gmath.xor(x,y);


        public static double inc_64f(double x)
            => ++x;

        public static double inc_g64f(double x)
            => gfp.inc(x);

        public static double dec_64f(double x)
            => --x;

        public static double dec_g64f(double x)
            => gfp.dec(x);

        public static double dec_64f(ref double x)
            => --x;

        public static ref double dec_g64f(ref double x)        
            => ref gfp.dec(ref x);


        #region emit

        public sbyte emit8i()
        {
            return -0x25;
        }

        public byte emit8u()
        {
            return 0x25;
        }

        public short emit16i()
        {
            return - 0x5432;
        }

        public ushort emit16u()
        {
            return 0x5432;
        }

        public int emit32i()
        {
            return -0x212425;
        }

        public uint emit32u()
        {
            return 0x44033022;
        }

        public long emit64i()
        {

            return Int64.MinValue;
        }

        public ulong emit64u()
        {

            return 0x66055044033022;
        }

        public float emit32f()
        {

            return 20304050.335255f;
        }

        public double emit64f()
        {

            return -358298783.335255;
        }

        #endregion
 
 
    }
}