//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using VecLen = NatSeq<N1,N2,N3>;
    
    using static zfunc;


    public class tblockv_sub : UnitTest<tblockv_sub>
    {   
        //protected override int CycleCount => Pow2.T14;
        
        public void blockv_sub_123x8i()
        {
            blockv_sub_check<VecLen,sbyte>();
        }

        public void blockv_sub_123x8i_bench()
        {
            blockv_sub_bench<VecLen,sbyte>();
        }

        public void blockv_sub_123x8()
        {
            blockv_sub_check<VecLen,byte>();
        }

        public void blockv_sub_123x8_bench()
        {
            blockv_sub_bench<VecLen,byte>();
        }

        public void blockv_sub_123x16i()
        {
            blockv_sub_check<VecLen,short>();
        }

        public void blockv_sub_123x16i_bench()
        {
            blockv_sub_bench<VecLen,short>();
        }

        public void blockv_sub_123x16()
        {
            blockv_sub_check<VecLen,ushort>();
        }

        public void blockv_sub_123x16_bench()
        {
            blockv_sub_bench<VecLen,ushort>();
        }

        public void blockv_sub_123x32i()
        {
            blockv_sub_check<VecLen,int>();
        }

        public void blockv_sub_123x32i_bench()
        {
            blockv_sub_bench<VecLen,int>();
        }

        public void blockv_sub_123x32()
        {
            blockv_sub_check<VecLen,uint>();
        }

        public void blockv_sub_123x32_bench()
        {
            blockv_sub_bench<VecLen,uint>();
        }

        public void blockv_sub_123x64i()
        {
            blockv_sub_check<VecLen,long>();
        }

        public void blockv_sub_123x64i_bench()
        {
            blockv_sub_bench<VecLen,long>();
        }

        public void blockv_sub_123x64()
        {
            blockv_sub_check<VecLen,ulong>();
        }

        public void blockv_sub_123x64_bench()
        {
            blockv_sub_bench<VecLen,ulong>();
        }

        public void blockv_sub_123x32f()
        {
            blockv_sub_check<VecLen,float>();
        }

        public void blockv_sub_123x32f_bench()
        {
            blockv_sub_bench<VecLen,float>();
        }

        public void blockv_sub_123x64f()
        {
            blockv_sub_check<VecLen,double>();
        }

        public void blockv_sub_123x64f_bench()
        {
            blockv_sub_bench<VecLen,double>();
        }

        void blockv_sub_check<N,T>()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var n = new N();
            var dst = BlockVector.Zero<N,T>();
            for(var i=0; i< SampleSize; i++)            
            {
                var v1 = Random.BlockVec<N,T>();
                var v2 = Random.BlockVec<N,T>();
                var v3 = BlockVector.Load(gmath.sub(v1.Unsized,v2.Unsized), n);                
                Linear.sub(ref v1, v2);
                Claim.yea(v3 == v1);
            } 
        }

        void blockv_sub_bench<N,T>(N n = default)
            where T : unmanaged
            where N : ITypeNat, new()
        {
            var opcount = CycleCount*RoundCount;
            var sw = stopwatch(false);
            var opname = $"blockv_sub_{n}x{bitsize<T>()}";
            var dst = BlockVector.Zero<N,T>();
            for(var i=0; i<opcount; i++)
            {
                var v1 = Random.BlockVec<N,T>();
                var v2 = Random.BlockVec<N,T>();
                sw.Start();
                Linear.sub(ref v1, v2);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

    }


}