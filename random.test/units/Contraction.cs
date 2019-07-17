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

    
    using static zfunc;
    
    public class Contraction : UnitTest<Contraction>
    {
        public void MeasureContractU64()
        {
            var n = Pow2.T20;
            var src = Random.Array<ulong>(n);
            var result = measure(Pow2.T20, "divide", "contract",
                _ => {
                    var last = 0ul;
                    for(var i=0;i<n; i++)
                        last = src[i] /100;
                },

                _ => {
                    var last = 0ul;
                    for(var i=0;i<n; i++)
                        last = src[i].Contract(100ul);
                }
            );
            TracePerf(result);
        }

        public void MeasureContractU32()
        {
            var n = Pow2.T20;
            var src = Random.Array<uint>(n);
            var result = measure(Pow2.T20, "divide", "contract",
                _ => {
                    var last = 0u;
                    for(var i=0;i<n; i++)
                        last = src[i] /100;
                },

                _ => {
                    var last = 0u;
                    for(var i=0;i<n; i++)
                        last = src[i].Contract(100u);
                }
            );
            TracePerf(result);
        }

        public void MeasureContractU16()
        {
            var n = Pow2.T20;
            var src = Random.Array<ushort>(n);
            var result = measure(Pow2.T20, "divide", "contract",
                _ => {
                    ushort last = (ushort)0u;
                    for(var i=0;i<n; i++)
                        last = (ushort)(src[i] /100);
                },

                _ => {
                    ushort last = 0;
                    for(var i=0;i<n; i++)
                        last = src[i].Contract(100);
                }
            );
            TracePerf(result);
        }

        public void MeasureContractU8()
        {
            var n = Pow2.T20;
            var src = Random.Array<byte>(n);
            var result = measure(Pow2.T20, "divide", "contract",
                _ => {
                    byte last = (byte)0u;
                    for(var i=0;i<n; i++)
                        last = (byte)(src[i] /100);
                },

                _ => {
                    byte last = 0;
                    for(var i=0;i<n; i++)
                        last = src[i].Contract(100);
                }
            );
            TracePerf(result);
        }

        public void ContractU16()
        {
            var upper = (ushort)100;
            var buckets = new ushort[100];
            var partition = closed((ushort)(upper + 1), (ushort)(UInt16.MaxValue - Pow2.T04)).Partition(100);
            Claim.eq(partition.Length, 100);
        
            for(ushort i=0; i<partition.Length; i++)
            {
                 var part = partition[i];
                 var lContract = part.Left.Contract(upper);
                 var rContract = part.Right.Contract(upper);
                 Claim.lteq(lContract,upper);
                 Claim.lteq(rContract,upper);

                 buckets[lContract] += 1;
                 if(i == (partition.Length - 1))                 
                    buckets[rContract] += 1;
            }

            Claim.eq(1, buckets.Where(b => b > 1).Count());
            Claim.eq((ushort)2, buckets.First(b => b == 2));
            buckets[buckets.FirstIndexOf((ushort)2)] = 1;            
            Claim.yea(buckets.AllEqual(1));
        }

        public void ContractU8()
        {
            var upper = (byte)Pow2.T07;
            var buckets = new byte[Pow2.T08];
            for(var i=0; i<Pow2.T08; i++)
                buckets[((byte)i).Contract(upper)] += 1;
            
            var zidx = buckets.FirstIndexOf((byte)0);
            Claim.eq(upper,zidx);

            for(var i=0; i< Pow2.T08; i++)
            {
                if(i < zidx)
                    Claim.eq((byte)2, buckets[i]);
                else if(i >= zidx)
                    Claim.eq((byte)0, buckets[i]);
            }
        
        }

        public void ContractU32()
        {
            var upper = 100u;
            var buckets = new uint[100];
            var partition = closed(upper + 1, UInt32.MaxValue - Pow2.T04).Partition(100);
            Claim.eq(partition.Length, 100);
        
            for(var i=0; i<partition.Length; i++)
            {
                 var part = partition[i];
                 var lContract = part.Left.Contract(upper);
                 var rContract = part.Right.Contract(upper);
                 Claim.lteq(lContract,upper);
                 Claim.lteq(rContract,upper);

                 buckets[lContract] += 1;
                 if(i == (partition.Length - 1))                 
                    buckets[rContract] += 1;
            }

            Claim.eq(1, buckets.Where(b => b > 1).Count());
            Claim.eq(2, buckets.First(b => b == 2));
            buckets[buckets.FirstIndexOf(2u)] = 1;            
            Claim.yea(buckets.AllEqual(1));
        }

        public void ContractU64()
        {
            var upper = 100ul;
            var buckets = new ulong[100];
            var partition = closed(upper + 1, UInt64.MaxValue - Pow2.T04).Partition(100);
            Claim.eq(partition.Length, 100);

            for(var i=0; i<partition.Length; i++)
            {
                 var part = partition[i];
                 var lContract = part.Left.Contract(upper);
                 var rContract = part.Right.Contract(upper);
                 Claim.lteq(lContract,upper);
                 Claim.lteq(rContract,upper);

                 buckets[lContract] += 1;
                 if(i == (partition.Length - 1))                 
                    buckets[rContract] += 1;
            }

            Claim.eq(1, buckets.Where(b => b > 1).Count());
            Claim.eq(2, buckets.First(b => b == 2));
            buckets[buckets.FirstIndexOf(2ul)] = 1;            
            Claim.yea(buckets.AllEqual(1));

        }

        public void BoundRandom()
        {
            var src = RNG.Polyrand(Random).Take<ulong>(Pow2.T24);
            var max = (ulong)Pow2.T08;
            var buckets = new ulong[max];
            foreach(var item in src)
            {
                var next = item.Contract(max);
                Claim.lt(next,max);
                ++buckets[next];
            }
            
        }

    }

}
