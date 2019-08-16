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
       [MethodImpl(Inline)]
        public static Vec256<uint> swap(Vec256<uint> src, byte i, byte j)
        {
            Span<uint> control = stackalloc uint[Vec256<uint>.Length];
            for(byte k=0; k<control.Length; k++)
            {
                if(k == i)        
                    control[k] = j;
                else if(k == j)
                    control[k] = i;
                else
                    control[k] = k;
            }
            return permute8x32(src,Vec256.Load(ref control[0]));
        }

        [MethodImpl(Inline)]
        public static Vec256<int> swap(Vec256<int> src, byte i, byte j)
        {
            Span<int> control = stackalloc int[Vec256<int>.Length];
            for(byte k=0; k<control.Length; k++)
            {
                if(k == i)        
                    control[k] = j;
                else if(k == j)
                    control[k] = i;
                else
                    control[k] = k;
            }
            return permute8x32(src,Vec256.Load(ref control[0]));
        }
    }

}