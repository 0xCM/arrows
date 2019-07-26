//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    partial class BitMatrixOps
    {    
        static string Format(this Span<byte> src, int rowlen)            
        {
            var dst = gbits.bitchars(src);
            var sb = sbuild();
            for(var i=0; i<dst.Length; i+= rowlen)
            {
                var rowbits = dst.Slice(i, rowlen);
                Claim.eq(rowbits.Length, rowlen);                
                var row = new string(rowbits.Intersperse(AsciSym.Space));                                
                sb.AppendLine(row);
            }
            return sb.ToString();
        }

        [MethodImpl(Inline)]
        static string Format(this Span<ushort> src, int rowlen)            
            => MemoryMarshal.AsBytes(src).Format(rowlen);

        [MethodImpl(Inline)]
        static string Format(this Span<uint> src, int rowlen)            
            => MemoryMarshal.AsBytes(src).Format(rowlen);

        [MethodImpl(Inline)]
        static string Format(this Span<ulong> src, int rowlen)            
            => MemoryMarshal.AsBytes(src).Format(rowlen);

        [MethodImpl(Inline)]
        public static string Format(this in BitMatrix4 src)
            => src.bits.Format(4);

        [MethodImpl(Inline)]
        public static string Format(this in BitMatrix8 src)
            => src.bits.Format(8);

        [MethodImpl(Inline)]
        public static string Format(this in BitMatrix16 src)
            => src.bits.Format(16);    

        [MethodImpl(Inline)]
        public static string Format(this in BitMatrix32 src)
            => src.bits.Format(32);    

        [MethodImpl(Inline)]
        public static string Format(this in BitMatrix64 src)
            => src.bits.Format(64);    
        
 
    }
}