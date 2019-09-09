//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;
    
    using static zfunc;

    public class t_mod : UnitTest<t_mod>
    {
        public void mod_mul()
        {
            mod_mul_check(n3);
            mod_mul_check(n5);
            mod_mul_check(n7);
            mod_mul_check(n10);
            mod_mul_check(n11);
            mod_mul_check(n13);
            mod_mul_check(n32);
            mod_mul_check(n64);
            mod_mul_check(n128);
            mod_mul_check(n1024);
        }

        public void mod_inc()
        {
            mod_inc_check(n128);
            mod_inc_check(n5);
            mod_inc_check(n20);            
        }

        public void mod_dec()
        {
            mod_dec_check(n13);
            mod_dec_check(n17);
            mod_dec_check(n32);
            mod_dec_check(n64);
            mod_dec_check(n128);
        }

        public void mod_inv()
        {
            mod_inverse_check(n3);
            mod_inverse_check(n5);
            mod_inverse_check(n7);
            mod_inverse_check(n11);
            mod_inverse_check(n13);
            mod_inverse_check(n17);
            mod_inverse_check(n19);
            mod_inverse_check(n31);
            mod_inverse_check(N41);
            mod_inverse_check(n1277);
        }

        public void mod_add()
        {
            var samples = Pow2.T08;
            mod_add_check(samples,n87);
            mod_add_check(samples,n64);
            mod_add_check(samples,n512);
        }

        public void mod_create()
        {
            var n = new N32();
            
            var a = Mod.Define(11, n);
            var b = Mod.Define(21, n);
            var c = Mod.Define(0, n);
            var d = a + b;
            Claim.eq(c,d);
        }

        public void mod_create_imp()
        {
            var n = new N15();

            Mod<N15> x = 5;
            Claim.eq(Mod.Define(5,n),x);

            var a0 = x + 2;
            Claim.eq(Mod.Define(7,n),a0);
        }

        public void mod_sub()
        {
            var n = new N15();

            Mod<N15> a = 5;
            
            var b14a = a + 9;
            Claim.eq(Mod.Define(14,n), b14a);

            var b14b = a - 6;
            Claim.eq(Mod.Define(14,n), b14a);
        }

        void mod_add_check<N>(int samples, N n = default)
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

        void mod_mul_check<N>(N n = default)
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
 
        void mod_inverse_check<N>(N n = default)
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

        void mod_dec_check<N>(N n = default)
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

        void mod_inc_check<N>(N n = default)
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

    }
}