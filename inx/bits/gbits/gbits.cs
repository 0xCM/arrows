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
    using static zfunc;
    using static As;
    using static AsIn;

    public static partial class gbits
    {
            
        /// <summary>
        /// Sets an identified bit to a supplied value
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref T set<T>(ref T src, byte pos, in Bit value)            
            where T : struct
        {
            if(value)
                enable(ref src, pos);
            else
                disable(ref src, pos);
            return ref src;
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
                throw unsupported<T>();
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
                throw unsupported<T>();
        }

        /// <summary>
        /// Given 2^n, finds n
        /// </summary>
        /// <param name="pow2">A value obtained by raising 2 to some power</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T exp<T>(T pow2)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(uint8(pow2));
            else if(typeof(T) == typeof(byte))
                return generic<T>(uint16(pow2));
            else if(typeof(T) == typeof(byte))
                return generic<T>(uint32(pow2));
            else if(typeof(T) == typeof(byte))
                return generic<T>(uint64(pow2));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T loff<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 Bits.loff(ref int8(ref src));
            if(typeof(T) == typeof(byte))
                 Bits.loff(ref uint8(ref src));
            if(typeof(T) == typeof(short))
                 Bits.loff(ref int16(ref src));
            if(typeof(T) == typeof(ushort))
                 Bits.loff(ref uint16(ref src));
            if(typeof(T) == typeof(int))
                 Bits.loff(ref int32(ref src));
            if(typeof(T) == typeof(uint))
                 Bits.loff(ref uint32(ref src));
            if(typeof(T) == typeof(long))
                 Bits.loff(ref int64(ref src));
            if(typeof(T) == typeof(ulong))
                 Bits.loff(ref uint64(ref src));
            else
                throw unsupported<T>();

            return ref src;
        }       
 
 
        /// <summary>
        /// Returns the position of the least on bit in the source
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static T lopos<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.lopos(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.lopos(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.lopos(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.lopos(uint64(src)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Constructs a bytespan where each entry, ordered from lo to hi, represents a single bit in the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static ReadOnlySpan<byte> bitseq<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return Bits.bitseq(uint8(src));
            else if(typeof(T) == typeof(sbyte))
                return Bits.bitseq(int8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.bitseq(uint16(src));
            else if(typeof(T) == typeof(short))
                return Bits.bitseq(int16(src));
            else if(typeof(T) == typeof(int))
                return Bits.bitseq(int32(src));
            else if(typeof(T) == typeof(long))
                return Bits.bitseq(int64(src));
            else if(typeof(T) == typeof(uint))
                return Bits.bitseq(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.bitseq(uint64(src));
            else            
                throw unsupported<T>();            
        }        


        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static ref T packseq<T>(ReadOnlySpan<byte> src, out T dst)
            where T : struct
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                dst = generic<T>(ref Bits.packseq(src, out byte _));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                dst = generic<T>(ref Bits.packseq(src, out ushort _));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                dst = generic<T>(ref Bits.packseq(src, out uint _));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                dst = generic<T>(ref Bits.packseq(src, out ulong _));
            else            
                throw unsupported<T>();            
            return ref dst;
        }        

        /// <summary>
        /// Constructs the bitstring text for an integral value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static string bstext<T>(in T src)
        {
            if(typeof(T) == typeof(byte))
                return Bits.bstext(uint8(in src));
            else if(typeof(T) == typeof(sbyte))
                return Bits.bstext(int8(in src));
            else if(typeof(T) == typeof(ushort))
                return Bits.bstext(uint16(in src));
            else if(typeof(T) == typeof(short))
                return Bits.bstext(int16(in src));
            else if(typeof(T) == typeof(uint))
                return Bits.bstext(uint32(in src));
            else if(typeof(T) == typeof(int))
                return Bits.bstext(int32(in src));
            else if(typeof(T) == typeof(ulong))
                return Bits.bstext(uint64(in src));
            else if(typeof(T) == typeof(long))
                return Bits.bstext(int64(in src));
            else            
                throw unsupported<T>();            
        }

        public static ref T parse<T>(in ReadOnlySpan<char> src, in int offset, out T dst)
            where T : struct
        {            
            var last = Math.Min(Unsafe.SizeOf<T>()*8, src.Length) - 1;                                    
            dst = gmath.zero<T>();
            for(int i=offset, pos = 0; i<= last; i++, pos++)
                if(src[i] == Bit.One)
                    gbits.enable(ref dst, pos);                        
            return ref dst;
        }

        /// <summary>
        /// Determines whether identified bits in the operands agree.
        /// </summary>
        /// <param name="lhs">The first bit source</param>
        /// <param name="nx">The first bit position</param>
        /// <param name="rhs">The second bit source</param>
        /// <param name="ny">The second bit position</param>
        /// <typeparam name="S">The left operand type</typeparam>
        /// <typeparam name="T">The right operand type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All, PrimalKind.All)]
        public static bool match<S,T>(in S lhs, in int nx, T rhs, in int ny)
            where S : struct
            where T : struct
                => test(in lhs, in nx) == test(in rhs, in ny);     
    }
}