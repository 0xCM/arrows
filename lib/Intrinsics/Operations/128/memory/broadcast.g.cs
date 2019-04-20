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
    
    using static zcore;
    using static inxfunc;


    partial class InXG
    {


    }

    partial class SSR
    {
        /// <summary>
        /// The generic add operator via stateless singleton reification
        /// </summary>
        public readonly struct InXGtG<T> : InXGt<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXGt<T> Operator = cast<InXGt<T>>(InXBitTest.TheOnly);

            public Vec128<T> gt(Vec128<T> lhs, Vec128<T> rhs)
            {
                throw new NotImplementedException();
            }
        }


        public readonly struct InXGt : 
            InXGt<double>
        {        
            public static readonly InXBitTest TheOnly = default;

            public Vec128<double> gt(Vec128<double> lhs, Vec128<double> rhs)
            {
                throw new NotImplementedException();
            }
        }


    }
            

}