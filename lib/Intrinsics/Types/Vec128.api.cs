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
    using static inxfunc;

    public partial class Vec128
    {



        [MethodImpl(Inline)]
        public static Vec128<T> zero<T>()
            where T : struct, IEquatable<T>                    
            => Vector128<T>.Zero;

        [MethodImpl(Inline)]
        public static Vec128<T> define<T>(Vector128<T> src)
            where T : struct, IEquatable<T>            
                => src.ToVec128();

        [MethodImpl(Inline)]
        public static unsafe Vec128<T> define<T>(T[] src, int offset = 0)
            where T : struct, IEquatable<T>
        {            

            var i = offset;

            if(typematch<T,sbyte>())            
                return vInt8(src,offset);

            if(typematch<T,byte>())            
                return vUInt8(src,offset);

            if(typematch<T,short>())            
                return vInt16(src,offset);

            if(typematch<T,ushort>())            
                return VUint16(src,offset);

            if(typematch<T,int>())            
                return vInt32(src,offset);

            if(typematch<T,uint>())            
                return vUInt32(src,offset);

            if(typematch<T,long>())            
                return vInt64(src,offset);

            if(typematch<T,ulong>())            
                return vUInt64(src,offset);

            if(typematch<T,float>())            
                return vFloat32(src,offset);

            if(typematch<T,double>())            
                return vFloat64(src,offset);

            throw new NotSupportedException();

        }        

        

        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(Index<T> src)
            where T : struct, IEquatable<T>            
                => define<T>(src.ToArray(),0);

        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(T[] src)
            where T : struct, IEquatable<T>            
                => define<T>(src,0);


        [MethodImpl(Inline)]
        public static Vec128<T> define<T>(ArraySegment<T> src)
            where T : struct, IEquatable<T>            
                => define<T>(src.Array,src.Offset);

        [MethodImpl(Inline)]
        public static Index<Vec128<T>> define<T>(T[] src)
            where T : struct, IEquatable<T>
        {
            var vecLen = Vec128<T>.Length;
            var vecCount = src.Length / vecLen;
            if(src.Length % vecCount != 0)
               throw errseglen(src);
            var segments = src.Partition(vecLen);
            var dst =  new Vec128<T>[vecCount];

            var i =0;
            foreach(var seg in segments)
                dst[i++] = define(seg);

            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> define(byte x0)
            => Vector128.Create(x0);


        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> define(
            byte x0, byte x1, byte x2, byte x3,  
            byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11,
            byte x12, byte x13, byte x14, byte x15) 
                =>  Vector128.Create(x0, x1, x2, x3, x4, x5, x6, x7, 
                    x8, x9, x10, x11,x12, x13, x14, x15);


        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> define(sbyte x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> define(sbyte x0, sbyte x1, sbyte x2, sbyte x3, 
                sbyte x4, sbyte x5, sbyte x6, sbyte x7,
                sbyte x8, sbyte x9, sbyte x10, sbyte x11,
                sbyte x12, sbyte x13, sbyte x14, sbyte x15)
                    => Vector128.Create(x0, x1, x2, x3, x4, x5, x6, x7, 
                        x8, x9, x10, x11,x12, x13, x14, x15);


        [MethodImpl(Inline)]
        public static unsafe Vec128<short> define(short x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> define(
                short x0, short x1, short x2, short x3, 
                short x4, short x5, short x6, short x7) 
                    => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> define(ushort x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> define(ushort x0, ushort x1, ushort x2, ushort x3, 
                ushort x4, ushort x5, ushort x6, ushort x7)
                    => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> define(int x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> define(int x0, int x1, int x2, int x3)
            => Vector128.Create(x0,x1,x2,x3);

        
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> define(uint x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> define(uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0,x1,x2,x3);

        
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> define(long x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> define(long x0, long x1)
            => Vector128.Create(x0,x1);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> define(ulong x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> define(ulong x0, ulong x1)
            => Vector128.Create(x0,x1);

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> define(float x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<float> define(float x0, float x1, float x2, float x3)
            => Vector128.Create(x0,x1,x2,x3);
    
        [MethodImpl(Inline)]
        public static unsafe Vec128<double> define(double x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> define(double x0, double x1)
            => Vector128.Create(x0,x1);

        [MethodImpl(Inline)]
        public static Vec128<byte> define(byte[] src, int startpos = 0)
            => InX.load(src,startpos);

        [MethodImpl(Inline)]
        public static Vec128<int> define(int[] src, int startpos = 0)
            => InX.load(src,startpos);

        [MethodImpl(Inline)]
        public static Vec128<double> define(double[] src, int startpos)
            => InX.load(src,startpos);

        [MethodImpl(Inline)]
        public static Vec128<byte> define(Span128<byte> src)
            => InX.load(src);

        [MethodImpl(Inline)]
        public static Vec128<int> define(Span128<int> src)
            => InX.load(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> define(Span128<uint> src)
            => InX.load(src);

        [MethodImpl(Inline)]
        public static Vec128<long> define(Span128<long> src)
            => InX.load(src);

        [MethodImpl(Inline)]
        public static Vec128<ulong> define(Span128<ulong> src)
            => InX.load(src);

        [MethodImpl(Inline)]
        public static Vec128<float> define(Span128<float> src)
            => InX.load(src);

        [MethodImpl(Inline)]
        public static Vec128<double> define(Span128<double> src)
            => InX.load(src);

        public static IEnumerable<Vec128<T>> stream<T>(T[] src)
            where T : struct, IEquatable<T>
        {
            foreach(var segment in src.Partition(Vec128<T>.Length))
                yield return define<T>(segment);                    
        }
 
        public static IEnumerable<Vec128<T>> stream<T>(Index<T> src)
            where T : struct, IEquatable<T>
                => stream<T>(src.ToArray());
 
        [MethodImpl(Inline)]
        static Vec128<T> vInt8<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>
        {
            var i = startpos;
            var src = datasource<sbyte>(data, data.Length,startpos);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
            );
            return cast<Vec128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt8<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>
        {
            var i = startpos;
            var src = datasource<byte>(data, data.Length,startpos);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
            );
            return cast<Vec128<T>>(dst);
        }


        [MethodImpl(Inline)]
        static Vec128<T> vInt16<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = datasource<short>(data,data.Length,startpos);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
                );
            return cast<Vec128<T>>(dst);

        }

        [MethodImpl(Inline)]
        static Vec128<T> VUint16<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = datasource<ushort>(data,data.Length,startpos);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
                );
            return cast<Vec128<T>>(dst);

        }

        [MethodImpl(Inline)]
        static Vec128<T> vInt32<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = datasource<int>(data,data.Length,startpos);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return cast<Vec128<T>>(dst);

        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt32<T>(T[] data, int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = datasource<uint>(data, data.Length, startpos);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return cast<Vec128<T>>(dst);

        }

        [MethodImpl(Inline)]
        static Vec128<T> vInt64<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = datasource<long>(data,data.Length,startpos);
            var dst = define(src[i++],src[i++]);
            return cast<Vec128<T>>(dst);

        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt64<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = datasource<ulong>(data,data.Length,startpos);
            var dst = define(src[i++],src[i++]);
            return cast<Vec128<T>>(dst);

        }

        static Vec128<T> vFloat32x<T>(T[] data, int offset = 0)
            where T : struct, IEquatable<T>            
        {
            var src = datasource<float>(data,data.Length,offset);            
            var result = Vector128.CreateScalarUnsafe(src[0]);
            result = Sse41.Insert(result, Vector128.CreateScalarUnsafe(src[1]), 0x10);
            result = Sse41.Insert(result, Vector128.CreateScalarUnsafe(src[2]), 0x20);
            result = Sse41.Insert(result, Vector128.CreateScalarUnsafe(src[3]), 0x30);
            return cast<Vector128<T>>(result);

        }

        [MethodImpl(Inline)]
        static Vec128<T> vFloat32<T>(T[] data, int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = datasource<float>(data,data.Length,startpos);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return cast<Vec128<T>>(dst);

        }

        [MethodImpl(Inline)]
        static Vec128<T> vFloat64<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = datasource<double>(data,data.Length,startpos);
            var dst = define(src[i++],src[i++]);
            return cast<Vec128<T>>(dst);

        }

    }

}