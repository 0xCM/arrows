//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    
    //using static mfunc;
    using static zfunc;

    public static class Converter
    {

        [MethodImpl(Inline)]
        public static T convert<S,T>(S src, out T dst)
            where S : struct, IEquatable<S>
            where T : struct, IEquatable<T>
        {
            var srcKind = PrimalKinds.kind<S>();
            switch(srcKind)
            {
                
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(srcKind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static T convert<T>(sbyte src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static T convert<T>(byte src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }


        [MethodImpl(Inline)]
        public static T convert<T>(short src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static T convert<T>(ushort src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static T convert<T>(int src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static T convert<T>(uint src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }


        [MethodImpl(Inline)]
        public static T convert<T>(long src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }


        [MethodImpl(Inline)]
        public static T convert<T>(ulong src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static T convert<T>(float src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static T convert<T>(double src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                  dst = generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        #region int8 => X

        [MethodImpl(Inline)]
        static sbyte convert(sbyte src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        static byte convert(sbyte src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        static short convert(sbyte src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        static ushort convert(sbyte src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        static int convert(sbyte src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        static uint convert(sbyte src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        static long convert(sbyte src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        static ulong convert(sbyte src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        static float convert(sbyte src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        static double convert(sbyte src, out double dst)
            => dst = (double)src;

        #endregion            

        #region uint8 => X

        [MethodImpl(Inline)]
        static sbyte convert(byte src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        static byte convert(byte src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        static short convert(byte src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        static ushort convert(byte src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        static int convert(byte src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        static uint convert(byte src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        static long convert(byte src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        static ulong convert(byte src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        static float convert(byte src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        static double convert(byte src, out double dst)
            => dst = (double)src;

        #endregion            

        #region int16 => X

        [MethodImpl(Inline)]
        static sbyte convert(short src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        static byte convert(short src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        static short convert(short src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        static ushort convert(short src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        static int convert(short src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        static uint convert(short src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        static long convert(short src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        static ulong convert(short src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        static float convert(short src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        static double convert(short src, out double dst)
            => dst = (double)src;

        #endregion            

        #region uint16 => X

        [MethodImpl(Inline)]
        static sbyte convert(ushort src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        static byte convert(ushort src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        static short convert(ushort src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        static ushort convert(ushort src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        static int convert(ushort src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        static uint convert(ushort src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        static long convert(ushort src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        static ulong convert(ushort src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        static float convert(ushort src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        static double convert(ushort src, out double dst)
            => dst = (double)src;

        #endregion            

        #region int32 => X

        [MethodImpl(Inline)]
        static sbyte convert(int src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        static byte convert(int src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        static short convert(int src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        static ushort convert(int src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        static int convert(int src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        static uint convert(int src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        static long convert(int src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        static ulong convert(int src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        static float convert(int src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        static double convert(int src, out double dst)
            => dst = (double)src;

        #endregion            
 
        #region uint32 => X

        [MethodImpl(Inline)]
        static sbyte convert(uint src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        static byte convert(uint src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        static short convert(uint src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        static ushort convert(uint src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        static int convert(uint src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        static uint convert(uint src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        static long convert(uint src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        static ulong convert(uint src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        static float convert(uint src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        static double convert(uint src, out double dst)
            => dst = (double)src;

        #endregion            
 
        #region int64 => X

        [MethodImpl(Inline)]
        static sbyte convert(long src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        static byte convert(long src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        static short convert(long src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        static ushort convert(long src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        static int convert(long src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        static uint convert(long src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        static long convert(long src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        static ulong convert(long src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        static float convert(long src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        static double convert(long src, out double dst)
            => dst = (double)src;

        #endregion            

        #region uint64 => X

        [MethodImpl(Inline)]
        static sbyte convert(ulong src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        static byte convert(ulong src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        static short convert(ulong src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        static ushort convert(ulong src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        static int convert(ulong src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        static uint convert(ulong src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        static long convert(ulong src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        static ulong convert(ulong src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        static float convert(ulong src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        static double convert(ulong src, out double dst)
            => dst = (double)src;

        #endregion            

        #region float32 => X

        [MethodImpl(Inline)]
        static sbyte convert(float src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        static byte convert(float src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        static short convert(float src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        static ushort convert(float src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        static int convert(float src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        static uint convert(float src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        static long convert(float src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        static ulong convert(float src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        static float convert(float src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        static double convert(float src, out double dst)
            => dst = (double)src;

        #endregion            

        #region float64 => X

        [MethodImpl(Inline)]
        static sbyte convert(double src, out sbyte dst)
            => dst = (sbyte)src;

        [MethodImpl(Inline)]
        static byte convert(double src, out byte dst)
            => dst = (byte)src;

        [MethodImpl(Inline)]
        static short convert(double src, out short dst)
            => dst = (short)src;

        [MethodImpl(Inline)]
        static ushort convert(double src, out ushort dst)
            => dst = (ushort)src;

        [MethodImpl(Inline)]
        static int convert(double src, out int dst)
            => dst = (int)src;

        [MethodImpl(Inline)]
        static uint convert(double src, out uint dst)
            => dst = (uint)src;

        [MethodImpl(Inline)]
        static long convert(double src, out long dst)
            => dst = (long)src;

        [MethodImpl(Inline)]
        static ulong convert(double src, out ulong dst)
            => dst = (ulong)src;

        [MethodImpl(Inline)]
        static float convert(double src, out float dst)
            => dst = (float)src;

        [MethodImpl(Inline)]
        static double convert(double src, out double dst)
            => dst = (double)src;

        #endregion            


        # region helpers
 
        [MethodImpl(Inline)]
        static sbyte int8<T>(T src)
            => Unsafe.As<T,sbyte>(ref src);

        [MethodImpl(Inline)]
        static ref sbyte int8<T>(ref T src)
            => ref Unsafe.As<T,sbyte>(ref src);

        [MethodImpl(Inline)]
        static byte uint8<T>(T src)
            => Unsafe.As<T,byte>(ref src);

        [MethodImpl(Inline)]
        static ref byte uint8<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

        [MethodImpl(Inline)]
        static short int16<T>(T src)
            => Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline)]
        static ref short int16<T>(ref T src)
            => ref Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline)]
        static ushort uint16<T>(T src)
            => Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline)]
        static ref ushort uint16<T>(ref T src)
            => ref Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline)]
        static int int32<T>(T src)
            => Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline)]
        static ref int int32<T>(ref T src)
            => ref Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline)]
        static uint uint32<T>(T src)
            => Unsafe.As<T,uint>(ref src);

        [MethodImpl(Inline)]
        static ref uint uint32<T>(ref T src)
            => ref Unsafe.As<T,uint>(ref src);

        [MethodImpl(Inline)]
        static long int64<T>(T src)
            => Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline)]
        static ref long int64<T>(ref T src)
            => ref Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline)]
        static ulong uint64<T>(T src)
            => Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline)]
        static ref ulong uint64<T>(ref T src)
            => ref Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline)]
        static float float32<T>(T src)
            => Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline)]
        static ref float float32<T>(ref T src)
            => ref Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline)]
        static double float64<T>(T src)
            => Unsafe.As<T,double>(ref src);

        [MethodImpl(Inline)]
        static ref double float64<T>(ref T src)
            => ref Unsafe.As<T,double>(ref src);

        [MethodImpl(Inline)]
        static T generic<T>(sbyte src)
            => Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline)]
        static ref T generic<T>(ref sbyte src)
            => ref Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline)]
        static T generic<T>(byte src)
            => Unsafe.As<byte,T>(ref src);


        [MethodImpl(Inline)]
        static ref T generic<T>(ref byte src)
            => ref Unsafe.As<byte,T>(ref src);

        [MethodImpl(Inline)]
        static T generic<T>(short src)
            => Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline)]
        static ref T generic<T>(ref short src)
            => ref Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline)]
        static T generic<T>(ushort src)
            => Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline)]
        static ref T generic<T>(ref ushort src)
            => ref Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline)]
        static T generic<T>(int src)
            => Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline)]
        static ref T generic<T>(ref int src)
            => ref Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline)]
        static T generic<T>(uint src)
            => Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline)]
        static ref T generic<T>(ref uint src)
            => ref Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline)]
        static T generic<T>(long src)
            => Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline)]
        static ref T generic<T>(ref long src)
            => ref Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline)]
        static T generic<T>(ulong src)
            => Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline)]
        static ref T generic<T>(ref ulong src)
            => ref Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline)]
        static T generic<T>(float src)
            => Unsafe.As<float,T>(ref src);


        [MethodImpl(Inline)]
        public static ref T generic<T>(ref float src)
            => ref Unsafe.As<float,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(double src)
            => Unsafe.As<double,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref double src)
            => ref Unsafe.As<double,T>(ref src);


        #endregion
 
        #region  Experimental

       [MethodImpl(Inline)]
       public static ref T to<S,T>(S src, ref T dst)
            where S : struct, IEquatable<S>
            where T : struct, IEquatable<T>            
        {
            var dstKind = PrimalKinds.kind<T>();
            switch(dstKind)
            {
                case PrimalKind.int8:
                    convert(src, ref int8(ref dst));
                break;
                case PrimalKind.uint8:
                    convert(src, ref uint8(ref dst));
                    break;
                case PrimalKind.int16:
                    convert(src, ref int16(ref dst));
                    break;
                case PrimalKind.uint16:
                    convert(src, ref uint16(ref dst));
                    break;
                case PrimalKind.int32:
                    convert(src, ref int32(ref dst));
                    break;
                case PrimalKind.uint32:
                    convert(src, ref uint32(ref dst));
                    break;
                case PrimalKind.int64:
                    convert(src, ref int64(ref dst));
                    break;
                case PrimalKind.uint64:
                    convert(src, ref uint64(ref dst));
                    break;
                case PrimalKind.float32:
                    convert(src, ref float32(ref dst));
                    break;
                case PrimalKind.float64:                
                    convert(src, ref float64(ref dst));
                break;
                default:
                    throw unsupported(dstKind);
            }

            return ref dst;
        }

        [MethodImpl(Inline)]
        public static sbyte convert<T>(T src, ref sbyte dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static byte convert<T>(T src, ref byte dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }


        [MethodImpl(Inline)]
        public static short convert<T>(T src, ref short dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static ushort convert<T>(T src, ref ushort dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static int convert<T>(T src, ref int dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static uint convert<T>(T src, ref uint dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static long convert<T>(T src, ref long dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static ulong convert<T>(T src, ref ulong dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        [MethodImpl(Inline)]
        public static float convert<T>(T src, ref float dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }


        [MethodImpl(Inline)]
        public static double convert<T>(T src, ref double dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    convert(int8(src), out dst);
                break;
                case PrimalKind.uint8:
                    convert(uint8(src), out dst);
                    break;
                case PrimalKind.int16:
                    convert(int16(src), out dst);
                    break;
                case PrimalKind.uint16:
                    convert(uint16(src), out dst);
                    break;
                case PrimalKind.int32:
                    convert(int32(src), out dst);
                    break;
                case PrimalKind.uint32:
                    convert(uint32(src), out dst);
                    break;
                case PrimalKind.int64:
                    convert(int64(src), out dst);
                    break;
                case PrimalKind.uint64:
                    convert(uint64(src), out dst);
                    break;
                case PrimalKind.float32:
                    convert(float32(src), out dst);
                    break;
                case PrimalKind.float64:                
                    convert(float64(src), out dst);
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

      #endregion
 
    }
}