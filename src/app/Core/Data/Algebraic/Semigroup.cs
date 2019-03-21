//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Runtime.CompilerServices;
    using static corefunc;
    using static Class;

    partial class Reify
    {
        public readonly struct SemigroupM<T> : Class.SemigroupM<T>, Singleton<SemigroupM<T>>
            where T : Class.SemigroupM<T>, new()
        {    
            static readonly Class.SemigroupM<T> Ops = ops<T,SemigroupM<T>>();

            public static SemigroupM<T> Inhabitant = default;
            

            public SemigroupM<T> inhabitant 
                => Inhabitant;

            [MethodImpl(Inline)]
            public T mul(T lhs, T rhs)
                => Ops.mul(lhs,rhs);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs)
                => Ops.eq(lhs,rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs)
                => Ops.neq(lhs,rhs);

            [MethodImpl(Inline)]
            public T apply(T lhs, T rhs) 
                => mul(lhs,rhs);

            public Func<T, T, T> multiplication
                => mul;

        }

        public readonly struct SemigroupA<T> : Class.SemigroupA<T>, Singleton<SemigroupA<T>>
            where T : Class.SemigroupA<T>, new()
        {    
            static readonly Class.SemigroupA<T> Ops = ops<T,SemigroupA<T>>();

            public static SemigroupA<T> Inhabitant = default;
            
            public SemigroupA<T> inhabitant 
                => Inhabitant;

            public Func<T, T, T> addition 
                => add;

            [MethodImpl(Inline)]
            public T add(T a, T b) 
                => Ops.add(a,b);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs) 
                => Ops.eq(lhs,rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs) 
                => Ops.neq(lhs,rhs);

            [MethodImpl(Inline)]
            public T apply(T lhs, T rhs) 
                => add(lhs,rhs);

        }

    }
}