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

    using static zfunc;


    [DisplayName("scenarios-primal")]
    class PrimalScenarios
    {
        # region add

        public static sbyte add8i(sbyte x, sbyte y)
            => (sbyte)(x + y);

        public static byte add8u(byte x, byte y)
            => (byte)(x + y);

        public static short add16i(short x, short y)
            => (short)(x + y);

        public static ushort add16u(ushort x, ushort y)
            => (ushort)(x + y);

        public static int add32i(int x, int y)
            => x + y;

        public static uint add32u(uint x, uint y)
            => x + y;

        public static long add64i(long x, long y)
            => x + y;

        public static ulong add64u(ulong x, ulong y)
            => x + y;

        public static float add32f(float x, float y)
            => x + y;

        public static double add64f(double x, double y)
            => x + y;

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

        public static int or32i(int x, int y)
            => x | y;

        public static uint or32u(uint x, uint y)
            => x | y;

        public static long or64i(long x, long y)
            => x | y;

        public static ulong or64u(ulong x, ulong y)
            => x | y;
        
        #endregion

        # region sub

        public static sbyte sub8i(sbyte x, sbyte y)
            => (sbyte)(x - y);

        public static byte sub8u(byte x, byte y)
            => (byte)(x - y);

        public static short sub16i(short x, short y)
            => (short)(x - y);

        public static ushort sub16u(ushort x, ushort y)
            => (ushort)(x - y);

        public static int sub32i(int x, int y)
            => x - y;

        public static uint sub32u(uint x, uint y)
            => x - y;

        public static long sub64i(long x, long y)
            => x - y;

        public static ulong sub64u(ulong x, ulong y)
            => x - y;

        public static float sub32f(float x, float y)
            => x - y;

        public static double sub64f(double x, double y)
            => x - y;

        #endregion

        #region rot

        public static byte rotr8u(byte src, byte offset)
            => (byte) ((src >> (int)offset) | (src << (8 - offset)));

        public static ushort rotr16u(ushort src, ushort offset)
            => (ushort) ((src >> (int)offset) | (src << (16 - offset)));

        public static uint rotr32u(uint src, uint offset)
            => (src >> (int)offset) | (src << (32 - (int)offset));

        public static ulong rotr64u(ulong src, ulong offset)
            => (src >> (int)offset) | (src << (64 - (int)offset));

        public static byte rotl8u(byte x, byte offset)
            => (byte)((x << (int)offset) | (x >> (int)(8 - offset)));

        public static ushort rotl16u(ushort x, ushort offset)
            => (ushort)(((uint)x << (int)offset) | ((uint)x >> (16 - offset)));

        public static uint rotl32u(uint x, uint offset)
            => (x << (int)offset) | (x >> (int)(32 - offset));

        public static ulong rotl64u(ulong x, ulong offset)
            => (x << (int)offset) | (x >> (int)(64 - offset));


        #endregion

        #region negate

        public static sbyte negate(sbyte src)
            => (sbyte)(- src);

        public static byte negate(byte src)
            => (byte)(~src + 1);
     
        public static short negate(short src)
            => (short)(- src);

        public static ushort negate(ushort src)
            => (ushort)(~src + 1);

        public static int negate(int src)
            => -src;

        public static uint negate(uint src)
            => ~src + 1;

        public static long negate(long src)
            => -src;

        public static ulong negate(ulong src)
            => ~src + 1;

        public static float negate(float src)
            => -src;

        public static double negate(double src)
            => -src;
 
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

    }
}