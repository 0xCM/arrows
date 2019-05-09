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
    
    
    using static global::mfunc;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx2;

    
    partial class dinx
    {

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<short> lhs, in Vec128<short> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<int> lhs, in Vec128<int> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<long> lhs, in Vec128<long> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<float> lhs, in Vec128<float> rhs)
            => allOn(Avx2.CompareEqual(lhs, rhs).AsUInt64());
        
        [MethodImpl(Inline)]
        public static bool eq(in Vec128<double> lhs, in Vec128<double> rhs)
            => allOn(CompareEqual(lhs, rhs).AsUInt64());
  
        [MethodImpl(Inline)]
        public static BitVectorU32 eq(in Vec256<byte> lhs, in Vec256<byte> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            var x0 = extract(result, 0);
            var x1 = extract(result, 1);
            var dst = new Bit[32];
            for(byte i = 0; i< 16; i++)
                dst[i] = extract(x0, i);

            for(byte j = 0; j< 16; j++)
                dst[16 + j] = extract(x0, j);
            return BitVectorU32.Define(dst);

        }

        [MethodImpl(Inline)]
        public static bool eq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            var x0 = extract(result, 0);
            var x1 = extract(result, 1);

            return allOn(extract(result,0)) && allOn(extract(result,1));
        }

        [MethodImpl(Inline)]
        public static BitVectorU16 eq(in Vec256<short> lhs, in Vec256<short> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            var x0 = extract(result,0).ToArray();
            var x1 = extract(result,1).ToArray();

            return BitVectorU16.Define(            
                x0[0], x0[1], x0[2], x0[3],
                x0[4], x0[5], x0[6], x0[7],
                x1[0], x1[1], x1[2], x1[3],
                x1[4], x1[5], x1[6], x1[7]
                );
        }

        [MethodImpl(Inline)]
        public static BitVectorU16 eq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            var x0 = extract(result, 0);
            var x1 = extract(result, 1);

            return BitVectorU16.Define(            
                extract(x0, 0), extract(x0, 1), extract(x0, 2), extract(x0, 3),
                extract(x0, 4), extract(x0, 5), extract(x0, 6), extract(x0, 7),
                extract(x1, 0), extract(x1, 1), extract(x1, 2), extract(x1, 3),
                extract(x1, 4), extract(x1, 5), extract(x1, 6), extract(x1, 7)                
                );
        }            

        [MethodImpl(Inline)]
        public static BitVectorU8 eq(in Vec256<int> lhs, in Vec256<int> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            var x0 = extract(result, 0);
            var x1 = extract (result, 1);
            return BitVectorU8.Define(            
                extract(x0, 0), extract(x0, 1), extract(x0, 2), extract(x0, 3),
                extract(x1, 0), extract(x1, 1), extract(x1, 2), extract(x1, 3));
        }


        [MethodImpl(Inline)]
        public static BitVectorU8 eq(in Vec256<uint> lhs, in Vec256<uint> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            var x0 = extract(result, 0);
            var x1 = extract (result, 1);
            return BitVectorU8.Define(            
                extract(x0, 0), extract(x0, 1), extract(x0, 2), extract(x0, 3),
                extract(x1, 0), extract(x1, 1), extract(x1, 2), extract(x1, 3));
                                              
        }
    }
}