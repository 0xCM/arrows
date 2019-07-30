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

        

        

        # region add

        public static sbyte add8i(sbyte x, sbyte y)
            => (sbyte)(x + y);

        public static sbyte add8i_In(in sbyte x, in sbyte y)
            => (sbyte)(x + y);

        public static ref sbyte add8i_Ref(ref sbyte x, in sbyte y)
        {
            x += y;
            return ref x;
        }

        public static byte add8u(byte x, byte y)
            => (byte)(x + y);

        public static byte add8u_In(in byte x, in byte y)
            => (byte)(x + y);

        public static ref byte add8u_Ref(ref byte x, in byte y)
        {
            x += y;
            return ref x;
        }

        public static short add16i(short x, short y)
            => (short)(x + y);

        public static short add16i_In(in short x, in short y)
            => (short)(x + y);

        public static ref short add16i_Ref(ref short x, in short y)
        {
            x += y;
            return ref x;
        }

        public static ushort add16u(ushort x, ushort y)
            => (ushort)(x + y);

        public static ushort add16u_In(in ushort x, in ushort y)
            => (ushort)(x + y);

        public static ref ushort add16u_Ref(ref ushort x, in ushort y)
        {
            x += y;
            return ref x;
        }

        public static int add32i(int x, int y)
            => x + y;

        public static int add32i_In(in int x, in int y)
            => x + y;

        public static ref int add32i_Ref(ref int x, in int y)
        {
            x += y;
            return ref x;
        }

        public static uint add32u(uint x, uint y)
            => x + y;

        public static uint add32u_In(in uint x, in uint y)
            => x + y;

        public static ref uint add32u_Ref(ref uint x, in uint y)
        {
            x += y;
            return ref x;
        }

        public static long add64i(long x, long y)
            => x + y;

        public static long add64i_In(in long x, in long y)
            => x + y;

        public static ref long add64i_Ref(ref long x, in long y)
        {
            x += y;
            return ref x;
        }

        public static ulong add64u(ulong x, ulong y)
            => x + y;

        public static ulong add64u_In(in ulong x, in ulong y)
            => x + y;

        public static ref ulong add64u_Ref(ref ulong x, in ulong y)
        {
            x += y;
            return ref x;
        }

        public static float add32f(float x, float y)
            => x + y;

        public static double add64f(double x, double y)
            => x + y;

        public static double add64f_In(in double x, in double y)
            => x + y;

        public static ref double add64f_Ref(ref double x, in double y)
        {
            x += y;
            return ref x;
        }

        public static float add32f_In(in float x, in float y)
            => x + y;

        public static ref float add32f_Ref(ref float x, in float y)
        {
            x += y;
            return ref x;
        }

        #endregion

        # region add3

        public static sbyte add8ix3(sbyte x, sbyte y, sbyte z)
            => (sbyte)(x + y + z);

        public static byte add8ux3(byte x, byte y, byte z)
            => (byte)(x + y + z);

        public static short add16ix3(short x, short y, short z)
            => (short)(x + y + z);

        public static ushort add16ux3(ushort x, ushort y, ushort z)
            => (ushort)(x + y + z);

        public static int add32ix3(int x, int y, int z)
            => x + y + z;

        public static uint add32ux3(uint x, uint y, uint z)
            => x + y + z;

        public static long add64ix3(long x, long y, long z)
            => x + y + z;

        public static ulong add64ux3(ulong x, ulong y, ulong z)
            => x + y + z;

        public static float add32fx3(float x, float y, float z)
            => x + y + z;

        public static double add64fx3(double x, double y, double z)
            => x + y + z;

        #endregion

        # region and

        public static byte and8u(byte x, byte y)
            => (byte)(x & y);

        public static sbyte and8i(sbyte x, sbyte y)
            => (sbyte)(x & y);

        public static short and16i(short x, short y)
            => (short)(x & y);

        public static ushort and16u(ushort x, ushort y)
            => (ushort)(x & y);

        public static int and32i(int x, int y)
            => x & y;

        public static uint and32u(uint x, uint y)
            => x & y;

        public static long and64i(long x, long y)
            => x & y;

        public static ulong and64u(ulong x, ulong y)
            => x & y;
        
        #endregion

        # region div

        public static sbyte div8i(sbyte x, sbyte y)
            => (sbyte)(x / y);

        public static byte div8u(byte x, byte y)
            => (byte)(x / y);

        public static short div16i(short x, short y)
            => (short)(x / y);

        public static ushort div16u(ushort x, ushort y)
            => (ushort)(x / y);

        public static int div32i(int x, int y)
            => x / y;

        public static uint div32u(uint x, uint y)
            => x / y;

        public static long div64i(long x, long y)
            => x / y;

        public static ulong div64u(ulong x, ulong y)
            => x / y;

        public static float div32f(float x, float y)
            => x / y;

        public static double div64f(double x, double y)
            => x / y;

        #endregion

        # region mul

        public static sbyte mul8i(sbyte x, sbyte y)
            => (sbyte)(x * y);

        public static byte mul8u(byte x, byte y)
            => (byte)(x * y);

        public static short mul16i(short x, short y)
            => (short)(x * y);

        public static ushort mul16u(ushort x, ushort y)
            => (ushort)(x * y);

        public static int mul32i(int x, int y)
            => x * y;

        public static int mul32i(int x, int y, int z)
            => x * y * z;

        public static int mul32i(int a, int b, int c, int d, int e, int f)
            => a*b*c*d*e*f;

        public static uint mul32u(uint x, uint y)
            => x * y;

        public static long mul64i(long x, long y)
            => x * y;

        public static ulong mul64u(ulong x, ulong y)
            => x * y;

        public static float mul32f(float x, float y)
            => x * y;

        public static double mul64f(double x, double y)
            => x * y;

        #endregion

        # region mod

        public static sbyte mod8i(sbyte x, sbyte y)
            => (sbyte)(x % y);

        public static byte mod8u(byte x, byte y)
            => (byte)(x % y);

        public static short mod16i(short x, short y)
            => (short)(x % y);

        public static ushort mod16u(ushort x, ushort y)
            => (ushort)(x % y);

        public static int mod32i(int x, int y)
            => x % y;

        public static uint mod32u(uint x, uint y)
            => x % y;

        public static long mod64i(long x, long y)
            => x % y;

        public static ulong mod64u(ulong x, ulong y)
            => x % y;

        public static float mod32f(float x, float y)
            => x % y;

        public static double mod64f(double x, double y)
            => x % y;

        #endregion

        # region or

        public static byte or8u(byte x, byte y)
            => (byte)(x | y);

        public static sbyte or8i(sbyte x, sbyte y)
            => (sbyte)(x | y);

        public static short or16i(short x, short y)
            => (short)(x | y);

        public static ushort or16u(ushort x, ushort y)
            => (ushort)(x | y);

        public static ushort or16u_2(ushort x, ushort y)
            => x |=y;

        public static int or32i(int x, int y)
            => x | y;

        public static uint or32u(uint x, uint y)
            => x | y;

        public static long or64i(long x, long y)
            => x | y;

        [MethodImpl(Inline | Optimize)]
        public static ulong or64u(ulong x, ulong y)
            => x | y;
        
        #endregion

        # region sub

        [MethodImpl(Inline | Optimize)]
        public static sbyte sub8i(sbyte x, sbyte y)
            => (sbyte)(x - y);

        [MethodImpl(Inline | Optimize)]
        public static byte sub8u(byte x, byte y)
            => (byte)(x - y);

        [MethodImpl(Inline | Optimize)]
        public static short sub16i(short x, short y)
            => (short)(x - y);

        [MethodImpl(Inline | Optimize)]
        public static ushort sub16u(ushort x, ushort y)
            => (ushort)(x - y);

        [MethodImpl(Inline | Optimize)]
        public static int sub32i(int x, int y)
            => x - y;

        [MethodImpl(Inline | Optimize)]
        public static uint sub32u(uint x, uint y)
            => x - y;

        [MethodImpl(Inline | Optimize)]
        public static long sub64i(long x, long y)
            => x - y;

        [MethodImpl(Inline | Optimize)]
        public static ulong sub64u(ulong x, ulong y)
            => x - y;

        [MethodImpl(Inline | Optimize)]
        public static float sub32f(float x, float y)
            => x - y;

        [MethodImpl(Inline | Optimize)]
        public static double sub64f(double x, double y)
            => x - y;

        #endregion

        #region negate

        [MethodImpl(Inline | Optimize)]
        public static sbyte negate8i(sbyte src)
            => (sbyte)(- src);

        [MethodImpl(Inline | Optimize)]
        public static byte negate8u(byte src)
            => (byte)(~src + 1);
     
        [MethodImpl(Inline | Optimize)]
        public static short negate16i(short src)
            => (short)(- src);

        [MethodImpl(Inline | Optimize)]
        public static ushort negate16u(ushort src)
            => (ushort)(~src + 1);

        [MethodImpl(Inline | Optimize)]
        public static int negate32i(int src)
            => -src;

        [MethodImpl(Inline | Optimize)]
        public static uint negate32u(uint src)
            => ~src + 1;

        [MethodImpl(Inline | Optimize)]
        public static long negate64i(long src)
            => -src;

        [MethodImpl(Inline | Optimize)]
        public static ulong negate64u(ulong src)
            => ~src + 1;

        [MethodImpl(Inline | Optimize)]
        public static float negate32f(float src)
            => 0 - src;

        [MethodImpl(Inline | Optimize)]
        public static double negate64f(double src)
            => 0 - src;
 

        #endregion

        #region inc

        public static sbyte inc(sbyte src)
            => (sbyte)(src++);

        public static byte inc(byte src)
            => (byte)(src++);
     
        public static short inc(short src)
            => (short)(src++);

        public static ushort inc(ushort src)
            => (ushort)(src++);

        public static int inc(int src)
            => src++;

        public static uint inc(uint src)
            => src++;

        public static long inc(long src)
            => src++;

        public static ulong inc(ulong src)
            => src++;

        public static float inc(float src)
            => src++;

        public static double inc(double src)
            => src++;
 
        #endregion

        #region flip
        
        [MethodImpl(Inline | Optimize)]
        public static sbyte flip8i(sbyte src)
            => (sbyte)(~src);

        [MethodImpl(Inline | Optimize)]
        public static byte flip8u(byte src)
            => (byte)(~src);
     
        [MethodImpl(Inline | Optimize)]
        public static short flip16i(short src)
            => (short)(~src);

        [MethodImpl(Inline | Optimize)]
        public static ushort flip16u(ushort src)
            => (ushort)(~src);

        [MethodImpl(Inline | Optimize)]
        public static int flip32i(int src)
            => ~src;

        [MethodImpl(Inline | Optimize)]
        public static uint flip32u(uint src)
            => ~src;

        [MethodImpl(Inline | Optimize)]
        public static long flip64i(long src)
            => ~src;

        [MethodImpl(Inline | Optimize)]
        public static ulong flip64u(ulong src)
            => ~src;

        [MethodImpl(Inline | Optimize)]
        public static float flip32f(float src)
            => BitConverter.Int32BitsToSingle(~BitConverter.SingleToInt32Bits(src));

        [MethodImpl(Inline | Optimize)]
        public static double flip64f(double src)
            => BitConverter.Int64BitsToDouble(~BitConverter.DoubleToInt64Bits(src));
 
        #endregion


        [MethodImpl(Inline | Optimize)]
        public static int abs(int x)
        {
            var mask = x >> 31;
            return (x ^ mask) - mask; 
        }

        [MethodImpl(Inline | Optimize)]
        public static short abs(short x)
            => (short)abs((int)x);

    }
}