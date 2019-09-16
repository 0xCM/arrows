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

    public class t_blockv_add : UnitTest<t_blockv_add>
    {   

        public void blockv_add_123x8i()
        {
            blockv_add_check<VecLen,sbyte>();
        }

        public void blockv_add_123x8i_bench()
        {
            blockv_add_bench<VecLen,sbyte>();
        }

        public void blockv_add_123x8()
        {
            blockv_add_check<VecLen,byte>();
        }

        public void blockv_add_123x8_bench()
        {
            blockv_add_bench<VecLen,byte>();
        }

        public void blockv_add_123x16i()
        {
            blockv_add_check<VecLen,short>();
        }

        public void blockv_add_123x16i_bench()
        {
            blockv_add_bench<VecLen,short>();
        }

        public void blockv_add_123x16()
        {
            blockv_add_check<VecLen,ushort>();
        }

        public void blockv_add_123x16_bench()
        {
            blockv_add_bench<VecLen,ushort>();
        }

        public void blockv_add_123x32i()
        {
            blockv_add_check<VecLen,int>();
        }

        public void blockv_add_123x32i_bench()
        {
            blockv_add_bench<VecLen,int>();
        }

        public void blockv_add_123x32()
        {
            blockv_add_check<VecLen,uint>();
        }

        public void blockv_add_123x32_bench()
        {
            blockv_add_bench<VecLen,uint>();
        }

        public void blockv_add_123x64i()
        {
            blockv_add_check<VecLen,long>();
        }

        public void blockv_add_123x64i_bench()
        {
            blockv_add_bench<VecLen,long>();
        }

        public void blockv_add_123x64()
        {
            blockv_add_check<VecLen,ulong>();
        }

        public void blockv_add_123x64_bench()
        {
            blockv_add_bench<VecLen,ulong>();
        }

        public void blockv_add_123x32f()
        {
            blockv_add_check<VecLen,float>();
        }

        public void blockv_add_123x32f_bench()
        {
            blockv_add_bench<VecLen,float>();
        }

        public void blockv_add_123x64f()
        {
            blockv_add_check<VecLen,double>();
        }

        public void blockv_add_123x64f_bench()
        {
            blockv_add_bench<VecLen,double>();
        }

        void blockv_add_check<N,T>()
            where N : ITypeNat, new()
            where T : struct
        {
            var n = new N();
            var v4 = BlockVector.Alloc<N,T>();
            for(var i=0; i< CycleCount; i++)            
            {
                var v1 = Random.BlockVec<N,T>();
                var v2 = Random.BlockVec<N,T>();
                var v3 = BlockVector.Load(gmath.add(v1.Unsized,v2.Unsized), n);
                Linear.add(ref v1, v2);
                Claim.yea(v3 == v1);
            }
        }

        void blockv_add_bench<N,T>(N n = default)
            where T : unmanaged
            where N : ITypeNat, new()
        {
            var opcount = CycleCount*RoundCount;
            var sw = stopwatch(false);
            var opname = $"blockv_add_{n}x{bitsize<T>()}";
            var dst = BlockVector.Zero<N,T>();
            for(var i=0; i<opcount; i++)
            {
                var v1 = Random.BlockVec<N,T>();
                var v2 = Random.BlockVec<N,T>();
                sw.Start();
                Linear.add(ref v1, v2);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }


    }

}