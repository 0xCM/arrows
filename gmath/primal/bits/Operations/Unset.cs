//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    partial class Bits
    {                
                
        [MethodImpl(Inline)]
        public static ref byte unset(ref byte src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static byte unset(byte src, int pos)
            => unset(ref src, pos);

        [MethodImpl(Inline)]
        public static ref sbyte unset(ref sbyte src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static sbyte unset(sbyte src, int pos)
            => unset(ref src, pos);

        [MethodImpl(Inline)]
        public static ref short unset(ref short src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static short unset(short src, int pos)
             => unset(ref src, pos);


        [MethodImpl(Inline)]
        public static ushort unset(ushort src, int pos)
             => unset(ref src, pos);

        [MethodImpl(Inline)]
        public static ref ushort unset(ref ushort src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static int unset(int src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ref int unset(ref int src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static uint unset(uint src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ref uint unset(ref uint src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static long unset(long src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ref long unset(ref long src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ulong unset(ulong src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ref ulong unset(ref ulong src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

    }
}