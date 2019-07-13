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


    public class NatModTest : UnitTest<NatModTest>
    {

        public void TestCreate()
        {
            var n = new N32();
            
            var a = Mod.Define(11, n);
            var b = Mod.Define(21, n);
            var c = Mod.Define(0, n);
            var d = a + b;
            Claim.eq(c,d);
        }

        public void TestImplicitCreate()
        {
            var n = new N15();

            Mod<N15> x = 5;
            Claim.eq(Mod.Define(5,n),x);

            var a0 = x + 2;
            Claim.eq(Mod.Define(7,n),a0);

        }

        public void TestIncrement()
        {
            var n = new N5();
            var x = Mod.Define(n);
            var a0 = x;
            var a1 = ++x;
            var a2 = ++x;
            var a3 = ++x;
            var a4 = ++x;
            var a5 = ++x;
            Claim.eq(Mod.Define(n), a0);
            Claim.eq(Mod.Define(1, n), a1);
            Claim.eq(Mod.Define(2, n), a2);
            Claim.eq(Mod.Define(3, n), a3);
            Claim.eq(Mod.Define(4, n), a4);
            Claim.eq(Mod.Define(n), a5);
        }

        public void TestDecrement()
        {

            var n = new N5();
            var x = Mod.Define(n);
            var a0 = x;
            var a1 = --x;
            var a2 = --x;
            var a3 = --x;
            var a4 = --x;
            var a5 = --x;
            Claim.eq(Mod.Define(n), a0);
            Claim.eq(Mod.Define(4, n), a1);
            Claim.eq(Mod.Define(3, n), a2);
            Claim.eq(Mod.Define(2, n), a3);
            Claim.eq(Mod.Define(1, n), a4);
            Claim.eq(Mod.Define(n), a5);

        }

        public void TestSubtraction()
        {
            var n = new N15();

            Mod<N15> a = 5;
            
            var b14a = a + 9;
            Claim.eq(Mod.Define(14,n), b14a);

            var b14b = a - 6;
            Claim.eq(Mod.Define(14,n), b14a);
        }

        public void TestAddition()
        {
            var N = NatSeq<N8,N7>.Rep;
            var n = (uint)N.value;
            var n0 = Mod.Define(N);

            var samples = Pow2.T08;
            var lhs = Random.Span<uint>(samples);
            var rhs = Random.Span<uint>(samples);
            for(var i=0; i<samples; i++)
            {
                var x = lhs[i];
                var y = rhs[i];
                
                var xN = n0 + x;
                Claim.eq(Mod.Define(x,N), xN);

                var yN = n0 + y;
                Claim.eq(Mod.Define(y,N), yN);
                
                var zN = xN + yN;                
                var z = (uint)(((ulong)x + (ulong)y) % (ulong)n);
                Claim.eq(z, zN.State, appMsg($"{xN} + {yN} = {zN} != {z} = ({x} + {y}) % {n}", SeverityLevel.Error));                
            }

        }

        static string FormatTable<T>(T[,] entries, uint m, uint n, uint offset = 0)
        {
            var sb = sbuild();

            for(var i=0; i<n; i++)
                if(i == 0)
                    sb.Append(". |".PadRight(4));
                else
                    sb.Append($"{i}".PadRight(3));
            sb.AppendLine();
            sb.AppendLine(new string('-', (int)(3*n)));

            for(var i=offset; i<m; i++)
            {
                sb.Append($"{i} |".PadRight(4));
                for(var j=offset; j<n; j++)
                    sb.Append($"{entries[i,j]}".PadRight(3));
                sb.AppendLine();                
            }
            return sb.ToString();

        }

        public void TestMul()
        {
            var N = new N7();
            var n = (uint)N.value;
            var n0 = Mod.Define(N);            
            var expect = new uint[n,n];
            for(var i=0u; i<N; i++)
            for(var j=0u; j<N; j++)
            {
                var x = n0 + i;
                var y = n0 + j;
                var z = x*y;
                expect[i,j] = (i*j) % (uint)N.value;

                Claim.eq(expect[i,j], z);
            }

            Trace(FormatTable(expect,n,n,1));
        }

        void TestInversion()
        {
            var N = new N11();
            var n0 = Mod.Define(N);
            var n1 = n0 + 1u;
            for(var i=1u; i<N; i++)
            {
                var x = n0 + i;
                var y = x.Invert();
                var z = x * y;
                //Claim.eq(n1,z);
                Trace($"{x}*{y} = {z}");
            }
        }

    }

}