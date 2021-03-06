//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    public abstract class AsmOpTest<U> : UnitTest<U>
        where U : AsmOpTest<U>
    {
        protected void VerifyOp<T>(AsmBinOp<T> asmop, Func<T,T,T> refop, int? n = null)
            where T : unmanaged
        {
            var lhs = Random.Array<T>(n ?? SampleSize);
            var rhs = Random.Array<T>(n ?? SampleSize);
            var setup = from args in lhs.Zip(rhs)
                          let expect = refop(args.First, args.Second)
                          let actual = asmop(args.First, args.Second) 
                          select (expect, actual, success: expect.Equals(actual));
            var execute = from r in setup
                          where !r.success
                          select (r.expect, r.actual);
            Claim.eq(0, execute.Count());            
        }

        protected void VerifyOp<T>(AsmUnaryOp<T> asmop, Func<T,T> refop, int? n = null)
            where T : unmanaged
        {
            TypeCaseStart<T>();
            var src = Random.Array<T>(n ?? SampleSize);
            var setup = from arg in src
                          let expect = refop(arg)
                          let actual = asmop(arg) 
                          select (expect, actual, success: expect.Equals(actual));
            var execute = from r in setup
                          where !r.success
                          select (r.expect, r.actual);
            Claim.eq(0, execute.Count());            
            TypeCaseEnd<T>();
        }

        protected void VerifyOp<T>(AsmCode<T> code, Func<T,T,T> refop)
            where T : unmanaged
                => VerifyOp(code.CreateBinOp<T>(), refop, SampleSize);

        protected void VerifyOp<T>(AsmCode<T> code, Func<T,T> refop, int n)
            where T : unmanaged
                => VerifyOp(code.CreateUnaryOp<T>(),refop,n);
    }
}