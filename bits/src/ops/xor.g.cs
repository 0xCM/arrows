//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;
    using static AsInX;

    partial class gbits
    {
        [MethodImpl(Inline)]
        public static T xor<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(lhs) ^ int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) ^ uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) ^ int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) ^ uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs) ^ int32(rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs) ^ uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs) ^ int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs) ^ uint64(rhs));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.xor(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                Bits.xor(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                Bits.xor(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                Bits.xor(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                Bits.xor(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                Bits.xor(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                Bits.xor(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                Bits.xor(ref uint64(ref lhs), uint64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> xor<T>(in ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs, in Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.xor(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                Bits.xor(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                Bits.xor(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                Bits.xor(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                Bits.xor(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                Bits.xor(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                Bits.xor(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                Bits.xor(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static Span<T> xor<T>(in ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
                => xor(in lhs,in rhs, span<T>(length(lhs,rhs)));
        

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Memory<T> xor<T>(in Memory<T> lhs, in ReadOnlyMemory<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.xor(int8(lhs.Span), int8(rhs.Span));
            else if(typeof(T) == typeof(byte))
                Bits.xor(uint8(lhs.Span), uint8(rhs.Span));
            else if(typeof(T) == typeof(short))
                Bits.xor(int16(lhs.Span), int16(rhs.Span));
            else if(typeof(T) == typeof(ushort))
                Bits.xor(uint16(lhs.Span), uint16(rhs.Span));
            else if(typeof(T) == typeof(int))
                Bits.xor(int32(lhs.Span), int32(rhs.Span));
            else if(typeof(T) == typeof(uint))
                Bits.xor(uint32(lhs.Span), uint32(rhs.Span));
            else if(typeof(T) == typeof(long))
                Bits.xor(int64(lhs.Span), int64(rhs.Span));
            else if(typeof(T) == typeof(ulong))
                Bits.xor(uint64(lhs.Span), uint64(rhs.Span));
            else
                throw unsupported<T>();
            return ref lhs;
        }


        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> xor<T>(in Span<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.xor(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                Bits.xor(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                Bits.xor(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                Bits.xor(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                Bits.xor(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                Bits.xor(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                Bits.xor(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                Bits.xor(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> xor<T>(in Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.xor(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                Bits.xor(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                Bits.xor(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                Bits.xor(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                Bits.xor(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                Bits.xor(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                Bits.xor(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                Bits.xor(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }
 
         [MethodImpl(Inline)]
        public static Vec128<T> xor<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.xor(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.xor(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.xor(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.xor(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.xor(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.xor(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.xor(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.xor(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.xor(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.xor(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> xor<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.xor(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.xor(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.xor(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.xor(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.xor(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.xor(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.xor(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.xor(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.xor(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.xor(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void xor<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                Bits.xor(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                Bits.xor(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                Bits.xor(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                Bits.xor(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.xor(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.xor(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.xor(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.xor(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                Bits.xor(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.xor(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }
        
        [MethodImpl(Inline)]
        public static void xor<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                Bits.xor(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                Bits.xor(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                Bits.xor(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                Bits.xor(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.xor(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.xor(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.xor(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.xor(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                Bits.xor(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.xor(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
         public static Span128<T> xor<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).XOrSpan(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).XOrSpan(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).XOrSpan(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).XOrSpan(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).XOrSpan(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).XOrSpan(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).XOrSpan(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).XOrSpan(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).XOrSpan(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).XOrSpan(float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;   
        }

        [MethodImpl(Inline)]
        public static Span256<T> xor<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).XOrSpan(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).XOrSpan(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).XOrSpan(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).XOrSpan(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).XOrSpan(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).XOrSpan(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).XOrSpan(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).XOrSpan(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).XOrSpan(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).XOrSpan(float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;   
        }

        static Span128<sbyte> XOrSpan(this ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, in Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<byte> XOrSpan(this ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, in Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<short> XOrSpan(this ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, in Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<ushort> XOrSpan(this ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, in Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<int> XOrSpan(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, in Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<uint> XOrSpan(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, in Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<long> XOrSpan(this ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, in Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<ulong> XOrSpan(this ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<float> XOrSpan(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, in Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<double> XOrSpan(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, in Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<sbyte> XOrSpan(this ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, in Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<byte> XOrSpan(this ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, in Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<short> XOrSpan(this ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, in Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<ushort> XOrSpan(this ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, in Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<int> XOrSpan(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, in Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<uint> XOrSpan(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<long> XOrSpan(this ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, in Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<ulong> XOrSpan(this ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<float> XOrSpan(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, in Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<double> XOrSpan(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, in Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        } 
 
    }
}