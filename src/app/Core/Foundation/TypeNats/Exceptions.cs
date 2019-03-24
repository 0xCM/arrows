//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using static corefunc;


    public class NatConstraintException : Exception
    {
        public string Expect {get;}
        
        public string Actual{get;}

        public string Constraint {get;}

        public NatConstraintException(string constraint, uint expect, uint actual)
        {
            this.Constraint = constraint;
            this.Expect = expect.ToString();
            this.Actual = actual.ToString();            
        }

        public NatConstraintException(string constraint, (uint x, uint y) relation )
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