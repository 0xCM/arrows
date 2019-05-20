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
        public static string bitstring<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return bitstring(in As.int8(ref src));

            if(kind == PrimalKind.uint8)
                return bitstring(in As.uint8(ref src));

            if(kind == PrimalKind.int16)
                return bitstring(in As.int16(ref src));

            if(kind == PrimalKind.uint16)
                return bitstring(in As.uint16(ref src));

            if(kind == PrimalKind.int32)
                return bitstring(in As.int32(ref src));

            if(kind == PrimalKind.uint32)
                return bitstring(in As.uint32(ref src));

            if(kind == PrimalKind.int64)
                return bitstring(in As.int64(ref src));

            if(kind == PrimalKind.uint64)
                return bitstring(in As.uint64(ref src));

            throw unsupported(kind);
                
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in byte src)
        {
            Span<char> dst = stackalloc char[Pow2.T03];
            var last = Pow2.T03 - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            return new string(dst);
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in sbyte src)
        {
            Span<char> dst = stackalloc char[Pow2.T03];
            var last = Pow2.T03 - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            return new string(dst);
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in short src)
        {
            Span<char> dst = stackalloc char[Pow2.T04];
            var last = Pow2.T04 - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            return new string(dst);
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in ushort src)
        {
            Span<char> dst = stackalloc char[Pow2.T04];
            var last = Pow2.T04 - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            return new string(dst);
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in int src)
        {
            Span<char> dst = stackalloc char[Pow2.T05];
            var last = Pow2.T05 - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            return new string(dst);
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in uint src)
        {
            Span<char> dst = stackalloc char[Pow2.T05];
            var last = Pow2.T05 - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            return new string(dst);
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in long src)
        {
            Span<char> dst = stackalloc char[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            return new string(dst);
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in ulong src)
        {
            Span<char> dst = stackalloc char[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            return new string(dst);
        }



    }

}