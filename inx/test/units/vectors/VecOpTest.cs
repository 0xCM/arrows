//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using VecLen = NatSeq<N1,N2,N3>;
    
    using static zfunc;
    using static Nats;    
    public static class VecRandX
    {

        public static RandomPair<N,T> DataSet<N,T>(this IRandomSource random, N length = default)
            where T : struct
            where N : ITypeNat, new()
            => new RandomPair<N, T>(random);

    }

    /// <summary>
    /// Defines a pair of random vectors
    /// </summary>
      public ref struct RandomPair<N,T>
            where T : struct
            where N : ITypeNat, new()
        {
            public RandomPair(IRandomSource random)
            {
                LeftVec = random.NatVector<N,T>();
                RightVec = random.NatVector<N,T>();
                LeftSrc = LeftVec.Unsized;
                RightSrc = RightVec.Unsized;
            }
            
            public Span<N,T> LeftSrc;

            public Vector<N,T> LeftVec;

            public Span<N,T> RightSrc;

            public Vector<N,T> RightVec;
        }

    public class VecOpTest : UnitTest<VecOpTest>
    {   
        void VerifyEquality<N,T>(Vector<N,T> vExpect, Vector<N,T> vResult)
            where T : struct
            where N : ITypeNat, new()
        {
            var len = (int)(new N().value);

            for(var i = 0; i< len; i++)
                Claim.eq(vExpect[i], vResult[i]);

            var eq = vExpect.Eq(vResult);
            for(var i=0; i<len; i++)
                Claim.yea(eq[i]);            
        }        



        void And<N,T>()
            where T : struct
            where N : ITypeNat, new()
        {
            var rep = new N();
            var len = (int)rep.value;
            var data = Random.DataSet<N,T>();            
            var vResult = data.LeftVec.And(data.RightVec);
            
            var calcs = span<T>(len);
            for(var i = 0; i< calcs.Length; i++)
                calcs[i] = gbits.and(data.LeftSrc[i], data.RightSrc[i]);
            var vExpect = Vector.Load(calcs, rep);            
            
            VerifyEquality(vExpect, vResult);
        }


        void Add<N,T>(int cycles = DefaltCycleCount)
            where N : ITypeNat, new()
            where T : struct
        {
            var n = new N();
            for(var i=0; i< cycles; i++)            
            {
                var v1 = Random.NatVector<N,T>();
                var v2 = Random.NatVector<N,T>();
                var v3 = Vector.Load(gmath.add(v1.Unsized,v2.Unsized), n);
                var v4 = v1.Add(v2);
                Claim.yea(v3 == v4);
            }
        }

        void Sub<N,T>(int cycles = DefaltCycleCount)
            where N : ITypeNat, new()
            where T : struct
        {
            var n = new N();
            for(var i=0; i< cycles; i++)            
            {
                var v1 = Random.NatVector<N,T>();
                var v2 = Random.NatVector<N,T>();
                var v3 = Vector.Load(gmath.sub(v1.Unsized,v2.Unsized), n);
                var v4 = v1.Sub(v2);
                Claim.yea(v3 == v4);
            }
        }

        public void VectorAdd()
        {
            Add<VecLen,byte>();
            Add<VecLen,sbyte>();
            Add<VecLen,short>();
            Add<VecLen,ushort>();
            Add<VecLen,int>();
            Add<VecLen,uint>();
            Add<VecLen,long>();
            Add<VecLen,ulong>();
            Add<VecLen,float>();
            Add<VecLen,double>();
            
        }

        public void VectorSub()
        {
            Sub<VecLen,byte>();
            Sub<VecLen,sbyte>();
            Sub<VecLen,short>();
            Sub<VecLen,ushort>();
            Sub<VecLen,int>();
            Sub<VecLen,uint>();
            Sub<VecLen,long>();
            Sub<VecLen,ulong>();
            Sub<VecLen,float>();
            Sub<VecLen,double>();

        }

        public void VectorAnd()
        {
            And<VecLen,byte>();
            And<VecLen,sbyte>();
            And<VecLen,short>();
            And<VecLen,ushort>();
            And<VecLen,int>();
            And<VecLen,uint>();
            And<VecLen,long>();
            And<VecLen,ulong>();
            
        }


    }

}