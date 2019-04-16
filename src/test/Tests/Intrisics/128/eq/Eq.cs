//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    /// <summary>
    /// Characterizes a constant value
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    public interface Constant<T>
        where T : struct, IEquatable<T>
    {
        T Value {get;}
    }
    
    readonly struct EqualityMarker<T> : Constant<T>
        where T : struct, IEquatable<T>
    {
        static readonly T Marker = EqualityMarker.value<T>();

        T Constant<T>.Value 
        {
            [MethodImpl(Inline)]
            get => Marker;
        }
            
    }

    public readonly struct EqualityMarker :
        Constant<byte>,
        Constant<sbyte>,
        Constant<short>,
        Constant<ushort>,
        Constant<int>,
        Constant<uint>,
        Constant<long>,
        Constant<ulong>,
        Constant<float>,
        Constant<double>
    {
        public static readonly EqualityMarker TheOnly = default;

        public static T value<T>()
            where T : struct, IEquatable<T>
                => cast<Constant<T>>(TheOnly).Value;
        
        sbyte Constant<sbyte>.Value 
        {
            [MethodImpl(Inline)]
            get => -1;
        }

        byte Constant<byte>.Value 
            => 0xff;

        short Constant<short>.Value 
            => -1;

        ushort Constant<ushort>.Value 
        {
            [MethodImpl(Inline)]
            get => 0xFFFF;
        }

        int Constant<int>.Value 
            => -1;

        uint Constant<uint>.Value 
        {
            [MethodImpl(Inline)]
            get => 0xFFFFFFFF;
        }

        long Constant<long>.Value 
            => -1;

        ulong Constant<ulong>.Value 
            => 0xFFFFFFFFFFFFFFFF;

        float Constant<float>.Value 
            => float.NaN;

        double Constant<double>.Value 
            => float.NaN;

    }
    public abstract class EqTest<S,T> : InXTest<S,T>
        where S : EqTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected const string BasePath = P.InX128 + P.eq;        
        
        protected static readonly InX128Eq<T> InXOp = InX128G.eq<T>();
        
        protected static readonly Operative.PrimOps<T> PrimOps = primops.typeops<T>();
        
        protected T[] LeftDataSrc {get;}

        protected T[]  RightDataSrc {get;}
        protected IReadOnlyList<Vec128<T>> LeftVecSrc {get;}

        protected IReadOnlyList<Vec128<T>> RightVecSrc {get;}

        protected EqTest(Interval<T>? domain = null, int? sampleSize = null)
            : base("+", domain, sampleSize)        
        {
            this.LeftDataSrc = RandomArray(SampleSize);
            this.RightDataSrc = LeftDataSrc;
            this.LeftVecSrc = Vec128.stream(LeftDataSrc).ToReadOnlyList();
            this.RightVecSrc = Vec128.stream(RightDataSrc).ToReadOnlyList();
        }
                
        protected IEnumerable<Vec128<T>> ApplyOp()
        {
            for(var i = 0; i< VecCount; i++)
                yield return InXOp.eq(LeftVecSrc[i], RightVecSrc[i]);            
        }

        protected void VerifyOp()
        {
            var zero = primops.zero<T>();
            var result = ApplyOp().ToReadOnlyList();
            for(var i = 0; i<LeftVecSrc.Count; i++)
            {
                var components = result[i].ToArray();
                if(components.Any(c => c.Equals(zero)))
                    Claim.fail("The components are not equal");
            }
                
        }

        protected void trace(int count, [CallerMemberName] string caller = null)
            => base.trace($"Compared equality for {count} vectors",caller);
        
        public virtual void Verify() {}

        public virtual void Apply() {}

    }


}