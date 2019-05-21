//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic; 


    public class DemandException : Exception
    {
        public string Expect {get;}
        
        public string Actual{get;}

        public string Constraint {get;}

        public DemandException(string constraint, object expect, object actual)
        {
            this.Constraint = constraint;
            this.Expect = expect.ToString();
            this.Actual = actual.ToString();            
        }

        public DemandException(string constraint, (uint x, uint y) relation )
        {
            this.Constraint = constraint;
            this.Expect = $"({relation.x}, {relation.y})";            
            this.Actual = string.Empty;
        }

        public DemandException(string constraint, (ulong x, ulong y) relation )
        {
            this.Constraint = constraint;
            this.Expect = $"({relation.x}, {relation.y})";            
            this.Actual = string.Empty;
        }

        public override string Message 
            => Actual != string.Empty 
             ? $"Natural number {Constraint} failed. Expected: {Expect} | Actual: {Actual}"
             : $"Natural invariant {Constraint} failed: {Expect}";

    }

}