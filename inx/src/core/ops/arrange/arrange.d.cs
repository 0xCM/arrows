//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
        
    partial class dinx
    {    
        /// <summary>
        /// Rearranges the source vector according to the indices specified in the control vector
        /// dst[i] = src[control[i]]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        /// <remarks>Approach follows https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector/30669632#30669632</remarks>
        public static Vec256<byte> arrange(Vec256<byte> src, Vec256<byte> control)
        {
            var a = src;
            var b = dinx.swaphl(src);
            var s1 = dinx.shuffle(a, dinx.add(control, K0));
            var s2 = dinx.shuffle(b, dinx.add(control, K1));
            return dinx.or(s1,s2);
        }

        const byte M70 = 0b01110000;
        const byte MF0 = 0b11110000;

        static readonly Vec256<byte> K0 = Vec256.FromBytes(
            M70, M70, M70, M70, M70, M70, M70, M70, 
            M70, M70, M70, M70, M70, M70, M70, M70,            
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0, 
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0);

        static readonly Vec256<byte> K1 = Vec256.FromBytes(
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0, 
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0,
            
            M70, M70, M70, M70, M70, M70, M70, M70, 
            M70, M70, M70, M70, M70, M70, M70, M70);            

    }

}