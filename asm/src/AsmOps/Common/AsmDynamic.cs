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
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;

    public delegate T AsmBinOp<T>(T x, T y)
        where T : unmanaged;

    public delegate Vector128<T> Asm128BinOp<T>(Vector128<T> x, Vector128<T> y)
        where T : unmanaged;

    public delegate T AsmUnaryOp<T>(T x)
        where T : unmanaged;

    public delegate T AsmEmitter<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public static unsafe class AsmDynOp
    {
        /// <summary>
        /// Creates a value-producing assembly operator that accepts no arguments
        /// </summary>
        /// <param name="code">The code to execute</param>
        /// <param name="name">The emitter name</param>
        /// <typeparam name="T">The emission type</typeparam>
        public static AsmEmitter<T> CreateEmitter<T>(this AsmCode<T> code, string name = null)
            where T : unmanaged

        {
            var t = typeof(T);
            var argTypes = new Type[]{};
            var returnType = t;
            var method = new DynamicMethod(name ?? "anon", returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldc_I8, (long)code.Pointer);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            
            return (AsmEmitter<T>)method.CreateDelegate(typeof(AsmEmitter<T>));
        }

        /// <summary>
        /// Creates a unary assembly operator 
        /// </summary>
        /// <param name="code">The code to execute</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static AsmUnaryOp<T> CreateUnaryOp<T>(this AsmCode<T> code, string name = null)
            where T : unmanaged
        {
            var t = typeof(T);
            var argTypes = new Type[]{t};
            var returnType = t;
            var method = new DynamicMethod(name ?? "anon", returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldc_I8, (long)code.Pointer);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return (AsmUnaryOp<T>)method.CreateDelegate(typeof(AsmUnaryOp<T>));
        }

        /// <summary>
        /// Creates a binary assembly operator 
        /// </summary>
        /// <param name="code">The code to execute</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static AsmBinOp<T> CreateBinOp<T>(this AsmCode<T> code, string name = null)
            where T : unmanaged
        {
            var t = typeof(T);
            var argTypes = new Type[]{t,t};
            var returnType = t;
            var method = new DynamicMethod(name ?? "anon", returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.Emit(OpCodes.Ldc_I8, (long)code.Pointer);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return (AsmBinOp<T>)method.CreateDelegate(typeof(AsmBinOp<T>));
        }
    }
}