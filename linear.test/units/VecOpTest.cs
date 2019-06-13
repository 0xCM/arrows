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

            var eq = vExpect == vResult;
            for(var i=0; i<len; i++)
                Claim.@true(eq[i]);            
        }        


        void Add<N,T>()
            where T : struct
            where N : ITypeNat, new()
        {
            var rep = new N();
            var len = (int)rep.value;
            var data = Randomizer.DataSet<N,T>();            
            var vResult = data.LeftVec + data.RightVec;
            
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
            var data = Randomizer.DataSet<N,T>();            
            var vResult = data.LeftVec - data.RightVec;
            
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
            var data = Randomizer.DataSet<N,T>();            
            var vResult = data.LeftVec & data.RightVec;
            
            var calcs = span<T>(len);
            for(var i = 0; i< calcs.Length; i++)
                calcs[i] = gmath.and(data.LeftSrc[i], data.RightSrc[i]);
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

    }

}