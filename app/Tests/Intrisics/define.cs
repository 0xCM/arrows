//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;


    [DisplayName(Path)]
    public class InX128Define : UnitTest<InX128Define>
    {
        public const string Path = P.InX128 + P.create;


        public InX128Define()
        {

        }

        IEnumerable<Vec128<uint>> Vec128UInt32Stream(uint[] cells)
            => from v in Arr.partition(cells, Vec128<uint>.Length) 
                select Vec128.define(v);

        
        public void StoreInt32Vec()
        {
            var src = new int[]{-50,-25,25,50};
            var dst = new int[src.Length];
            var v1 = Vec128.define(src);
            InX.store(v1, dst, 0);
            var v2 = Vec128.define(dst);
            Claim.eq(v1,v2);
        }


        public void StoreUInt32Vecs()
        {
            var vecCount = Pow2.T16;
            var mem = MemoryPartition.define((int)vecCount * Vec128<uint>.Length, Vec128<uint>.Length);

            trace($"Storing data from {mem.PartCount} {type<Vec128<uint>>().DisplayName()} vectors");

            var dst = alloc<uint>(mem.TotalLength); 
            var src = Context.RandomArray<uint>(Interval.closed(10u,500u), mem.TotalLength);
            var vectors = Vec128UInt32Stream(src).ToArray();
            InX.store(vectors,dst);

            void ValidatePart(int cix, int pix)
            {
                var v = vectors[pix];
                iter(mem.PartLength, 
                    i => Claim.eq(src[cix + i], v[i]));
            }
            
            mem.GetIndex().IterateParts(ValidatePart);

        }

        public void DefineUInt8Vec()
        {
            var src = Context.RandomArray<byte>(Interval.closed<byte>(0,155), Vec128<byte>.Length);
            Claim.eq(Vec128<byte>.Length, src.Length);

            var v1 = Vec128.define(src.ToSpan128());
            var i = 0;
            var v2 = Vec128.define(
                src[i++], src[i++],src[i++], src[i++],
                src[i++], src[i++],src[i++], src[i++],
                src[i++], src[i++],src[i++], src[i++],
                src[i++], src[i++],src[i++], src[i++]
            );

            Claim.eq(v1,v2);
        }

        public void DefineUInt8Vecs()
        {
            var domain = Interval.closed<byte>(0,155);
            var src = Context.RandomArrays<byte>(domain, Vec128<byte>.Length).Take(Pow2.T15);
            foreach(var arr in src)
            {
                Claim.eq(Vec128<byte>.Length, arr.Length);
                var v1 = Vec128.define(arr.ToSpan128());
                var v2 = Vec128.define(arr);                
                Claim.eq(v1,v2);
            }            
        }

        public void DefineInt32Vecs()
        {
            var domain = Interval.closed(-250000,250000);
            var src = Context.RandomArrays<int>(domain, Vec128<int>.Length).Take(Pow2.T15);
            foreach(var arr in src)
            {
                Claim.eq(Vec128<int>.Length, arr.Length);
                var v0 = Vec128.define(arr[0], arr[1], arr[2], arr[3]);
                var v1 = Vec128.define(arr.ToSpan128());
                var v2 = Vec128.define(arr);
                Claim.eq(v0,v1);
                Claim.eq(v0,v2);

            }            
        }

        public void DefineFloat32Vec()
        {
            var src = new float[]{-50,-25,25,50};
            var v1 = Vec128.define(src);
            var v2 = Vec128.define(src.ToSpan128());
            Claim.eq(v1,v2);
        }

        public void DefineFloat64Vec()
        {
            var src = new double[]{50,25};
            var v1 = Vec128.define(src);
            var v2 = Vec128.define(src,0);
            Claim.eq(v1,v2);
        }
    }

}