//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    [SuppressUnmanagedCodeSecurity]
    public static unsafe class AsmBinOp
    {
        /// <summary>
        /// Creates a binary operator that invokes an assembly function via interop invocation of an unmanaged function pointer
        /// </summary>
        /// <param name="code">The source code</param>
        /// <typeparam name="T">The operand type</typeparam>
        /// <remarks>Obviously, this only works if the assembly code expects two T-operands and returns a T-result!</remarks>
        [MethodImpl(Inline)]
        public static AsmBinOp<T> CreateBinOpPI<T>(this AsmCode code)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return code.CreateBinOpI8().ToGeneric<BinOpI8,T>();                
            else if(typeof(T) == typeof(byte))
                return code.CreateBinOpU8().ToGeneric<BinOpU8,T>();                
            else if(typeof(T) == typeof(short))
                return code.CreateBinOpI16().ToGeneric<BinOpI16,T>();                
            else if(typeof(T) == typeof(ushort))
                return code.CreateBinOpU16().ToGeneric<BinOpU16,T>();                
            else if(typeof(T) == typeof(int))
                return code.CreateBinOpI32().ToGeneric<BinOpI32,T>();                
            else if(typeof(T) == typeof(uint))
                return code.CreateBinOpU32().ToGeneric<BinOpU32,T>();                
            else if(typeof(T) == typeof(long))
                return code.CreateBinOpI64().ToGeneric<BinOpI64,T>();                
            else if(typeof(T) == typeof(ulong))
                return code.CreateBinOpU64().ToGeneric<BinOpU64,T>();                
            else if(typeof(T) == typeof(float))
                return code.CreateBinOpF32().ToGeneric<BinOpF32,T>();                
            else if(typeof(T) == typeof(double))
                return code.CreateBinOpF64().ToGeneric<BinOpF64,T>();                
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static AsmBinOp<T> ToGeneric<S,T>(this S specific)            
            where S : Delegate
            where T : unmanaged
                => Unsafe.As<S, AsmBinOp<T>>(ref specific);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate sbyte BinOpI8(sbyte x, sbyte y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate byte BinOpU8(byte x, byte y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate ushort BinOpU16(ushort x, ushort y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate short BinOpI16(short x, short y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate int BinOpI32(int x, int y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate uint BinOpU32(uint x, uint y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate long BinOpI64(long x, long y);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate ulong BinOpU64(ulong x, ulong y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate float BinOpF32(float x, float y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate double BinOpF64(double x, double y);

        [MethodImpl(Inline)]
        static BinOpI8 CreateBinOpI8(this AsmCode code)
            => code.CreateDelegate<BinOpI8>();

        [MethodImpl(Inline)]
        static BinOpU8 CreateBinOpU8(this AsmCode code)
            => code.CreateDelegate<BinOpU8>();

        [MethodImpl(Inline)]
        static BinOpI16 CreateBinOpI16(this AsmCode code)
            => code.CreateDelegate<BinOpI16>();

        [MethodImpl(Inline)]
        static BinOpU16 CreateBinOpU16(this AsmCode code)
            => code.CreateDelegate<BinOpU16>();

        [MethodImpl(Inline)]
        static BinOpI32 CreateBinOpI32(this AsmCode code)
            => code.CreateDelegate<BinOpI32>();

        [MethodImpl(Inline)]
        static BinOpU32 CreateBinOpU32(this AsmCode code)
            => code.CreateDelegate<BinOpU32>();

        [MethodImpl(Inline)]
        static BinOpI64 CreateBinOpI64(this AsmCode code)
            => code.CreateDelegate<BinOpI64>();

        [MethodImpl(Inline)]
        static BinOpU64 CreateBinOpU64(this AsmCode code)
            => code.CreateDelegate<BinOpU64>();

        [MethodImpl(Inline)]
        static BinOpF32 CreateBinOpF32(this AsmCode code)
            => code.CreateDelegate<BinOpF32>();

        [MethodImpl(Inline)]
        static BinOpF64 CreateBinOpF64(this AsmCode code)
            => code.CreateDelegate<BinOpF64>();

    }
}