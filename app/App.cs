﻿using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;

using Core;

using static corefunc;

using C = Core.Contracts;

namespace App04
{


    class Program
    {

        static void EffectPartition()
        {
            var ops = Operations.float64();
            var parition = ops.partition(0, 1);
            iter(parition, print);            
        }

        static void CalcDivisors(intg<long> value)
        {
            print($"calculating the divisors of {value}");
            printeach(intG.divisors(value));
        }

        static void TestPrimality(intg<int> value)
        {
            var prime = intG.prime(value);
            if(prime)
                print($"{value} is prime");
            else
                print($"{value} is not prime");
        }

        static T dot<N,T>(Reify.Slice<N,T> s1, Reify.Slice<N,T> s2)
            where N : TypeNat
            where T : new()
            {
                var ops = Operations.integer<T>();
                var result = ops.zero;
                for(var i=0; i< s1.length; i++)
                    result = ops.add(result, ops.mul(s1[i],s2[i]));
                return result;                    
            }
        static void CreateSlices()
        {
            var s1 = slice<N5,int>(1,2,3,4,5);
            var s2 = slice<N5,int>(1,1,1,1,1);
            var dp = dot(s1,s2);
            print($"dot product = {dp}");

        }

        static void TwiddleInt32Bits(int src)
        {
            print($"Begin {MethodInfo.GetCurrentMethod().Name}");
                        
            print($"src={src}");

            var hi = Bits.hi(src);
            print($"hi={hi}");
            
            var lo = Bits.lo(src);        
            print($"lo={lo}");

            var dst = Bits.concat(hi,lo);
            print($"dst={dst}");

            print($"End {MethodInfo.GetCurrentMethod().Name}");
        }

        static void TwiddleUInt32Bits(uint src)
        {
            print($"Begin {MethodInfo.GetCurrentMethod().Name}");
                        
            print($"src={src}");

            var hi = Bits.hi(src);
            print($"hi={hi}");
            
            var lo = Bits.lo(src);        
            print($"lo={lo}");

            var dst = Bits.concat(hi,lo);
            print($"dst={dst}");

            print($"End {MethodInfo.GetCurrentMethod().Name}");
        }

        static void TwiddleUInt64Bits(ulong src)
        {
            print($"Begin {MethodInfo.GetCurrentMethod().Name}");
                        
            print($"src={src}");

            var hi = Bits.hi(src);
            print($"hi={hi}");
            
            var lo = Bits.lo(src);        
            print($"lo={lo}");

            var dst = Bits.concat(hi,lo);
            print($"dst={dst}");

            print($"End {MethodInfo.GetCurrentMethod().Name}");
        }

        static void Perf(uint n)
        {
            print($"uint - executing, n = {n}");
            var sw = stopwatch();
            for(var i = 0; i < n; i++)                
            {
                var j = i* n/2 + n/3 * 2 - i * n/4 - 17 * n/5;
                var t1 = j >= 70 + 1;
                var t2 = 4*j < 23829;
                var a1 = j*2 & j*4 | j*7 ^ j*8;
            }
            print($"uint finished - {elapsed(sw)}ms");

        }




        static void Perf(intg<uint> n)
        {
            print($"intg<uint> - executing, n = {n}");
            var sw = stopwatch();
            for(var i = n.zero; i < n; i++)                
            {
                var j = i* n/2 + n/3 * 2 - i * n/4 - 17 * n/5;
                var t1 = j >= 70 + n.one;
                var t2 = 4*j < 23829;
                var a1 = j*2 & j*4 | j*7 ^ j*8;
            }
            print($"intg<uint> finished - {elapsed(sw)}ms");

        }

        static void Perf(intg<int> n)
        {
            print($"intg<long> Misc(n = ${n})");
            var sw = stopwatch();
            for(var i = n.zero; i < n; i++)                
            {
                var j = i* n/2 + n/3 * 2 - i * n/4 - 17 * n/5;
                var t1 = j >= 70 + n.one;
                var t2 = 4*j < 23829;
                var a1 = j*2 & j*4 | j*7 ^ j*8;
            }
            print($"intg<long> Misc(finished): {elapsed(sw)}ms");

        }

        static void Misc(decimal n)
        {
            print($"decimal Misc(n = ${n})");
            var sw = stopwatch();
            for(var i = 0m; i < n; i++)                
            {
                var j = i* n/2 + n/3 * 2 - i * n/4 - 17 * n/5;
                var t1 = j >= 70 + 1;
                var t2 = 4*j < 23829;
                var a1 = j*2 + j*4 + j*7 + j*8;
            }
            print($"decimal Misc(finished): {elapsed(sw)}ms");

        }

        static void Misc(long n)
        {
            print($"long Misc(n = ${n})");
            var sw = stopwatch();
            for(long i = 0; i < n; i++)                
            {
                var j = i* n/2 + n/3 * 2 - i * n/4 - 17 * n/5;
                var t1 = j >= 70 + 1;
                var t2 = 4*j < 23829;
                var a1 = j*2 & j*4 | j*7 ^ j*8;
            }
            print($"long Misc(finished): {elapsed(sw)}ms");

        }

