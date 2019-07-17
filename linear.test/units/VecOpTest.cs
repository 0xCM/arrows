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

        public static DataSet<N,T> DataSet<N,T>(this IRandomSource random, N length = default)
            where T : struct
            where N : ITypeNat, new()
            => new DataSet<N, T>(random);

    }

      public ref struct DataSet<N,T>
            where T : struct
            where N : ITypeNat, new()
        {
            public DataSet(IRandomSource random)
            {
                LeftSrc = random.Span<N,T>();
                RightSrc = random.Span<N,T>();
                LeftVec = Vector.Load(LeftSrc.Replicate());
                RightVec = Vector.Load(RightSrc);
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


        void Add<N,T>()
            where T : struct
            where N : ITypeNat, new()
        {
            var rep = new N();
            var len = (int)rep.value;
            var data = Random.DataSet<N,T>();            
            var vResult = data.LeftVec.Add(data.RightVec);
            
            var calcs = span<T>(len);
            for(var i = 0; i< calcs.Length; i++)
                calcs[i] = gmath.add(data.LeftSrc[i], data.RightSrc[i]);
            var vExpect = Vector.Load(calcs, rep);            
            
            VerifyEquality(vExpect, vResult);

        }

        void Sub<N,T>()
            where T : struct
            where N : ITypeNat, new()
        {
            var rep = new N();
            var len = (int)rep.value;
            var data = Random.DataSet<N,T>();            
            var vResult = data.LeftVec.Sub(data.RightVec);
            
            var calcs = span<T>(len);
            for(var i = 0; i< calcs.Length; i++)
                calcs[i] = gmath.sub(data.LeftSrc[i], data.RightSrc[i]);
            var vExpect = Vector.Load(calcs, rep);            
            
            VerifyEquality(vExpect, vResult);
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

        public void VectorConcat()
        {
            var n = NatSum<N4,N3>.Rep.Reduce<N7>();
            var v1 = Vector.Load(N4, 1,2,3,4);
            var v2 = Vector.Load(N3, 5,6,7);
            var v3 = v1.Concat(v2, NatSum<N4,N3>.Rep).ReDim(N7);
            var v4 = Vector.Load(N7, 1, 2, 3, 4, 5, 6, 7);
            var v5 = v3.Eq(v4);
            Claim.yea(v5.Unsize().All(x => true));

        }

    }

}