//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;

    using C = Contracts;
    
    public static class QR
    {
        public static QR<T> define<T>(T q, T r)
            => new QR<T>(q,r);
    }
    
    public readonly struct QR<T>
    {
        public readonly T q;
        
        public readonly T r;

        [MethodImpl(Inline)]
        public QR(T q, T r)
        {
            this.q = q;
            this.r = r;
        }
    }

    public static class BinaryOperator
    {
        public static C.BinaryOperator<T> define<T>(Func<T,T,T> op, bool commutative = false)
            => commutative 
            ?  cast<C.BinaryOperator<T>>(new Commutative<T>(op)) 
            : new BinaryOperator<T>(op);
    }

    public static class UnaryOperator
    {
        public static C.UnaryOperator<T> define<T>(Func<T,T> op)
            => new UnaryOperator<T>(op);
    }

    public readonly struct UnaryOperator<T> : C.UnaryOperator<T>
    {
        readonly Func<T,T> op;

        [MethodImpl(Inline)]
        public T apply(T x)
            => op(x);

        [MethodImpl(Inline)]
        public UnaryOperator(Func<T,T> op)
            => this.op = op;
    }

    public readonly struct BinaryOperator<T> : C.BinaryOperator<T>
    {
        readonly Func<T,T,T> op;

        [MethodImpl(Inline)]
        T C.BinaryOperator<T>.compose(T a, T b)
            => op(a,b);

        [MethodImpl(Inline)]
        public BinaryOperator(Func<T,T,T> op)
            => this.op = op;
    }

    /// <summary>
    /// Defines a commutative operator
    /// </summary>
    public readonly struct Commutative<T> : C.Commutative<T>
    {
        readonly Func<T,T,T> op;

        [MethodImpl(Inline)]
        T C.BinaryOperator<T>.compose(T a, T b)
            => op(a,b);

        [MethodImpl(Inline)]
        public Commutative(Func<T,T,T> op)
            => this.op = op;
    }


    /// <summary>
    /// Provides a layer of indirection for, and gives a concrete type to, an IEnumerable instance
    /// </summary>
    public readonly struct Enumerable<I> : C.Enumerable<Enumerable<I>,I>
    {
        readonly IEnumerable<I> src;
        
        public Enumerable(IEnumerable<I> src)
        {
            this.src = src;
        }

        IEnumerator<I> IEnumerable<I>.GetEnumerator()
            => src.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => src.GetEnumerator();

        public Enumerable<I> redefine(IEnumerable<I> src)
            => new Enumerable<I>(src);
        
    }

    public static class Enumerable
    {
        public static Enumerable<I> define<I>(IEnumerable<I> src)
            => new Enumerable<I>(src); 

        public static Enumerable<I> define<I>(params I[] src)
            => new Enumerable<I>(src); 

        /// <summary>
        /// Instantiates the canonical conrete type (but does not force evaluation) 
        /// for an IEnumerable instance
        /// </summary>
        /// <param name="src">The</param>
        /// <typeparam name="I"></typeparam>
        /// <returns></returns>
        public static Enumerable<I> Reify<I>(this IEnumerable<I> src)
            => define(src);
    }
    
}