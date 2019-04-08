using System;
using System.Linq;
using System.Reflection;
using SN = System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;

using Z0;
using Z0.Testing;

using static zcore;

using static Z0.Nats;

namespace App04
{

    using N128 = NatSeq<N1,N2,N8>;
    using N512 = NatSeq<N5,N1,N2>;

    class Program
    {


        static void TestPrimality(int min, int max)
        {            
            for(var i = min; i<=max; i++)            
            {
            
                if(prime(i.ToIntG()))
                    print($"{i} is prime");
                else
                    print($"{i} is not prime");
            }
        }


        static T dot<N,T>(Z0.Slice<N,T> s1, Z0.Slice<N,T> s2)
            where N : TypeNat, new()
            where T : struct, Equatable<T>
            {
                var ops = primops.type<T>();
                var result = ops.zero;
                for(var i=0; i< s1.length; i++)
                    result = ops.add(result, ops.mul(s1[i],s2[i]));
                return result;                    
            }
        static void CreateSlices()
        {
            var s1 = slice<N5,intg<int>>(1,2,3,4,5);
            var s2 = slice<N5,intg<int>>(1,1,1,1,1);
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


        static void Mul(long n)
        {
            print($"long & intg<long> Mul(n = {n})");
            long count = n;
            var v1 = range<long>(1, n).ToArray();
            var v2 = range<long>(1, n).ToArray();
            var v3 = range<long>(1, n).ToArray();
            var v4 = array<long>(n);
            var v1u = v1.Unwrap();
            var v2u = v2.Unwrap();
            var v3u = v3.Unwrap();
            var v4u = array<long>(n);
            var swu = stopwatch();
            for(int i=0; i < count; i++)
                v4u[i] = v1u[i]*v2u[i]*v3u[i];
            print($"long Mul(finished): {elapsed(swu)}ms");

            var sw = stopwatch();
            for(int i=0; i < count; i++)
                v4[i] = v1[i]*v2[i]*v3[i];
            print($"intg<long> Mul(finished): {elapsed(sw)}ms");

        }

        static void Sum(long n)
        {
            print($"intg<long> Sum(n = {n})");
            long count = n;
            var v1 = range<long>(1, n).ToArray();
            var v2 = range<long>(1, n).ToArray();
            var v3 = range<long>(1, n).ToArray();
            var v4 = array<long>(n);
            var sw = stopwatch();
            for(int i=0; i < count; i++)
                v4[i] = v1[i]+v2[i]+v3[i];
            print($"intg<long> Sum(finished): {elapsed(sw)}ms");
        }

        static void Sum(real<long> n)
        {
            print($"long Sum(n = {n})");
            long count = n;
            var v1 = reals<long>(1, n).Unwrap().Freeze();
            var v2 = reals<long>(1, n).Unwrap().Freeze();
            var v3 = reals<long>(1, n).Unwrap().Freeze();
            var v4 = array<real<long>>(n);
            var sw = stopwatch();
            for(int i=0; i < count; i++)
                v4[i] = v1[i]+v2[i]+v3[i];
            print($"long Sum(finished): {elapsed(sw)}ms");
        }

        static void SumMulLong(int reps, long vecLen)
        {
            void generic()
            {
                print($"intg<long> SumMul(n = {vecLen})");
                var v1 = range<long>(1, vecLen).ToArray();
                var v2 = range<long>(1, vecLen).ToArray();
                var v3 = range<long>(1, vecLen).ToArray();
                var v4 = array<long>(vecLen);
                var sw = stopwatch();
                for(int i=0; i < vecLen; i++)
                    v4[i] = v1[i]+v2[i]+v3[i] + v1[i]*v2[i]*v3[i];
                print($"intg<long> SumMul(finished): {elapsed(sw)}ms");
            }

            void system()
            {
                print($"long SumMul(n = {vecLen})");
                var v1 = range<long>(1, vecLen).Unwrap().Freeze();
                var v2 = range<long>(1, vecLen).Unwrap().Freeze();
                var v3 = range<long>(1, vecLen).Unwrap().Freeze();
                var v4 = array<long>(vecLen);
                var sw = stopwatch();
                for(int i=0; i < vecLen; i++)
                    v4[i] = v1[i]+v2[i]+v3[i] + v1[i]*v2[i]*v3[i];
                print($"long SumMul(finished): {elapsed(sw)}ms");
            }

            for(var k = 0; k<reps; k++)
            {
                generic();
                system();
            }

        }



        static void DisplayBits()
        {
            print(primops.bitstring(numg<byte>(155)));
            print(primops.bitstring(numg<short>(888)));
            print(primops.bitstring(numg(132593u)));
            print(primops.bitstring(numg(132593.34m)));
            print(primops.bitstring(numg(7.00)));

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

            Mul(Cycles);
            print();

            Sum(CyclesG);
            Sum(Cycles);
            print();

            SumMulLong(5,CyclesG);

        }

        static void Ranges()
        {
            printeach(range<int>(1,9));
            printeach(range<int>(9,1));
        

        }

        static void Slices()
        {
            var s1 = Z0.N256.Seq.NatSlice(range<int>(1,256));
            var s2 = Z0.N256.Seq.NatSlice(range<int>(1,256));
            print(Slice.add(s1,s2));
            //print(Slice.mul(s1,s2));
            print(Slice.sum(s1));
            print(Slice.square(s1));

            
        }

        static void Vectors()
        {
            var v1 = vector<N9,intg<long>>(1,2,3,4,5,6,7,8,9);
            var v2 = vector<N9,intg<long>>(9,8,7,6,5,4,3,2,1);
            var result = Vector.mul(v1,v2);
            print($"{v1} * {v2} = {result}");
        }

        static void Integers()
        {
            var total = u(0);
            for(var i=0; i<1024; i++)
                print(total++);
        }

        static void IntModN()
        {
            var x = modring<NatSeq<N1,N2>,uint>(32u);
            var y = modring<NatSeq<N1,N2>,uint>(18u);
            print($"x := {x}, y := {y}");
            print($"{x} + {y} = {x + y}");
            print($"{x} * {y} = {x * y}");


        }

        static void NatSeq()
        {            
            print($"{N128.Rep}");
            print($"{N512.Rep}");
            print($"{NatSeq<N1,N2>.Rep}");
            print($"{Nat.nat<NatSeq<N4,N3,N2>>()}");

        }

        static void VectorArithmetic()
        {
            var v1 = Nats.N3.NatVec(ints(1,2,3));
            var v2 = Nats.N3.NatVec(ints(3,2,1));
            var v3 = Vector.add(v1,v2);
            print($"{v1} + {v2} = {v3}");
        }

        static void NatReflect(uint min, uint max)
        {
            print($"Creating type nat range {min}..{max}");
            var sw = stopwatch();
            var result = Nat.reflect(min,max).ToList();
            print($"Created {result.Count} natural values in {sw.ElapsedMilliseconds}ms");
        }
        
        static void RandomU64(ulong count)
        {
            var r = new Randomizer();
            var current = 0ul;
            while(++current <= count)
                write($"{r.next()}, ");
        }



        // static void Partitions()
        // {
        //     var left = real(UInt16.MinValue);
        //     var right = real(UInt16.MaxValue);
        //     var width = (right - left)/real<ushort>(100);
        //     var i = (left,right).ToClosedInterval();
        //     var p = Interval.partition(i, width).ToList();            
        //     print($"interval = {i}, partition width = {width}, point count = {p.Count}");
        // }

        // public static void Histo(uint trials)
        // {
        //     var min = UInt16.MinValue;
        //     var max = UInt16.MaxValue;
        //     var hg = Histogram.define(min, max);            
        //     var r = new Randomizer();
        //     print($"binwidth = {hg.binwidth}");            
        //     hg.distribute(r.many(trials,min,max));
        //     iter(hg.ratios(), r => print($"{r.bin} : {r.ratio}"));

        // }

        public static void Histo<T>(int trials)
        {
            
        }

        static real<T> sum<T>(params real<T>[] values)
            where T : struct, IEquatable<T>
        {
            var total = Z0.real<T>.Zero;
            foreach(var v in values)
                total += v;
            return total;
        }

        

        public static void BitOps1()
        {
            ShowBit(u(34), 0);
            ShowBit(u(34), 1);
            ShowBit(u(34), 2);
            ShowBit(u(34), 3);
            ShowBit(u(34), 4);
            ShowBit(u(34), 5);            
            ShowBit(u(34), 6);
            ShowBit(u(34), 7);


        }

        static void ShowBit<T>(intg<T> x, int pos)
            where T : struct, IEquatable<T>
                => print($"value: {x}, bits = {x.bitstring()} bit[{pos}] = {bit(x,pos)}");
        
        public static void PrintBits<T>(intg<T> src)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i < (int)src.bitsize; i ++)
                ShowBit(src, i);
        }

