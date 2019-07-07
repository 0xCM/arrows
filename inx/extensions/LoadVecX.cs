//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static As;

    public static class LoadVecX
    {
        /// <summary>
        /// Loads a 128-bit vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> LoadVec128<T>(this Span128<T> src, int block = 0)            
            where T : struct            
                => Vec128.load(src,block);

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> LoadVec128<T>(this ReadOnlySpan128<T> src, int block = 0)            
            where T : struct            
                => Vec128.load(src,block);

        /// <summary>
        /// Loads a 256-bit vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> LoadVec256<T>(this Span256<T> src, int block = 0)            
            where T : struct            
                => Vec256.load(src, block);

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> LoadVec256<T>(this ReadOnlySpan256<T> src, int block = 0)            
            where T : struct            
                => Vec256.load(src,block);

        #if XYZX

        [MethodImpl(Inline)]
        public static Vec128<sbyte> LoadVec128(this ReadOnlySpan128<sbyte> src, int offset = 0)
            => Vec128.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<byte> LoadVec128(this ReadOnlySpan128<byte> src, int offset = 0)
            => Vec128.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<short> LoadVec128(this ReadOnlySpan128<short> src, int offset = 0)
            => Vec128.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> LoadVec128(this ReadOnlySpan128<ushort> src, int offset = 0)
            => Vec128.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<int> LoadVec128(this ReadOnlySpan128<int> src, int offset = 0)
            => Vec128.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<uint> LoadVec128(this ReadOnlySpan128<uint> src, int offset = 0)
            => Vec128.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<long> LoadVec128(this ReadOnlySpan128<long> src, int offset = 0)
            => Vec128.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> LoadVec128(this ReadOnlySpan128<ulong> src, int offset = 0)
            => Vec128.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<float> LoadVec128(this ReadOnlySpan128<float> src, int offset = 0)
            => Vec128.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<double> LoadVec128(this ReadOnlySpan128<double> src, int offset = 0)
            => Vec128.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> LoadVec256(this ReadOnlySpan256<sbyte> src, int offset = 0)
            => Vec256.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<byte> LoadVec256(this ReadOnlySpan256<byte> src, int offset = 0)
            => Vec256.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<short> LoadVec256(this ReadOnlySpan256<short> src, int offset = 0)
            => Vec256.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> LoadVec256(this ReadOnlySpan256<ushort> src, int offset = 0)
            => Vec256.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<int> LoadVec256(this ReadOnlySpan256<int> src, int offset = 0)
            => Vec256.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<uint> LoadVec256(this ReadOnlySpan256<uint> src, int offset = 0)
            => Vec256.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<long> LoadVec256(this ReadOnlySpan256<long> src, int offset = 0)
            => Vec256.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> LoadVec256(this ReadOnlySpan256<ulong> src, int offset = 0)
            => Vec256.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<float> LoadVec256(this ReadOnlySpan256<float> src, int offset = 0)
            => Vec256.load(ref asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<double> LoadVec256(this ReadOnlySpan256<double> src, int offset = 0)
            => Vec256.load(ref asRef(in src[offset]));    
        #endif

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> LoadVec128(this Span<sbyte> src, int offset = 0)
            => Vec128.load(ref src[offset]);

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<byte> LoadVec128(this Span<byte> src, int offset = 0)
            => Vec128.load(ref src[offset]);
  
        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<short> LoadVec128(this Span<short> src, int offset = 0)
            => Vec128.load(ref src[offset]);
 
        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> LoadVec128(this Span<ushort> src, int offset = 0)
            => Vec128.load(ref src[offset]);
 
        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<int> LoadVec128(this Span<int> src, int offset = 0)
            => Vec128.load(ref src[offset]);

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<uint> LoadVec128(this Span<uint> src, int offset = 0)
            => Vec128.load(ref src[offset]);

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<long> LoadVec128(this Span<long> src, int offset = 0)
            => Vec128.load(ref src[offset]);
 
        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> LoadVec128(this Span<ulong> src, int offset = 0)
            => Vec128.load(ref src[offset]);

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<float> LoadVec128(this Span<float> src, int offset = 0)
            => Vec128.load(ref src[offset]);

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<double> LoadVec128(this Span<double> src, int offset = 0)
            => Vec128.load(ref src[offset]);

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> LoadVec256(this Span<sbyte> src, int offset = 0)
            => Vec256.load(ref src[offset]);

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<byte> LoadVec256(this Span<byte> src, int offset = 0)
            => Vec256.load(ref src[offset]);
  
        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<short> LoadVec256(this Span<short> src, int offset = 0)
            => Vec256.load(ref src[offset]);
 
        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> LoadVec256(this Span<ushort> src, int offset = 0)
            => Vec256.load(ref src[offset]);
 
        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<int> LoadVec256(this Span<int> src, int offset = 0)
            => Vec256.load(ref src[offset]);

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<uint> LoadVec256(this Span<uint> src, int offset = 0)
            => Vec256.load(ref src[offset]);

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<long> LoadVec256(this Span<long> src, int offset = 0)
            => Vec256.load(ref src[offset]);
 
        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> LoadVec256(this Span<ulong> src, int offset = 0)
            => Vec256.load(ref src[offset]);
 
         /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<float> LoadVec256(this Span<float> src, int offset = 0)
            => Vec256.load(ref src[offset]);

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<double> LoadVec256(this Span<double> src, int offset = 0)
            => Vec256.load(ref src[offset]);
    }
}