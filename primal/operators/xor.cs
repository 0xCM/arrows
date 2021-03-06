//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class math
    {

        [MethodImpl(Inline)]
        public static sbyte xor(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static byte xor(byte lhs, byte rhs)
            => (byte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static short xor(short lhs, short rhs)
            => (short)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static ushort xor(ushort lhs, ushort rhs)
            => (ushort)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static int xor(int lhs, int rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static uint xor(uint lhs, uint rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static long xor(long lhs, long rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static ulong xor(ulong lhs, ulong rhs)
            => lhs ^ rhs;

 
        [MethodImpl(Inline)]
        public static ref sbyte xor(ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte)(lhs ^ rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte xor(ref byte lhs, byte rhs)
        {
            lhs = (byte)(lhs ^ rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short xor(ref short lhs, short rhs)
        {
            lhs = (short)(lhs ^ rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort xor(ref ushort lhs, ushort rhs)
        {
            lhs = (ushort)(lhs ^ rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int xor(ref int lhs, int rhs)
        {
            lhs = lhs ^ rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint xor(ref uint lhs, uint rhs)
        {
            lhs = lhs ^ rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long xor(ref long lhs, long rhs)
        {
            lhs = lhs ^ rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong xor(ref ulong lhs, ulong rhs)
        {
            lhs = lhs ^ rhs;
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref sbyte xor(in sbyte lhs, in sbyte rhs, ref sbyte dst)
        {
            dst = (sbyte)(lhs ^ rhs);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte xor(in byte lhs, in byte rhs, ref byte dst)
        {
            dst = (byte)(lhs ^ rhs);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short xor(in short lhs, in short rhs, ref short dst)
        {
            dst = (short)(lhs ^ rhs);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort xor(in ushort lhs, in ushort rhs, ref ushort dst)
        {
            dst = (ushort)(lhs ^ rhs);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int xor(in int lhs, in int rhs, ref int dst)
        {
            dst = lhs ^ rhs;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint xor(in uint lhs, in uint rhs, ref uint dst)
        {
            dst = lhs ^ rhs;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long xor(in long lhs, in long rhs, ref long dst)
        {
            dst = lhs ^ rhs;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong xor(in ulong lhs, in ulong rhs, ref ulong dst)
        {
            dst = lhs ^ rhs;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref float xor(in float lhs, in float rhs, ref float dst)
        {
            dst = BitConverter.Int32BitsToSingle(lhs.ToBits() ^ rhs.ToBits());
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double xor(in double lhs, in double rhs, ref double dst)
        {
            dst = BitConverter.Int64BitsToDouble(lhs.ToBits() ^ rhs.ToBits());
            return ref dst;
        }        
    }
}