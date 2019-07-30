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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    
    partial class dinx
    {
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
 
    }
}