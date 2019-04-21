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
            ClaimEq(SampleSize, VecCount*VecLength);

        }


        protected virtual Vec128BinOp<T> VecOp {get;}

        protected virtual Vec128BinOut<T> VecOpOut {get;}

        protected virtual Vec128BinAOut<T> VecOpAOut {get;}

        protected virtual IndexBinOp<T> IndexOp {get;}

        protected IEnumerable<Vec128<T>> Results()
            => Results(VecOp);

        protected IEnumerable<ArraySegment<T>> LeftSegments
            => Arr.partition(LeftDataSrc, VecLength);

        protected IEnumerable<ArraySegment<T>> RightSegments
            => Arr.partition(RightDataSrc, VecLength);

        IEnumerable<Vec128<T>> Expected()
        {
            var leftSeg = LeftSegments.ToArray();
            var rightSeg = RightSegments.ToArray();
            for(var i =0; i< VecCount; i++)
                yield return Vec128.define(IndexOp(leftSeg[i],rightSeg[i]));
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

        protected Index<Vec128<T>> Apply(Vec128BinAOut<T> vecop)
        {
            var storage = new T[SampleSize];
            for(int i = 0, offset = 0; i<VecCount; i++, offset += VecLength)
                vecop(LeftVecSrc[i], RightVecSrc[i], storage, offset);                
            return storage.Stream128().ToIndex();            
        }

        protected Index<Vec128<T>> Apply(Vec128BinOut<T> vecop)
        {
            var results = new Vec128<T>[VecCount];
            for(int i = 0, offset = 0; i<VecCount; i++, offset += VecLength)
                vecop(LeftVecSrc[i], RightVecSrc[i], out results[i]);                
            return results;        
        }


        protected void VerifyMatch(Index<Vec128<T>> lhs, Index<Vec128<T>> rhs)
        {
            for(var i = 0; i<VecCount; i++)
                ClaimEq(lhs[i], rhs[i]);
        }

        public virtual Index<Vec128<T>> ApplyCanonicalOp()
        {
            if(VecOp == null)
                return Index<Vec128<T>>.Empty;

            return Apply(VecOp);
        }

        public virtual Index<Vec128<T>> ApplyOutOp()
        {
            if(VecOpOut == null)
                return Index<Vec128<T>>.Empty;

            return(Apply(VecOpOut));
        }


        public virtual Index<Vec128<T>> ApplyStoreOp()
        {
            if(VecOpAOut == null)
                return Index<Vec128<T>>.Empty;

            return Apply(VecOpAOut);

        }

        public virtual void VerifyCanonicalOp()            
            => VerifyMatch(Expect, ApplyCanonicalOp());

        public virtual void VerifyOutOp()
            => VerifyMatch(Expect, ApplyOutOp());

        public virtual void VerifyStoreOp()
            => VerifyMatch(Expect, ApplyStoreOp());

        public virtual void VerifyAll()
        {
            VerifyCanonicalOp();
            VerifyStoreOp();
            VerifyOutOp();
        }

        protected void ApplyAll(int? reps = null)
        {
            var repeat = reps ?? Defaults.OpApplyReps;

            var statsMsg = $"{VecCount} vector pairs | {reps} reps";
            

            if(VecOp != null)
            {
                var sw = begin($"Applying canonical {OpName} operation | {statsMsg}");
                iter(repeat, i => ApplyCanonicalOp());
                end($"Applied canonical {OpName} operation | {statsMsg}", sw);                
            }

            if(VecOpAOut != null)
            {
                var sw = begin($"Applying {OpName} store operation | {statsMsg}");
                iter(repeat, i => ApplyStoreOp());
                end($"Applied {OpName} store operation | {statsMsg}",sw);
            }

            if (VecOpOut != null)
            {
                var sw = begin($"Verifing {OpName} operation with output parameter | {statsMsg}");
                iter(repeat, i => ApplyOutOp());                                    
                end($"Applied {OpName} operation with output parameter | {statsMsg} ",sw);
            }
        }

        public virtual void Verify()
            => Verify(VecOp, IndexOp);        

        public virtual void Apply()
            => Results().ToList();
    } 
}