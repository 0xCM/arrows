//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    

    partial class math
    {
        #region in

        [MethodImpl(Inline)]
        public static sbyte flip(sbyte src)
            => (sbyte)(~ src);

        [MethodImpl(Inline)]
        public static byte flip(byte src)
            => (byte)(~ src);

        [MethodImpl(Inline)]
        public static short flip(short src)
            => (short)(~ src);

        [MethodImpl(Inline)]
        public static ushort flip(ushort src)
            => (ushort)(~ src);

        [MethodImpl(Inline)]
        public static int flip(int src)
            => ~ src;

        [MethodImpl(Inline)]
        public static uint flip(uint src)
            => ~ src;

        [MethodImpl(Inline)]
        public static long flip(long src)
            => ~ src;

        [MethodImpl(Inline)]
        public static ulong flip(ulong src)
            => ~ src;

        #endregion

        #region out

        [MethodImpl(Inline)]
        public static ref sbyte flip(sbyte src, out sbyte dst)
        {
            dst = (sbyte) ~src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte flip(byte src, out byte dst)
        {
            dst = (byte) ~src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short flip(short src, out short dst)
        {
            dst = (short) ~src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort flip(ushort src, out ushort dst)
        {
            dst = (ushort) ~src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int flip(int src, out int dst)
        {
            dst = ~src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint flip(uint src, out uint dst)
        {
            dst = ~src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long flip(long src, out long dst)
        {
            dst = ~src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong flip(ulong src, out ulong dst)
        {
            dst = ~src;
            return ref dst;
        }

        #endregion

        #region io


        [MethodImpl(Inline)]
        public static ref sbyte flip(ref sbyte src)
        {
            src = (sbyte) ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte flip(ref byte src)
        {
            src = (byte) ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short flip(ref short src)
        {
            src = (short) ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort flip(ref ushort src)
        {
            src = (ushort) ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int flip(ref int src)
        {
            src = ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint flip(ref uint src)
        {
            src = ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long flip(ref long src)
        {
            src = ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong flip(ref ulong src)
        {
            src = ~src;
            return ref src;
        }
 
        #endregion


    }

}