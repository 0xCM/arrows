//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    
    
    partial class dinx
    {
        [MethodImpl(Inline)]
        public static bool on(in Vec128<byte> src)
            => TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool on(in Vec128<sbyte> src)
            => TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool on(in Vec128<short> src)
            => TestAllOnes(src);        

        [MethodImpl(Inline)]
        public static bool on(in Vec128<ushort> src)
            => TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool on(in Vec128<int> src)
            => TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool on(in Vec128<uint> src)
            => TestAllOnes(src);
                        
        [MethodImpl(Inline)]
        public static bool on(in Vec128<long> src)
            => TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool on(in Vec128<ulong> src)
            => TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool off(in Vec128<sbyte> src, in Vec128<sbyte> mask)
            => TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool off(in Vec128<byte> src, in Vec128<byte> mask)
            => TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool off(in Vec128<short> src, in Vec128<short> mask)
            => TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool off(in Vec128<ushort> src, in Vec128<ushort> mask)
            => TestAllZeros(src ,mask);

        [MethodImpl(Inline)]
        public static bool off(in Vec128<int> src, in Vec128<int> mask)
            => TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool off(in Vec128<uint> src, in Vec128<uint> mask)
            => TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool off(in Vec128<ulong> src, in Vec128<ulong> mask)
            => TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool off(in Vec128<long> src, in Vec128<long> mask)
            => TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool testc(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec128<short> lhs, in Vec128<short> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec128<int> lhs, in Vec128<int> rhs)
            => TestC(lhs, rhs);        
        
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec128<long> lhs, in Vec128<long> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => TestC(lhs, rhs);                     

        [MethodImpl(Inline)]
        public static bool testc(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec256<short> lhs, in Vec256<short> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec256<int> lhs, in Vec256<int> rhs)
            => TestC(lhs, rhs);        
        
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec256<long> lhs, in Vec256<long> rhs)
            => TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testc(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => TestC(lhs, rhs);                             
 

        [MethodImpl(Inline)]
        public static bool testMix(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => TestMixOnesZeros(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testMix(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => TestMixOnesZeros(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testMix(in Vec128<short> lhs, in Vec128<short> rhs)
            => TestMixOnesZeros(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testMix(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => TestMixOnesZeros(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testMix(in Vec128<int> lhs, in Vec128<int> rhs)
            => TestMixOnesZeros(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testMix(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => TestMixOnesZeros(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testMix(in Vec128<long> lhs, in Vec128<long> rhs)
            => TestMixOnesZeros(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testMix(in Vec128<ulong> lhs, in Vec128<ulong> rhs) 
            => TestMixOnesZeros(lhs, rhs);        

    }
}