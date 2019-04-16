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
    public class InX128Define : InXTest<InX128Define>
    {
        public const string Path = P.InX128 + P.create;


        public InX128Define()
        {

        }
        IEnumerable<Vec128<uint>> Vec128UInt32Stream(uint min, uint max, uint vecCount)
        {
            var vecLen = (uint)Vec128<uint>.Length;
            var cellCount = vecLen*vecCount;
            var srcList = Random(min, max).Freeze(cellCount);  
            var srcArray = array<uint>(srcList);
            return InX.stream(srcArray);
        }

        IEnumerable<Vec128<uint>> Vec128UInt32Stream(uint[] cells)
            => from v in Arr.partition(cells, Vec128<uint>.Length) 
                select Vec128.define(v);
                 //cells.Partition(Vec128<uint>.Length).Select(Vec128.define);

        public void StreamUInt32Vecs()
        {
            var veclen = (uint)Vec128<uint>.Length;
            Claim.eq(4u,veclen);
            
            var vecTypeName = type<Vec128<uint>>().DisplayName();
            var vecCount = veclen * Pow2.T16;
            trace($"Streaming {vecCount} {vecTypeName} vectors");
            

            var srcList = Random<uint>(250, 50000).Freeze(vecCount);  
            var srcArray = array<uint>(srcList);
            var srcStream = InX.stream(srcArray);
            var it = srcStream.GetEnumerator();
            for(var i = 0; i<srcList.Count; i += 4)
            {   
                Claim.@true(it.MoveNext());
                var listVec = Vec128.define(srcList[i], srcList[i+1], srcList[i+2], srcList[i + 3]);
                Claim.eq(listVec, it.Current);
            }                
        }


        public void StoreUInt32Vecs()
        {
            var vecCount = Pow2.T16;
            var mem = MemoryPartition.define((int)vecCount * Vec128<uint>.Length, Vec128<uint>.Length);

            trace($"Storing data from {mem.PartCount} {type<Vec128<uint>>().DisplayName()} vectors");

            var dst = alloc<uint>(mem.TotalLength); 
            var src = RandomArray(10u,500u,mem.TotalLength);
            var vectors = Vec128UInt32Stream(src).ToReadOnlyList();
            InX.store(vectors,dst);

            void ValidatePart(int cix, int pix)
            {
                var v = vectors[pix];
                iter(mem.PartLength, 
                    i => Claim.eq(src[cix + i], v[i]));
            }
            
            mem.GetIndex().IterateParts(ValidatePart);

        }

        public void LoadUInt8Vec()
        {
            var src = RandomArray<byte>(0,155, Vec128<byte>.Length);
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

        public void LoadUInt8Vecs()
        {
            var src = RandomArrays<byte>(0,155, Vec128<byte>.Length).Take(Pow2.T15);
            foreach(var arr in src)
            {
                Claim.eq(Vec128<byte>.Length, arr.Length);
                var v1 = Vec128.define(arr.ToSpan128());
                var v2 = Vec128.define(arr);                
                Claim.eq(v1,v2);

            }
            
        }

        public void LoadInt32Vec()
        {
            var src = new int[]{-50,-25,25,50};
            var v1 = Vec128.define(src[0],src[1],src[2],src[3]);
            var v2 = Vec128.define(src);
            Claim.eq(v1,v2);
        }

        public void LoadInt32Vecs()
        {
            var src = RandomArrays<int>(-250000,250000, Vec128<int>.Length).Take(Pow2.T15);
            foreach(var arr in src)
            {
                Claim.eq(Vec128<int>.Length, arr.Length);
                var v1 = Vec128.define(arr.ToSpan128());
                var v2 = Vec128.define(arr);                
                Claim.eq(v1,v2);

            }
            
        }

        public void StoreInt32Vec()
        {
            var src = new int[]{-50,-25,25,50};
            var dst = new int[src.Length];
            var v1 = Vec128.define(src);
            InX.store(v1, dst, 0);
            var v2 = Vec128.define(dst);
            Claim.eq(v1,v2);
        }

        public void LoadInt64Vec()
        {
            var src = new long[]{50,25};
            var v1 = Vec128.define(src);
            var v2 = Vec128.define(src.ToSpan128());
            Claim.eq(v1,v2);
        }

        public void LoadInt64Vecs()
        {
            var src = new long[]{-50,-25, 25, 50};

            var v1 = Vec128.define(src.ToSpan128(0));
            Claim.eq(v1, Vec128.define(src[0],src[1]));

            var v2 = Vec128.define(src.ToSpan128(2));
            Claim.eq(v2, Vec128.define(src[2],src[3]));

            var vecs = InX.stream(src).ToList();
            Claim.eq(v1,vecs[0]);
            Claim.eq(v2,vecs[1]);
        }

        public void LoadUInt64Vec()
        {
            var src = new ulong[]{50,25};
            var v1 = Vec128.define(src);
            var v2 = Vec128.define(src.ToSpan128());
            Claim.eq(v1,v2);
        }

        public void LoadUInt64Vecs()
        {
            var src = new ulong[]{50,25, 75, 85};

            var v1 = Vec128.define(src.ToSpan128(0));
            Claim.eq(v1, Vec128.define(src[0],src[1]));

            var v2 = Vec128.define(src.ToSpan128(2));
            Claim.eq(v2, Vec128.define(src[2],src[3]));

            var vecs = InX.stream(src).ToList();
            Claim.eq(v1,vecs[0]);
            Claim.eq(v2,vecs[1]);
        }

        public void LoadUInt32Vec()
        {
            var src = new uint[]{50,25,25,50};
            var v1 = Vec128.define(src);
            var v2 = Vec128.define(src.ToSpan128());
            Claim.eq(v1,v2);
        }



        public void LoadFloat32Vec()
        {
            var src = new float[]{-50,-25,25,50};
            var v1 = Vec128.define(src);
            var v2 = Vec128.define(src.ToSpan128());
            Claim.eq(v1,v2);
        }

        public void LoadFloat64Vec()
        {
            var src = new double[]{50,25};
            var v1 = Vec128.define(src);
            var v2 = Vec128.define(src,0);
            Claim.eq(v1,v2);
        }
    }

}