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

    public abstract class InXTest<S,T> : UnitTest<S>
        where S : InXTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected static readonly int PrimSize = Vec128<T>.ComponentSize;

        protected static readonly int VecLength = Vec128<T>.Length;

        protected static readonly Operative.PrimOps<T> PrimOps = primops.typeops<T>();

        protected override string OpName {get;}

        protected int VecCount
            => SampleSize / VecLength;

        protected InXTest(string opname, Interval<T>? domain = null, int? sampleSize = null)
            :base(sampleSize)
        {
            this.OpName = opname;
            this.Domain = domain ?? Defaults.get<T>().Domain;       
            
            this.UnarySrc = RandArray();
            Claim.eq(UnarySrc.Length, SampleSize);
            Claim.eq(VecLength,  16 / PrimSize);

            this.LeftDataSrc = RandArray(SampleSize);
            this.RightDataSrc = RandArray(SampleSize);
            this.LeftVecSrc = Vec128.stream(LeftDataSrc).ToIndex();
            this.RightVecSrc = Vec128.stream(RightDataSrc).ToIndex();

        }

        protected PrimKind PritiveKind {get;} = PrimKinds.kind<T>();

        protected Interval<T> Domain {get;}

        protected Index<T> UnarySrc {get;}

        protected Index<T> LeftDataSrc {get;}

        protected Index<T> RightDataSrc {get;}

        protected Index<Vec128<T>> LeftVecSrc {get;}

        protected Index<Vec128<T>> RightVecSrc {get;}

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
        protected void Verify(Vec128BinOp<T> vecop, IndexBinOp<T> listop)
        {
            var leftVals = Arr.partition(LeftDataSrc.ToArray(), VecLength).ToReadOnlyList();
            var rightVals = Arr.partition(RightDataSrc.ToArray(), VecLength).ToReadOnlyList();
            for(var i = 0; i<VecCount; i++)
            {
                var lvec = LeftVecSrc[i];
                var rvec = RightVecSrc[i];
                var actual = vecop(lvec, rvec);                
                var expect = Vec128.single(listop(leftVals[i],rightVals[i]));
                ClaimEq(lvec, rvec, expect, actual,i);
            }                
        }

        protected virtual void ClaimEq(Vec128<T> lvec, Vec128<T> rvec, Vec128<T> expect, Vec128<T> actual, int i)
        {
            if(!expect.Equals(actual))
                throw new Exception($"Operator failure during iteration {i}: {lvec} OpName {rvec} | Expected = {expect}, Actual = {actual}");
        }

        /// <summary>
        /// Partitions the source array into array segments with vector length
        /// </summary>
        protected IEnumerable<ArraySegment<T>> UnarySrcSegments
            =>  Arr.partition(UnarySrc.ToArray(), VecLength);

        /// <summary>
        /// Defines a stream of vectors over the source array
        /// </summary>
        protected IEnumerable<Vec128<T>> UnarySrcVectors
            => UnarySrcSegments.Select(seg => Vec128.define(seg));

        /// <summary>
        /// Iterates the source segments into a receiver
        /// </summary>
        /// <param name="receiver">The segment receiver</param>
        protected void IterUnarySegments(Action<ArraySegment<T>> receiver)
        {
            foreach(var seg in UnarySrcSegments)
                receiver(seg);
        }

        /// <summary>
        /// Iterates the source vectors into a receiver
        /// </summary>
        /// <param name="receiver">The vector receiver</param>
        protected void IterUnaryVectors(Action<Vec128<T>> receiver)
        {
            foreach(var vec in UnarySrcVectors)
                receiver(vec);
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
                

        /// <summary>
        /// Discretizes the instance domain using an optionall-specified partition width
        /// </summary>
        /// <param name="step">The width of each partition</param>
        protected IEnumerable<T> Partition(T? step = null)
            => Domain.Discretize(step);

        /// <summary>
        /// Produces an array of random values
        /// </summary>
        /// <param name="count">The number of values in the produced array</param>
        protected T[] RandArray(Interval<T> domain, int? count = null)
            => RandomIndex(domain, count ?? SampleSize);

        /// <summary>
        /// Produces a list of random values
        /// </summary>
        /// <param name="domain">The interval from which the values are selected</param>
        /// <param name="count">The number of values in the produced list</param>
        protected Index<T> RandIndex(Interval<T> domain, int? count = null)
            => RandomStream(domain).TakeArray(count ?? SampleSize);


        /// <summary>
        /// Produces an array of random values
        /// </summary>
        /// <param name="count">The number of values in the produced array</param>
        protected T[] RandArray(int? count = null)
            => RandArray(Domain, count ?? SampleSize);


        /// <summary>
        /// Produces a list of random values
        /// </summary>
        /// <param name="count">The number of values in the produced list</param>
        protected Index<T> RandIndex(int? count = null)
            => RandIndex(Domain,count ?? SampleSize);

        /// <summary>
        /// Produces a random list that occupies 128 bits = 16 bytes of memory
        /// </summary>
        protected Index<T> RandIndex128()
            => RandIndex(VecLength);

        /// <summary>
        /// Produces a random array that occupies 128 bits = 16 bytes of memory
        /// </summary>
        protected T[] RandArray128()
            => RandArray(VecLength);


        /// <summary>
        /// Produces a random 128-bit vector
        /// </summary>
        protected Vec128<T> RandVec128()        
            => Vec128.single<T>(RandArray(VecLength));

        /// <summary>
        /// Produces a stream of random arrays where each array occupies 128 bits = 16 bytes of memory
        /// </summary>
        /// <param name="count">The number of arrays to produce</param>
        protected IEnumerable<T[]> RandArrays128(int? count = null)
        {
            for(var i = 0; i< (count ?? VecCount); i++)
                 yield return RandArray128();
        }

        /// <summary>
        /// Produces a stream of random lists where each list occupies 128 bits = 16 bytes of memory
        /// </summary>
        /// <param name="count">The number of lists to produce</param>
        protected IEnumerable<Index<T>> RandIndexes128(int? count = null)
        {
            for(var i = 0; i< (count ?? VecCount); i++)
                 yield return RandIndex128();
        }
            
        /// <summary>
        /// Produces a stream of random 128-bit vectors
        /// </summary>
        /// <param name="count">The number of vectors to produce</param>
        protected IEnumerable<Vec128<T>> RandVecs128(int? count = null)        
        {
            for(var i = 0; i< (count ?? VecCount); i++)
                 yield return RandVec128();
        }        

        protected void trace(int count, [CallerMemberName] string caller = null)
            => base.trace($"Applied the {OpName} operator over {count} vectors", caller);

    }    
}