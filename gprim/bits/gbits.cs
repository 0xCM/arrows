//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static As;

    public static class gbits
    {

        [MethodImpl(Inline)]
        public static ulong pop<T>(T src)
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                 return Bits.pop(int8(src));
            else if(typeof(T) == typeof(byte))
                 return Bits.pop(uint8(src));
            else if(typeof(T) == typeof(short))
                 return Bits.pop(int16(src));
            else if(typeof(T) == typeof(ushort))
                 return Bits.pop(uint16(src));
            else if(typeof(T) == typeof(int))
                 return Bits.pop(int32(src));
            else if(typeof(T) == typeof(uint))
                 return Bits.pop(uint32(src));
            else if(typeof(T) == typeof(long))
                 return Bits.pop(int64(src));
            else if(typeof(T) == typeof(ulong))
                 return Bits.pop(uint64(src));
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }


        [MethodImpl(Inline)]
        public static bool test<T>(in T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.test(in AsIn.int8(asRef(in src)), pos);
            else if(typeof(T) == typeof(byte))
                 return Bits.test(in AsIn.uint8(asRef(in src)), pos);
            else if(typeof(T) == typeof(short))
                 return Bits.test(in AsIn.int16(asRef(in src)), pos);
            else if(typeof(T) == typeof(ushort))
                 return Bits.test(in AsIn.uint16(asRef(in src)), pos);
            else if(typeof(T) == typeof(int))
                 return Bits.test(in AsIn.int32(asRef(in src)), pos);
            else if(typeof(T) == typeof(uint))
                 return Bits.test(in AsIn.uint32(asRef(in src)), pos);
            else if(typeof(T) == typeof(long))
                 return Bits.test(in AsIn.int64(asRef(in src)), pos);
            else if(typeof(T) == typeof(ulong))
                 return Bits.test(in AsIn.uint64(asRef(in src)), pos);
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static T parse<T>(string bitstring, int offset = 0)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.parse(bitstring, offset, out sbyte dst));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.parse(bitstring, offset, out byte dst));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.parse(bitstring, offset, out short dst));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.parse(bitstring, offset, out ushort dst));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.parse(bitstring, offset, out int dst));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.parse(bitstring, offset, out uint dst));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.parse(bitstring, offset, out long dst));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.parse(bitstring, offset, out ulong dst));
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        public static Span<T> pack<S,T>(ReadOnlySpan<S> src, Span<T> dst)            
            where S : struct
            where T : struct
        {
            var srcIx = 0;
            var dstOffset = 0;
            var dstIx = 0;
            var srcSize = SizeOf<S>.BitSize;
            var dstSize = SizeOf<T>.BitSize;
            
            while(srcIx < src.Length && dstIx < dst.Length)
            {
                for(var i = 0; i< srcSize; i++)
                    if(test(src[srcIx], i))
                       enable(ref dst[dstIx], dstOffset + i);

                srcIx++;
                if((dstOffset + srcSize) >= dstSize)
                {
                    dstOffset = 0;
                    dstIx++;
                }
                else
                    dstOffset += srcSize;
            }
            return dst;

        }

        [MethodImpl(Inline)]
        public static ref T bitpack<T>(in ReadOnlySpan<Bit> src, out T dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            dst = default(T);
            
            if(typeof(T) == typeof(sbyte))
                Bits.bitpack(in src, out int8(ref dst));
            else if(typeof(T) == typeof(byte))
                Bits.bitpack(in src, out uint8(ref dst));
            else if(typeof(T) == typeof(short))
                Bits.bitpack(in src, out int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                Bits.bitpack(in src, out uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.bitpack(in src, out int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.bitpack(in src, out uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.bitpack(in src, out int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.bitpack(in src, out uint64(ref dst));        
            else
                throw unsupported(PrimalKinds.kind<T>());                
            
            return ref dst;
        }

        public static string bitstring<T>(in T src, bool tlz = false, bool pfs = false)
            where T : struct
        {
            var count = SizeOf<T>.BitSize;
            var dst = new char[count];
            var last = count - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = gbits.test(in src,i) ? '1' : '0';
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart('0') : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;            
        }


        [MethodImpl(Inline)]
        public static ref T enable<T>(ref T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.enable(ref int8(ref src), in pos);
            else if(typeof(T) == typeof(byte))
                Bits.enable(ref uint8(ref src), in pos);
            else if(typeof(T) == typeof(short))
                Bits.enable(ref int16(ref src), in pos);
            else if(typeof(T) == typeof(ushort))
                Bits.enable(ref uint16(ref src), in pos);
            else if(typeof(T) == typeof(int))
                Bits.enable(ref int32(ref src), in pos);
            else if(typeof(T) == typeof(uint))
                Bits.enable(ref uint32(ref src), in pos);
            else if(typeof(T) == typeof(long))
                Bits.enable(ref int64(ref src), in pos);
            else if(typeof(T) == typeof(ulong))
                Bits.enable(ref uint64(ref src), in pos);
            else
                throw unsupported(PrimalKinds.kind<T>());

            return ref src;                            
        }

        [MethodImpl(Inline)]
        public static ref T disable<T>(ref T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.disable(ref int8(ref src), in pos);
            else if(typeof(T) == typeof(byte))
                Bits.disable(ref uint8(ref src), in pos);
            else if(typeof(T) == typeof(short))
                Bits.disable(ref int16(ref src), in pos);
            else if(typeof(T) == typeof(ushort))
                Bits.disable(ref uint16(ref src), in pos);
            else if(typeof(T) == typeof(int))
                Bits.disable(ref int32(ref src), in pos);
            else if(typeof(T) == typeof(uint))
                Bits.disable(ref uint32(ref src), in pos);
            else if(typeof(T) == typeof(long))
                Bits.disable(ref int64(ref src), in pos);
            else if(typeof(T) == typeof(ulong))
                Bits.disable(ref uint64(ref src), in pos);
            else
                throw unsupported(PrimalKinds.kind<T>());
                
            return ref src;                            
        }
            
        [MethodImpl(Inline)]
        public static ref T toggle<T>(ref T src, int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.toggle(ref int8(ref src), pos);
            else if(typeof(T) == typeof(byte))
                Bits.toggle(ref uint8(ref src), pos);
            else if(typeof(T) == typeof(short))
                Bits.toggle(ref int16(ref src), pos);
            else if(typeof(T) == typeof(ushort))
                Bits.toggle(ref uint16(ref src), pos);
            else if(typeof(T) == typeof(int))
                Bits.toggle(ref int32(ref src), pos);
            else if(typeof(T) == typeof(uint))
                Bits.toggle(ref uint32(ref src), pos);
            else if(typeof(T) == typeof(long))
                Bits.toggle(ref int64(ref src), pos);
            else if(typeof(T) == typeof(ulong))
                Bits.toggle(ref uint64(ref src), pos);
            else
                throw unsupported(PrimalKinds.kind<T>());

            return ref src;                            
        }

        [MethodImpl(Inline)]
        public static T toggle<T>(T src, int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.toggle(int8(src), pos));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.toggle(uint8(src), pos));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.toggle(int16(src), pos));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.toggle(uint16(src), pos));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.toggle(int32(src), pos));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.toggle(uint32(src), pos));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.toggle(int64(src), pos));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.toggle(uint64(src), pos));
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static ulong ntz<T>(in T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.ntz(AsIn.int8(in asRef(in src)));
            else if(typeof(T) == typeof(byte))
                 return Bits.ntz(AsIn.uint8(in asRef(in src)));
            else if(typeof(T) == typeof(short))
                 return Bits.ntz(AsIn.int16(in asRef(in src)));
            else if(typeof(T) == typeof(ushort))
                 return Bits.ntz(AsIn.uint16(in asRef(in src)));
            else if(typeof(T) == typeof(int))
                 return Bits.ntz(AsIn.int32(in asRef(in src)));
            else if(typeof(T) == typeof(uint))
                 return Bits.ntz(AsIn.uint32(in asRef(in src)));
            else if(typeof(T) == typeof(long))
                 return Bits.ntz(AsIn.int64(in asRef(in src)));
            else if(typeof(T) == typeof(ulong))
                 return Bits.ntz(AsIn.uint64(in asRef(in src)));
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static ulong nlz<T>(in T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                 return Bits.nlz(AsIn.uint8(in asRef(in src)));
            else if(typeof(T) == typeof(ushort))
                 return Bits.nlz(AsIn.uint16(in asRef(in src)));
            else if(typeof(T) == typeof(uint))
                 return Bits.nlz(AsIn.uint32(in asRef(in src)));
            else if(typeof(T) == typeof(ulong))
                 return Bits.nlz(AsIn.uint64(in asRef(in src)));
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static ref T loOff<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 Bits.loOff(ref int8(ref src));
            if(typeof(T) == typeof(byte))
                 Bits.loOff(ref uint8(ref src));
            if(typeof(T) == typeof(short))
                 Bits.loOff(ref int16(ref src));
            if(typeof(T) == typeof(ushort))
                 Bits.loOff(ref uint16(ref src));
            if(typeof(T) == typeof(int))
                 Bits.loOff(ref int32(ref src));
            if(typeof(T) == typeof(uint))
                 Bits.loOff(ref uint32(ref src));
            if(typeof(T) == typeof(long))
                 Bits.loOff(ref int64(ref src));
            if(typeof(T) == typeof(ulong))
                 Bits.loOff(ref uint64(ref src));
            else
                throw unsupported(PrimalKinds.kind<T>());

            return ref src;
        }       
    }
}