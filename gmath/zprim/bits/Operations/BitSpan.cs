//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    partial class Bits
    {                
        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.uint8)
                return bitspan(in As.uint8(ref src));

            if(kind == PrimalKind.int8)
                return bitspan(in As.int8(ref src));

            if(kind == PrimalKind.int16)
                return bitspan(in As.int16(ref src));

            if(kind == PrimalKind.uint16)
                return bitspan(in As.uint16(ref src));

            if(kind == PrimalKind.int32)
                return bitspan(in As.int32(ref src));

            if(kind == PrimalKind.uint32)
                return bitspan(in As.uint32(ref src));

            if(kind == PrimalKind.int64)
                return bitspan(in As.int64(ref src));

            if(kind == PrimalKind.uint64)
                return bitspan(in As.uint64(ref src));

            throw unsupported(kind);                
        }

        [MethodImpl(Inline)]
        public static ref T bitpack<T>(in ReadOnlySpan<Bit> src, out T dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            dst = default(T);
            
            if(kind == PrimalKind.uint8)
                bitpack(in src, out As.uint8(ref dst));
            
            else if(kind == PrimalKind.int8)
                bitpack(in src, out As.int8(ref dst));

            else if(kind == PrimalKind.int16)
                bitpack(in src, out As.int16(ref dst));

            else if(kind == PrimalKind.uint16)
                bitpack(in src, out As.uint16(ref dst));

            else if(kind == PrimalKind.int32)
                bitpack(in src, out As.int32(ref dst));

            else if(kind == PrimalKind.uint32)
                bitpack(in src, out As.uint32(ref dst));

            else if(kind == PrimalKind.int64)
                bitpack(in src, out As.int64(ref dst));

            else if(kind == PrimalKind.uint64)
                bitpack(in src, out As.uint64(ref dst));
            else
                throw unsupported(kind);                
            
            return ref dst;
        }


        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in sbyte src)
        {
            var dst = new Bit[Pow2.T03];
            var last = Pow2.T03 - 1;
            for(var i = 0; i <= last; i++)
                test(in src, in i, out dst[last - i]);            
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static ref sbyte bitpack(in ReadOnlySpan<Bit> src, out sbyte dst)
        {
            dst = 0;
            var last = math.min(Pow2.T03, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (sbyte)(OneI32 << i);
            return ref dst;
        }

        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in byte src)
        {
            var dst = new Bit[Pow2.T03];
            var last = Pow2.T03 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static ref byte bitpack(in ReadOnlySpan<Bit> src, out byte dst)
        {
            dst = 0;
            var last = math.min(Pow2.T03, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (byte)(OneI32 << i);
            return ref dst;
        }


        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in ushort src)
        {
            var dst = new Bit[Pow2.T04];
            var last = Pow2.T04 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static ref ushort bitpack(in ReadOnlySpan<Bit> src, out ushort dst)
        {
            dst = 0;
            var last = math.min(Pow2.T04, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (ushort)(OneI32 << i);
            return ref dst;
        }

        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in short src)
        {
            var dst = new Bit[Pow2.T04];
            var last = Pow2.T04 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static ref short bitpack(in ReadOnlySpan<Bit> src, out short dst)
        {
            dst = 0;
            var last = math.min(Pow2.T04, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (short)(OneI32 << i);
            return ref dst;
        }

        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in int src)
        {
            var dst = new Bit[Pow2.T05];
            var last = Pow2.T05 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static ref int bitpack(in ReadOnlySpan<Bit> src, out int dst)
        {
            dst = 0;
            var last = math.min(Pow2.T05, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1 << i);
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<Bit> bitspan(in uint src)
        {
            var dst = new Bit[Pow2.T05];
            var last = Pow2.T05 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static ref uint bitpack(in ReadOnlySpan<Bit> src, out uint dst)
        {
            dst = 0;
            var last = math.min(Pow2.T05, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1u << i);
            return ref dst;
        }

        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in long src)
        {
            var dst = new Bit[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }        

        [MethodImpl(Optimize)]
        public static ref long bitpack(in ReadOnlySpan<Bit> src, out long dst)
        {
            dst = 0;
            var last = math.min(Pow2.T06, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1L << i);
            return ref dst;
        }


        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in ulong src)
        {
            var dst = new Bit[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                test(src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static ref ulong bitpack(in ReadOnlySpan<Bit> src, out ulong dst)
        {
            dst = 0;
            var last = math.min(Pow2.T06, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1ul << i);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static Span<Bit> bitspan(in float src)
            => bitspan(BitConverter.SingleToInt32Bits(src));

        
        [MethodImpl(Inline)]
        public static Span<Bit> bitspan(in double src)
            => bitspan(Bits.bitsI64(src));

    }
}