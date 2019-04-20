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
    using static inxfunc;


    partial class InXG
    {

        /// <summary>
        /// Obtains the op1[T] operator bundle
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXConvert<S,T> convert<S,T>()
            where T : struct, IEquatable<T>
            where S : struct, IEquatable<S>
                => SSR.InXConvertG<S,T>.Operator;

        /// <summary>
        /// Applies the operator
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> convert<S,T>(Vec128<S> lhs, out Vec128<T> rhs)
            where T : struct, IEquatable<T>
            where S : struct, IEquatable<S>
                => SSR.InXConvertG<S,T>.TheOnly.convert(lhs, out rhs);

    }

    partial class SSR
    {
        /// <summary>
        /// Defines the generic operator via stateless singleton reification
        /// </summary>
        public readonly struct InXConvertG<S,T> : InXConvert<S,T>
            where T : struct, IEquatable<T>
            where S : struct, IEquatable<S>
        {
            public static readonly InXConvert<S,T> Operator = cast<InXConvert<S,T>>(InXConvert.TheOnly);

            public static readonly InXConvertG<S,T> TheOnly = default;

            public Vec128<T> convert(Vec128<S> src, out Vec128<T> dst)
                => Operator.convert(src, out dst);
        }


        public readonly struct InXConvert : 
            InXConvert<sbyte,short>,
            InXConvert<sbyte,int>,
            InXConvert<sbyte,long>,
            InXConvert<byte,short>,
            InXConvert<byte,int>,
            InXConvert<byte,long>,
            InXConvert<short,int>,
            InXConvert<short,long>,
            InXConvert<ushort,int>,
            InXConvert<ushort,long>,
            InXConvert<int,long>,
            InXConvert<uint,long>
        {        
            public static readonly InXConvert TheOnly = default;

            [MethodImpl(Inline)]
            public Vec128<short> convert(Vec128<sbyte> src, out Vec128<short> dst)
                => dst = Avx2.ConvertToVector128Int16(src);

            [MethodImpl(Inline)]
            public Vec128<int> convert(Vec128<sbyte> src, out Vec128<int> dst)
                => dst = Avx2.ConvertToVector128Int32(src);

            [MethodImpl(Inline)]
            public Vec128<long> convert(Vec128<sbyte> src, out Vec128<long> dst)
                => dst = Avx2.ConvertToVector128Int64(src);

            [MethodImpl(Inline)]
            public Vec128<short> convert(Vec128<byte> src, out Vec128<short> dst)
                =>  dst = Avx2.ConvertToVector128Int16(src);

            [MethodImpl(Inline)]
            public Vec128<int> convert(Vec128<byte> src, out Vec128<int> dst)
                => dst = Avx2.ConvertToVector128Int32(src);

            [MethodImpl(Inline)]
            public Vec128<long> convert(Vec128<byte> src, out Vec128<long> dst)
                => dst = Avx2.ConvertToVector128Int64(src);
     
            [MethodImpl(Inline)]
            public Vec128<int> convert(Vec128<short> src, out Vec128<int> dst)
                => dst = Avx2.ConvertToVector128Int32(src);

            [MethodImpl(Inline)]
            public Vec128<long> convert(Vec128<short> src, out Vec128<long> dst)
                => dst = Avx2.ConvertToVector128Int64(src);

            [MethodImpl(Inline)]
            public Vec128<int> convert(Vec128<ushort> src, out Vec128<int> dst)
                => dst = Avx2.ConvertToVector128Int32(src);

            [MethodImpl(Inline)]
            public Vec128<long> convert(Vec128<ushort> src, out Vec128<long> dst)
                => dst = Avx2.ConvertToVector128Int64(src);

            [MethodImpl(Inline)]
            public Vec128<long> convert(Vec128<int> src, out Vec128<long> dst)
                => dst = Avx2.ConvertToVector128Int64(src);

            [MethodImpl(Inline)]
            public Vec128<long> convert(Vec128<uint> src, out Vec128<long> dst)
                => dst = Avx2.ConvertToVector128Int64(src);


        }


    }
            

}