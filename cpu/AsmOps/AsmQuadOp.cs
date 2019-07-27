//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

 
    public delegate T AsmQuadOp<T>(T x, T y, out T a, out T b)
        where T : struct;


    public static unsafe class AsmQuadOp
    {
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        public delegate void QuadOpI32(int x, int y, out int a, out int b);

        
        [MethodImpl(Inline)]
        public static QuadOpI32 OpI32(this AsmCode code)
            => code.CreateDelegate<QuadOpI32>();

    }


}