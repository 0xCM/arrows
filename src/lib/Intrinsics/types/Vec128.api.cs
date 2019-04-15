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
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    using static x86;

    public partial class Vec128
    {

        // [MethodImpl(Inline)]
        // public static unsafe Vec128<T> define<T>(IReadOnlyList<T> src)
        //     where T : struct, IEquatable<T>
        // {
        //     void* vec = typecode<T>() switch 
        //     {
        //         TypeCode.SByte => i8vec(src, 16),
        //         TypeCode.Byte => u8vec(src, 16),
        //         TypeCode.Int16 => i16vec(src, 8),
        //         TypeCode.UInt16 => u16vec(src, 8),
        //         TypeCode.Int32 => i32vec(src, 4),
        //         TypeCode.UInt32 => u32vec(src, 4),
        //         TypeCode.Int64 => i64vec(src, 2),
        //         TypeCode.UInt64 => u64vec(src, 2),
        //         TypeCode.Single => f32vec(src, 4),
        //         TypeCode.Double => f64vec(src,2),
        //         _ => throw new NotSupportedException()
        //     };        

        //     return castref<Vector128<T>>(vec);                    
        // }        


        /// <summary>
        /// Constructs a 128-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source list</param>
        /// <typeparam name="T">The primitive type</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe Vec128<T> define<T>(IReadOnlyList<T> data)
            where T : struct, IEquatable<T>
        {            

            var len = Vec128<T>.Length;
            
            if(typematch<T,sbyte>())            
            {
                var src = datasource<sbyte>(data,len);
                var dst =  stackalloc sbyte[len];
                return castref<Vector128<T>>(copy(src,dst));
            }

            if(typematch<T,byte>())            
            {
                var src = datasource<byte>(data,len);
                var dst =  stackalloc byte[len];
                return castref<Vector128<T>>(copy(src,dst));
            }

            if(typematch<T,short>())            
            {
                var src = datasource<short>(data,len);
                var dst =  stackalloc short[len];
                return castref<Vector128<T>>(copy(src,dst));
            }

            if(typematch<T,ushort>())            
            {
                var src = datasource<ushort>(data,len);
                var dst =  stackalloc ushort[len];
                return castref<Vector128<T>>(copy(src,dst));
            }

            if(typematch<T,int>())            
            {
                var src = datasource<int>(data,len);
                var dst =  stackalloc int[len];
                return castref<Vector128<T>>(copy(src,dst));
            }

            if(typematch<T,uint>())            
            {
                var src = datasource<uint>(data,len);
                var dst =  stackalloc uint[len];
                return castref<Vector128<T>>(copy(src,dst));
            }

            if(typematch<T,long>())            
            {
                var src = datasource<long>(data,len);
                var dst =  stackalloc long[len];
                return castref<Vector128<T>>(copy(src,dst));
            }

            if(typematch<T,ulong>())            
            {
                var src = datasource<ulong>(data,len);
                var dst =  stackalloc ulong[len];
                return castref<Vector128<T>>(copy(src,dst));
            }

            if(typematch<T,float>())            
            {
                var src = datasource<float>(data,len);
                var dst =  stackalloc float[len];
                return castref<Vector128<T>>(copy(src,dst));
            }

            if(typematch<T,double>())            
            {
                var src = datasource<double>(data,len);
                var dst =  stackalloc double[len];
                return castref<Vector128<T>>(copy(src,dst));
            }

            throw new NotSupportedException();

        }        

    
        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> define(
            byte x0, byte x1, byte x2, byte x3,  
            byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11,
            byte x12, byte x13, byte x14, byte x15
            )
        {
            var raw = stackalloc byte[]{
                x0,x1,x2,x3,x4,x5,x6,x7,
                x8,x9,x10,x11,x12,x13,x14,x15
                };
            return castref<Vector128<byte>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> define(sbyte x0, sbyte x1, sbyte x2, sbyte x3, 
                sbyte x4, sbyte x5, sbyte x6, sbyte x7,
                sbyte x8, sbyte x9, sbyte x10, sbyte x11,
                sbyte x12, sbyte x13, sbyte x14, sbyte x15)
        {
            var raw = stackalloc sbyte[]{
                    x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15
                    };
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


        [MethodImpl(Inline)]
        public static Vec128<byte> load(byte[] src, int startpos = 0)
            => InX.load(src,startpos);

        [MethodImpl(Inline)]
        public static Vec128<byte> load(Span128<byte> src, int startpos = 0)
            => InX.load(src,startpos);


        [MethodImpl(Inline)]
        public static Vec128<int> load(int[] src, int startpos = 0)
            => InX.load(src,startpos);

        [MethodImpl(Inline)]
        public static Vec128<int> load(Span128<int> src, int startpos = 0)
            => InX.load(src,startpos);

        [MethodImpl(Inline)]
        public static Vec128<uint> load(Span128<uint> src, int startpos = 0)
            => InX.load(src,startpos);


        [MethodImpl(Inline)]
        public static Vec128<long> load(Span128<long> src, int startpos = 0)
            => InX.load(src,startpos);


        [MethodImpl(Inline)]
        public static Vec128<ulong> load(Span128<ulong> src, int startpos = 0)
            => InX.load(src,startpos);


        [MethodImpl(Inline)]
        public static Vec128<float> load(Span128<float> src, int startpos = 0)
            => InX.load(src,startpos);

        [MethodImpl(Inline)]
        public static Vec128<double> load(double[] src, int startpos)
            => InX.load(src,startpos);

        [MethodImpl(Inline)]
        public static Vec128<double> load(Span128<double> src, int startpos = 0)
            => InX.load(src,startpos);

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
 
    }

    partial class xcore
    {

        /// <summary>
        ///  Constructs a 128-bit vector from components taken from the head of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> NextVec128(this IEnumerable<sbyte> src)
            => Vec128.define(src.Freeze(Vec128<sbyte>.Length));

        /// <summary>
        /// Constructs a 128-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source lit</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> ToVec128(this IReadOnlyList<sbyte> src)
            => Vec128.define(src);

        /// <summary>
        ///  Constructs a 128-bit vector from components taken from the head of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static Vec128<short> NextVec128(this IEnumerable<short> src)
                => Vec128.define(src.Freeze(Vec128<short>.Length));

        /// <summary>
        /// Constructs a 128-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source lit</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<short> ToVec128(this IReadOnlyList<short> src)
                => Vec128.define(src);

       /// <summary>
        ///  Constructs a 128-bit vector from components taken from the head of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> NextVec128(this IEnumerable<ushort> src)
                => Vec128.define(src.Freeze(Vec128<ushort>.Length));

        /// <summary>
        /// Constructs a 128-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source lit</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<ushort> ToVec128(this IReadOnlyList<ushort> src)
                => Vec128.define(src);

        /// <summary>
        ///  Constructs a 128-bit vector from components taken from the head of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static Vec128<int> NextVec128(this IEnumerable<int> src)
                => Vec128.define(src.Freeze(Vec128<int>.Length));

        /// <summary>
        /// Constructs a 128-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source lit</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<int> ToVec128(this IReadOnlyList<int> src)
                => Vec128.define(src);

        /// <summary>
        ///  Constructs a 128-bit vector from components taken from the head of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> NextVec128(this IEnumerable<uint> src)
                => Vec128.define(src.Freeze(Vec128<uint>.Length));

        /// <summary>
        /// Constructs a 128-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source lit</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<uint> ToVec128(this IReadOnlyList<uint> src)
                => Vec128.define(src);

        /// <summary>
        ///  Constructs a 128-bit vector from components taken from the head of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static Vec128<long> NextVec128(this IEnumerable<long> src)
                => Vec128.define(src.Freeze(Vec128<long>.Length));

        /// <summary>
        /// Constructs a 128-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source lit</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<long> ToVec128(this IReadOnlyList<long> src)
                => Vec128.define(src);

        /// <summary>
        ///  Constructs a 128-bit vector from components taken from the head of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> NextVec128(this IEnumerable<ulong> src)
                => Vec128.define(src.Freeze(Vec128<ulong>.Length));

        /// <summary>
        /// Constructs a 128-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source lit</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<ulong> ToVec128(this IReadOnlyList<ulong> src)
                => Vec128.define(src);

        /// <summary>
        ///  Constructs a 128-bit vector from components taken from the head of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static Vec128<float> NextVec128(this IEnumerable<float> src)
                => Vec128.define(src.Freeze(Vec128<float>.Length));

        /// <summary>
        /// Constructs a 128-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source lit</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<float> ToVec128(this IReadOnlyList<float> src)
                => Vec128.define(src);

        /// <summary>
        ///  Constructs a 128-bit vector from components taken from the head of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static Vec128<double> NextVec128(this IEnumerable<double> src)
                => Vec128.define(src.Freeze(Vec128<double>.Length));

        /// <summary>
        /// Constructs a 128-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source lit</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<double> ToVec128(this IReadOnlyList<double> src)
                => Vec128.define(src);

    }
}