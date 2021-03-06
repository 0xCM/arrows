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
    
    
    using static As;
    using static zfunc;

    partial class MathX
    {

        [MethodImpl(Inline)]
        public static int ToBits(this float src)
            => BitConverter.SingleToInt32Bits(src);

        [MethodImpl(Inline)]
        public static long ToBits(this double src)
            => BitConverter.DoubleToInt64Bits(src);

        public static Option<int> WriteTo<T>(this DivisorIndex<T> src, FolderPath dst)
            where T : struct
        {
            var filename = FileName.Define($"divisors{src.Range}.csv");
            var outpath = dst + filename;
            var lists = src.Lists.OrderBy(x => x.Dividend);
            return outpath.Overwrite(lists.Select(d => d.ToString()).ToArray());
        }

        //Adapted from corefx repo
        static bool SequenceEqual<T>(ref T first, ref T second, int length)
            where T : struct
        {

            if (Unsafe.AreSame(ref first, ref second))
                return true;

            IntPtr offset = (IntPtr)0; 
            T x;
            T y;
            while (length >= 8)
            {
                length -= 8;
                
                x = refAdd(ref first, offset + 0);
                y = refAdd(ref second, offset + 0);
                if(gmath.neq(x, y))
                    return false;                
                x = refAdd(ref first, offset + 1);
                y = refAdd(ref second, offset + 1);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 2);
                y = refAdd(ref second, offset + 2);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 3);
                y = refAdd(ref second, offset + 3);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 4);
                y = refAdd(ref second, offset + 4);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 5);
                y = refAdd(ref second, offset + 5);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 6);
                y = refAdd(ref second, offset + 6);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 7);
                y = refAdd(ref second, offset + 7);
                if(gmath.neq(x, y))
                    return false;

                offset += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                x = refAdd(ref first, offset);
                y = refAdd(ref second, offset);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 1);
                y = refAdd(ref second, offset + 1);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 2);
                y = refAdd(ref second, offset + 2);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 3);
                y = refAdd(ref second, offset + 3);
                if(gmath.neq(x, y))
                    return false;

                offset += 4;
            }

            while (length > 0)
            {
                x = refAdd(ref first, offset);
                y = refAdd(ref second, offset);
                if(gmath.neq(x, y))
                    return false;
                offset += 1;
                length--;
            }

            return true;
        }

        //Adapted from corefx repo
        static bool Contains<T>(ref T src, T match, int length)
            where T : struct
        {
            IntPtr index = (IntPtr)0;

            while (length >= 8)
            {
                length -= 8;

                if (gmath.eq(match, refAdd(ref src, index + 0)) ||
                    gmath.eq(match, refAdd(ref src, index + 1)) ||
                    gmath.eq(match, refAdd(ref src, index + 2)) ||
                    gmath.eq(match, refAdd(ref src, index + 3)) ||
                    gmath.eq(match, refAdd(ref src, index + 4)) ||
                    gmath.eq(match, refAdd(ref src, index + 5)) ||
                    gmath.eq(match, refAdd(ref src, index + 6)) ||
                    gmath.eq(match, refAdd(ref src, index + 7)))
                return true;
                
                index += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                if (gmath.eq(match, refAdd(ref src, index + 0)) ||
                    gmath.eq(match, refAdd(ref src, index + 1)) ||
                    gmath.eq(match, refAdd(ref src, index + 2)) ||
                    gmath.eq(match, refAdd(ref src, index + 3)))
                return true;

                index += 4;
            }

            while (length > 0)
            {
                length -= 1;

                if (gmath.eq(match, refAdd(ref src, index)))
                    return true;

                index += 1;
            }
            return false;        
        }

        public static bool Identical<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)        
                where T : struct        
        {
            for(var i = 0; i< Span128.Length(lhs,rhs); i++)
                if(gmath.neq(lhs[i],rhs[i]))
                    return false;
            return true;
        }

        public static bool Identical<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)        
            where T : struct        
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(gmath.neq(lhs[i],rhs[i]))
                    return false;
            return true;
        }

        public static bool Identical<T>(this Span256<T> lhs, Span256<T> rhs)        
            where T : struct        
                => lhs.ReadOnly().Identical(rhs);

        public static bool Identical<T>(this Span128<T> lhs, Span128<T> rhs)        
            where T : struct        
                => lhs.ReadOnly().Identical(rhs);

        [MethodImpl(Inline)]
        public static bool Identical<T>(this Span<T> lhs, Span<T> rhs)  
            where T : struct       
        {
            
            if(lhs.Length != rhs.Length)
                return false;
            return SequenceEqual(ref lhs[0], ref rhs[0], lhs.Length);
        }

        [MethodImpl(Inline)]
        public static bool Identical<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)  
            where T : struct       
        {
            if(lhs.Length != rhs.Length)
                return false;
            return SequenceEqual(ref asRef(in lhs[0]), ref asRef(in rhs[0]), lhs.Length);
        }

        [MethodImpl(Inline)]
        public static T Quotient<T>(this Ratio<T> src)        
            where T : struct       
                => gmath.div(src.A, src.B);
    }

}