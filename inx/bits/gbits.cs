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
        const string BitSpecifier = "0b";

        [MethodImpl(Inline)]
        public static T shiftr<T>(T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) >> offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) >> offset));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) >> offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) >> offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) >> offset);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) >> offset);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) >> offset);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) >> offset);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static T shiftr<T>(T src, T offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) >> (int)int8(offset)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) >> (int)uint8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) >> (int)int16(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) >> (int)uint16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) >> (int)int32(offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) >> (int)uint32(offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) >> (int)int64(offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) >> (int)uint64(offset));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T shiftr<T>(ref T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(ref int8(ref src), offset);
            else if(typeof(T) == typeof(byte))
                math.shiftr(ref uint8(ref src), offset);
            else if(typeof(T) == typeof(short))
                math.shiftr(ref int16(ref src), offset);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(ref uint16(ref src), offset);
            else if(typeof(T) == typeof(int))
                math.shiftr(ref int32(ref src), offset);
            else if(typeof(T) == typeof(uint))
                math.shiftr(ref uint32(ref src), offset);
            else if(typeof(T) == typeof(long))
                math.shiftr(ref int64(ref src), offset);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(ref uint64(ref src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }           


        [MethodImpl(Inline)]
        public static T shiftl<T>(T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) << offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) << offset));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) << offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) << offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) << offset);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) << offset);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) << offset);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) << offset);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static T shiftl<T>(T src, T offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) << (int)int8(offset)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) << (int)uint8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) << (int)int16(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) << (int)uint16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) << (int)int32(offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) << (int)uint32(offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) << (int)int64(offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) << (int)uint64(offset));
            else            
                throw unsupported<T>();
        }           


        [MethodImpl(Inline)]
        public static ref T shiftl<T>(ref T lhs, int rhs)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(ref int8(ref lhs), rhs);
            else if (typeof(T) == typeof(byte))
                math.shiftl(ref uint8(ref lhs), rhs);
            else if (typeof(T) == typeof(short))
                math.shiftl(ref int16(ref lhs), rhs);
            else if (typeof(T) == typeof(ushort))
                math.shiftl(ref uint16(ref lhs), rhs);
            else if (typeof(T) == typeof(int))
                math.shiftl(ref int32(ref lhs), rhs);
            else if (typeof(T) == typeof(uint))
                math.shiftl(ref uint32(ref lhs), rhs);
            else if (typeof(T) == typeof(long))
                math.shiftl(ref int64(ref lhs), rhs);
            else if (typeof(T) == typeof(ulong))
                math.shiftl(ref uint64(ref lhs), rhs);
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static T shiftl<T>(in T lhs, in uint rhs)
            where T : struct
                => shiftl(lhs, (int)rhs);

        [MethodImpl(Inline)]
        public static T shiftl<T>(in T lhs, in ulong rhs)
            where T : struct
                => shiftl(lhs, (int)rhs);

        /// <summary>
        /// Counts the number enabled source bits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static ulong pop<T>(in T src)
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                 return Bits.pop(int8(in src));
            else if(typeof(T) == typeof(byte))
                 return Bits.pop(uint8(in src));
            else if(typeof(T) == typeof(short))
                 return Bits.pop(int16(in src));
            else if(typeof(T) == typeof(ushort))
                 return Bits.pop(uint16(in src));
            else if(typeof(T) == typeof(int))
                 return Bits.pop(int32(in src));
            else if(typeof(T) == typeof(uint))
                 return Bits.pop(uint32(in src));
            else if(typeof(T) == typeof(long))
                 return Bits.pop(int64(in src));
            else if(typeof(T) == typeof(ulong))
                 return Bits.pop(uint64(in src));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Determines whether a position-identified bit in value is enabled
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
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
            else if(typeof(T) == typeof(float))
                 return Bits.test(in AsIn.float32(asRef(in src)), pos);
            else if(typeof(T) == typeof(double))
                 return Bits.test(in AsIn.float64(asRef(in src)), pos);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Queries a bit source for the status of its most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline)]
        public static Bit hibit<T>(in T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.hibit(in AsIn.int8(asRef(in src)));
            else if(typeof(T) == typeof(byte))
                 return Bits.hibit(in AsIn.uint8(asRef(in src)));
            else if(typeof(T) == typeof(short))
                 return Bits.hibit(in AsIn.int16(asRef(in src)));
            else if(typeof(T) == typeof(ushort))
                 return Bits.hibit(in AsIn.uint16(asRef(in src)));
            else if(typeof(T) == typeof(int))
                 return Bits.hibit(in AsIn.int32(asRef(in src)));
            else if(typeof(T) == typeof(uint))
                 return Bits.hibit(in AsIn.uint32(asRef(in src)));
            else if(typeof(T) == typeof(long))
                 return Bits.hibit(in AsIn.int64(asRef(in src)));
            else if(typeof(T) == typeof(ulong))
                 return Bits.hibit(in AsIn.uint64(asRef(in src)));
            else if(typeof(T) == typeof(float))
                 return Bits.hibit(in AsIn.float32(asRef(in src)));
            else if(typeof(T) == typeof(double))
                 return Bits.hibit(in AsIn.float64(asRef(in src)));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Queries a bit source for the status of its least significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline)]
        public static Bit lobit<T>(in T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.lobit(in AsIn.int8(asRef(in src)));
            else if(typeof(T) == typeof(byte))
                 return Bits.lobit(in AsIn.uint8(asRef(in src)));
            else if(typeof(T) == typeof(short))
                 return Bits.lobit(in AsIn.int16(asRef(in src)));
            else if(typeof(T) == typeof(ushort))
                 return Bits.lobit(in AsIn.uint16(asRef(in src)));
            else if(typeof(T) == typeof(int))
                 return Bits.lobit(in AsIn.int32(asRef(in src)));
            else if(typeof(T) == typeof(uint))
                 return Bits.lobit(in AsIn.uint32(asRef(in src)));
            else if(typeof(T) == typeof(long))
                 return Bits.lobit(in AsIn.int64(asRef(in src)));
            else if(typeof(T) == typeof(ulong))
                 return Bits.lobit(in AsIn.uint64(asRef(in src)));
            else if(typeof(T) == typeof(float))
                 return Bits.lobit(in AsIn.float32(asRef(in src)));
            else if(typeof(T) == typeof(double))
                 return Bits.lobit(in AsIn.float64(asRef(in src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T pack<T>(in ReadOnlySpan<Bit> src, out T dst)
            where T : struct
        {
            dst = default;
            
            if(typeof(T) == typeof(sbyte))
                Bits.pack(in src, out int8(ref dst));
            else if(typeof(T) == typeof(byte))
                Bits.pack(in src, out uint8(ref dst));
            else if(typeof(T) == typeof(short))
                Bits.pack(in src, out int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                Bits.pack(in src, out uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.pack(in src, out int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.pack(in src, out uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.pack(in src, out int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.pack(in src, out uint64(ref dst));        
            else
                throw unsupported<T>();
            
            return ref dst;
        }


        /// <summary>
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
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
                throw unsupported<T>();

            return ref src;                            
        }

        /// <summary>
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static T enable<T>(T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.enable(int8(src), pos));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.enable(uint8(src), pos));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.enable(int16(src), pos));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.enable(uint16(src), pos));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.enable(int32(src), pos));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.enable(uint32(src), pos));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.enable(int64(src), pos));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.enable(uint64(src), pos));
            else
                throw unsupported<T>();            
        }

        /// <summary>
        /// Disables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
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
            else if(typeof(T) == typeof(float))
                Bits.disable(ref float32(ref src), in pos);
            else if(typeof(T) == typeof(double))
                Bits.disable(ref float64(ref src), in pos);
            else
                throw unsupported<T>();
                
            return ref src;                            
        }
            
        /// <summary>
        /// Sets an identified bit to a supplied value
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T set<T>(ref T src, in int pos, Bit value)            
            where T : struct
        {
            if(value)
                enable(ref src, pos);
            else
                disable(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T toggle<T>(ref T src, in int pos)
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
            else if(typeof(T) == typeof(float))
                Bits.toggle(ref float32(ref src), pos);
            else if(typeof(T) == typeof(double))
                Bits.toggle(ref float64(ref src), pos);
            else
                throw unsupported<T>();

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
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.toggle(float32(src), pos));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.toggle(float64(src), pos));
            else
                throw unsupported<T>();
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
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static T rotr<T>(T src, T offset)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotr(uint8(src), uint8(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotr(uint16(src), uint16(offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotr(uint32(src), uint32(offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotr(uint64(src), uint64(offset)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static ref T rotr<T>(ref T src, in T offset)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                Bits.rotr(ref uint8(ref src), in uint8(in offset));
            else if(typeof(T) == typeof(ushort))
                Bits.rotr(ref uint16(ref src), in uint16(in offset));
            else if(typeof(T) == typeof(uint))
                Bits.rotr(ref uint32(ref src), in uint32(in offset));
            else if(typeof(T) == typeof(ulong))
                Bits.rotr(ref uint64(ref src), in uint64(in offset));
            else            
                throw unsupported<T>();
            return ref src;
        }           
 
 
        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static T rotl<T>(T src, T offset)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotl(uint8(src), uint8(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotl(uint16(src), uint16(offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotl(uint32(src), uint32(offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotl(uint64(src), uint64(offset)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static ref T rotl<T>(ref T src, in T offset)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                Bits.rotl(ref uint8(ref src), uint8(in offset));
            else if(typeof(T) == typeof(ushort))
                Bits.rotl(ref uint16(ref src), uint16(in offset));
            else if(typeof(T) == typeof(uint))
                Bits.rotl(ref uint32(ref src), uint32(in offset));
            else if(typeof(T) == typeof(ulong))
                Bits.rotl(ref uint64(ref src), uint64(in offset));
            else            
                throw unsupported<T>();
            return ref src;
        }           

        /// <summary>
        /// Extracts a sequence of mask-identifed bits from the source
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static T extract<T>(T src, T mask)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.extract(uint8(src), uint8(mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.extract(uint16(src), uint16(mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.extract(uint32(src), uint32(mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.extract(uint64(src), uint64(mask)));
            else            
                throw unsupported<T>();
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
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static T extract<T>(in T lhs, in byte start, in byte length)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.extract(in int8(in lhs), in start, in length));
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.extract(in uint8(in lhs), in start, in length));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.extract(in int16(in lhs), in start, in length));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.extract(in uint16(in lhs), in start, in length));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.extract(in int32(in lhs), in start, in length));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.extract(in uint32(in lhs), in start, in length));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.extract(in int64(in lhs), in start, in length));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.extract(in uint64(in lhs), in start, in length));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static T deposit<T>(in T src, in T mask)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.deposit(in uint8(in src), in uint8(in mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.deposit(in uint16(in src), in uint16(in mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.deposit(in uint32(in src), in uint32(in mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.deposit(in uint64(in src), in uint64(in mask)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Deposits mask-identified bits from the source
        /// </summary>
        /// <param name="src">The source/target value</param>
        /// <param name="mask"></param>
        /// <typeparam name="T">The identifiying mask</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static ref T deposit<T>(ref T src, T mask)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                Bits.deposit(ref uint8(ref src), uint8(mask));
            else if(typeof(T) == typeof(ushort))
                Bits.deposit(ref uint16(ref src), uint16(mask));
            else if(typeof(T) == typeof(uint))
                Bits.deposit(ref uint32(ref src), uint32(mask));
            else if(typeof(T) == typeof(ulong))
                Bits.deposit(ref uint64(ref src), uint64(mask));
            else            
                throw unsupported<T>();
            return ref src;
        }

        /// <summary>
        /// Constructs a bytespan where each entry, ordered from lo to hi,
        /// represents a single bit in the soure value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static ReadOnlySpan<byte> bitseq<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return Bits.bitseq(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.bitseq(uint16(src));
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
            if(typeof(T) == typeof(byte))
                dst = generic<T>(ref Bits.packseq(src, out byte _));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(ref Bits.packseq(src, out ushort _));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(ref Bits.packseq(src, out uint _));
            else if(typeof(T) == typeof(ulong))
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
        public static string bstext<T>(T src)
        {
            if(typeof(T) == typeof(byte))
                return Bits.bstext(uint8(src));
            else if(typeof(T) == typeof(sbyte))
                return Bits.bstext(int8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.bstext(uint16(src));
            else if(typeof(T) == typeof(short))
                return Bits.bstext(int16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.bstext(uint32(src));
            else if(typeof(T) == typeof(int))
                return Bits.bstext(int32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.bstext(uint64(src));
            else if(typeof(T) == typeof(long))
                return Bits.bstext(int64(src));
            else            
                throw unsupported<T>();            
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static char bitchar<T>(in T src, int pos)
            where T : struct
                => gbits.test(in src, pos)  ? AsciDigits.A1 : AsciDigits.A0;                

        /// <summary>
        /// Constructs bitstring characters for integral values
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static ReadOnlySpan<char> bitchars<T>(in T src)
        {
            if(typeof(T) == typeof(byte))
                return Bits.bitchars(uint8(in src));
            else if(typeof(T) == typeof(sbyte))
                return Bits.bitchars(int8(in src));
            else if(typeof(T) == typeof(ushort))
                return Bits.bitchars(uint16(in src));
            else if(typeof(T) == typeof(short))
                return Bits.bitchars(int16(in src));
            else if(typeof(T) == typeof(uint))
                return Bits.bitchars(uint32(in src));
            else if(typeof(T) == typeof(int))
                return Bits.bitchars(int32(in src));
            else if(typeof(T) == typeof(ulong))
                return Bits.bitchars(uint64(in src));
            else if(typeof(T) == typeof(long))
                return Bits.bitchars(int64(in src));
            else            
                throw unsupported<T>();            
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static BitString bitstring<T>(T src)
            => bitchars<T>(src).Reverse();

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

        /// <summary>
        /// Converts a span of primal values to a span of characters, each of which represent a bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [PrimalKinds(PrimalKind.All)]
        public static Span<char> bitchars<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var segcount = src.Length;
            var seglen = Unsafe.SizeOf<T>()*8;
            var bitcount = segcount * seglen;
            Span<char> dst = new char[bitcount];
            var lastix = bitcount - 1;
            for(var seg = 0; seg < segcount; seg++)
            for(var pos = 0; pos < seglen; pos++, lastix--)
                dst[lastix] = bitchar(in src[seg], pos);
            return dst;         
        }

        /// <summary>
        /// Converts a span of primal values to a span of characters, each of which represent a bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static Span<char> bitchars<T>(Span<T> src)
            where T : struct
                => bitchars(src.ReadOnly());
        
    }
}