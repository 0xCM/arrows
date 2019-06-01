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
        public static bool nonzero(in Vec128<byte> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec128<sbyte> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec128<short> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec128<ushort> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec128<int> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec128<uint> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec128<long> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec128<ulong> src) 
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec256<byte> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec256<sbyte> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec256<short> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec256<ushort> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec256<int> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec256<uint> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec256<long> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        public static bool nonzero(in Vec256<ulong> src) 
            => ! TestZ(src,src);        

    }
}