        public static void ShowBits<T>(intg<T> src)
            where T : struct, IEquatable<T>
                => print(src.bitstring());


        public static void GenRandMatrices<T>(uint count, real<T> min, real<T> max)
            where T : struct, IEquatable<T>
        {
            var stream = Rand.matrices<N2,N2,T>(min,max);
            printeach(stream.Take((int)count));
        }

        public static void GenRandVectors<T>(uint count, real<T> min, real<T> max)
            where T : struct, IEquatable<T>
        {
            var stream = Rand.vectors<N5,T>(min,max);
            printeach(stream.Take((int)count));
        }

        public static void BitVectors()
        {
            var bv16fixed = BitVector.define(Nats.N16, u(0b1010000001010110));
            var bv16var = BitVector.define(Nats.N16, bigint(0b1010000001010110));

            print($"bv16var  : bitstring={bv16var}, bitcount={bv16var.length}");
            print($"bv16fixed: bitstring={bv16fixed}, bitcount={bv16fixed.length}");


            var bv32fixed = BitVector.define(Nats.N32, u(0b00100000010101101010000001010110));
            var bv32var = BitVector.define(Nats.N32, bigint(0b00100000010101101010000001010110));

            print($"bv32var  : bitstring={bv32var}, bitcount={bv32var.length}");
            print($"bv32fixed: bitstring={bv32fixed}, bitcount={bv32fixed.length}");


        }

