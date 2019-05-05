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
            => Vec128.stream(cells);
        
        public void StoreInt32Vec()
        {
            var src = new int[]{-50,-25,25,50};
            var dst = new int[src.Length];
            var v1 = Vec128.single(src);
            dinx.store(v1, dst, 0);
            var v2 = Vec128.single(dst);
            Claim.eq(v1,v2);
        }


        public void StoreUInt32Vecs()
        {
            var vecCount = Pow2.T16;
            var mem = MemoryPartition.define((int)vecCount * Vec128<uint>.Length, Vec128<uint>.Length);

            trace($"Storing data from {mem.PartCount} {type<Vec128<uint>>().DisplayName()} vectors");

            var dst = alloc<uint>(mem.TotalLength); 
            var src = Randomizer.Array<uint>(Interval.closed(10u,500u), mem.TotalLength);
            var vectors = Vec128UInt32Stream(src).ToArray();
            dinx.store(vectors,dst);

            void ValidatePart(int cix, int pix)
            {
                var v = vectors[pix];
                iter(mem.PartLength, 
                    i => Claim.eq(src[cix + i], v[i]));
            }
            
            mem.GetIndex().IterateParts(ValidatePart);

        }



        public void DefineFloat64Vec()
        {
            var src = new double[]{50,25};
            var v1 = Vec128.single(src);
            var v2 = Vec128.load(src,0);
            Claim.eq(v1,v2);
        }
    }

}