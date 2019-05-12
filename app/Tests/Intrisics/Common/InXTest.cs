//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static zfunc;
    using static mfunc;

    public abstract class InXTest<S,T> : Testing.UnitTest<S>
        where S : InXTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected static readonly int ComponentSize = Vec128<T>.CellSize;

        protected static readonly int VecLength = Vec128<T>.Length;

        protected override string OpName {get;}

        protected int VecCount
            => SampleSize / VecLength;

        protected InXTest(OpId<T> OpId, Interval<T>? domain = null, int? sampleSize = null)
            :base(sampleSize)
        {
            this.OpId = OpId;
            this.OpName = OpId.ToString();
            this.Domain = domain ?? Defaults.get<T>().Domain;       
            
            this.UnarySrc = RandArray();
            Claim.eq(UnarySrc.Length, SampleSize);
            Claim.eq(VecLength,  16 / ComponentSize);
            Claim.eq(VecLength*VecCount, SampleSize);

            var lArray = RandArray(SampleSize);
            Claim.eq(lArray.Length, SampleSize);
            this.LeftDataSrc = lArray;
            
            this.LeftVecSrc = Vec128.exhaust(lArray);
            Claim.eq(LeftVecSrc.Length, VecCount);

            var rArray =  Randomizer.Array<T>(SampleSize);
            Claim.eq(rArray.Length, SampleSize);
            this.RightDataSrc = rArray;

            this.RightVecSrc = Vec128.exhaust(rArray);
            Claim.eq(RightVecSrc.Length, VecCount);


        }

        public OpId<T> OpId {get;}
        
        protected Interval<T> Domain {get;}

        protected Index<T> UnarySrc {get;}

        protected Index<T> LeftDataSrc {get;}

        protected Index<T> RightDataSrc {get;}

        protected Vec128<T>[] LeftVecSrc {get;}

        protected Vec128<T>[] RightVecSrc {get;}

        protected IEnumerable<Vec128<T>> Results(Vec128BinOp<T> vecop)
        {
            for(var i = 0; i< VecCount; i++)
                yield return vecop(LeftVecSrc[i], RightVecSrc[i]);            
        }

        /// <summary>
        /// Applies a specified intrinsic binary operator the the left and right source vectors and
        /// compares the respective result vectors to the values obtained by applying a specified
        /// primtive operator over the source vectors
        /// </summary>
        /// <param name="vecop">The intrinsic vector operator</param>
        /// <param name="listop">The primitive operator</param>
        protected void Verify(Vec128BinOp<T> vecop, PrimalFusedBinOp<T> listop)
        {
            var leftVals = partition(LeftDataSrc.ToArray(), VecLength).ToReadOnlyList();
            var rightVals =partition(RightDataSrc.ToArray(), VecLength).ToReadOnlyList();
            for(var i = 0; i<VecCount; i++)
            {
                var lvec = LeftVecSrc[i];
                var rvec = RightVecSrc[i];
                var actual = vecop(lvec, rvec);                
                var expect = Vec128.single<T>(listop(leftVals[i],rightVals[i]));
                ClaimEq(lvec, rvec, expect, actual,i);
            }                
        }

        protected virtual void ClaimEq(Vec128<T> lvec, Vec128<T> rvec, Vec128<T> expect, Vec128<T> actual, int i)
        {
            if(!expect.Equals(actual))
                throw new Exception($"Operator failure during iteration {i}: {lvec} OpName {rvec} | Expected = {expect}, Actual = {actual}");
        }

        protected IEnumerable<Vector128<T>> UnarySrcVectors
        {
            get
            {
                for(var i = 0; i< UnarySrc.Length; i += VecLength)
                    yield return Vec128.define(UnarySrc.ToArray(), i);
            }
        }


        /// <summary>
        /// Interates the array indexes that are multiples of vector length into a receiver
        /// </summary>
        /// <param name="receiver">The function that receives each offset value</param>
        protected int IterOffsets(Action<int> receiver)
        {
            var offCount = 0;
            for(var offset =0; offset < SampleSize; offset += VecLength)
            {
                receiver(offset);
                offCount++;
            }
            Claim.eq(offCount, VecCount);
            return offCount;
        }

        /// <summary>
        /// Interates the array indexes that are multiples of vector length into a receiver
        /// that takes an order pair (c,i) where c := offsetCount, i := offsetIndex
        /// </summary>
        /// <param name="receiver">The function that receives each offset value</param>
        protected int IterOffsets(Action<int,int> receiver)
        {
            var offCount = 0;
            for(var offset =0; offset < SampleSize; offset += VecLength)
                receiver(offCount++,offset);
            Claim.eq(offCount, VecCount);
            return offCount;
        }
                
        /// Produces an array of random values
        /// </summary>
        /// <param name="count">The number of values in the produced array</param>
        protected T[] RandArray(int? count = null)
            => Randomizer.Array(Domain, count ?? SampleSize);

        protected void trace(string msg, [CallerMemberName] string caller = null)
            => base.Trace(msg, caller);

        protected void trace(int count, [CallerMemberName] string caller = null)
            => base.Trace($"Applied the {OpName} operator over {count} vectors", caller);
    }    
}