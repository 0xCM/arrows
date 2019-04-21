//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zcore;


    /// <summary>
    /// Characterizes the signature of a 128-bit scalar intrinsic binary operator
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Num128<T> Num128BinOp<T>(in Num128<T> lhs, in Num128<T> rhs)
        where T : struct, IEquatable<T>;

    /// <summary>
    /// Characterizes the signature of a 128-bit scalar intrinsic unary operator
    /// </summary>
    /// <param name="lhs">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Num128<T> Num128UnaryOp<T>(in Num128<T> src)
        where T : struct, IEquatable<T>;

    /// <summary>
    /// Characterizes the signature of a canonical 128-bit vector instrinsic binary operator
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec128<T> Vec128BinOp<T>(in Vec128<T> lhs,  in Vec128<T> rhs)
        where T : struct, IEquatable<T>;

    /// <summary>
    /// Characterizes the signature of an unsafe data transfer from a 
    /// source vector to a pointer-identified memory location
    /// </summary>
    /// <param name="src">The source data</param>
    /// <param name="dst">The target pointer</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public unsafe delegate void Vec128PStore<T>(in Vec128<T> src, void* dst)
        where T : struct, IEquatable<T>;

    /// <summary>
    /// Characterizes the signature of a 128-bit vector instrinsic binary operator that
    /// stores the computation result in an output parameter
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate void Vec128BinOut<T>(in Vec128<T> lhs,  in Vec128<T> rhs, out Vec128<T> dst)
        where T : struct, IEquatable<T>;

    /// <summary>
    /// Characterizes the signature of a 128-bit vector instrinsic binary operator that
    /// computes a result which is then stored to a memory location
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public unsafe delegate void Vec128BinPOut<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
        where T : struct, IEquatable<T>;    

    /// <summary>
    /// Characterizes the signature of a 128-bit vector instrinsic binary operator that
    /// computes a result which is then stored to an array
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate void Vec128BinAOut<T>(in Vec128<T> lhs, in Vec128<T> rhs, T[] dst, int offset = 0)
        where T : struct, IEquatable<T>;    

    /// <summary>
    /// Characterizes the signature of a 128-bit vector instrinsic binary operator that
    /// computes a result which is then stored to a span
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate void Vec128BinSOut<T>(in Vec128<T> lhs, in Vec128<T> rhs, Span<T> dst, int offset = 0)
        where T : struct, IEquatable<T>;        

    /// <summary>
    /// Characterizes the signature of a 128-bit vector intrinsic unary operator
    /// </summary>
    /// <param name="src">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec128<T> Vec128UnaryOp<T>(in Vec128<T> src)
        where T : struct, IEquatable<T>;

    /// <summary>
    /// Characterizes the signature of a 256-bit vector intrinsic unary operator
    /// </summary>
    /// <param name="src">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec256<T> Vec256BinOp<T>(in Vec256<T> lhs, in Vec256<T> rhs)
        where T : struct, IEquatable<T>;

    /// <summary>
    /// Characterizes the signature of a 256-bit vector intrinsic unary operator
    /// </summary>
    /// <param name="src">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec256<T> Vec256UnaryOp<T>(Vec256<T> src)
        where T : struct, IEquatable<T>;

    public delegate Index<T> IndexBinOp<T>(Index<T> lhs, Index<T> rhs)
        where T : struct, IEquatable<T>;

    public delegate T[] ArrayBinOp<T>(T[] lhs, T[] rhs)
        where T : struct, IEquatable<T>;

    public delegate T[] ArrayUnaryOp<T>(T[] src)
        where T : struct, IEquatable<T>;


}