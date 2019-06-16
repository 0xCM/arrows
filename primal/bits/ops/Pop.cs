//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {                
        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(sbyte src)
            => Popcnt.X64.PopCount((ulong)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(byte src)
            => Popcnt.X64.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(short src)
            => Popcnt.X64.PopCount((ulong)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(ushort src)
            => Popcnt.X64.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(int src)
            => Popcnt.X64.PopCount((ulong)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(uint src)
            => Popcnt.X64.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(long src)
            => Popcnt.X64.PopCount((ulong)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(ulong src)
            => Popcnt.X64.PopCount(src);
 
        public static ulong pop(in Span<byte> src)
        {
            var count = U64Zero;
            var blocksize = Pow2.T03;
            math.quorem(src.Length, blocksize, out Quorem<int> qr);
            for(var i = 0; i < src.Length; i+=blocksize)
            {
                Bytes.read(src, i, out ulong data);
                count += Popcnt.X64.PopCount(data);
            }
            return count;
        }

    }
}