//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    public static class VecG
    {
        [MethodImpl(Inline)]
        public static VecG<T> zero<T>(int minlen)
            where T : struct
            => alloc<T>(minlen);

        [MethodImpl(Inline)]
        public static VecG<T> load<T>(Span256<T> src)
            where T : struct
                => new VecG<T>(src);                
                
        [MethodImpl(Inline)]
        public static VecG<T> load<T>(ReadOnlySpan256<T> src)
            where T : struct
                => new VecG<T>(src); 

        [MethodImpl(Inline)]
        public static VecG<T> load<T>(Span<T> src)
            where T : struct
        {
            var blocklen = Span256.blocklength<T>();                        
            var qr = math.quorem(src.Length, blocklen);                        
            if(qr.Remainder == 0)
                return new VecG<T>(Span256.load(src));
            else
            {
                var blocks = qr.Quotient + 1;
                var dst = Span256.alloc<T>(blocks);
                src.CopyTo(dst);
                return new VecG<T>(dst);
            }                                            
        }

        [MethodImpl(Inline)]
        public static VecG<T> load<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var blocklen = Span256.blocklength<T>();                        
            var qr = math.quorem(src.Length, blocklen); 
            var blocks = qr.Quotient + (qr.Remainder == 0 ? 0 : 1);
            var dst = Span256.alloc<T>(blocks);
            src.CopyTo(dst);
            return new VecG<T>(dst);
        }


        [MethodImpl(Inline)]
        public static VecG<T> alloc<T>(int minlen)               
            where T : struct
        {
            var blocklen = Span256.blocklength<T>();                        
            var qr = math.quorem(minlen, blocklen); 
            var blocks = qr.Quotient + (qr.Remainder == 0 ? 0 : 1);
            var dst = Span256.alloc<T>(blocks);
            return new VecG<T>(dst);
        }
 
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> extract<T>(in VecG<T> src, out ReadOnlySpan<T> dst)        
            where T : struct
                => dst = src;

        [MethodImpl(Inline)]
        public static Span<T> extract<T>(in VecG<T> src, out Span<T> dst)        
            where T : struct
                => dst = src;
    }


}