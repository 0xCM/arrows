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

            _Expect = defer(() => Expected().ToIndex());
            Claim.eq(SampleSize, VecCount*VecLength);

        }

        protected virtual Vec128BinOp<T> VecOp {get;}

        protected virtual PrimalFusedBinOp<T> IndexOp {get;}

        protected IEnumerable<Vec128<T>> Results()
            => Results(VecOp);

        protected IEnumerable<ArraySegment<T>> LeftSegments
            => Arr.partition(LeftDataSrc.ToArray(), VecLength);

        protected IEnumerable<ArraySegment<T>> RightSegments
            => Arr.partition(RightDataSrc.ToArray(), VecLength);

        IEnumerable<Vec128<T>> Expected()
        {
            var leftSeg = LeftSegments.ToArray();
            var rightSeg = RightSegments.ToArray();
            for(var i =0; i< VecCount; i++)
                yield return Vec128.single<T>(IndexOp(leftSeg[i],rightSeg[i]));
        }

        Lazy<Index<Vec128<T>>> _Expect;

        Index<Vec128<T>> Expect => _Expect.Value;

        protected Index<Vec128<T>> Apply(Vec128BinOp<T> vecop)
        {
            var results = new Vec128<T>[VecCount];
            for(var i = 0; i<VecCount; i++)
                 results[i] = vecop(LeftVecSrc[i], RightVecSrc[i]);                    
            return results;
        }


        protected void VerifyMatch(Index<Vec128<T>> lhs, Index<Vec128<T>> rhs)
        {
            Claim.eq(lhs.Length,rhs.Length);

            for(var i = 0; i<VecCount; i++)
                Claim.eq(lhs[i], rhs[i]);
        }

        public virtual Index<Vec128<T>> ApplyCanonicalOp()
        {
            if(VecOp == null)
                return Index<Vec128<T>>.Empty;

            return Apply(VecOp);
        }

        public virtual void VerifyCanonicalOp()            
            => VerifyMatch(Expect, ApplyCanonicalOp());

        public virtual void VerifyAll()
        {
            VerifyCanonicalOp();
        }

        protected void ApplyAll(int? reps = null)
        {
            var repeat = reps ?? Defaults.OpApplyReps;

            var statsMsg = $"{VecCount} vector pairs | {reps} reps";
            

            if(VecOp != null)
            {
                var timing = Timing.begin($"Canonical {OpName} operation | {statsMsg}");
                iter(repeat, i => ApplyCanonicalOp());
                Timing.end(timing);                
            }
        }

        public virtual void Verify()
            => Verify(VecOp, IndexOp);        

        public virtual void Apply()
            => Results().ToList();
    } 
}