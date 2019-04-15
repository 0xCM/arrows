//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static x86;
    using static Operative;

    partial class Operative
    {
        public interface InX128Add<T>
            where T : struct, IEquatable<T>
        {
            Vec128<T> add(Vec128<T> lhs, Vec128<T> rhs);
        }

        public interface InX256Add<T>
            where T : struct, IEquatable<T>
        {
            Vec256<T> add(Vec256<T> lhs, Vec256<T> rhs);
        }

    }

    public readonly struct InX128Add : 
        InX128Add<byte>,
        InX128Add<sbyte>,
        InX128Add<short>,
        InX128Add<ushort>,
        InX128Add<int>,
        InX128Add<uint>,
        InX128Add<long>,
        InX128Add<ulong>,
        InX128Add<float>,
        InX128Add<double>
    {        
        public static readonly InX128Add Inhabitant = default;


        [MethodImpl(Inline)]
        public Vec128<byte> add(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<sbyte> add(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<short> add(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<ushort> add(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<int> add(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<uint> add(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<long> add(Vec128<long> lhs, Vec128<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<ulong> add(Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<double> add(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<float> add(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Add(lhs, rhs);
    }

    public partial class InX
    {

        [MethodImpl(Inline)]
        public static Num128<float> add(Num128<float> lhs, Num128<float> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(Vec128<float> lhs, Num128<float> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> add(Num128<double> lhs, Num128<double> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(Vec128<double> lhs, Num128<double> rhs)
            => Avx2.AddScalar(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<byte> add(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.Add(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<byte> add(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> add(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> add(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> add(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> add(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> add(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> add(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> add(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> add(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> add(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> add(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> add(Vec128<long> lhs, Vec128<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> add(Vec256<long> lhs, Vec256<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> add(Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> add(Vec256<ulong> lhs, Vec256<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> add(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Add(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<double> add(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.Add(lhs, rhs);
    }

    partial class xcore
    {
        [MethodImpl(Inline)]
        public static Vec128<byte> Add(this Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> Add(this Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> Add(this Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> Add(this Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> Add(this Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> Add(this Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> Add(this Vec128<long> lhs, Vec128<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> Add(this Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> Add(this Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> Add(this Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Add(lhs, rhs);
       
    }
}