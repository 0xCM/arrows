//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;


   public abstract class InXBinOpTest<S,T> : InXTest<S,T>
        where S : InXBinOpTest<S,T>
        where T : struct, IEquatable<T>

    
    {
        protected InXBinOpTest(string opname, Interval<T>? domain = null, int? sampleSize = null)
            : base(opname, domain, sampleSize)
        {


        }

        protected virtual Vec128BinOp<T> VecOp {get;}       

        protected virtual ListBinOp<T> ListOp {get;}


        protected IEnumerable<Vec128<T>> Results()
            => Results(VecOp);

        public virtual void Verify()
            => Verify(VecOp, ListOp);        

        public virtual void Apply()
            => Results().ToList();

    }

 
}