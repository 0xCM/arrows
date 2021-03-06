//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public class tbv_gf : BitVectorTest<tbv_gf>
    {

        public void gfmul256()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var v1 = Random.BitVector8();
                var v2 = Random.BitVector8();
                var p1 = Gf256.mul(v1,v2); 
                var p2 = Gf256.mul((byte)v1, (byte)v2);
                var p4 = Gf256.mul_ref(v1,v2);

                Claim.eq(p1,p2);
                Claim.eq(p1,p4);
            }
        }

        public void gfmul512()
        {
            for(var i=0; i< CycleCount; i++)
            {
                var x1 = Random.BitVector16(2*32);
                var x2 = Random.BitVector16(2*32);
                var p1 = Gf512.mul(x1,x2); 
                var p2 = Gf512.mul_ref(x1,x2);
                Claim.eq(p1,p2);       

                if(x1.Nonempty)
                {
                    var order = x1.Order();
                    Claim.eq(BitVector16.One, x1.Pow(order));
                }

            }
        
        }

        void gfmul512_table()
        {
            ref var table = ref Gf512.products(out BlockMatrix<N512,ushort> _);
            var all = BitVector16.All(9).ToSet();
            Claim.eq(all.Count,512);

            foreach(var v in BitVector16.All(9))
            {
                if(v.Nonempty)
                {
                    var square = v*v;
                    table.First(x => square == x).Require();
                    table.First(x => x == v).Require();
                    //table.First(x => x * v == BitVector16.One, out (int i, int j) _).OnNone( () => Trace($"{++counter} No inverse!", v.FormatBits()));
                }
            }
            
        }

        public void gfmul256_table()
        {
            ref var table = ref Gf256.products(out BlockMatrix<N256,byte> _);

            foreach(var v in BitVector8.All)
                if(v.Nonempty)
                    table.First(x => x * v == BitVector8.One, out (int i, int j) _).Require();
        }

        public void gford256()
        {                        
            foreach(var v in BitVector8.All)
            {
                if(v.Nonempty)
                {
                    var order = v.Order();
                    Claim.eq(BitVector8.One, v.Pow(order));
                }
            }
        }

        public void gfmul8()
        {
            var expect =  new byte[,]
            {
                {0b001, 0b010, 0b011, 0b100, 0b101, 0b110, 0b111},
                {0b010, 0b100, 0b110, 0b011, 0b001, 0b111, 0b101},
                {0b011, 0b110, 0b101, 0b111, 0b100, 0b001, 0b010},
                {0b100, 0b011, 0b111, 0b110, 0b010, 0b101, 0b001},
                {0b101, 0b001, 0b100, 0b010, 0b111, 0b011, 0b110},
                {0b110, 0b111, 0b001, 0b101, 0b011, 0b010, 0b100},
                {0b111, 0b101, 0b010, 0b001, 0b110, 0b100, 0b011}
            };

            var actual = Gf8.products();

            var text = sbuild();
            for(var i=0; i<7; i++)
            {
                for(var j=0; j<7; j++)
                {                    
                    text.Append(expect[i,j].ToBitString().Truncate(3).Format());
                    if(j != 6)
                        text.Append(AsciSym.Pipe);
                }
                text.AppendLine();
            }

            for(var i=0; i<7; i++)
            for(var j=0; j<7; j++)
                Claim.eq(expect[i,j], actual[i,j]);
        }

        public void gfpoly()
        {            
            gfpoly_check(GfPoly.Lookup<N3,byte>(), BitString.Parse("1011"));
            
            gfpoly_check(GfPoly.Lookup<N8,ushort>(), BitString.Parse("100011101"));
            Claim.eq((ushort)0b100011101, GfPoly.Lookup<N8,ushort>().Scalar);
            
            gfpoly_check(GfPoly.Lookup<N16,uint>(), BitString.Parse("10000001111011101"));
            
        }

        public void gfmulbv8_bench()
        {
            var lhsSrc = Random.Stream<byte>().Take(SampleSize).Select(BitVector8.FromScalar).ToArray();
            var rhsSrc = Random.Stream<byte>().Take(SampleSize).Select(BitVector8.FromScalar).ToArray();
            var result = BitVector8.Alloc();                        
            int Bench()
            {                
                for(var i=0; i< CycleCount; i++)
                for(var j=0; j< SampleSize; j++)
                    result &= lhsSrc[j] * rhsSrc[j];
                return SampleSize * CycleCount;
            }   

            Measure(Bench);

        }

        public void gfmul256_bench()
        {
            var lhsSrc = Random.Array<byte>(SampleSize);
            var rhsSrc = Random.Array<byte>(SampleSize);
            var result = (byte)0;
                        
            int Bench()
            {                
                for(var i=0; i< CycleCount; i++)
                for(var j=0; j< SampleSize; j++)
                    result &= Gf256.mul(lhsSrc[j],rhsSrc[j]);
                return CycleCount*SampleSize;
            }   

            Measure(Bench);
        }

        void gfmul256ref_bench()
        {
            var lhsSrc = Random.Array<byte>(SampleSize);
            var rhsSrc = Random.Array<byte>(SampleSize);
                        
            int Bench()
            {                
                var ops = 0;
                for(var i=0; i< CycleCount; i++)
                {
                    for(var j=0; j< SampleSize; j++)
                    {
                        Gf256.mul_ref(lhsSrc[j],rhsSrc[j]);
                        ops++;
                    }
                }
                return ops;
            }   

            Measure(Bench);
        }

        void gfpoly_check<N,T>(GfPoly<N,T> p, BitString match)
            where N : ITypeNat, new()
            where T : unmanaged
        {

            var bs = BitString.FromScalar(p.Scalar).Truncate(p.Degree + 1);
            Claim.eq(bs, match);  

        }

    }

}