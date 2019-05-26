//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;


    public static class RefTuple
    {
        public static RefTuple<X0> Define<X0>(X0 x0)
            => new RefTuple<X0>(x0);

        public static RefTuple<X0,X1> Define<X0,X1>(X0 x0, X1 x1)
            => new RefTuple<X0,X1>(x0,x1);

        public static RefTuple<X0,X1,X2> Define<X0,X1,X2>(X0 x0, X1 x1, X2 x2)
            => new RefTuple<X0,X1,X2>(x0,x1, x2);

    }
    
    public ref struct RefTuple<X0>
    {
        public RefTuple(X0 x0)
        {
            this.x0 = x0;
        }

        public X0 x0;
    }

    public ref struct RefTuple<X0,X1>
    {
        public X0 x0;

        public X1 x1;

        public RefTuple(X0 x0, X1 x1)
        {
            this.x0 = x0;
            this.x1 = x1;
        }
    }

    public ref struct RefTuple<X0,X1,X2>
    {
        public X0 x0;

        public X1 x1;

        public X2 x2;

        public RefTuple(X0 x0, X1 x1, X2 x2)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.x2 = x2;
        }
    }


}