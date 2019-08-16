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
        /// <summary>
        /// Computes the bitwise or of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.or(int8(lhs),int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.or(uint8(lhs),uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.or(int16(lhs),int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.or(uint16(lhs),uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.or(int32(lhs),int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.or(uint32(lhs),uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.or(int64(lhs),int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.or(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.or(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.or(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Computes the bitwise or of two primal operands and stores the
        /// result in the left operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T or<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.or(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                Bits.or(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                Bits.or(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                Bits.or(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                Bits.or(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                Bits.or(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                Bits.or(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                Bits.or(ref uint64(ref lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                Bits.or(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                Bits.or(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> or<T>(in ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs, in Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                or(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                or(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                or(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                or(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                or(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                or(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                or(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                or(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static Span<T> or<T>(in ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
                => or(lhs, rhs, span<T>(length(lhs,rhs)));

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> or<T>(in Span<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                or(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                or(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                or(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                or(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                or(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                or(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                or(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                or(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> or<T>(in Span<T> lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                or(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                or(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                or(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                or(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                or(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                or(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                or(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                or(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Vec128<T> or<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.or(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.or(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.or(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.or(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.or(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.or(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.or(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.or(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.or(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.or(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> or<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.or(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.or(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.or(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.or(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.or(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.or(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.or(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.or(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.or(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.or(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void or<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                Bits.or(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                Bits.or(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                Bits.or(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                Bits.or(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.or(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.or(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.or(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.or(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                Bits.or(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.or(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }
        
        [MethodImpl(Inline)]
        public static void or<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                Bits.or(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                Bits.or(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                Bits.or(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                Bits.or(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.or(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.or(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.or(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.or(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                Bits.or(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.or(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }         

        public static Span128<T> or<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).OrSpan(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).OrSpan(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).OrSpan(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).OrSpan(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).OrSpan(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).OrSpan(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).OrSpan(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).OrSpan(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).OrSpan(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).OrSpan(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;   
        }

        public static Span256<T> or<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).OrSpan(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).OrSpan(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).OrSpan(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).OrSpan(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).OrSpan(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).OrSpan(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).OrSpan(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).OrSpan(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).OrSpan(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).OrSpan(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;   
        }

        static Span<sbyte> or(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<byte> or(Span<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<short> or(Span<short> lhs, ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<ushort> or(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<int> or(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<uint> or(Span<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<long> or(Span<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<ulong> or(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<sbyte> or(Span<sbyte> lhs, sbyte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<byte> or(Span<byte> lhs, byte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<short> or(Span<short> lhs, short rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<ushort> or(Span<ushort> lhs, ushort rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<int> or(Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<uint> or(Span<uint> lhs, uint rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<long> or(Span<long> lhs, long rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<ulong> or(Span<ulong> lhs, ulong rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }


        static Span128<sbyte> OrSpan(this ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, in Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<byte> OrSpan(this ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, in Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<short> OrSpan(this ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, in Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<ushort> OrSpan(this ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, in Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<int> OrSpan(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, in Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<uint> OrSpan(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, in Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<long> OrSpan(this ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, in Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<ulong> OrSpan(this ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<float> OrSpan(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, in Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<double> OrSpan(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, in Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<sbyte> OrSpan(this ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, in Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<byte> OrSpan(this ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, in Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<short> OrSpan(this ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, in Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<ushort> OrSpan(this ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, in Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<int> OrSpan(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, in Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<uint> OrSpan(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<long> OrSpan(this ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, in Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<ulong> OrSpan(this ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<float> OrSpan(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, in Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<double> OrSpan(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, in Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        } 

        static Span<sbyte> or(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<byte> or(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<short> or(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<ushort> or(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<int> or(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<uint> or(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<long> or(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<ulong> or(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = lhs[i] | rhs[i];
            return dst;                
        }


        [MethodImpl(Inline)]
        static Span<byte> OrSpan(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => or(lhs, rhs, span<byte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<sbyte> OrSpan(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => or(lhs, rhs, span<sbyte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<short> OrSpan(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => or(lhs, rhs, span<short>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<ushort> OrSpan(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => or(lhs, rhs, span<ushort>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<int> OrSpan(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => or(lhs, rhs, span<int>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<uint> OrSpan(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => or(lhs, rhs, span<uint>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<long> OrSpan(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => or(lhs, rhs, span<long>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<ulong> OrSpan(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => or(lhs, rhs, span<ulong>(length(lhs,rhs)));
 

    }
}