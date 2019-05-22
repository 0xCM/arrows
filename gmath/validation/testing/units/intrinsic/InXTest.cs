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

    public abstract class InXTest<S,T> : UnitTest<S>
        where S : InXTest<S,T>
        where T : struct
    {
        protected static readonly int ComponentSize = Vec128<T>.CellSize;

        protected static readonly int VecLength = Vec128<T>.Length;


        /// Produces an array of random values
        /// </summary>
        /// <param name="count">The number of values in the produced array</param>
        protected T[] RandArray()
            => Randomizer.Array<T>(Config.SampleSize,Config.Get<T>().SampleDomain);

        protected InXTest(OpId<T> OpId, ITestConfig config = null)
            : base((config ?? TestConfigDefaults.Default()).WithSampleSize(4 * Pow2.T08))
        {
            this.OpId = OpId;
            this.VecCount = Config.SampleSize / VecLength;            
            this.UnarySrc = RandArray();
            this.LeftSamples = RandArray();
            this.RightSamples = RandArray();

            Claim.eq(VecLength,  16 / ComponentSize);
            Claim.eq(VecLength*VecCount, Config.SampleSize);
        }

        protected int VecCount {get;}

        public OpId<T> OpId {get;}
        
        protected Index<T> UnarySrc {get;}

        protected T[] LeftSamples;

        protected T[] RightSamples;

        protected Vec128<T> LeftVector(int index)
            => Vec128.define(LeftSamples, index*VecLength);

        protected Vec128<T> RightVector(int index)
            => Vec128.define(RightSamples, index*VecLength);

        protected IEnumerable<Vec128<T>> Results(Vec128BinOp<T> op)
        {
            for(var i = 0; i< VecCount; i++)
                yield return op(LeftVector(i), RightVector(i));            
        }

        /// <summary>
        /// Applies a specified intrinsic binary operator the the left and right source vectors and
        /// compares the respective result vectors to the values obtained by applying a specified
        /// primtive operator over the source vectors
        /// </summary>
        /// <param name="vectorOp">The intrinsic vector operator</param>
        /// <param name="listOp">The primitive operator</param>
        protected void Verify(Vec128BinOp<T> vectorOp, PrimalFusedBinOp<T> listOp)
        {
            var leftParts = partition(LeftSamples, VecLength).ToReadOnlyList();
            var rightParts =partition(RightSamples, VecLength).ToReadOnlyList();
            for(var i = 0; i<VecCount; i++)
            {
                var lhs = LeftVector(i);
                var rhs = RightVector(i);
                var expect = Vec128.single<T>(listOp(leftParts[i], rightParts[i]));
                var result = vectorOp(lhs, rhs);                
                ClaimEq(lhs, rhs, expect, result,i);
            }                
        }

        protected virtual void ClaimEq(Vec128<T> lvec, Vec128<T> rvec, Vec128<T> expect, Vec128<T> actual, int i)
        {
            if(!expect.Eq(actual))
                throw new Exception($"Operator failure during iteration {i}: {lvec} OpName {rvec} | Expected = {expect}, Actual = {actual}");
        }

        /// <summary>
        /// Interates the array indexes that are multiples of vector length into a receiver
        /// </summary>
        /// <param name="receiver">The function that receives each offset value</param>
        protected int IterOffsets(Action<int> receiver)
        {
            var offCount = 0;
            for(var offset =0; offset < Config.SampleSize; offset += VecLength)
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
            for(var offset =0; offset < Config.SampleSize; offset += VecLength)
                receiver(offCount++,offset);
            Claim.eq(offCount, VecCount);
            return offCount;
        }            

    }    
}