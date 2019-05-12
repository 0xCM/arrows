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

    
    using static mfunc;
    using static As;

    public static class Converters
    {
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

        static sbyte convert<T>(T src, out sbyte dst)
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

        public static T convert<T>(sbyte src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = As.generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = As.generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = As.generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = As.generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = As.generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = As.generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = As.generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = As.generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = As.generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = As.generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        static byte convert<T>(T src, out byte dst)
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

        public static T convert<T>(byte src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = As.generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = As.generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = As.generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = As.generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = As.generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = As.generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = As.generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = As.generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = As.generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = As.generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        static short convert<T>(T src, out short dst)
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

        public static T convert<T>(short src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = As.generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = As.generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = As.generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = As.generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = As.generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = As.generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = As.generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = As.generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = As.generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = As.generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        static ushort convert<T>(T src, out ushort dst)
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

        public static T convert<T>(ushort src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = As.generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = As.generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = As.generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = As.generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = As.generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = As.generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = As.generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = As.generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = As.generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = As.generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        static int convert<T>(T src, out int dst)
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

        public static T convert<T>(int src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = As.generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = As.generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = As.generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = As.generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = As.generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = As.generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = As.generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = As.generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = As.generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = As.generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        static uint convert<T>(T src, out uint dst)
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

        public static T convert<T>(uint src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = As.generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = As.generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = As.generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = As.generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = As.generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = As.generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = As.generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = As.generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = As.generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = As.generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        static long convert<T>(T src, out long dst)
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

        public static T convert<T>(long src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = As.generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = As.generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = As.generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = As.generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = As.generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = As.generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = As.generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = As.generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = As.generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = As.generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        static ulong convert<T>(T src, out ulong dst)
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

        public static T convert<T>(ulong src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = As.generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = As.generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = As.generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = As.generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = As.generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = As.generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = As.generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = As.generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = As.generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = As.generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        static float convert<T>(T src, out float dst)
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

        public static T convert<T>(float src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = As.generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = As.generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = As.generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = As.generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = As.generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = As.generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = As.generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = As.generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = As.generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = As.generic<T>(convert(src, out double f64));
                break;
                default:
                    throw unsupported(kind);
            }
                            
           return dst;            
        }

        static double convert<T>(T src, out double dst)
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

        public static T convert<T>(double src, out T dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                  dst = As.generic<T>(convert(src, out sbyte i8));
                break;
                case PrimalKind.uint8:
                  dst = As.generic<T>(convert(src, out byte u8));
                    break;
                case PrimalKind.int16:
                  dst = As.generic<T>(convert(src, out short i16));
                    break;
                case PrimalKind.uint16:
                  dst = As.generic<T>(convert(src, out ushort u16));
                    break;
                case PrimalKind.int32:
                  dst = As.generic<T>(convert(src, out int i32));
                    break;
                case PrimalKind.uint32:
                  dst = As.generic<T>(convert(src, out uint u32));
                    break;
                case PrimalKind.int64:
                  dst = As.generic<T>(convert(src, out long i64));
                    break;
                case PrimalKind.uint64:
                  dst = As.generic<T>(convert(src, out ulong u64));
                    break;
                case PrimalKind.float32:
                  dst = As.generic<T>(convert(src, out float f32));
                    break;
                case PrimalKind.float64:                
                  dst = As.generic<T>(convert(src, out double f64));
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


    }
}