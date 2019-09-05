//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.IO;
    
    using static zfunc;

    public class t_mod : UnitTest<t_mod>
    {

        public void modmul()
        {
            VerifyMul(n3);
            VerifyMul(n5);
            VerifyMul(n7);
            VerifyMul(n10);
            VerifyMul(n11);
            VerifyMul(n13);
            VerifyMul(n32);
            VerifyMul(n64);
            VerifyMul(n128);
            VerifyMul(n1024);
        }

        public void modinc()
        {
            VerifyIncrement(n128);
            VerifyIncrement(n5);
            VerifyIncrement(n20);            
        }

        public void moddec()
        {
            VerifyDecrement(n13);
            VerifyDecrement(n17);
            VerifyDecrement(n32);
            VerifyDecrement(n64);
            VerifyDecrement(n128);
        }

        public void modinv()
        {
            VerifyInverse(n3);
            VerifyInverse(n5);
            VerifyInverse(n7);
            VerifyInverse(n11);
            VerifyInverse(n13);
            VerifyInverse(n17);
            VerifyInverse(n19);
            VerifyInverse(n31);
            VerifyInverse(N41);
            VerifyInverse(n1277);
        }

        public void modadd()
        {
            var samples = Pow2.T08;
            VerifyAdd(samples,n87);
            VerifyAdd(samples,n64);
            VerifyAdd(samples,n512);
        }

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

        void VerifyIncrement<N>(N n = default)
            where N :ITypeNat, new()
        {
            TypeCaseStart<N>();

            var x = Mod.Define(n);
            var y = Mod.Define(n);
            var max = (uint)n.value;

            x++; x++; x++;
            y += 3u;
            Claim.eq(x,y);

            x++; x++; x++; x++; x++; x++; x++; x++; x++; x++;
            y += 10u;
            Claim.eq(x,y);


            var a = Mod.Define(max,n);
            var b = Mod.Define(max,n);

            for(var k = 1; k<max*3; k++)            
            {
                ++a; 
                Claim.eq(a, b += 1u);
            }

            TypeCaseEnd<N>();
        }


        void VerifyDecrement<N>(N n = default)
            where N :ITypeNat, new()
        {
            TypeCaseStart<N>();

            var max = (uint)n.value - 1;
            var last = Mod.Define(max, n);
            var m = last;
            
            var i = (int)max;
            do --m;
            while(--i >= 0);
            
            Claim.eq(m, last);

            var x = max;
            var y = Mod.Define(max,n);

            for(var k = 1; k<i*3; k++)            
            {
                --x; 
                Claim.eq(x, y -= 1u);
            }

            TypeCaseEnd<N>();

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

        public void VerifyAdd<N>(int samples, N n = default)
            where N :ITypeNat, new()
        {
            TypeCaseStart<N>();

            var nVal = (uint)n.value;
            var n0 = Mod.Define(n);

            var lhs = Random.Span<uint>(samples);
            var rhs = Random.Span<uint>(samples);
            for(var i=0; i<samples; i++)
            {
                var x = lhs[i];
                var y = rhs[i];
                
                var xN = n0 + x;
                Claim.eq(Mod.Define(x,n), xN);

                var yN = n0 + y;
                Claim.eq(Mod.Define(y,n), yN);
                
                var zN = xN + yN;                
                var z = (uint)(((ulong)x + (ulong)y) % (ulong)nVal);
                Claim.eq(z, zN.State, appMsg($"{xN} + {yN} = {zN} != {z} = ({x} + {y}) % {n}", SeverityLevel.Error));                
            }

            TypeCaseEnd<N>();
        }


        static string FormatTable<T>(T[,] entries, uint offset = 0)
        {
            var sb = sbuild();
            var m = entries.GetLength(0);
            var n = entries.GetLength(1);

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

        void VerifyMul<N>(N n = default)
            where N : ITypeNat, new()
        {
            TypeCaseStart<N>();
            var nVal = (uint)n.value;
            var n0 = Mod.Define(n);            
            var expect = new uint[nVal,nVal];
            for(var i=0u; i<nVal; i++)
            for(var j=0u; j<nVal; j++)
            {
                var x = n0 + i;
                var y = n0 + j;
                var z = x*y;
                expect[i,j] = (i*j) % nVal;

                Claim.eq(expect[i,j], z);
            }
            TypeCaseEnd<N>();
        }
 
        void VerifyInverse<N>(N n = default)
            where N : ITypeNat, new()
        {

            TypeCaseStart<N>();
            var n0 = Mod.Define(n);
            var n1 = n0 + 1u;
            for(var i=1u; i<n.value; i++)
            {
                var x = n0 + i;
                var y = x.Invert();
                var z = x * y;
                Claim.eq(n1, z);
            }
            TypeCaseEnd<N>();
        }
    }
}