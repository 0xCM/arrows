//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inxfunc;
    using static Operative;

    public interface InXOp
    {

    }


    public interface InXOp<T> : InXOp
        where T : struct, IEquatable<T>
    {

    }

    public interface InXOp<S,T>
        where S : struct, IEquatable<S>
        where T : struct, IEquatable<T>
    {

    }

    public interface InXAnd<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> and(in Vec128<T> lhs, in Vec128<T> rhs);        
    }

    public interface InXAbs<S,T> : InXOp<S,T>
        where S : struct, IEquatable<S>
        where T : struct, IEquatable<T>
    {
        Vec128<T> abs(Vec128<S> src);
    }

    public interface InXAdd<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> add(in Vec128<T> lhs, in Vec128<T> rhs);
    }

    public interface InXAvg<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> avg(Vec128<T> lhs, Vec128<T> rhs);
        Vec256<T> avg(Vec256<T> lhs, Vec256<T> rhs);
    }


    public interface InXDiv<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> div(Vec128<T> lhs, Vec128<T> rhs);
        
        Num128<T> div(Num128<T> lhs, Num128<T> rhs);
    }



    public interface InXSub<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> sub(Vec128<T> lhs, Vec128<T> rhs);
    }

    public interface InXBitTest<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        bool allOn(Vec128<T> src);
        
        bool allOff(Vec128<T> src, Vec128<T> mask);

        bool testC(Vec128<T> lhs, Vec128<T> rhs);
        
        bool testZ(Vec128<T> lhs, Vec128<T> rhs);
    }

    public interface InXEq<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> eq(Vec128<T> lhs, Vec128<T> rhs);
    }

    public interface InXGt<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> gt(Vec128<T> lhs, Vec128<T> rhs);
    }

    public interface InXNgt<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> ngt(Vec128<T> lhs, Vec128<T> rhs);
    }

    public interface InXGtEq<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> gteq(Vec128<T> lhs, Vec128<T> rhs);
    }

    public interface InXLt<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> lt(Vec128<T> lhs, Vec128<T> rhs);
    }

    public interface InXNlt<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> nlt(Vec128<T> lhs, Vec128<T> rhs);
    }

    public interface InXLtEq<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> gteq(Vec128<T> lhs, Vec128<T> rhs);
    }



    /// <summary>
    /// Defines data transfer operations from  arrays and spans to vectors
    /// </summary>
    /// <typeparam name="T">The primitive element type</typeparam>
    public interface InXLoad<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        /// <summary>
        /// Hydrates a vector from a span
        /// </summary>
        /// <param name="src">the source span</param>
        Vec128<T> load(Span128<T> src);

        /// <summary>
        /// Hydrates a vector from a parameter array
        /// </summary>
        /// <param name="src">the source values</param>
        Vec128<T> load(params T[] src);

        /// <summary>
        /// Hydrates a vector from an array
        /// </summary>
        /// <param name="src">the source values</param>
        Vec128<T> load(T[] src, int offset = 0);
    }

    public interface InXMin<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> min(Vec128<T> lhs, Vec128<T> rhs);
    }

    public interface InXFloor<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Num128<T> floor(Num128<T> src);

        Vec128<T> floor(Vec128<T> src);

    }

    public interface InXCeiling<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Num128<T> ceiling(Num128<T> src);
        
        Vec128<T> ceiling(Vec128<T> src);

    }

    public interface InXMax<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> max(Vec128<T> lhs, Vec128<T> rhs);
    }

    /// <summary>
    /// Defines logical or operations between vectors
    /// </summary>
    /// <typeparam name="T">The primitive type</typeparam>
    public interface InXOr<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        /// <summary>
        /// Computes the logical or between the operands
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        Vec128<T> or(Vec128<T> lhs, Vec128<T> rhs);        
    }

    /// <summary>
    /// Defines data transfer operations from vector sources to target arrays
    /// </summary>
    /// <typeparam name="T">The primitive type</typeparam>
    public interface InXStore<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        /// <summary>
        /// Writes data data in a source vector to a target array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target array</param>
        /// <param name="offset">The position in the target array where receipt of source data can begin</param>
        void store(in Vec128<T> src, T[] dst, int offset = 0);

        /// <summary>
        /// Writes data data in a list of source vectors to a target array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target array</param>
        /// <param name="offset">The position in the target array where receipt of source data can begin</param>
        void store(in Index<Vec128<T>> src, T[] dst, int offset = 0);
    }

    /// <summary>
    /// Defines floating-point comparison operations
    /// </summary>
    /// <typeparam name="T">The primitive floating-point type, either single or double</typeparam>
    public interface InXCmpF<T> : InXOp
        where T : struct, IEquatable<T>

    {
        bool cmpf(Num128<T> lhs, Num128<T> rhs, FloatComparisonMode mode);
        
        bool[] cmpf(Vec128<T> lhs, Vec128<T> rhs, FloatComparisonMode mode);
    }

    public interface InXSqrt<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Num128<T> sqrt(Num128<T> lhs);
     
        Vec128<T> sqrt(Vec128<T> lhs);        

        Vec256<T> sqrt(Vec256<T> lhs);        

    }

    public interface InXConvert<S,T> : InXOp<S,T>
        where T : struct, IEquatable<T>
        where S : struct, IEquatable<S>
    {
        Vec128<T> convert(Vec128<S> src, out Vec128<T> dst);
    }


    public interface InXStream<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        /// <summary>
        /// Constructs a stream of vectors predicated on an array
        /// </summary>
        /// <param name="src">The source data</param>
        IEnumerable<Vec128<T>> stream(T[] src);
    }

    public interface InXXOr<T> : InXOp<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> xor(Vec128<T> lhs, Vec128<T> rhs);        
    }
}