//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics.X86;

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

    public delegate bool[] Vec128CmpFloat<T>(in Vec128<T> lhs, in Vec128<T> rhs, FloatComparisonMode mode)
        where T : struct;

    public delegate Vec128<T> Vec128TernaryOp<T>(in Vec128<T> x, in Vec128<T> y, in Vec128<T> z)
        where T : struct;

    public delegate bool Vec128UnaryPred<T>(in Vec128<T> src)
        where T : struct;

    public delegate bool Vec128BinPred<T>(in Vec128<T> lhs, in Vec128<T> rhs)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a canonical 128-bit vector heterogenous binary operator
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec128<T> Vec128BinOp<S, T>(in Vec128<S> lhs, in Vec128<S> rhs)
        where T : struct
        where S : struct;

    /// <summary>
    /// Characterizes the signature of a canonical 128-bit vector binary operator
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec128<T> Vec128BinOp<T>(in Vec128<T> lhs, in Vec128<T> rhs)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a function that loads a 128-bit vector from a pointer
    /// </summary>
    /// <param name="src">Identifies the memory location from which to hydrate the vector</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public unsafe delegate Vec128<T> Vec128LoadOp<T>(void* src)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of an unsafe data transfer from a 
    /// source vector to a pointer-identified memory location
    /// </summary>
    /// <param name="src">The source data</param>
    /// <param name="dst">The target pointer</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public unsafe delegate void Vec128StorePOp<T>(in Vec128<T> src, void* dst)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of an unsafe data transfer from a 
    /// source vector to an array
    /// </summary>
    /// <param name="src">The source data</param>
    /// <param name="dst">The target pointer</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public unsafe delegate void Vec128StoreAOp<T>(in Vec128<T> src, T[] dst, int offset = 0)
        where T : struct;


    /// <summary>
    /// Characterizes the signature of a 128-bit vector instrinsic binary operator that
    /// stores the computation result in an output parameter
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate void Vec128BinOut<T>(in Vec128<T> lhs, in Vec128<T> rhs, out Vec128<T> dst)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a 128-bit vector instrinsic binary operator that
    /// computes a result which is then stored to a memory location
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public unsafe delegate void Vec128BinPOut<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a 128-bit vector instrinsic binary operator that
    /// computes a result which is then stored to an array
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate void Vec128BinAOut<T>(in Vec128<T> lhs, in Vec128<T> rhs, T[] dst, int offset = 0)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a 128-bit vector instrinsic binary operator that
    /// computes a result which is then stored to a span
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate void Vec128BinSOut<T>(in Vec128<T> lhs, in Vec128<T> rhs, Span<T> dst, int offset = 0)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a 128-bit vector intrinsic unary operator
    /// </summary>
    /// <param name="src">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec128<T> Vec128UnaryOp<T>(in Vec128<T> src)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a function that transforms arrays into 128-bit vector streams
    /// </summary>
    /// <param name="src">The data source</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate IEnumerable<Vec128<T>> Vec128StreamOp<T>(T[] src)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a 256-bit vector intrinsic unary operator
    /// </summary>
    /// <param name="src">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec256<T> Vec256BinOp<T>(in Vec256<T> lhs, in Vec256<T> rhs)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a canonical 256-bit vector heterogenous binary operator
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec256<T> Vec256BinOp<S, T>(in Vec256<S> lhs, in Vec256<S> rhs)
        where T : struct
        where S : struct;

    /// <summary>
    /// Characterizes the signature of a 256-bit vector intrinsic unary operator
    /// </summary>
    /// <param name="src">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec256<T> Vec256UnaryOp<T>(Vec256<T> src)
        where T : struct;

    /// <summary>
    /// Characterizes the signature of a function that loads a 128-bit vector from a pointer
    /// </summary>
    /// <param name="src">Identifies the memory location from which to hydrate the vector</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public unsafe delegate Vec256<T> Vec256LoadOp<T>(void* src, out Vec256<T> dst)
        where T : struct;

}