        static IEnumerable<ulong> from(ulong min, ulong max)
        {
            for(var i = min; i <=max; i++)
                yield return i;
        }
        static IEnumerable<ulong> divisors(ulong src)
        {        
            if(src != 0 && src != 1)
            {
                var upper = src/2 + 1;
                var candidates = from(2, upper);
                foreach(var c in candidates)
                    if(src % c == 0 )
                        yield return c;
            }    
        }


        static void ConverterSpeed()
        {

            var vectors = Rand.vectors(Nats.N10, -250000L, 250000L);
            var sample = vectors.Take(Pow2.T20).Freeze();
            var sw = stopwatch();
            var realvecs = map(sample, 
                v => vector(Nats.N0, ConvertG.toReal<long,double>(v.unwrap())));
            print($"Converted {realvecs.Count} long vectors to double vectors in {sw.ElapsedMilliseconds}ms");
        }    
        static void bitplay()
        {


            Func<sbyte,int,bool> t2 = (x,i) => primops.testbit(x,i);
            Func<byte,int,bool> t4 = (x,i) => primops.testbit(x,i);

            byte b1 = 0b110010;
            var b1Bits = slice(t4(b1,5), t4(b1,4), t4(b1,3),t4(b1,2), t4(b1,1), t4(b1,0));
            var b1Bits2 = slice(Bit.read(b1,5), Bit.read(b1,4), Bit.read(b1,3),Bit.read(b1,2), Bit.read(b1,1), Bit.read(b1,0));
            var b1BitString = b1Bits.ToBitString();
            //print($"b1: value - {b1}, bits = {b1Bits2.ToBitString()}");

            sbyte b2 = 0b110010;
            var b2Bits = slice(t2(b2,5), t2(b2,4), t2(b2,3), t2(b2,2), t2(b2,1), t2(b2,0));
            var b2BitString = b2Bits.ToBitString();
            //print($"b2: value - {b2}, bits = {b2BitString}");
            
            var v8 = BitVector.parse(Nats.N8,"0b00110010");
            var v16 = BitVector.parse(Nats.N16,"0b0011001000110010");
            var v32 = BitVector.parse(Nats.N32,"0b00110010001100100011001000110010");
            var v64 = BitVector.parse(Nats.N64,"0b0011001000110010001100100011001000110010001100100011001000110010");
             print($"v8: bits - {v8}, value - {v8.unwrap()}");
             print($"v16: bits - {v16}, value - {v16.unwrap()}");
             print($"v32: bits - {v32}, value - {v32.unwrap()}");
             print($"v64: bits - {v64}, value - {v64.unwrap()}");
            

        }


    }
}
