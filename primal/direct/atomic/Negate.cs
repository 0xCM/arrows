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
        [MethodImpl(Inline)]
        public static sbyte negate(sbyte src)
            => (sbyte)(- src);

        [MethodImpl(Inline)]
        public static byte negate(byte src)
            => (byte)(~src + 1);
     
        [MethodImpl(Inline)]
        public static short negate(short src)
            => (short)(- src);

        [MethodImpl(Inline)]
        public static ushort negate(ushort src)
            => (ushort)(~src + 1);

        [MethodImpl(Inline)]
        public static int negate(int src)
            => -src;

        [MethodImpl(Inline)]
        public static uint negate(uint src)
            => ~src + 1;

        [MethodImpl(Inline)]
        public static long negate(long src)
            => -src;

        [MethodImpl(Inline)]
        public static ulong negate(ulong src)
            => ~src + 1;

        [MethodImpl(Inline)]
        public static float negate(float src)
            => -src;

        [MethodImpl(Inline)]
        public static double negate(double src)
            => -src;
 
        [MethodImpl(Inline)]
        public static ref sbyte negate(ref sbyte src)
        {
            src = (sbyte) - src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte negate(ref byte src)
        {
            src = negate(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short negate(ref short src)
        {
            src = (short) - src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort negate(ref ushort src)
        {
            src = negate(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int negate(ref int src)
        {
            src = - src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint negate(ref uint src)
        {
            src = negate(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long negate(ref long src)
        {
            src = - src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong negate(ref ulong src)
        {
            src = negate(src);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref float negate(ref float src)
        {
            src = - src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double negate(ref double src)
        {
            src = - src;
            return ref src;
        }
   }
}