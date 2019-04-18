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
        /// Obtains the bittest[T] operator bundle
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXBitTest<T> bittest<T>()
            where T : struct, IEquatable<T>
                => SSR.InXBitTestG<T>.Operator;

        [MethodImpl(Inline)]
        public static bool allOn<T>(Vec128<T> src)
            where T : struct, IEquatable<T>
                => SSR.InXBitTestG<T>.TheOnly.allOn(src);
        
        [MethodImpl(Inline)]
        public static bool allOff<T>(Vec128<T> src, Vec128<T> mask)
            where T : struct, IEquatable<T>
                => SSR.InXBitTestG<T>.TheOnly.allOff(src, mask);


        [MethodImpl(Inline)]
        public static bool testC<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXBitTestG<T>.TheOnly.testC(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool testZ<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXBitTestG<T>.TheOnly.testZ(lhs, rhs);

    }

    partial class SSR
    {
        /// <summary>
        /// The generic add operator via stateless singleton reification
        /// </summary>
        public readonly struct InXBitTestG<T> : InXBitTest<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXBitTest<T> Operator = cast<InXBitTest<T>>(InXBitTest.TheOnly);
            
            public static readonly InXBitTestG<T> TheOnly = default;

            [MethodImpl(Inline)]
            public bool allOff(Vec128<T> src, Vec128<T> mask)
                => Operator.allOff(src,mask);

            [MethodImpl(Inline)]
            public bool allOn(Vec128<T> src)
                => Operator.allOn(src);

            [MethodImpl(Inline)]
            public bool testC(Vec128<T> lhs, Vec128<T> rhs)
                => Operator.testC(lhs,rhs);

            [MethodImpl(Inline)]
            public bool testZ(Vec128<T> lhs, Vec128<T> rhs)
                => Operator.testZ(lhs,rhs);
        }

        public readonly struct InXBitTest : 
            InXBitTest<byte>,
            InXBitTest<sbyte>,
            InXBitTest<short>,
            InXBitTest<ushort>,
            InXBitTest<int>,
            InXBitTest<uint>,
            InXBitTest<long>,
            InXBitTest<ulong>
        {        
            public static readonly InXBitTest TheOnly = default;

            [MethodImpl(Inline)]
            public bool allOn(Vec128<byte> src)
                => Avx.TestAllOnes(src);

            [MethodImpl(Inline)]
            public bool allOn(Vec128<sbyte> src)
                => Avx.TestAllOnes(src);

            [MethodImpl(Inline)]
            public bool allOn(Vec128<short> src)
                => Avx.TestAllOnes(src);        

            [MethodImpl(Inline)]
            public bool allOn(Vec128<ushort> src)
                => Avx.TestAllOnes(src);

            [MethodImpl(Inline)]
            public bool allOn(Vec128<int> src)
                => Avx.TestAllOnes(src);

            [MethodImpl(Inline)]
            public bool allOn(Vec128<uint> src)
                => Avx.TestAllOnes(src);
                            
            [MethodImpl(Inline)]
            public bool allOn(Vec128<long> src)
                => Avx.TestAllOnes(src);

            [MethodImpl(Inline)]
            public bool allOn(Vec128<ulong> src)
                => Avx.TestAllOnes(src);

            [MethodImpl(Inline)]
            public bool allOff(Vec128<ulong> src, Vec128<ulong> mask)
                => Avx.TestAllZeros(src, mask);

            [MethodImpl(Inline)]
            public bool allOff(Vec128<uint> src, Vec128<uint> mask)
                => Avx.TestAllZeros(src, mask);

            [MethodImpl(Inline)]
            public bool allOff(Vec128<ushort> src, Vec128<ushort> mask)
                => Avx.TestAllZeros(src ,mask);

            [MethodImpl(Inline)]
            public bool allOff(Vec128<sbyte> src,  Vec128<sbyte> mask)
                => Avx.TestAllZeros(src, mask);

            [MethodImpl(Inline)]
            public bool allOff(Vec128<int> src,  Vec128<int> mask)
                => Avx.TestAllZeros(src, mask);

            [MethodImpl(Inline)]
            public bool allOff(Vec128<short> src,  Vec128<short> mask)
                => Avx.TestAllZeros(src, mask);
            
            [MethodImpl(Inline)]
            public bool allOff(Vec128<byte> src,  Vec128<byte> mask)
                => Avx.TestAllZeros(src, mask);

            [MethodImpl(Inline)]
            public bool allOff(Vec128<long> src,  Vec128<long> mask)
                => Avx.TestAllZeros(src, mask);

            [MethodImpl(Inline)]
            public bool testZ(Vec128<byte> lhs, Vec128<byte> rhs)
                => Avx.TestZ(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testZ(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
                => Avx.TestZ(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testZ(Vec128<short> lhs, Vec128<short> rhs)
                => Avx.TestZ(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testZ(Vec128<int> lhs, Vec128<int> rhs)
                => Avx.TestZ(lhs, rhs);        
            
            [MethodImpl(Inline)]
            public bool testZ(Vec128<long> lhs, Vec128<long> rhs)
                => Avx.TestZ(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testZ(Vec128<ushort> lhs, Vec128<ushort> rhs)
                => Avx.TestZ(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testZ(Vec128<uint> lhs, Vec128<uint> rhs)
                => Avx.TestZ(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testZ(Vec128<ulong> lhs, Vec128<ulong> rhs) 
                => Avx.TestZ(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testC(Vec128<byte> lhs, Vec128<byte> rhs)
                => Avx.TestC(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testC(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
                => Avx.TestC(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testC(Vec128<short> lhs, Vec128<short> rhs)
                => Avx.TestC(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testC(Vec128<int> lhs, Vec128<int> rhs)
                => Avx.TestC(lhs, rhs);        
            
            [MethodImpl(Inline)]
            public bool testC(Vec128<long> lhs, Vec128<long> rhs)
                => Avx.TestC(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testC(Vec128<ushort> lhs, Vec128<ushort> rhs)
                => Avx.TestC(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testC(Vec128<uint> lhs, Vec128<uint> rhs)
                => Avx.TestC(lhs, rhs);        

            [MethodImpl(Inline)]
            public bool testC(Vec128<ulong> lhs, Vec128<ulong> rhs)
                => Avx.TestC(lhs, rhs);        
                

        }
    }
}

