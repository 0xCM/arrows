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
    using static BitRef;


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
            var expect = new byte[,]
            {
                {001, 010, 011, 100, 101, 110, 111},
                {010, 100, 110, 011, 001, 111, 101},
                {011, 110, 101, 111, 100, 001, 010},
                {100, 011, 111, 110, 010, 101, 001},
                {101, 001, 100, 010, 111, 011, 110},
                {110, 111, 001, 101, 011, 010, 100},
                {111, 101, 010, 001, 110, 100, 011}
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

            Trace(text.ToString());
            Trace(actual.Format(render:x => x.ToBitString().Format()));

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
            var v = BitVector8.Parse("11010111");
            Claim.eq(v, BitVector8.FromScalar(0b11010111));
            Claim.eq(v^3, BitVector8.One);
            foreach(var u in BitVector8.All)
            {
                if(u.Nonempty)
                {
                    var order = u.Order();
                    Claim.eq(BitVector8.One, u^order);
                }
            }

        }

    }

}