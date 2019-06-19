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

    public static class gbits
    {
        const string BitSpecifier = "0b";

        [MethodImpl(Inline)]
        public static T shiftr<T>(T lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(lhs) >> rhs));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) >> rhs));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) >> rhs));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) >> rhs));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs)  >> rhs);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs)  >> rhs);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs)  >> rhs);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs)  >> rhs);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T shiftr<T>(ref T lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(ref int8(ref lhs), rhs);
            else if(typeof(T) == typeof(byte))
                math.shiftr(ref uint8(ref lhs), rhs);
            else if(typeof(T) == typeof(short))
                math.shiftr(ref int16(ref lhs), rhs);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(ref uint16(ref lhs), rhs);
            else if(typeof(T) == typeof(int))
                math.shiftr(ref int32(ref lhs), rhs);
            else if(typeof(T) == typeof(uint))
                math.shiftr(ref uint32(ref lhs), rhs);
            else if(typeof(T) == typeof(long))
                math.shiftr(ref int64(ref lhs), rhs);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(ref uint64(ref lhs), rhs);
            else
                throw unsupported<T>();
            return ref lhs;
        }           

        [MethodImpl(Inline)]
        public static Span<T> shiftr<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(lhs), rhs, int8(dst));
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(lhs), rhs, uint8(dst));
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(lhs), rhs, int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(lhs), rhs, uint16(dst));
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(lhs), rhs, int32(dst));
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(lhs), rhs, uint32(dst));
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(lhs), rhs, int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(lhs), rhs, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<T> shiftr<T>(ReadOnlySpan<T> lhs, int rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(lhs), rhs, int8(dst));
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(lhs), rhs, uint8(dst));
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(lhs), rhs, int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(lhs), rhs, uint16(dst));
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(lhs), rhs, int32(dst));
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(lhs), rhs, uint32(dst));
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(lhs), rhs, int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(lhs), rhs, uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> shiftr<T>(ReadOnlySpan<T> lhs, int rhs)
            where T : struct
            => shiftr(lhs, rhs, span<T>(lhs.Length));

        [MethodImpl(Inline)]
        public static ref Span<T> shiftr<T>(ref Span<T> lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(lhs), rhs);
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(lhs), rhs);
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(lhs), rhs);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(lhs), rhs);
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(lhs), rhs);
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(lhs), rhs);
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(lhs), rhs);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(lhs), rhs);
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> shiftr<T>(ref Span<T> lhs, Span<int> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(lhs), rhs);
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(lhs), rhs);
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(lhs), rhs);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(lhs), rhs);
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(lhs), rhs);
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(lhs), rhs);
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(lhs), rhs);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(lhs), rhs);
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static T shiftl<T>(T lhs, int rhs)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                return generic<T>(math.shiftl(int8(lhs), rhs));
            else if (typeof(T) == typeof(byte))
                return generic<T>(math.shiftl(uint8(lhs), rhs));
            else if (typeof(T) == typeof(short))
                return generic<T>(math.shiftl(int16(lhs), rhs));
            else if (typeof(T) == typeof(ushort))
                return generic<T>(math.shiftl(uint16(lhs), rhs));
            else if (typeof(T) == typeof(int))
                return generic<T>(math.shiftl(int32(lhs), rhs));
            else if (typeof(T) == typeof(uint))
                return generic<T>(math.shiftl(uint32(lhs), rhs));
            else if (typeof(T) == typeof(long))
                return generic<T>(math.shiftl(int64(lhs), rhs));
            else if (typeof(T) == typeof(ulong))
                return generic<T>(math.shiftl(uint64(lhs), rhs));
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
        public static Span<T> shiftl<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs, Span<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(lhs), rhs, int8(dst));
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(lhs), rhs, uint8(dst));
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(lhs), rhs, int16(dst));
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(lhs), rhs, uint16(dst));
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(lhs), rhs, int32(dst));
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(lhs), rhs, uint32(dst));
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(lhs), rhs, int64(dst));
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(lhs), rhs, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> lhs, int rhs, Span<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(lhs), rhs, int8(dst));
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(lhs), rhs, uint8(dst));
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(lhs), rhs, int16(dst));
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(lhs), rhs, uint16(dst));
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(lhs), rhs, int32(dst));
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(lhs), rhs, uint32(dst));
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(lhs), rhs, int64(dst));
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(lhs), rhs, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> lhs, int rhs)
            where T : struct
            => shiftl(lhs, rhs, span<T>(lhs.Length));

        [MethodImpl(Inline)]
        public static ref Span<T> shiftl<T>(ref Span<T> lhs, int rhs)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(lhs), rhs);
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(lhs), rhs);
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(lhs), rhs);
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(lhs), rhs);
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(lhs), rhs);
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(lhs), rhs);
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(lhs), rhs);
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(lhs), rhs);
            else
                throw unsupported(PrimalKinds.kind<T>());
            return ref lhs;

        }

        [MethodImpl(Inline)]
        public static ref Span<T> shiftl<T>(ref Span<T> lhs, Span<int> rhs)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(lhs), rhs);
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(lhs), rhs);
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(lhs), rhs);
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(lhs), rhs);
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(lhs), rhs);
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(lhs), rhs);
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(lhs), rhs);
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(lhs), rhs);
            else
                throw unsupported(PrimalKinds.kind<T>());
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
                throw unsupported<T>();
        }

        /// <summary>
        /// Determines whether a position-identified bit in value is enabled
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline)]
        public static bool test<T>(in T src, in BitPos pos)
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


        [MethodImpl(Inline)]
        public static ref T enable<T>(ref T src, in BitPos pos)
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

        [MethodImpl(Inline)]
        public static T enable<T>(T src, in BitPos pos)
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

        [MethodImpl(Inline)]
        public static ref T disable<T>(ref T src, in BitPos pos)
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
            
        [MethodImpl(Inline)]
        public static ref T toggle<T>(ref T src, in BitPos pos)
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
        public static T toggle<T>(T src, BitPos pos)
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
 
        [MethodImpl(Inline)]
        public static T rotr<T>(T lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotr(uint8(lhs), rhs));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotr(uint16(lhs), rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotr(uint32(lhs), rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotr(uint64(lhs), rhs));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T rotr<T>(ref T lhs, in int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                Bits.rotr(ref uint8(ref lhs), in rhs);
            else if(typeof(T) == typeof(ushort))
                Bits.rotr(ref uint16(ref lhs), in rhs);
            else if(typeof(T) == typeof(uint))
                Bits.rotr(ref uint32(ref lhs), in rhs);
            else if(typeof(T) == typeof(ulong))
                Bits.rotr(ref uint64(ref lhs), in rhs);
            else            
                throw unsupported<T>();
            return ref lhs;
        }           

 
        [MethodImpl(Inline)]
        public static T rotl<T>(T lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotl(uint8(lhs), rhs));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotl(uint16(lhs), rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotl(uint32(lhs), rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotl(uint64(lhs), rhs));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T rotl<T>(ref T lhs, in int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                Bits.rotl(ref uint8(ref lhs), in rhs);
            else if(typeof(T) == typeof(ushort))
                Bits.rotl(ref uint16(ref lhs), in rhs);
            else if(typeof(T) == typeof(uint))
                Bits.rotl(ref uint32(ref lhs), in rhs);
            else if(typeof(T) == typeof(ulong))
                Bits.rotl(ref uint64(ref lhs), in rhs);
            else            
                throw unsupported<T>();
            return ref lhs;
        }           

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static T range<T>(in T lhs, in BitPos start, in byte length)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.range(in int8(in lhs), in start, in length));
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.range(in uint8(in lhs), in start, in length));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.range(in int16(in lhs), in start, in length));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.range(in uint16(in lhs), in start, in length));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.range(in int32(in lhs), in start, in length));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.range(in uint32(in lhs), in start, in length));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.range(in int64(in lhs), in start, in length));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.range(in uint64(in lhs), in start, in length));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Determines whether identified bits in the operands agree.
        /// </summary>
        /// <param name="x">The first bit source</param>
        /// <param name="nx">The first bit position</param>
        /// <param name="y">The second bit source</param>
        /// <param name="ny">The second bit position</param>
        /// <typeparam name="S">The left operand type</typeparam>
        /// <typeparam name="T">The right operand type</typeparam>
        [MethodImpl(Inline)]
        public static bool match<S,T>(in S x, in BitPos nx, T y, in BitPos ny)
            where S : struct
            where T : struct
                => test(in x, in nx) == test(in y, in ny);

        public static ref Span<T> rotr<T>(ref Span<T> io, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var len = io.Length;
            for(var i=0; i<len; i++)
                io[i] = rotr(io[i],rhs[i]);
            return ref io;
        }

        public static ref Span<T> rotl<T>(ref Span<T> io, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var len = io.Length;
            for(var i=0; i<len; i++)
                io[i] = rotl(io[i],rhs[i]);
            return ref io;
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

    }
}