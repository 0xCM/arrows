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

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using NumVec = System.Numerics.Vector;

    using static zcore;
    using static x86;
    using static System.TypeCode;

    partial class Vec128
    {

        [MethodImpl(Inline)]
        internal static T element<T>(Vector128<T> src, int idx)
            where T : struct, IEquatable<T>
        {
            ref T e0 = ref Unsafe.As<Vector128<T>, T>(ref src);                    
            return Unsafe.Add(ref e0, idx);           
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> define(byte x0, byte x1, byte x2, byte x3, 
            byte x4, byte x5, byte x6, byte x7,
            byte x8, byte x9, byte x10, byte x11,
            byte x12, byte x13, byte x14, byte x15)
        {
            var raw = stackalloc byte[]{x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15};
            return castref<Vector128<byte>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> define(sbyte x0, sbyte x1, sbyte x2, sbyte x3, 
                sbyte x4, sbyte x5, sbyte x6, sbyte x7,
                sbyte x8, sbyte x9, sbyte x10, sbyte x11,
                sbyte x12, sbyte x13, sbyte x14, sbyte x15)
        {
            var raw = stackalloc sbyte[]{x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15};
            return castref<Vector128<sbyte>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> define(short x0, short x1, short x2, short x3, 
                short x4, short x5, short x6, short x7)
        {
            var raw = stackalloc short[]{x0,x1,x2,x3,x4,x5,x6,x7};
            return castref<Vector128<short>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> define(ushort x0, ushort x1, ushort x2, ushort x3, 
                ushort x4, ushort x5, ushort x6, ushort x7)
        {
            var raw = stackalloc ushort[]{x0,x1,x2,x3,x4,x5,x6,x7};
            return castref<Vector128<ushort>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> define(int x0, int x1, int x2, int x3)
        {
            var raw = stackalloc int[]{x0,x1,x2,x3};
            return castref<Vector128<int>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> define(uint x0, uint x1, uint x2, uint x3)
        {
            var raw = stackalloc uint[]{x0,x1,x2,x3};
            return castref<Vector128<uint>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> define(long x0, long x1)
        {
            var raw = stackalloc long[]{x0,x1};
            return castref<Vector128<long>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> define(ulong x0, ulong x1)
        {
            var raw = stackalloc ulong[]{x0,x1}; 
            return castref<Vector128<ulong>>(raw);            
            
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> define(float x0, float x1, float x2, float x3)
        {
            var raw = stackalloc float[]{x0,x1,x2,x3};
            return castref<Vector128<float>>(raw);            
            
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> define(double x0, double x1)
        {
            var raw = stackalloc double[]{x0,x1};
            return castref<Vector128<double>>(raw);            
            
        }

        /// <summary>
        /// Defines a vector stream predicated on a stream of component values
        /// </summary>
        /// <param name="src">The component source</param>
        /// <typeparam name="T">The component type</typeparam>
        public static IEnumerable<Vec128<T>> stream<T>(IEnumerable<T> src)
            where T : struct, IEquatable<T>
        {
            var len = Vec128<T>.Length;
            foreach(var components in src.Partition(len))
            {
                if(components.Count != len)
                    break;
                yield return define<T>(components);                    
            }            
        }


        [MethodImpl(Inline)]
        public static unsafe Scalar128<T> scalar<T>(T value)
            where T : struct, IEquatable<T>
        {
            void* scalar = typecode<T>() switch 
            {
                TypeCode.SByte => i8scalar(value),
                TypeCode.Byte => u8scalar(value),
                TypeCode.Int16 => i16scalar(value),
                TypeCode.UInt16 => u16scalar(value),
                TypeCode.Int32 => i32scalar(value),
                TypeCode.UInt32 => u32scalar(value),
                TypeCode.Int64 => i64scalar(value),
                TypeCode.UInt64 => u64scalar(value),
                TypeCode.Single => f32scalar(value),
                TypeCode.Double => f64scalar(value),
                _ => throw new NotSupportedException()
            };        

            return castref<Vector128<T>>(scalar);                    
         }

        [MethodImpl(Inline)]
        public static unsafe Vec128<T> define<T>(IReadOnlyList<T> src)
            where T : struct, IEquatable<T>
        {
            void* vec = typecode<T>() switch 
            {
                TypeCode.SByte => i8vec(src),
                TypeCode.Byte => u8vec(src),
                TypeCode.Int16 => i16vec(src),
                TypeCode.UInt16 => u16vec(src),
                TypeCode.Int32 => i32vec(src),
                TypeCode.UInt32 => u32vec(src),
                TypeCode.Int64 => i64vec(src),
                TypeCode.UInt64 => u64vec(src),
                TypeCode.Single => f32vec(src),
                TypeCode.Double => f64vec(src),
                _ => throw new NotSupportedException()
            };        

            return castref<Vector128<T>>(vec);                    
        }
 
 

        [MethodImpl(Inline)]
        static unsafe void* i8scalar(object value)
        {
            var dst =  stackalloc sbyte[16];
            dst[0] = cast<sbyte>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        static unsafe void* i8vec(object src)
        {
            var dst =  stackalloc sbyte[16];
            copy((IReadOnlyList<sbyte>)src,dst);
            return dst;            
        }

        [MethodImpl(Inline)]
        static unsafe void* u8scalar(object value)
        {
            var dst =  stackalloc byte[16];
            dst[0] = cast<byte>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        static unsafe void* u8vec(object src)
        {
            var dst =  stackalloc byte[16];
            copy((IReadOnlyList<byte>)src,dst);
            return dst;            
        }

        [MethodImpl(Inline)]
        static unsafe void* i16vec(object src)
        {
            var dst =  stackalloc short[8];
            copy((IReadOnlyList<short>)src,dst);
            return dst;            
        }

        [MethodImpl(Inline)]
        static unsafe void* i16scalar(object value)
        {
            var dst =  stackalloc short[8];
            dst[0] = cast<short>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        static unsafe void* u16scalar(object value)
        {
            var dst =  stackalloc ushort[8];
            dst[0] = cast<ushort>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        static unsafe void* u16vec(object src)
        {
            var dst =  stackalloc ushort[8];
            copy((IReadOnlyList<ushort>)src,dst);
            return dst;            
        }

        [MethodImpl(Inline)]
        static unsafe void* i32scalar(object value)
        {
            var dst =  stackalloc int[4];
            dst[0] = cast<int>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        static unsafe void* i32vec(object src)
        {
            var dst =  stackalloc int[4];
            copy((IReadOnlyList<int>)src,dst);
            return dst;            
        }

        [MethodImpl(Inline)]
        static unsafe void* u32scalar(object value)
        {
            var dst =  stackalloc uint[4];
            dst[0] = cast<uint>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        static unsafe void* u32vec(object src)
        {
            var dst =  stackalloc uint[4];
            copy((IReadOnlyList<uint>)src,dst);
            return dst;            
        }

        [MethodImpl(Inline)]
        static unsafe void* i64scalar(object value)
        {
            var dst =  stackalloc long[2];
            dst[0] = cast<long>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        static unsafe void* i64vec(object src)
        {
            var dst =  stackalloc long[2];
            copy((IReadOnlyList<long>)src,dst);
            return dst;            
        }

        [MethodImpl(Inline)]
        static unsafe void* u64scalar(object value)
        {
            var dst =  stackalloc ulong[2];
            dst[0] = cast<ulong>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        static unsafe void* u64vec(object src)
        {
            var dst =  stackalloc ulong[2];
            copy((IReadOnlyList<ulong>)src,dst);
            return dst;            
        }

        [MethodImpl(Inline)]
        static unsafe void* f32scalar(object value)
        {
            var dst =  stackalloc float[4];
            dst[0] = cast<float>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        static unsafe void* f32vec(object src)
        {
            var dst =  stackalloc float[4];
            copy((IReadOnlyList<float>)src,dst);
            return dst;            
        }

        [MethodImpl(Inline)]
        static unsafe void* f64scalar(object value)
        {
            var dst =  stackalloc double[2];
            dst[0] = cast<double>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        static unsafe void* f64vec(object src)
        {
            var dst =  stackalloc double[2];
            copy((IReadOnlyList<double>)src,dst);
            return dst;            
        }

 
    }

}