        static void Misc(intg<long> n)
        {
            print($"intg<long> Misc(n = ${n})");
            var sw = stopwatch();
            for(long i = n.zero; i < n; i++)                
            {
                var j = i* n/2 + n/3 * 2 - i * n/4 - 17 * n/5;
                var t1 = j >= 70 + n.one;
                var t2 = 4*j < 23829;
                var a1 = j*2 & j*4 | j*7 ^ j*8;
            }
            print($"intg<long> Misc(finished): {elapsed(sw)}ms");
        }

        static void Mul(intg<long> n)
        {
            print($"intg<long> Mul(n = {n})");
            long count = n;
            var v1 = range<long>(1, n).ToArray();
            var v2 = range<long>(1, n).ToArray();
            var v3 = range<long>(1, n).ToArray();
            var v4 = array<intg<long>>(n);
            var sw = stopwatch();
            for(long i=0; i < count; i++)
            {
                v4[i] = v1[i]*v2[i]*v3[i];
            }
            print($"intg<long> Mul(finished): {elapsed(sw)}ms");
        }

        static void Mul(long n)
        {
            print($"long Mul(n = {n})");
            long count = n;
            var v1 = range<long>(1, n).Unwrap();
            var v2 = range<long>(1, n).Unwrap();
            var v3 = range<long>(1, n).Unwrap();
            var v4 = array<long>(n);
            var sw = stopwatch();
            for(int i=0; i < count; i++)
            {
                v4[i] = v1[i]*v2[i]*v3[i];
            }
            print($"long Mul(finished): {elapsed(sw)}ms");

        }

        static void Sum(intg<long> n)
        {
            print($"intg<long> Sum(n = {n})");
            long count = n;
            var v1 = range<long>(1, n).ToArray();
            var v2 = range<long>(1, n).ToArray();
            var v3 = range<long>(1, n).ToArray();
            var v4 = array<intg<long>>(n);
            var sw = stopwatch();
            for(int i=0; i < count; i++)
                v4[i] = v1[i]+v2[i]+v3[i];
            print($"intg<long> Sum(finished): {elapsed(sw)}ms");
        }

        static void Sum(long n)
        {
            print($"long Sum(n = {n})");
            long count = n;
            var v1 = range<long>(1, n).Unwrap();
            var v2 = range<long>(1, n).Unwrap();
            var v3 = range<long>(1, n).Unwrap();
            var v4 = array<long>(n);
            var sw = stopwatch();
            for(int i=0; i < count; i++)
                v4[i] = v1[i]+v2[i]+v3[i];
            print($"long Sum(finished): {elapsed(sw)}ms");
        }

        static void SumMul(intg<long> n)
        {
            print($"intg<long> SumMul(n = {n})");
            long count = n;
            var v1 = range<long>(1, n).ToArray();
            var v2 = range<long>(1, n).ToArray();
            var v3 = range<long>(1, n).ToArray();
            var v4 = array<intg<long>>(n);
            var sw = stopwatch();
            for(int i=0; i < count; i++)
                v4[i] = v1[i]+v2[i]+v3[i] + v1[i]*v2[i]*v3[i];
            print($"intg<long> SumMul(finished): {elapsed(sw)}ms");
        }

        static void SumMul(long n)
        {
            print($"long SumMul(n = {n})");
            long count = n;
            var v1 = range<long>(1, n).Unwrap();
            var v2 = range<long>(1, n).Unwrap();
            var v3 = range<long>(1, n).Unwrap();
            var v4 = array<long>(n);
            var sw = stopwatch();
            for(int i=0; i < count; i++)
                v4[i] = v1[i]+v2[i]+v3[i] + v1[i]*v2[i]*v3[i];
            print($"long SumMul(finished): {elapsed(sw)}ms");
        }

        static void SplitDouble(double src)
        {
            var parts = Bits.split(src);
            var exp =  bitstring<double>(parts.exponent);
        }

        static void DisplayBits()
        {
            print(bitstring(numg<byte>(155)));
            print(bitstring(numg<short>(888)));
            print(bitstring(numg(132593u)));
            print(bitstring(numg(132593.34m)));
            print(bitstring(numg(7.00)));

        }

        static void Initialize()
        {

        }

        static readonly intg<long> CyclesG = 10000000;
        static readonly long Cycles = CyclesG;

        static void Perf()
        {
            Misc(CyclesG);
            Misc(Cycles);
            print();

            Mul(CyclesG);
            Mul(Cycles);
            print();

            Sum(CyclesG);
            Sum(Cycles);
            print();

            SumMul(CyclesG);
            SumMul(Cycles);

        }

        static void Semigroups()
        {
            var sg = semigroup<long>();
            //print(sg.(3,4));

        }
        static void Main(string[] args)
        {            
            Semigroups();
        }
    }
}
