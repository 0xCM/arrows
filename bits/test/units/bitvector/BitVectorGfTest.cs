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

    using static Nats;


    public class BitVectorGfTest : UnitTest<BitVectorGfTest>
    {

        public void BenchGfBvMul()
        {
            var samples = Pow2.T14;
            var cycles = Pow2.T08;
            var lhsSrc = Random.Stream<byte>().Take(samples).Select(BitVector8.FromScalar).ToArray();
            var rhsSrc = Random.Stream<byte>().Take(samples).Select(BitVector8.FromScalar).ToArray();
                        
            int Bench()
            {                
                var ops = 0;
                for(var i=0; i< cycles; i++)
                {
                    for(var j=0; j< samples; j++)
                    {
                        var result = lhsSrc[j] * rhsSrc[j];
                        ops++;
                    }
                }
                return ops;
            }   

            Measure(Bench);

        }


        public void BenchGfMulAlt()
        {
            var samples = Pow2.T14;
            var cycles = Pow2.T08;
            var lhsSrc = Random.Array<byte>(samples);
            var rhsSrc = Random.Array<byte>(samples);
                        
            int Bench()
            {                
                var ops = 0;
                for(var i=0; i< cycles; i++)
                {
                    for(var j=0; j< samples; j++)
                    {
                        Gf256.mulAlt(lhsSrc[j],rhsSrc[j]);
                        ops++;
                    }
                }
                return ops;
            }   

            Measure(Bench);

        }

        public void VerifyGf8()
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


            // Trace(text.ToString());
            // Trace(actual.Format(render:x => x.ToBitString().Format()));

            for(var i=0; i<7; i++)
            for(var j=0; j<7; j++)
                Claim.eq(expect[i,j], actual[i,j]);


        }

        public void BenchGfMul()
        {
            var samples = Pow2.T14;
            var cycles = Pow2.T08;
            var lhsSrc = Random.Array<byte>(samples);
            var rhsSrc = Random.Array<byte>(samples);
                        
            int Bench()
            {                
                var ops = 0;
                for(var i=0; i< cycles; i++)
                {
                    for(var j=0; j< samples; j++)
                    {
                        Gf256.mul(lhsSrc[j],rhsSrc[j]);
                        ops++;
                    }
                }
                return ops;
            }   

            Measure(Bench);
        }


        public void VerifyGfMul()
        {

            for(var i=0; i<Pow2.T08; i++)
            {
                var v1 = Random.BitVector8();
                var v2 = Random.BitVector8();
                var p1 = Gf256.mul(v1,v2); 
                var p2 = Gf256.mul((byte)v1, (byte)v2);
                var p4 = Gf256.mulAlt(v1,v2);

                Claim.eq(p1,p2);
                Claim.eq(p1,p4);
            }

        }

        public void VerifyMulTable()
        {
            var t1 = Gf256.products(1, 5);
            var t2 = Gf256.products<N5>();
            for(var i=1; i <= 5; i++)
            {
                for(var j=1; j<=5; j++)
                {
                    var product = Gf256.mul((byte)i,(byte)j);
                    var e1 = t2[i - 1, j - 1];
                    var e2 = t1[i - 1, j - 1];
                    Claim.eq(e1, product);
                    Claim.eq(e2, product);
                }
            }
        }

        public void VerifyOrders()
        {                        
            foreach(var u in BitVector8.All)
            {
                if(u.Nonempty)
                {
                    var order = u.Order();
                    // Trace($"order({u}) = {order}");
                    // Trace($"pow({u},{order}) = {u^order}");
                    Claim.eq(BitVector8.One, u^order);
                }
            }

        }

    }

}