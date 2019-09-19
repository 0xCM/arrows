//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class ts_pack : UnitTest<ts_pack>
    {
        public void pack_1x8()
        {
            pack1xN_check<byte>();
        }

        public void pack_1x16()
        {
            pack1xN_check<ushort>();
        }

        public void pack_1x32()
        {
            pack1xN_check<uint>();
        }

        public void pack_1x64()
        {
            pack1xN_check<ulong>();
        }

        public void pack_2x16()
        {
            var src = Random.Span<ushort>(Pow2.T11);
            foreach(var x in src)
            {
                (var x0, var x1) = Bits.split(x);
                var y = Bits.pack(x0, x1);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt16(new byte[]{x0, x1}));
            }
        }

        public void pack_4x32()
        {
            var src = Random.Span<uint>(Pow2.T11);
            foreach(var x in src)
            {
                (var x0, var x1, var x2, var x3) = Bits.split(x, new N4());
                var y = Bits.pack(x0, x1, x2, x3);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt32(new byte[]{x0, x1, x2, x3}));
            }

            {
                var xval = 0b10100111001110001110010110101000;
                var x0 = (byte)0b10101000;
                var x1 = (byte)0b11100101;
                var x2 = (byte)0b00111000;
                var x3 = (byte)0b10100111;
                Claim.eq(xval, Bits.pack(x0, x1, x2,x3));

                var bsExpect = "10100111001110001110010110101000";
                var bsActual = xval.ToBitString().Format();
                Claim.eq(bsExpect, bsActual);

                var bsAssembly = BitString.Assemble("10101000", "11100101", "00111000","10100111").Format();
                Claim.eq(bsExpect, bsAssembly);
            }
        }

        public void pack_8x64()
        {
            var src = Random.Span<ulong>(Pow2.T11);
            foreach(var x in src)
            {
                (var x0, var x1, var x2, var x3, var x4, var x5, var x6, var x7) = Bits.split(x, new N8());
                var y = Bits.pack(x0, x1, x2, x3, x4, x5, x6, x7);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt64(new byte[]{x0, x1, x2, x3, x4, x5, x6, x7}));
            }
        }

        public void pack_reversed()
        {
            var x0 = Random.Next<byte>();
            var y0 = x0.ToBitString().Reverse().Pack().First();
            var z0 = Bits.rev(x0);
            Claim.eq(y0,z0);

            var x1 = Random.Next<ushort>();
            var y1 = x1.ToBitString().Reverse().Pack().TakeUInt16();
            var z1 = Bits.rev(x1);
            Claim.eq(y1,z1);

            var x2 = Random.Next<uint>();
            var y2 = x2.ToBitString().Reverse().Pack().TakeUInt32();
            var z2 = Bits.rev(x2);
            Claim.eq(y2,z2);

            var x3 = Random.Next<ulong>();
            var y3 = x3.ToBitString().Reverse().Pack().TakeUInt64();
            var z3 = Bits.rev(x3);
            Claim.eq(y3,z3);
        }

        public void pack_bools()
        {                
            var r1 = Bits.pack(false,true, true, false);
            var e1 = (byte)0b0110;
            Claim.eq(1,r1.Length);
            Claim.eq(e1, r1[0]);

            var r2 = Bits.pack(false, true, true, true);
            var e2 = (byte)0b1110;
            Claim.eq(1,r2.Length);
            Claim.eq(e2, r2[0]);

            var r3 = Bits.pack(false, true, true, true, true, false);
            var e3 = (byte)0b011110;
            Claim.eq(1,r3.Length);
            Claim.eq(e3, r3[0]);
        }

        public void unpack_bitspan()
        {
            var src = 32093283484328432ul;
            src.Unpack(out Span<Bit> bits);
            var bitsPC = bits.PopCount();
            src.Unpack(out Span<byte> bytes);
            var bytesPC = bytes.PopCount();
            Claim.eq(bitsPC, bytesPC);        
        }

        public void pack_bistring()
        {
            var x =  0b111010010110011010111001110000100001101ul;
            var xbs = BitString.Parse("111010010110011010111001110000100001101");
            var packed = xbs.Pack(0, 8);
            var joined = packed.TakeUInt64();
            Claim.Equals(x,joined);
        }

        public void pack_roundtrip()
        {            
            pack_roundtrip_check<uint>(43);
            pack_roundtrip_check<ushort>(73);
            pack_roundtrip_check<ulong>(128);
        }

        public void pack_splits()
        {
            var src = Random.Span<ulong>(Pow2.T11);
            foreach(var x in src)
            {
                (var x0, var x1, var x2, var x3, var x4, var x5, var x6, var x7) = Bits.split(x, new N8());

                for(var i=0; i<8; i++)
                {
                    var dst = (byte)0;
                    var pos = (byte)(Pow2.pow(i) - 1);
                    Bits.pack(in x0, in x1, in x2, in x3, in x4, in x5, in x6, in x7, pos, ref dst);
                    
                    var j = 0;
                    Claim.yea(gbits.match(dst, j++, x0, pos));
                    Claim.yea(gbits.match(dst, j++, x1, pos));
                    Claim.yea(gbits.match(dst, j++, x2, pos));
                    Claim.yea(gbits.match(dst, j++, x3, pos));
                    Claim.yea(gbits.match(dst, j++, x4, pos));
                    Claim.yea(gbits.match(dst, j++, x5, pos));
                    Claim.yea(gbits.match(dst, j++, x6, pos));
                    Claim.yea(gbits.match(dst, j++, x7, pos));                    
                }
            }
        }

        public void pack_span32u()
        {
            var x0 = BitVector32.FromScalar(0b00001010110000101001001111011001u);
            var x1 = BitVector32.FromScalar(0b00001010110110101001001111000001u);
            var src = Random.Span<byte>(Pow2.T04).ReadOnly();
            var packed = span<uint>(src.Length / 4);
            gbits.pack(src, packed);

            for(var i = 0; i<packed.Length; i++)
            {
                 var x = BitVector32.FromScalar(BitConverter.ToUInt32(src.Slice(4*i)));
                 var y = BitVector32.FromScalar(packed[i]);
                Claim.eq((uint)x, (uint)y, AppMsg.Error($"{x.ToBitString()} != {y.ToBitString()}"));
            }        
        }

        public void pack_span64u()
        {
            var x0 = BitVector32.FromScalar(0b00001010110000101001001111011001u);
            var x1 = BitVector32.FromScalar(0b00001010110110101001001111000001u);
            var src = Random.Span<byte>(Pow2.T04).ReadOnly();
            var packed = span<ulong>(src.Length / 8);
            gbits.pack(src, packed);

            for(var i = 0; i<packed.Length; i++)
            {
                 var x = BitVector64.FromScalar(BitConverter.ToUInt64(src.Slice(8*i)));
                 var y = BitVector64.FromScalar(packed[i]);
                Claim.eq((ulong)x, (ulong)y, AppMsg.Error($"{x.ToBitString()} != {y.ToBitString()}"));
            }        
        }

        public void pack_split_u16()
        {
            var len = Pow2.T08;
            var lhs = Random.Array<byte>(len);
            var rhs = Random.Array<byte>(len);
            for(var i=0; i<len; i++)
            {
                var dst = Bits.pack(lhs[i], rhs[i]);
                (var x0, var x1) = Bits.split(dst);
                
                Claim.eq(x0, lhs[i]);
                Claim.eq(x1, rhs[i]);

            }        
        }
        
        void pack_roundtrip_check<T>(BitSize bitcount)
            where T : unmanaged
        {
            var src = Random.BitString(bitcount);
            Claim.eq(bitcount, src.Length);

            var x = src.ToBits();
            Claim.eq(bitcount, x.Length);
            
            var y = Bits.pack(x);
            var sizeT = size<T>();
            
            var q = Math.DivRem(bitcount, 8, out int r);
            var bytes = q + (r == 0 ? 0 : 1);
            Claim.eq(bytes, y.Length);

            var bulk = ByteSpan.ReadValues<T>(y,out Span<byte> rem);

            var merged = rem.Length != 0 ? bulk.Extend(bulk.Length + 1) : bulk;
            if(merged.Length != bulk.Length)
                merged[merged.Length - 1] = rem.TakeScalar<T>();

            var bsOutput = merged.ToBitString().Truncate(bitcount);
            Claim.eq(src, bsOutput);
            Claim.eq((src & ~bsOutput).PopCount(),0);    

        }

        /// <summary>
        /// Verifies the correct operation of the generic pack function
        /// that compresses sizeof(T)*8 bits into a single T value
        /// </summary>
        /// <param name="cycles">The number of times the test is repeated</param>
        /// <typeparam name="T">The primal type</typeparam>
        void pack1xN_check<T>(int cycles = DefaltCycleCount)
            where T : struct
        {
            for(var cycle=0; cycle<cycles; cycle++)
            {
                var src = Random.Next<T>();
                var unpacked = gbits.unpack(in src, out Span<Bit> _);
                for(var j = 0; j<unpacked.Length; j++)
                    Claim.eq(gbits.test(in src, in j), (bool)unpacked[j]);
                
                var dst = default(T);
                gbits.pack(unpacked, ref dst);
                Claim.eq(src, dst);
            }
        }

    }
}