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


    public delegate T BinaryOp<T>(T lhs, T rhs);

    public delegate S BinaryOp<S,T>(S lhs, T rhs);

    public delegate T ShiftOp<T>(T lhs, int units);

    public delegate T BinaryOpIn<T>(in T lhs, in T rhs);

    public delegate ref T BinaryOpRef<T>(ref T lhs, T rhs);
    
    public delegate T BinaryOpOut<T>(T lhs, T rhs, out T dst);

    public delegate T UnaryOp<T>(T src);

    public delegate T UnaryOpOut<T>(T src, out T dst);

    public delegate ref T UnaryOpRef<T>(ref T io);

    public delegate bool BinaryPredicate<T>(T lhs, T rhs);

}