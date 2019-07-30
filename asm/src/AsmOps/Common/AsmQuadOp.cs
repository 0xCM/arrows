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

        [MethodImpl(Inline)]
        public static AsmQuadOp<T> Create<T>(AsmCode<T> code)
            where T : struct
        {
            if(typeof(T) == typeof(int))
                return code.CreateDelegate<QuadOpI32>().ToGeneric<QuadOpI32,T>();                
            else 
                throw unsupported<T>();
        }

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate void QuadOpI32(int x, int y, out int a, out int b);

        [MethodImpl(Inline)]
        static AsmQuadOp<T> ToGeneric<S,T>(this S specific)            
            where S : Delegate
            where T : struct
                => Unsafe.As<S, AsmQuadOp<T>>(ref specific);

        
        [MethodImpl(Inline)]
        static QuadOpI32 OpI32(AsmCode code)
            => code.CreateDelegate<QuadOpI32>();

    }


}