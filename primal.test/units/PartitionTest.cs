//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public class PartitionTest : UnitTest<PartitionTest>
    {        


        public void Part0()
        {
            var src = leftclosed(5,12);
            var dst = src.StepwisePartitionPoints(1);
            var fmt = dst.Map(x => x.ToString()).Concat(", ");
            Claim.eq(src.Width() + 1, dst.Length);            
            Claim.eq(items(5,6,7,8,9,10,11,12).TakeSpan(), dst);
        }

        public void Part1()
        {
            var src = leftclosed(5,20);
            var dst = src.StepwisePartition(1);
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(leftclosed(5,6), dst.First());
            Claim.eq(leftclosed(19,20), dst.Last());

        }

        public void Part2()
        {
            var src = closed(5,20);
            var dst = src.StepwisePartition(1);
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(leftclosed(5,6), dst.First());
            Claim.eq(closed(19,20), dst.Last());
        }

        public void Part3()
        {
            var src = open(5,20);
            var dst = src.StepwisePartition(1);
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(open(5,6), dst.First());
            Claim.eq(leftclosed(19,20), dst.Last());
        }


        public void Part4()
        {
            var src = leftopen(1,100);
            var dst = src.PartitionPoints(10);
            Claim.eq(10,dst.Length);
            Claim.eq(1, dst.First());
            Claim.eq(100, dst.Last());
        }

        public void Part6()
        {
            var src = closed(1,103);
            var dst = src.Partition(13);            
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");   
            Claim.yea(dst.Last().RightClosed);

        }

        void VerifyPoints<T>(T min, T max, T step)
            where T : struct
        {
            var points = open(min, max).StepwisePartitionPoints(step); 
            var width = gmath.sub(max,min);
            var deltaSum = gmath.zero<T>();
            for(var i=0; i<points.Length - 1; i++)           
            {
                var left = points[i];
                var right = points[i + 1];
                gmath.add<T>(ref deltaSum, gmath.sub(right,left));                
            }

            Claim.eq(width, deltaSum);
            

            
        }

        public void VerifyPoints()
        {
            VerifyPoints(0, 99, 1);
            VerifyPoints(0.0, 99.0, 1.0);
            VerifyPoints(0.0, 100, 0.5);
            VerifyPoints(0.0, 100, 0.72);
            VerifyPoints(0, 99, 1);
            VerifyPoints(0u, 99u, 1u);
            VerifyPoints(0L, 99L, 1u);
            VerifyPoints(0ul,99ul, 1ul);
            VerifyPoints(-250.75, 100.20, 1.0);
            VerifyPoints(-250.75f, 100.20f, 1.0f);

            VerifyPoints(100, 233, 5);
            VerifyPoints(100, 234, 5);
            VerifyPoints(100, 235, 5);
            VerifyPoints(-100, 75, 3);

        }

    }
}