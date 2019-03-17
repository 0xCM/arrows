//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;

    public interface BinaryRelation<A,B>
    {
        bool related(A a, B b);
    }

    public interface Reflexive<A> : BinaryRelation<A,A>
    {

    }

    public interface Equivalence<X>
    {

    }

}