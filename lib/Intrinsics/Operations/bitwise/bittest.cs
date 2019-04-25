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
    
    using static zcore;
    using static inxfunc;

    
    partial class InX
    {
        [MethodImpl(Inline)]
        public static bool allOn(in Vec128<byte> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOn(in Vec128<sbyte> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOn(in Vec128<short> src)
            => Avx.TestAllOnes(src);        

        [MethodImpl(Inline)]
        public static bool allOn(in Vec128<ushort> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOn(in Vec128<int> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOn(in Vec128<uint> src)
            => Avx.TestAllOnes(src);
                        
        [MethodImpl(Inline)]
        public static bool allOn(in Vec128<long> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOn(in Vec128<ulong> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOff(in Vec128<ulong> src, in Vec128<ulong> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool allOff(in Vec128<uint> src, in Vec128<uint> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool allOff(in Vec128<ushort> src, in Vec128<ushort> mask)
            => Avx.TestAllZeros(src ,mask);

        [MethodImpl(Inline)]
        public static bool allOff(in Vec128<sbyte> src,  Vec128<sbyte> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool allOff(in Vec128<int> src,  Vec128<int> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool allOff(in Vec128<short> src,  Vec128<short> mask)
            => Avx.TestAllZeros(src, mask);
        
        [MethodImpl(Inline)]
        public static bool allOff(in Vec128<byte> src,  Vec128<byte> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool allOff(in Vec128<long> src,  Vec128<long> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool testZ(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx.TestZ(lhs, rhs);        
        
        [MethodImpl(Inline)]
        public static bool testZ(in Vec128<long> lhs, in Vec128<long> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(in Vec128<ulong> lhs, in Vec128<ulong> rhs) 
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx.TestC(lhs, rhs);        
        
        [MethodImpl(Inline)]
        public static bool testC(in Vec128<long> lhs, in Vec128<long> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Avx.TestC(lhs, rhs);        
             
    }

}