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

    using static BitRef;


    public class tbv_dot : UnitTest<tbv_dot>
    {
        public void dot4()
        {
            dot4_check();            
        }

        public void dot8()
        {
            dot8_check();            
        }

        public void dot16()
        {
            dot16_check();            
        }

        public void dot32()
        {
            dot32_check();            
        }

        public void dot64()
        {
            dot64_check();            
        }

        public void dotg()
        {
            dotg_check(10,0u);
            dotg_check(20,0u);
            dotg_check(63,0ul);
            dotg_check(64,0ul);
            dotg_check(87,(byte)0);
            dotg_check(128,(ushort)0);
            dotg_check(25,(ushort)0);
            dotg_check(256,0ul);
            dotg_check(2048,0u);
        }

        public void dotng()
        {
            dotng_check(n10,0u);
            dotng_check(n20,0u);
            dotng_check(n63,0ul);
            dotng_check(n64,0ul);
            dotng_check(n87,(byte)0);
            dotng_check(n128,(ushort)0);
            dotng_check(n25,(ushort)0);
            dotng_check(n256,0ul);
            dotng_check(n2048,0u);
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

        void dot4_check(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Polyrand.BitVector4();
                var y = Polyrand.BitVector4();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);            
            }
        }

        void dot8_check(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Polyrand.BitVector8();
                var y = Polyrand.BitVector8();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);            

                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        void dot16_check(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Polyrand.BitVector16();
                var y = Polyrand.BitVector16();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);   

                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        void dot32_check(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Polyrand.BitVector(n32);
                var y = Polyrand.BitVector(n32);
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);
            
                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        void dot64_check(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Polyrand.BitVector64();
                var y = Polyrand.BitVector64();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);

                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
                var c = zx % zy;
                Claim.yea(a == c);
            
            }
        }

        void dotg_check<T>(BitSize bitcount, T rep = default, int cycles = DefaltCycleCount)
            where T : struct
        {
            TypeCaseStart<T>();

            for(var i=0; i<cycles; i++)
            {
                var x = Polyrand.BitVector<T>(bitcount);
                var y = Polyrand.BitVector<T>(bitcount);
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);
            
            }

            TypeCaseEnd<T>();
        }

        void dotng_check<N,T>(N bitcount = default, T rep = default,  int cycles = DefaltCycleCount)
            where T : struct
            where N : ITypeNat, new()
        {
            NatCaseStart<N,T>();
            for(var i=0; i<cycles; i++)
            {
                var x = Polyrand.BitVector<N,T>();
                var y = Polyrand.BitVector<N,T>();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);            
            }

            NatCaseStart<N,T>();
        }
 
    }

}