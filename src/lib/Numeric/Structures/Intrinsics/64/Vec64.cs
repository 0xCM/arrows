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

    using NumVec = System.Numerics.Vector;

    public static class Vec64
    {
        static unsafe Vector64<T> i8<T>()
            where T : struct, IEquatable<T>
        {
            var raw = stackalloc sbyte[8];            
            var vec = Unsafe.AsRef<Vector64<T>>(raw);
            return vec;
        }

        static unsafe Vector64<T> u8<T>()
            where T : struct, IEquatable<T>
        {
            var raw = stackalloc byte[8];            
            var vec = Unsafe.AsRef<Vector64<T>>(raw);
            
            return vec;
        }

        static unsafe Vector64<T> u16<T>()
            where T : struct, IEquatable<T>
        {
            var raw = stackalloc ushort[4];            
            var data = Unsafe.AsRef<Vector64<T>>(raw);
            return data;
        }

        static unsafe Vector64<T> u32<T>(params T[] src)
            where T : struct, IEquatable<T>
        {
            var raw = stackalloc uint[2];            
            var data = Unsafe.AsRef<Vector64<T>>(raw);                        
            return data;
        }

        static unsafe Vec64<T> u64<T>(params T[] src)
            where T : struct, IEquatable<T>
        {
            var raw = stackalloc ulong[2];            
            var data = Unsafe.AsRef<Vec64<T>>(raw);
            return data;
        }

        [MethodImpl(Inline)]
        static unsafe T castref<T>(void* src)
            => Unsafe.AsRef<T>(src);

        [MethodImpl(Inline)]
        public static unsafe Vec64<sbyte> define(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7)
        {
            var data = stackalloc sbyte[]{x0,x1,x2,x3,x4,x5,x6,x7};
            return new Vec64<sbyte>(castref<Vector64<sbyte>>(data));
        }

        [MethodImpl(Inline)]
        public static IEnumerable<Vec64<sbyte>> define(IEnumerable<sbyte> src)
        {
            var partcount = Vector64<sbyte>.Count;
            foreach(var part in src.Partition(partcount))
            {
                if(part.Count == 0)
                {
                    var i = 0;
                    yield return define(
                        part[i++], part[i++],part[i++],part[i++],
                        part[i++], part[i++],part[i++],part[i++]
                        );
                }
                else
                {
                    throw new Exception("Size mismatch");
                }                    
            }

        }


        [MethodImpl(Inline)]
        public static unsafe Vec64<byte> define(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {
            var data = stackalloc byte[]{x0,x1,x2,x3,x4,x5,x6,x7};
            return new Vec64<byte>(castref<Vector64<byte>>(data));
        }

        [MethodImpl(Inline)]
        public static unsafe Vec64<short> define(short x0, short x1, short x2, short x3)
        {
            var data = stackalloc short[]{x0,x1,x2,x3};
            return new Vec64<short>(castref<Vector64<short>>(data));
        }

        [MethodImpl(Inline)]
        public static unsafe Vec64<ushort> define(ushort x0, ushort x1, ushort x2, ushort x3)
        {
            var data = stackalloc ushort[]{x0,x1,x2,x3};
            return new Vec64<ushort>(castref<Vector64<ushort>>(data));
        }


        [MethodImpl(Inline)]
        public static unsafe Vec64<int> define(int x0, int x1)
        {
            var data = stackalloc int[]{x0,x1};
            return new Vec64<int>(castref<Vector64<int>>(data));
        }

        [MethodImpl(Inline)]
        public static IReadOnlyList<Vec64<int>> define(IReadOnlyList<int> src)
        {
            if(src.Count % 2 != 0)
                throw new Exception("Size mismatch");

            var dst = new Vec64<int>[src.Count / 2];
            var parts = src.Partition(Vector64<int>.Count).ToReadOnlyList();
            for(var i = 0; i < dst.Length; i++)
                dst[i] = define(parts[i][0], parts[i][1]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe Vec64<uint> define(uint x0, uint x1)
        {
            var data = stackalloc uint[]{x0,x1};
            return new Vec64<uint>(castref<Vector64<uint>>(data));
        }

        [MethodImpl(Inline)]
        public static unsafe Vec64<long> define(long x0)
        {
            var data = stackalloc long[]{x0};
            return new Vec64<long>(castref<Vector64<long>>(data));
        }


        [MethodImpl(Inline)]
        public static unsafe Vec64<ulong> define(ulong x0)
        {
            var data = stackalloc ulong[]{x0};
            return new Vec64<ulong>(castref<Vector64<ulong>>(data));
        }

        [MethodImpl(Inline)]
        public static unsafe Vec64<float> define(float x0, float x1)
        {
            var raw = stackalloc float[]{x0,x1};
            var data = castref<Vector64<float>>(raw);
            return new Vec64<float>(data);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec64<double> define(double x0)
        {
            var raw = stackalloc double[]{x0};            
            var data = castref<Vector64<double>>(raw);
            return new Vec64<double>(data);
        }

        [MethodImpl(Inline)]
        internal static T element<T>(Vector64<T> src, int idx)
            where T : struct, IEquatable<T>
        {
            ref T e0 = ref Unsafe.As<Vector64<T>, T>(ref src);
            
            return Unsafe.Add(ref e0, idx);   
        
        }

    }

    public readonly struct Vec64<T>
        where T : struct, IEquatable<T>
    {
        
        readonly Vector64<T> data;
    
        [MethodImpl(Inline)]
        public Vec64(Vector64<T> src)
        {
            this.data = src;
        }

        public T this[int idx]
        {
            [MethodImpl(Inline)]
            get => Vec64.element(data,idx);
        }


        public override string ToString()
            => data.ToString();
    }
    
    
}