//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// Exchanges two components of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="i">The index of the first component</param>
        /// <param name="j">The index of the second component</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> swap(Vec256<uint> src, byte i, byte j)
        {
            var control = Vec256.Increments(0u);
            var tmp = control[i];
            control[i] = control[j];
            control[j] = tmp;
            // Span<uint> control = stackalloc uint[Vec256<uint>.Length];
            // for(byte k=0; k<control.Length; k++)
            // {
            //     if(k == i)        
            //         control[k] = j;
            //     else if(k == j)
            //         control[k] = i;
            //     else
            //         control[k] = k;
            // }
            return perm8x32(src,control);
        }

        [MethodImpl(Inline)]
        public static Vec256<int> swap(Vec256<int> src, byte i, byte j)
        {
            // Span<int> control = stackalloc int[Vec256<int>.Length];
            // for(byte k=0; k<control.Length; k++)
            // {
            //     if(k == i)        
            //         control[k] = j;
            //     else if(k == j)
            //         control[k] = i;
            //     else
            //         control[k] = k;
            // }
            var control = Vec256.Increments(0);
            var tmp = control[i];
            control[i] = control[j];
            control[j] = tmp;
            return perm8x32(src,control);
        }
    }

}