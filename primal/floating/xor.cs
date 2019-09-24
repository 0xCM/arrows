//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class fmath
    {


        [MethodImpl(Inline)]
        public static float xor(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(lhs.ToBits() ^ rhs.ToBits());

        [MethodImpl(Inline)]
        public static double xor(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(lhs.ToBits() ^ rhs.ToBits());         
        
        [MethodImpl(Inline)]
        public static ref float xor(ref float lhs, float rhs)
        {
            lhs = xor(lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double xor(ref double lhs, double rhs)
        {
            lhs = xor(lhs,rhs);
            return ref lhs;
        }


    }

}