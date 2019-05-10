//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zcore;



    public readonly struct Semigroup<T> : ISemigroupOps<T>
        where T : ISemigroup<T>, new()
    {    

        public static Semigroup<T> Inhabitant = default;
        

        [MethodImpl(Inline)]
        public bool eq(T lhs, T rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public bool neq(T lhs, T rhs) 
            => !lhs.Equals(rhs);
    }


    public readonly struct SemigroupM<T> : ISemigroupMOps<T>
        where T : ISemigroupM<T>, new()
    {    

        public static SemigroupM<T> Inhabitant = default;
        
        [MethodImpl(Inline)]
        public T mul(T lhs, T rhs)
            => lhs.mul(rhs);


        [MethodImpl(Inline)]
        public bool eq(T lhs, T rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public bool neq(T lhs, T rhs) 
            => !lhs.Equals(rhs);

    }

    public readonly struct SemigroupA<T> : ISemigroupAOps<T>
        where T : ISemigroupA<T>, new()
    {    
        
        [MethodImpl(Inline)]
        public T add(T lhs, T rhs) 
            => lhs.add(rhs);

        [MethodImpl(Inline)]
        public bool eq(T lhs, T rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public bool neq(T lhs, T rhs) 
            => !lhs.Equals(rhs);
    }

}