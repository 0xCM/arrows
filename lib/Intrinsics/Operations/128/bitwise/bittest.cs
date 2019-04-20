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
        public static bool allOn(Vec128<byte> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOn(Vec128<sbyte> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOn(Vec128<short> src)
            => Avx.TestAllOnes(src);        

        [MethodImpl(Inline)]
        public static bool allOn(Vec128<ushort> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOn(Vec128<int> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOn(Vec128<uint> src)
            => Avx.TestAllOnes(src);
                        
        [MethodImpl(Inline)]
        public static bool allOn(Vec128<long> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOn(Vec128<ulong> src)
            => Avx.TestAllOnes(src);

        [MethodImpl(Inline)]
        public static bool allOff(Vec128<ulong> src, Vec128<ulong> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool allOff(Vec128<uint> src, Vec128<uint> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool allOff(Vec128<ushort> src, Vec128<ushort> mask)
            => Avx.TestAllZeros(src ,mask);

        [MethodImpl(Inline)]
        public static bool allOff(Vec128<sbyte> src,  Vec128<sbyte> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool allOff(Vec128<int> src,  Vec128<int> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool allOff(Vec128<short> src,  Vec128<short> mask)
            => Avx.TestAllZeros(src, mask);
        
        [MethodImpl(Inline)]
        public static bool allOff(Vec128<byte> src,  Vec128<byte> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool allOff(Vec128<long> src,  Vec128<long> mask)
            => Avx.TestAllZeros(src, mask);

        [MethodImpl(Inline)]
        public static bool testZ(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(Vec128<short> lhs, Vec128<short> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(Vec128<int> lhs, Vec128<int> rhs)
            => Avx.TestZ(lhs, rhs);        
        
        [MethodImpl(Inline)]
        public static bool testZ(Vec128<long> lhs, Vec128<long> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testZ(Vec128<ulong> lhs, Vec128<ulong> rhs) 
            => Avx.TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(Vec128<short> lhs, Vec128<short> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(Vec128<int> lhs, Vec128<int> rhs)
            => Avx.TestC(lhs, rhs);        
        
        [MethodImpl(Inline)]
        public static bool testC(Vec128<long> lhs, Vec128<long> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx.TestC(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool testC(Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Avx.TestC(lhs, rhs);        
             
    }

}