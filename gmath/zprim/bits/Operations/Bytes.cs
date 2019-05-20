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
    using static As;

    partial class Bits
    {                

        [MethodImpl(Inline)]
        public static Span<byte> bytes<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.uint8)
                return bytes(in As.uint8(ref src));

            if(kind == PrimalKind.int8)
                return bytes(in As.int8(ref src));

            if(kind == PrimalKind.int16)
                return bytes(in As.int16(ref src));

            if(kind == PrimalKind.uint16)
                return bytes(in As.uint16(ref src));

            if(kind == PrimalKind.int32)
                return bytes(in As.int32(ref src));

            if(kind == PrimalKind.uint32)
                return bytes(in As.uint32(ref src));

            if(kind == PrimalKind.int64)
                return bytes(in As.int64(ref src));

            if(kind == PrimalKind.uint64)
                return bytes(in As.uint64(ref src));

            throw unsupported(kind);
                
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes<T>(T src, out Span<byte> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                bytes(in int8(ref src), out dst);                    
                
            else if(kind == PrimalKind.uint8)
                bytes(in uint8(ref src), out dst);                    

            else if(kind == PrimalKind.int16)
                bytes(in int16(ref src), out dst);                    

            else if(kind == PrimalKind.uint16)
                bytes(in uint16(ref src), out dst);                    

            else if(kind == PrimalKind.int32)
                bytes(in int32(ref src), out dst);                    

            else if(kind == PrimalKind.uint32)
                bytes(in uint32(ref src), out dst);                    

            else if(kind == PrimalKind.int64)
                bytes(in int64(ref src), out dst);

            else if(kind == PrimalKind.uint64)
                bytes(in uint64(ref src), out dst);
            else
                throw unsupported(kind);

            return ref dst;                
        }

        [MethodImpl(Inline)]
        public static Span<byte> bytes(in byte src)
            => span(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(in sbyte src)
            => span((byte)src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(in short src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(in ushort src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(in int src)
            => BitConverter.GetBytes(src); 

        [MethodImpl(Inline)]
        public static Span<byte> bytes(in uint src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(in long src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(in ulong src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(in float src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(in double src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes(in byte src, out Span<byte> dst)
        {
            dst = span<byte>(1);
            dst[0] = src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes(in sbyte src, out Span<byte> dst)
        {
            dst = span<byte>(1);
            dst[0] = (byte)src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes(in short src, out Span<byte> dst)
        {
            dst = span<byte>(2);
            BitConverter.TryWriteBytes(dst,src);
            return ref dst;
        }
        
        [MethodImpl(Inline)]
        public static ref Span<byte> bytes(in ushort src, out Span<byte> dst)
        {
            dst = span<byte>(2);
            BitConverter.TryWriteBytes(dst,src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes(in int src, out Span<byte> dst)
        {
            dst = span<byte>(4);
            BitConverter.TryWriteBytes(dst,src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes(in uint src, out Span<byte> dst)
        {
            dst = span<byte>(4);
            BitConverter.TryWriteBytes(dst,src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes(in long src, out Span<byte> dst)
        {
            dst = span<byte>(8);
            BitConverter.TryWriteBytes(dst,src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes(in ulong src, out Span<byte> dst)
        {
            dst = span<byte>(8);
            BitConverter.TryWriteBytes(dst,src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes(in float src, out Span<byte> dst)
        {
            dst = span<byte>(4);
            BitConverter.TryWriteBytes(dst,src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes(in double src, out Span<byte> dst)
        {
            dst = span<byte>(32);
            BitConverter.TryWriteBytes(dst,src);
            return ref dst;
        }
    }
}