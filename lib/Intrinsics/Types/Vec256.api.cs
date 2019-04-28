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

    using static zcore;
    using static inxfunc;

    public static class Vec256
    {
        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load(params byte[] src)
        {
            checklen256(src);

            fixed(byte* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load(params sbyte[] src)
        {
            checklen256(src);

            fixed(sbyte* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load(params short[] src)
        {
            checklen256(src);

            fixed(short* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load(params ushort[] src)
        {
            checklen256(src);

            fixed(ushort* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load(params int[] src)
        {
            checklen256(src);

            fixed(int* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load(params uint[] src)
        {
            checklen256(src);

            fixed(uint* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load(params long[] src)
        {
            checklen256(src);

            fixed(long* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load(params ulong[] src)
        {
            checklen256(src);

            fixed(ulong* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load(params float[] src)
        {
            checklen256(src);

            fixed(float* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load(params double[] src)
        {
            checklen256(src);

            fixed(double* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load(sbyte* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load(byte* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load(short* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load(ushort* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load(int* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load(uint* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load(long* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load(ulong* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load(float* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load(double* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> broadcast(byte* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> broadcast(sbyte* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> broadcast(short* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> broadcast(ushort* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> broadcast(int* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> broadcast(uint* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> broadcast(long* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> broadcast(ulong* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> broadcast(float* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> broadcast(double* src)
            => Avx2.BroadcastScalarToVector256(src);


        /// <summary>
        /// Constructs a 256-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source list</param>
        /// <typeparam name="T">The primitive type</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe Vec256<T> define<T>(Index<T> data)
            where T : struct, IEquatable<T>
        {            

            var len = Vec256<T>.Length;
            
            if(typematch<T,sbyte>())            
            {
                var src = datasource<sbyte>(data,len);
                var dst =  stackalloc sbyte[len];
                return castref<Vector256<T>>(copy(src,dst));
            }

            if(typematch<T,byte>())            
            {
                var src = datasource<byte>(data,len);
                var dst =  stackalloc byte[len];
                return castref<Vector256<T>>(copy(src,dst));
            }

            if(typematch<T,short>())            
            {
                var src = datasource<short>(data,len);
                var dst =  stackalloc short[len];
                return castref<Vector256<T>>(copy(src,dst));
            }

            if(typematch<T,ushort>())            
            {
                var src = datasource<ushort>(data,len);
                var dst =  stackalloc ushort[len];
                return castref<Vector256<T>>(copy(src,dst));
            }

            if(typematch<T,int>())            
            {
                var src = datasource<int>(data,len);
                var dst =  stackalloc int[len];
                return castref<Vector256<T>>(copy(src,dst));
            }

            if(typematch<T,uint>())            
            {
                var src = datasource<uint>(data,len);
                var dst =  stackalloc uint[len];
                return castref<Vector256<T>>(copy(src,dst));
            }

            if(typematch<T,long>())            
            {
                var src = datasource<long>(data,len);
                var dst =  stackalloc long[len];
                return castref<Vector256<T>>(copy(src,dst));
            }

            if(typematch<T,ulong>())            
            {
                var src = datasource<ulong>(data,len);
                var dst =  stackalloc ulong[len];
                return castref<Vector256<T>>(copy(src,dst));
            }

            if(typematch<T,float>())            
            {
                var src = datasource<float>(data,len);
                var dst =  stackalloc float[len];
                return castref<Vector256<T>>(copy(src,dst));
            }

            if(typematch<T,double>())            
            {
                var src = datasource<double>(data,len);
                var dst =  stackalloc double[len];
                return castref<Vector256<T>>(copy(src,dst));
            }

            throw new NotSupportedException();

        }        

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> define(
            sbyte x0, sbyte x1, sbyte x2, sbyte x3,  
            sbyte x4, sbyte x5, sbyte x6, sbyte x7, 
            sbyte x8, sbyte x9, sbyte x10, sbyte x11,
            sbyte x12, sbyte x13, sbyte x14, sbyte x15,
            sbyte x16, sbyte x17, sbyte x18, sbyte x19,  
            sbyte x20, sbyte x21, sbyte x22, sbyte x23, 
            sbyte x24, sbyte x25, sbyte x26, sbyte x27,
            sbyte x28, sbyte x29, sbyte x30, sbyte x31

            )
        {
            var raw = stackalloc sbyte[]{
                 x0,x1,x2,x3,x4,x5,x6,x7,
                 x8,x9,x10,x11,x12,x13,x14,x15,
                 x16,x17,x18,x19,x20,x21,x22,x23,
                 x24,x25,x26,x27,x28,x29,x30,x31
                 };
            return castref<Vector256<sbyte>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> define(
            byte x0, byte x1, byte x2, byte x3,  
            byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11,
            byte x12, byte x13, byte x14, byte x15,
            byte x16, byte x17, byte x18, byte x19,  
            byte x20, byte x21, byte x22, byte x23, 
            byte x24, byte x25, byte x26, byte x27,
            byte x28, byte x29, byte x30, byte x31

            )
        {
            var raw = stackalloc byte[]{
                 x0,x1,x2,x3,x4,x5,x6,x7,
                 x8,x9,x10,x11,x12,x13,x14,x15,
                 x16,x17,x18,x19,x20,x21,x22,x23,
                 x24,x25,x26,x27,x28,x29,x30,x31
                 };
            return castref<Vector256<byte>>(raw);                        
        }


        [MethodImpl(Inline)]
        public static unsafe Vec256<short> define(
            short x0, short x1, short x2, short x3,  
            short x4, short x5, short x6, short x7, 
            short x8, short x9, short x10, short x11,
            short x12, short x13, short x14, short x15
            )
        {
            var raw = stackalloc short[]{
                 x0,x1,x2,x3,x4,x5,x6,x7,
                 x8,x9,x10,x11,x12,x13,x14,x15
            };

            return castref<Vector256<short>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> define(
            ushort x0, ushort x1, ushort x2, ushort x3,  
            ushort x4, ushort x5, ushort x6, ushort x7, 
            ushort x8, ushort x9, ushort x10, ushort x11,
            ushort x12, ushort x13, ushort x14, ushort x15
            )
        {
            var raw = stackalloc ushort[]{
                 x0,x1,x2,x3,x4,x5,x6,x7,
                 x8,x9,x10,x11,x12,x13,x14,x15
            };
            
            return castref<Vector256<ushort>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> define(
            int x0, int x1, int x2, int x3,  
            int x4, int x5, int x6, int x7 
            )
        {
            var raw = stackalloc int[]{
                 x0,x1,x2,x3,x4,x5,x6,x7
            };

            return castref<Vector256<int>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> define(
            uint x0, uint x1, uint x2, uint x3,  
            uint x4, uint x5, uint x6, uint x7 
            )
        {
            var raw = stackalloc uint[]{
                 x0,x1,x2,x3,x4,x5,x6,x7
            };

            return castref<Vector256<uint>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> define(long x0, long x1, long x2, long x3)
        {
            var raw = stackalloc long[]{x0,x1,x2,x3};
            return castref<Vector256<long>>(raw);                        
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> define(ulong x0, ulong x1, ulong x2, ulong x3)
        {
            var raw = stackalloc ulong[]{x0,x1,x2,x3};
            return castref<Vector256<ulong>>(raw);                        
        }

       [MethodImpl(Inline)]
        public static unsafe Vec256<float> define(
            float x0, float x1, float x2, float x3,  
            float x4, float x5, float x6, float x7 
            )
        {
            var raw = stackalloc float[]{
                 x0,x1,x2,x3,x4,x5,x6,x7
            };

            return castref<Vector256<float>>(raw);                        
        }

 
        [MethodImpl(Inline)]
        public static unsafe Vec256<double> define(double x0, double x1, double x2, double x3)
        {
            var raw = stackalloc double[]{x0,x1,x2,x3};
            return castref<Vector256<double>>(raw);                        
        }

        public static IEnumerable<Vec256<T>> stream<T>(IEnumerable<T> src)
            where T : struct, IEquatable<T>
        {
            var len = Vec256<T>.Length;
            foreach(var components in src.Partition(len))
            {
                if(components.Count != len)
                    break;
                yield return define<T>(components);                    
            }            
        }
    }
 
}