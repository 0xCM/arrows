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
    using System.Numerics;
    
    using static zfunc;    
    

    partial class math
    {

 
        [MethodImpl(Inline)]
        public static ref sbyte sqrt(ref sbyte src)
        {
            src = (sbyte)MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte sqrt(ref byte src)
        {
            src = (byte)MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short sqrt(ref short src)
        {
            src = (short)MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort sqrt(ref ushort src)
        {
            src = (ushort)MathF.Sqrt(src);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref int sqrt(ref int src)
        {
            src = (int)MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint sqrt(ref uint src)
        {
            src = (uint)MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long sqrt(ref long src)
        {
            src = (long)Math.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong sqrt(ref ulong src)
        {
            src = (ulong)Math.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref float sqrt(ref float src)
        {
            src = MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double sqrt(ref double src)
        {
            src = Math.Sqrt(src);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref float sqrt(float src, out float dst)
        {
            dst = fmath.sqrt(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double sqrt(double src, out double dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }
   }
}