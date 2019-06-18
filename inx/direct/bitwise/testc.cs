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
        public static bool on(in Vec128<byte> src)
        {
            var a = And(Vec128.ones<byte>(), src);
            return TestC(a,a);
        }
            

        [MethodImpl(Inline)]
        public static bool on(in Vec128<sbyte> src)
        {
            var a = And(Vec128.ones<sbyte>(), src);
            return TestC(a,a);
        }

        [MethodImpl(Inline)]
        public static bool on(in Vec128<short> src)
        {
            var a = And(Vec128.ones<short>(), src);
            return TestC(a,a);
        }

        [MethodImpl(Inline)]
        public static bool on(in Vec128<ushort> src)
        {
            var a = And(Vec128.ones<ushort>(), src);
            return TestC(a,a);
        }

        [MethodImpl(Inline)]
        public static bool on(in Vec128<int> src)
            => src.Eq(Vec128.ones<int>());

        [MethodImpl(Inline)]
        public static bool on(in Vec128<uint> src)
            => src.Eq(Vec128.ones<uint>());
                        
        [MethodImpl(Inline)]
        public static bool on(in Vec128<long> src)
            => TestC(src,src);

        [MethodImpl(Inline)]
        public static bool on(in Vec128<ulong> src)
            => TestC(src,src);

        [MethodImpl(Inline)]
        public static bool on(in Vec256<byte> src)
            => TestC(src,src);

        [MethodImpl(Inline)]
        public static bool on(in Vec256<sbyte> src)
            => TestC(src,src);

        [MethodImpl(Inline)]
        public static bool on(in Vec256<short> src)
            => TestC(src,src);

        [MethodImpl(Inline)]
        public static bool on(in Vec256<ushort> src)
            => TestC(src,src);

        [MethodImpl(Inline)]
        public static bool on(in Vec256<int> src)
            => TestC(src,src);

        [MethodImpl(Inline)]
        public static bool on(in Vec256<uint> src)
            => TestC(src,src);
                        
        [MethodImpl(Inline)]
        public static bool on(in Vec256<long> src)
            => TestC(src,src);

        [MethodImpl(Inline)]
        public static bool on(in Vec256<ulong> src)
            => TestC(src,src);

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