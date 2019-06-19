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

    public static class NumX
    {

        [MethodImpl(Inline)]
        public static ref T Scalar<T>(this ref num<T> src)
            where T : struct
            => ref Unsafe.As<num<T>,T>(ref src);
        
        [MethodImpl(Inline)]
        public static ref num<T> Abs<T>(this ref num<T> src)
            where T : struct
                =>  ref Num.single(ref gmath.abs(ref Num.scalar(ref src)));

        [MethodImpl(Inline)]
        public static ref num<T> Sqrt<T>(this ref num<T> src)
            where T : struct 
                =>  ref Num.single(ref gmath.sqrt(ref Num.scalar(ref src)));

        [MethodImpl(Inline)]
        public static ref num<T> Add<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.add(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> Sub<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.sub(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> Mul<T>(this ref num<T> lhs, in num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.mul(ref Num.scalar(ref lhs), Num.scalar(ref As.asRef(in rhs))));

        [MethodImpl(Inline)]
        public static ref num<T> Div<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.div(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> Mod<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.mod(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> And<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.and(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> Or<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.or(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> XOr<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.xor(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> Flip<T>(this ref num<T> src)
            where T : struct
                =>  ref Num.single(ref gmath.flip(ref Num.scalar(ref src)));

        [MethodImpl(Inline)]
        public static ref num<T> Inc<T>(this ref num<T> src)
            where T : struct
                =>  ref Num.single(ref gmath.inc(ref Num.scalar(ref src)));

        [MethodImpl(Inline)]
        public static ref num<T> Dec<T>(this ref num<T> src)
            where T : struct
                =>  ref Num.single(ref gmath.dec(ref Num.scalar(ref src)));

        [MethodImpl(Inline)]
        public static ref num<T> Square<T>(this ref num<T> src)
            where T : struct
                =>  ref Num.single(ref gmath.square(ref Num.scalar(ref src)));

        [MethodImpl(Inline)]
        public static ref num<T> Negate<T>(this ref num<T> src)
            where T : struct
                =>  ref Num.single(ref gmath.negate(ref Num.scalar(ref src)));
 
        [MethodImpl(Inline)]
        public static PrimalKind PrimalKind<T>(this num<T> src)
            where T : struct
                => PrimalKinds.kind<T>();

        [MethodImpl(Inline)]
        public static bool NEq<T>(this num<T> lhs, num<T> rhs)
            where T : struct
                => gmath.neq(lhs.Scalar(), rhs.Scalar());

        [MethodImpl(Inline)]
        public static bool Gt<T>(this num<T> lhs, num<T> rhs)
            where T : struct
                => gmath.gt(lhs.Scalar(), rhs.Scalar());

        [MethodImpl(Inline)]
        public static bool GtEq<T>(this num<T> lhs, num<T> rhs)
            where T : struct
                => gmath.gteq(lhs.Scalar(), rhs.Scalar());

        [MethodImpl(Inline)]
        public static bool LtEq<T>(this num<T> lhs, num<T> rhs)
            where T : struct
                => gmath.lteq(lhs.Scalar(), rhs.Scalar());

        [MethodImpl(Inline)]
        public static bool Lt<T>(this num<T> lhs, num<T> rhs)
            where T : struct
                => gmath.lt(lhs.Scalar(), rhs.Scalar());

        [MethodImpl(NotInline)]
        public static num<T> Sum<T>(this ReadOnlySpan<num<T>> src)        
            where T : struct
        {
            var result = num<T>.Zero;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                result += it.Current;
            return result;            
        }

        [MethodImpl(Inline)]
        public static num<T> Sum<T>(this Span<num<T>> src)        
            where T : struct
            => src.ReadOnly().Sum();

        [MethodImpl(NotInline)]
        public static ref Span<num<T>> ScaleBy<T>(this ref Span<num<T>> io, num<T> factor)        
            where T : struct
        {
            for(var i = 0; i< io.Length; i++)
            {
                ref var x = ref io[i];
                x = x*factor;
            }
            return ref io;
        }
 
        [MethodImpl(NotInline)]
        public static Span<T> Extract<T>(this num<T>[] src)
            where T : struct        
        {
            var dst = span<T>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i].Scalar();
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> Extract<T>(this Span<num<T>> src)
            where T : struct        
        {
            var dst = span<T>(src.Length);
            for(var i=0; i< src.Length; i++)
                dst[i] = src[i].Scalar();
            return dst;
        }

        [MethodImpl(Inline)]
        public static num<byte> ToNumber(this byte src)
            => src;

        [MethodImpl(Inline)]
        public static num<sbyte> ToNumber(this sbyte src)
            => src;

        [MethodImpl(Inline)]
        public static num<short> ToNumber(this short src)
            => src;

        [MethodImpl(Inline)]
        public static num<ushort> ToNumber(this ushort src)
            => src;

        [MethodImpl(Inline)]
        public static num<int> ToNumber(this int src)
            => src;

        [MethodImpl(Inline)]
        public static num<uint> ToNumber(this uint src)
            => src;

        [MethodImpl(Inline)]
        public static num<long> ToNumber(this long src)
            => src;

        [MethodImpl(Inline)]
        public static num<float> ToNumber(this float src)
            => src;

        [MethodImpl(Inline)]
        public static num<double> ToNumber(this double src)
            => src;

        static Span<num<T>> ToNumbers<T>(this ReadOnlySpan<T> src)        
            where T : struct
        {
            var dst = span<num<T>>(src.Length);
            for(var i=0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;                        
        }

        [MethodImpl(Inline)]
        public static Span<num<sbyte>> ToNumbers(this ReadOnlySpan<sbyte> src)
            => src.ToNumbers<sbyte>();

        [MethodImpl(Inline)]
        public static Span<num<byte>> ToNumbers(this ReadOnlySpan<byte> src)
            => src.ToNumbers<byte>();

        [MethodImpl(Inline)]
        public static Span<num<short>> ToNumbers(this ReadOnlySpan<short> src)
            => src.ToNumbers<short>();

        [MethodImpl(Inline)]
        public static Span<num<ushort>> ToNumbers(this ReadOnlySpan<ushort> src)
            => src.ToNumbers<ushort>();

        [MethodImpl(Inline)]
        public static Span<num<int>> ToNumbers(this ReadOnlySpan<int> src)
            => src.ToNumbers<int>();

        [MethodImpl(Inline)]
        public static Span<num<uint>> ToNumbers(this ReadOnlySpan<uint> src)
            => src.ToNumbers<uint>();

        [MethodImpl(Inline)]
        public static Span<num<long>> ToNumbers(this ReadOnlySpan<long> src)
            => src.ToNumbers<long>();

        [MethodImpl(Inline)]
        public static Span<num<ulong>> ToNumbers(this ReadOnlySpan<ulong> src)
            => src.ToNumbers<ulong>();

        [MethodImpl(Inline)]
        public static Span<num<float>> ToNumbers(this ReadOnlySpan<float> src)
            => src.ToNumbers<float>();

        [MethodImpl(Inline)]
        public static Span<num<double>> ToNumbers(this ReadOnlySpan<double> src)
            => src.ToNumbers<double>();

        [MethodImpl(Inline)]
        public static ReadOnlySpan<num<T>> Numbers<T>(this ReadOnlySpan<T> src)
            where T : struct
                => Num.many(src);

        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this num<T> src, bool tlz = false)
            where T : struct
                => BitStringConvert.FromValue<T>(src.Scalar(), tlz);

        
        [MethodImpl(Inline)]
        public static ReadOnlySpanPair<num<T>> Numbers<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => Num.many(lhs).PairWith(Num.many(rhs));

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<DeciDigit> ToDecimalDigits<T>(this num<T> src)
            where T : struct    
                => DeciDigits.Parse(src.Abs().ToString());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
         [MethodImpl(Inline)]   
        public static Span<HexDigit> ToHexDigits<T>(this num<T> src)
            where T : struct    
                =>  HexDigits.Parse(src.ToString());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<BinaryDigit> ToBinaryDigits<T>(this num<T> src)
            where T : struct    
                =>  BinaryDigits.Parse(src.ToBitString());
    }
}