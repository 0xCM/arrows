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


    public class tbv_dot : UnitTest<tbv_dot>
    {
        void VerifyDot4(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Random.BitVector4();
                var y = Random.BitVector4();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);            
            }
        }

        void VerifyDot8(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Random.BitVector8();
                var y = Random.BitVector8();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);            

                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        void VerifyDot16(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Random.BitVector16();
                var y = Random.BitVector16();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);   

                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        void VerifyDot32(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Random.BitVector32();
                var y = Random.BitVector32();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);
            
                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        void VerifyDot64(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Random.BitVector64();
                var y = Random.BitVector64();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);

                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
                var c = zx % zy;
                Claim.yea(a == c);
            
            }
        }

        void VerifyDot<T>(BitSize bitcount, T rep = default, int cycles = DefaltCycleCount)
            where T : struct
        {
            TypeCaseStart<T>();

            for(var i=0; i<cycles; i++)
            {
                var x = Random.BitVector<T>(bitcount);
                var y = Random.BitVector<T>(bitcount);
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);
            
            }

            TypeCaseEnd<T>();
        }

        void VerifyDot<N,T>(N bitcount = default, T rep = default,  int cycles = DefaltCycleCount)
            where T : struct
            where N : ITypeNat, new()
        {
            NatCaseStart<N,T>();
            for(var i=0; i<cycles; i++)
            {
                var x = Random.BitVector<N,T>();
                var y = Random.BitVector<N,T>();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);            
            }

            NatCaseStart<N,T>();
        }


        public void Dot4()
        {
            VerifyDot4();            
        }

        public void Dot8()
        {
            VerifyDot8();            
        }

        public void Dot16()
        {
            VerifyDot16();            
        }

        public void Dot32()
        {
            VerifyDot32();            
        }

        public void Dot64()
        {
            VerifyDot64();            
        }

        public void DotT()
        {
            VerifyDot(10,0u);
            VerifyDot(20,0u);
            VerifyDot(63,0ul);
            VerifyDot(64,0ul);
            VerifyDot(87,(byte)0);
            VerifyDot(128,(ushort)0);
            VerifyDot(25,(ushort)0);
            VerifyDot(256,0ul);
            VerifyDot(2048,0u);
        }

        public void DotNT()
        {
            VerifyDot(N10,0u);
            VerifyDot(N20,0u);
            VerifyDot(N63,0ul);
            VerifyDot(N64,0ul);
            VerifyDot(N87,(byte)0);
            VerifyDot(N128,(ushort)0);
            VerifyDot(N25,(ushort)0);
            VerifyDot(N256,0ul);
            VerifyDot(N2048,0u);
        }


        void Dot4Table()
        {
            var result = sbuild();
            for(byte i=0; i< 0xF; i++)
            {
                var x = BitVector4.FromScalar(i);
                for(byte j = 0; j<0xF; j++)
                {
                    var y = BitVector4.FromScalar(j);
                    var a = x & y;
                    var and = $"AND = {a.FormatBits()}";
                    var popMod2 = $"AND > POP % 2 = {a.Pop() % 2}";
                    result.AppendLine($"{x.FormatBits()} * {y.FormatBits()} = {x % y} | {and} | {popMod2}");
                }
            }
            Trace(result.ToString());
        }
    }

}