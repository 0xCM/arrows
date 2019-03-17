using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Core;
using Core.Data;

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


        static void Main(string[] args)
        {            
            EffectPartition();
            
            Console.WriteLine("Hello");
        }
    }
}
