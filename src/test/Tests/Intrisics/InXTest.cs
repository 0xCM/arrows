//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
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
        protected static readonly int PrimSize = Vec128<T>.PrimSize;

        protected static readonly int VecLength = Vec128<T>.Length;

        protected override string OpName {get;}

        protected int VecCount
            => SampleSize / VecLength;

        protected InXTest(string opname, Interval<T>? domain = null, int? sampleSize = null)
            :base(sampleSize)
        {
            this.OpName = opname;
            this.Domain = domain ?? Defaults.get<T>().Domain;       
            this.SrcArray = RandArray();
            Claim.eq(SrcArray.Length, SampleSize);
            Claim.eq(VecLength,  16 / PrimSize);

        }

        protected Interval<T> Domain {get;}

        protected T[] SrcArray {get;}

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
            {
                receiver(offCount++,offset);
            }
            Claim.eq(offCount, VecCount);
            return offCount;

        }

        /// <summary>
        /// Partitions the source array into array segments with vector length
        /// </summary>
        protected IEnumerable<ArraySegment<T>> SrcSegments
            =>  Arr.partition(SrcArray, VecLength);

        /// <summary>
        /// Defines a stream of vectors over the source array
        /// </summary>
        protected IEnumerable<Vec128<T>> SrcVectors
            => SrcSegments.Select(seg => Vec128.define(seg));
                
        /// <summary>
        /// Iterates the source segments into a receiver
        /// </summary>
        /// <param name="receiver">The segment receiver</param>
        protected void IterSegments(Action<ArraySegment<T>> receiver)
        {
            foreach(var seg in SrcSegments)
                receiver(seg);
        }

        /// <summary>
        /// Iterates the source vectors into a receiver
        /// </summary>
        /// <param name="receiver">The vector receiver</param>
        protected void IterVectors(Action<Vec128<T>> receiver)
        {
            foreach(var vec in SrcVectors)
                receiver(vec);
        }

        protected string OpInfo<X,Y,Z>(X lhs, Y rhs, Z result)
            => $"{lhs} {OpName} {rhs} = {result}";

        /// <summary>
        /// Discretizes a specified domain using an optionally-specified 
        /// specified partition width
        /// </summary>
        /// <param name="domain">The interval to be partitioned</param>
        /// <param name="step">The width of each partition</param>
        protected IEnumerable<T> Partition(Interval<T> domain, T? step = null)
            => domain.Discretize(step);

        /// <summary>
        /// Discretizes the instance domain using an optionall-specified partition width
        /// </summary>
        /// <param name="step">The width of each partition</param>
        protected IEnumerable<T> Partition(T? step = null)
            => Partition(Domain,step);

        /// <summary>
        /// Produces an array of random values
        /// </summary>
        /// <param name="count">The number of values in the produced array</param>
        protected T[] RandArray(Interval<T> domain, int? count = null)
            => Context.RandArray(domain, count ?? SampleSize);


        /// <summary>
        /// Produces a stream of random-valued arrays
        /// </summary>
        /// <param name="min">The lower bound for produced values</param>
        /// <param name="max">The upper bound for produced values</param>
        /// <param name="count">The number of values in the produced array</param>
        protected IEnumerable<T[]> RandArrays(T min, T max, int count)
        {
            while(true)
                yield return Context.RandArray(min,max,count);
        }

        /// <summary>
        /// Produces a list of random values
        /// </summary>
        /// <param name="domain">The interval from which the values are selected</param>
        /// <param name="count">The number of values in the produced list</param>
        protected IReadOnlyList<T> RandList(Interval<T> domain, int count)
            => Context.Rand(domain).Freeze(count);

        /// <summary>
        /// Produces an interminable stream of random values
        /// </summary>
        /// <param name="min">The lower bound for produced values</param>
        /// <param name="max">The upper bound for produced values</param>
        protected IEnumerable<T> RandStream(T min, T max)
            => Context.Random<T>().stream(min,max);

        /// <summary>
        /// Produces an interminable stream of random values 
        /// <param name="domain">The interval from which the values are selected</param>
        protected IEnumerable<T> RandStream(Interval<T>? domain = null)
            => RandStream((domain ?? Domain).left, (domain ?? Domain).right);

        /// <summary>
        /// Produces a stream of random values
        /// </summary>
        /// <param name="count">The number of values the stream will yield, 
        /// which defaults to the sample size if unspecified</param>
        protected IEnumerable<T> RandStream(int? count = null)
            => RandStream(Domain).Take(count ?? SampleSize);

        /// <summary>
        /// Produces an array of random values
        /// </summary>
        /// <param name="count">The number of values in the produced array</param>
        protected T[] RandArray(int? count = null)
            => RandArray(Domain, count ?? SampleSize);

        /// <summary>
        /// Produces an array of random values
        /// </summary>
        /// <param name="min">The minimum entry value</param>
        /// <param name="max">The maximum entry value</param>
        /// <param name="len">The length of the produced array</param>
        protected T[] RandArray(T min, T max, uint len)
            => RandStream(min,max).TakeArray((int)len);

        /// <summary>
        /// Produces a list of random values
        /// </summary>
        /// <param name="count">The number of values in the produced list</param>
        protected IReadOnlyList<T> RandList(int? count = null)
            => RandList(Domain,count ?? SampleSize);

        /// <summary>
        /// Produces a list of random values
        /// </summary>
        /// <param name="count">The number of values in the produced list</param>
        protected IReadOnlyList<T> RandList(uint? count = null)
            => RandList(Domain, (int) (count ?? (uint)SampleSize));

        /// <summary>
        /// Produces a random list that occupies 128 bits = 16 bytes of memory
        /// </summary>
        protected IReadOnlyList<T> RandList128()
            => RandList(VecLength);

        /// <summary>
        /// Produces a random array that occupies 128 bits = 16 bytes of memory
        /// </summary>
        protected T[] RandArray128()
            => RandArray(VecLength);


        /// <summary>
        /// Produces a random 128-bit vector
        /// </summary>
        protected Vec128<T> RandVec128()        
            => Vec128.define(RandArray(VecLength));

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
        protected IEnumerable<IReadOnlyList<T>> RandLists128(int? count = null)
        {
            for(var i = 0; i< (count ?? VecCount); i++)
                 yield return RandList128();
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
    }    
}