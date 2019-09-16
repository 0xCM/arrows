//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {         

        /// <summary>
        /// Populates a target span with 8 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        public static Span<Bit> unpack(in byte src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T03];
            for(var i=0; i < dst.Length; i++)                
                read(in src, in i, out dst[i]);
            return dst; 
        }    


        /// <summary>
        /// Populates a target span with 16 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        public static Span<Bit> unpack(in ushort src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T04];
            for(var i=0; i < dst.Length; i++)
                read(in src, in i, out dst[i]);
            return dst; 
        }

        /// <summary>
        /// Populates a target span with 32 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        public static Span<Bit> unpack(in uint src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T05];
            for(var i=0; i < dst.Length; i++)
                read(in src, in i, out dst[i]);
            return dst; 
        }

        /// <summary>
        /// Populates a target span with 64 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        public static Span<Bit> unpack(in ulong src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T06];
            for(var i=0; i < dst.Length; i++)
                read(in src, in i, out dst[i]);
            return dst; 
        } 
    }
}