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
        public static string bitstring<T>(num<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return bitstring(As.int8(ref src.Scalar()));
                case PrimalKind.uint8:
                    return bitstring(As.uint8(ref src.Scalar()));
                case PrimalKind.int16:
                    return bitstring(As.int16(ref src.Scalar()));
                case PrimalKind.uint16:
                    return bitstring(As.uint16(ref src.Scalar()));
                case PrimalKind.int32:
                    return bitstring(As.int32(ref src.Scalar()));
                case PrimalKind.uint32:
                    return bitstring(As.uint32(ref src.Scalar()));
                case PrimalKind.int64:
                    return bitstring(As.int64(ref src.Scalar()));
                case PrimalKind.uint64:
                    return bitstring(As.uint64(ref src.Scalar()));
                case PrimalKind.float32:
                    return bitstring(As.float32(ref src.Scalar()));
                case PrimalKind.float64:
                    return bitstring(As.float64(ref src.Scalar()));                
                default:
                    throw unsupported(kind);
            }

        }

        [MethodImpl(Inline)]
        public static string bitstring(sbyte src)
            => zpad(Convert.ToString(src,2), 8);

        [MethodImpl(Inline)]
        public static string bitstring(byte src)
            => zpad(Convert.ToString(src,2), 8);

        [MethodImpl(Inline)]
        public static string bitstring(short src)
            => zpad(Convert.ToString(src,2), 16);

        [MethodImpl(Inline)]
        public static string bitstring(ushort src)
            => zpad(Convert.ToString(src,2), 16);

        [MethodImpl(Inline)]
        public static string bitstring(int src)
            => zpad(Convert.ToString(src,2), 32);

        [MethodImpl(Inline)]
        public static string bitstring(uint src)
            => zpad(Convert.ToString(src,2), 32);

        [MethodImpl(Inline)]
        public static string bitstring(long src)
            => zpad(Convert.ToString(src,2), 64);

        [MethodImpl(Inline)]
        public static string bitstring(ulong src)
        {
             (var x0, var x1) = split(src);
             return bitstring(x1) + bitstring(x0);
        }
            
        [MethodImpl(Inline)]
        public static string bitstring(float src)
            => bitstring(BitConverter.SingleToInt32Bits(src));

        [MethodImpl(Inline)]
        public static string bitstring(double src)
            => bitstring(Bits.bitsI64(src));

        [MethodImpl(Inline)]
        public static string bitstring(in U128 src)
            => bitstring(src.x0) + bitstring(src.x1);

        [MethodImpl(Inline)]
        public static string bitstring(in I128 src)
            => bitstring(src.x0) + bitstring(src.x1);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(short src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(ushort src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(int src)
            => BitConverter.GetBytes(src); 

        [MethodImpl(Inline)]
        public static Span<byte> bytes(uint src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(long src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(ulong src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(float src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(double src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static Span<byte> bytes(this in U128 src)
            => span(
                src.x0000, src.x0001, src.x0010, src.x0011,
                src.x0100, src.x0101, src.x0110, src.x0111,                        
                src.x1100, src.x1101, src.x1110, src.x1111,            
                src.x1000, src.x1001, src.x1010, src.x1011
            );

        [MethodImpl(Inline)]
        public static Span<byte> bytes(this in I128 src)
            => span(
                src.x0000, src.x0001, src.x0010, src.x0011,
                src.x0100, src.x0101, src.x0110, src.x0111,                        
                src.x1100, src.x1101, src.x1110, src.x1111,            
                src.x1000, src.x1001, src.x1010, src.x1011
            );

        [MethodImpl(NotInline)]
        public static Span<Bit> bits(sbyte src)
        {
            var bitsize = SizeOf<sbyte>.BitSize;
            var dst = span<Bit>(bitsize);
            for(var i = 0; i < bitsize; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(NotInline)]
        public static Span<Bit> bits(int src)
        {
            var dst = span<Bit>(SizeOf<int>.BitSize);
            for(var i = 0; i < SizeOf<int>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(Inline)]
        public static Span<Bit> bits(float src)
            => bits(BitConverter.SingleToInt32Bits(src));

        [MethodImpl(Inline)]
        public static Span<Bit> bits(double src)
            => bits(Bits.bitsI64(src));
 
        [MethodImpl(NotInline)]
        public static Span<Bit> bits(long src)
        {
            var dst = array<Bit>(SizeOf<long>.BitSize);
            for(var i = 0; i < SizeOf<long>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }        
   
        [MethodImpl(NotInline)]
        public static Bit[] bits(byte src)
        {
            var dst = array<Bit>(SizeOf<byte>.BitSize);
            for(var i = 0; i < SizeOf<byte>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(NotInline)]
        public static Bit[] bits(ushort src)
        {
            var dst = array<Bit>(SizeOf<ushort>.BitSize);
            for(var i = 0; i < SizeOf<ushort>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }
    
        [MethodImpl(NotInline)]
        public static Bit[] bits(uint src)
        {
            var dst = array<Bit>(SizeOf<uint>.BitSize);
            for(var i = 0; i < SizeOf<uint>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }
    
        [MethodImpl(NotInline)]
        public static Bit[] bits(ulong src)
        {
            var dst = array<Bit>(64);
            for(var i = 0; i < 64; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(NotInline)]
        public static Bit[] bits(in U128 src)
        {
            var dst = array<Bit>(128);
            for(var i = 0; i < 128; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(NotInline)]
        public static Bit[] bits(in I128 src)
        {
            var dst = array<Bit>(128);
            for(var i = 0; i < 128; i++)
                dst[i] = test(src,i);
            return dst; 
        }

    }

}