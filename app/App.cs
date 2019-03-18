using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Core;

using static corefunc;

namespace App04
{


    class Program
    {

        static void EffectPartition()
        {
            var ops = MathOps.float64();
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


        static void Main(string[] args)
        {            
            TestPrimality(1024);
            TestPrimality(17);
            
            Console.WriteLine("Hello");
        }
    }
}
