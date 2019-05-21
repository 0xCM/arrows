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
    using static mfunc;
    using static As;

    public static class gbits
    {
        [MethodImpl(Inline)]
        public static bool test<T>(T src, int pos)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                 return Bits.test(int8(ref src), pos);

            if(kind == PrimalKind.uint8)
                 return Bits.test(uint8(ref src), pos);

            if(kind == PrimalKind.int16)
                 return Bits.test(int16(ref src), pos);

            if(kind == PrimalKind.uint16)
                 return Bits.test(uint16(ref src), pos);

            if(kind == PrimalKind.int32)
                 return Bits.test(int32(ref src), pos);

            if(kind == PrimalKind.uint32)
                 return Bits.test(uint32(ref src), pos);

            if(kind == PrimalKind.int64)
                 return Bits.test(int64(ref src), pos);

            if(kind == PrimalKind.uint64)
                 return Bits.test((float)uint64(ref src), pos);

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref Bit test<T>(T src, in int pos, out Bit dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)            
                dst = Bits.test(in As.int8(ref src), in pos, out dst);
            else if(kind == PrimalKind.uint8)
                dst = Bits.test(in As.uint8(ref src), in pos, out dst);
            else if(kind == PrimalKind.int16)
                dst = Bits.test(in As.int16(ref src), in pos, out dst);
            else if(kind == PrimalKind.uint16)
                dst = Bits.test(in As.uint16(ref src), in pos, out dst);
            else if(kind == PrimalKind.int32)
                dst = Bits.test(in As.int32(ref src), in pos, out dst);
            else if(kind == PrimalKind.uint32)
                dst = Bits.test(in As.uint32(ref src), in pos, out dst);
            else if(kind == PrimalKind.int64)
                dst = Bits.test(in As.int64(ref src), in pos, out dst);
            else if(kind == PrimalKind.uint64)
                dst = Bits.test(in As.uint64(ref src), in pos, out dst);
            else
                throw unsupported(kind);

            return ref dst;                
            
        }

        [MethodImpl(Inline)]
        public static Bit test<T>(T src, in int pos)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)            
                return Bits.test(in As.int8(ref src), in pos);
            else if(kind == PrimalKind.uint8)
                return Bits.test(in As.uint8(ref src), in pos);
            else if(kind == PrimalKind.int16)
                return Bits.test(in As.int16(ref src), in pos);
            else if(kind == PrimalKind.uint16)
                return Bits.test(in As.uint16(ref src), in pos);
            else if(kind == PrimalKind.int32)
                return Bits.test(in As.int32(ref src), in pos);
            else if(kind == PrimalKind.uint32)
                return Bits.test(in As.uint32(ref src), in pos);
            else if(kind == PrimalKind.int64)
                return Bits.test(in As.int64(ref src), in pos);
            else if(kind == PrimalKind.uint64)
                return Bits.test(in As.uint64(ref src), in pos);
            else
                throw unsupported(kind);            
        }

        [MethodImpl(Inline)]
        public static T parse<T>(string bitstring, out T dst)
            where T : struct
                => dst = parse<T>(bitstring);

        [MethodImpl(NotInline)]
        public static T parse<T>(string bitstring)
            where T : struct
        {
            var prim = PrimalKinds.kind<T>();
            var offset = bitstring.StartsWith("0b") ? 2 : 0;
            switch(prim)
            {
                case PrimalKind.int8:
                {
                    Bits.parse(bitstring, offset, out sbyte dst);
                    return generic<T>(ref dst);
                }

                case PrimalKind.uint8:
                {
                    
                    Bits.parse(bitstring, offset, out byte dst);
                    return generic<T>(ref dst);
                }

                case PrimalKind.int16:
                {
                    Bits.parse(bitstring, offset, out short dst);
                    return generic<T>(ref dst);
                }

                case PrimalKind.uint16:
                {
                    Bits.parse(bitstring, offset, out ushort dst);
                    return generic<T>(ref dst);
                }

                case PrimalKind.int32:
                {
                    Bits.parse(bitstring, offset, out int dst);
                    return generic<T>(ref dst);
                }

                case PrimalKind.uint32:
                {
                    Bits.parse(bitstring, offset, out uint dst);
                    return generic<T>(ref dst);
                }

                case PrimalKind.int64:
                {
                    Bits.parse(bitstring, offset, out long dst);
                    return generic<T>(ref dst);
                }

                case PrimalKind.uint64:
                {
                    Bits.parse(bitstring, offset, out ulong dst);
                    return generic<T>(ref dst);
                }

                default:
                    throw new Exception($"Kind {prim} not supported");
            }
        }


        [MethodImpl(Inline)]
        public static Span<Bit> bitspan<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.uint8)
                return Bits.bitspan(in uint8(ref src));

            if(kind == PrimalKind.int8)
                return Bits.bitspan(in int8(ref src));

            if(kind == PrimalKind.int16)
                return Bits.bitspan(in int16(ref src));

            if(kind == PrimalKind.uint16)
                return Bits.bitspan(in uint16(ref src));

            if(kind == PrimalKind.int32)
                return Bits.bitspan(in int32(ref src));

            if(kind == PrimalKind.uint32)
                return Bits.bitspan(in uint32(ref src));

            if(kind == PrimalKind.int64)
                return Bits.bitspan(in int64(ref src));

            if(kind == PrimalKind.uint64)
                return Bits.bitspan(in uint64(ref src));

            if(kind == PrimalKind.float32)
                return Bits.bitspan(in float32(ref src));

            if(kind == PrimalKind.float64)
                return Bits.bitspan(in float64(ref src));

            throw unsupported(kind);                
        }

        [MethodImpl(Inline)]
        public static ref T bitpack<T>(in ReadOnlySpan<Bit> src, out T dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            dst = default(T);
            
            if(kind == PrimalKind.uint8)
                Bits.bitpack(in src, out uint8(ref dst));
            
            else if(kind == PrimalKind.int8)
                Bits.bitpack(in src, out int8(ref dst));

            else if(kind == PrimalKind.int16)
                Bits.bitpack(in src, out int16(ref dst));

            else if(kind == PrimalKind.uint16)
                Bits.bitpack(in src, out uint16(ref dst));

            else if(kind == PrimalKind.int32)
                Bits.bitpack(in src, out int32(ref dst));

            else if(kind == PrimalKind.uint32)
                Bits.bitpack(in src, out uint32(ref dst));

            else if(kind == PrimalKind.int64)
                Bits.bitpack(in src, out int64(ref dst));

            else if(kind == PrimalKind.uint64)
                Bits.bitpack(in src, out uint64(ref dst));
            
            else
                throw unsupported(kind);                
            
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static string bitstring<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return Bits.bitstring(in int8(ref src));

            if(kind == PrimalKind.uint8)
                return Bits.bitstring(in uint8(ref src));

            if(kind == PrimalKind.int16)
                return Bits.bitstring(in int16(ref src));

            if(kind == PrimalKind.uint16)
                return Bits.bitstring(in uint16(ref src));

            if(kind == PrimalKind.int32)
                return Bits.bitstring(in int32(ref src));

            if(kind == PrimalKind.uint32)
                return Bits.bitstring(in uint32(ref src));

            if(kind == PrimalKind.int64)
                return Bits.bitstring(in int64(ref src));

            if(kind == PrimalKind.uint64)
                return Bits.bitstring(in uint64(ref src));

            throw unsupported(kind);
                
        }

        [MethodImpl(Inline)]
        public static ref T enable<T>(ref T src, in int pos)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)            
                Bits.enable(ref int8(ref src), in pos);
            else if(kind == PrimalKind.uint8)
                Bits.enable(ref uint8(ref src), in pos);
            else if(kind == PrimalKind.int16)
                Bits.enable(ref int16(ref src), in pos);
            else if(kind == PrimalKind.uint16)
                Bits.enable(ref uint16(ref src), in pos);
            else if(kind == PrimalKind.int32)
                Bits.enable(ref int32(ref src), in pos);
            else if(kind == PrimalKind.uint32)
                Bits.enable(ref uint32(ref src), in pos);
            else if(kind == PrimalKind.int64)
                Bits.enable(ref int64(ref src), in pos);
            else if(kind == PrimalKind.uint64)
                Bits.enable(ref uint64(ref src), in pos);
            else
                throw unsupported(kind);

            return ref src;                            
        }

        [MethodImpl(Inline)]
        public static ref T disable<T>(ref T src, in int pos)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)            
                Bits.disable(ref int8(ref src), in pos);
            else if(kind == PrimalKind.uint8)
                Bits.disable(ref uint8(ref src), in pos);
            else if(kind == PrimalKind.int16)
                Bits.disable(ref int16(ref src), in pos);
            else if(kind == PrimalKind.uint16)
                Bits.disable(ref uint16(ref src), in pos);
            else if(kind == PrimalKind.int32)
                Bits.disable(ref int32(ref src), in pos);
            else if(kind == PrimalKind.uint32)
                Bits.disable(ref uint32(ref src), in pos);
            else if(kind == PrimalKind.int64)
                Bits.disable(ref int64(ref src), in pos);
            else if(kind == PrimalKind.uint64)
                Bits.disable(ref uint64(ref src), in pos);
            else
                throw unsupported(kind);

            return ref src;                            
        }


        [MethodImpl(Inline)]
        public static ref T parse<T>(in ReadOnlySpan<char> src, in int offset, out T dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            
            if(kind == PrimalKind.int8)            
                dst = generic<T>(ref Bits.parse(in src, offset, out sbyte x));
            else if(kind == PrimalKind.uint8)
                dst = generic<T>(ref Bits.parse(in src, offset, out byte x));
            else if(kind == PrimalKind.int16)
                dst = generic<T>(ref Bits.parse(in src, offset, out short x));
            else if(kind == PrimalKind.uint16)
                dst = generic<T>(ref Bits.parse(in src, offset, out ushort x));
            else if(kind == PrimalKind.int32)
                dst = generic<T>(ref Bits.parse(in src, offset, out int x));
            else if(kind == PrimalKind.uint32)
                dst = generic<T>(ref Bits.parse(in src, offset, out uint x));
            else if(kind == PrimalKind.int64)
                dst = generic<T>(ref Bits.parse(in src, offset, out long x));
            else if(kind == PrimalKind.uint64)
                dst = generic<T>(ref Bits.parse(in src, offset, out ulong x));
            else
                throw unsupported(kind);

            return ref dst;                            
        }

        [MethodImpl(Inline)]
        public static ref T parse<T>(in ReadOnlySpan<char> src, out T dst)
            where T : struct
        {
            parse(src, 0, out dst);
            return ref dst;
        }                                
        
        [MethodImpl(Inline)]
        public static T parse<T>(in ReadOnlySpan<char> src)
            where T : struct
                => parse(src, out T dst);
            
        [MethodImpl(Optimize)]
        public static ref T toggle<T>(ref T src, in int pos)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)            
                Bits.toggle(ref int8(ref src), in pos);
            else if(kind == PrimalKind.uint8)
                Bits.toggle(ref uint8(ref src), in pos);
            else if(kind == PrimalKind.int16)
                Bits.toggle(ref int16(ref src), in pos);
            else if(kind == PrimalKind.uint16)
                Bits.toggle(ref uint16(ref src), in pos);
            else if(kind == PrimalKind.int32)
                Bits.toggle(ref int32(ref src), in pos);
            else if(kind == PrimalKind.uint32)
                Bits.toggle(ref uint32(ref src), in pos);
            else if(kind == PrimalKind.int64)
                Bits.toggle(ref int64(ref src), in pos);
            else if(kind == PrimalKind.uint64)
                Bits.toggle(ref uint64(ref src), in pos);
            else
                throw unsupported(kind);

            return ref src;                            
        }

        [MethodImpl(Inline)]
        public static ulong pop<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                 return Bits.pop(int8(ref src));

            if(kind == PrimalKind.uint8)
                 return Bits.pop(uint8(ref src));

            if(kind == PrimalKind.int16)
                 return Bits.pop(int16(ref src));

            if(kind == PrimalKind.uint16)
                 return Bits.pop(uint16(ref src));

            if(kind == PrimalKind.int32)
                 return Bits.pop(int32(ref src));

            if(kind == PrimalKind.uint32)
                 return Bits.pop(uint32(ref src));

            if(kind == PrimalKind.int64)
                 return Bits.pop(int64(ref src));

            if(kind == PrimalKind.uint64)
                 return Bits.pop(uint64(ref src));

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ulong ntz<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                 return Bits.ntz(int8(ref src));

            if(kind == PrimalKind.uint8)
                 return Bits.ntz(uint8(ref src));

            if(kind == PrimalKind.int16)
                 return Bits.ntz(int16(ref src));

            if(kind == PrimalKind.uint16)
                 return Bits.ntz(uint16(ref src));

            if(kind == PrimalKind.int32)
                 return Bits.ntz(int32(ref src));

            if(kind == PrimalKind.uint32)
                 return Bits.ntz(uint32(ref src));

            if(kind == PrimalKind.int64)
                 return Bits.ntz(int64(ref src));

            if(kind == PrimalKind.uint64)
                 return Bits.ntz(uint64(ref src));

            throw unsupported(kind);
        }

    }


}