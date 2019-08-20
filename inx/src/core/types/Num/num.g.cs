//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;    
    using static System.Runtime.Intrinsics.X86.Sse2;    
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    
    using static zfunc;
    

    /// <summary>
    /// Characterizes a function that produces a 128-bit scalar vector given a scalar value
    /// </summary>
    /// <param name="src">The scalar upon which the vector is predicated</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Num128<T> Num128Factory<T>(T src)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a 128-bit scalar intrinsic binary operator
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Num128<T> Num128BinOp<T>(in Num128<T> lhs, in Num128<T> rhs)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a 128-bit scalar intrinsic unary operator
    /// </summary>
    /// <param name="lhs">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Num128<T> Num128UnaryOp<T>(in Num128<T> src)
        where T : struct;

    public delegate Num128<T> Num128TernaryOp<T>(in Num128<T> x, in Num128<T> y, in Num128<T> z)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of an unsafe data transfer from a 
    /// scalar source vector to a pointer-identified memory location
    /// </summary>
    /// <param name="src">The source data</param>
    /// <param name="dst">The target pointer</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public unsafe delegate void Num128PStore<T>(in Num128<T> src, void* dst)
        where T : struct;

    public delegate bool Num128CmpFloat<T>(in Num128<T> lhs, in Num128<T> rhs, FloatComparisonMode mode)
        where T : struct;

    public delegate bool Num128BinPred<T>(in Num128<T> lhs, in Num128<T> rhs)
        where T : struct;

    partial class ginx
    {

    }
}