//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class t_partition : UnitTest<t_partition>
    {        

        public void points()
        {
            points_check(0, 99, 1);
            points_check(0.0, 99.0, 1.0);
            points_check(0.0, 100, 0.5);
            points_check(0.0, 100, 0.72);
            points_check(0, 99, 1);
            points_check(0u, 99u, 1u);
            points_check(0L, 99L, 1u);
            points_check(0ul,99ul, 1ul);
            points_check(-250.75, 100.20, 1.0);
            points_check(-250.75f, 100.20f, 1.0f);

            points_check(100, 233, 5);
            points_check(100, 234, 5);
            points_check(100, 235, 5);
            points_check(-100, 75, 3);

        }

        public void part0()
        {
            var src = leftclosed(5,12);
            var dst = src.StepwisePartitionPoints(1);
            var fmt = dst.Map(x => x.ToString()).Concat(", ");
            Claim.eq(src.Width() + 1, dst.Length);            
            items(5,6,7,8,9,10,11,12).TakeSpan().ClaimEqual(dst);
        }

        public void part1()
        {
            var src = leftclosed(5,20);
            var dst = src.StepwisePartition(1);
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(leftclosed(5,6), dst.First());
            Claim.eq(leftclosed(19,20), dst.Last());

        }

        public void part2()
        {
            var src = closed(5,20);
            var dst = src.StepwisePartition(1);
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(leftclosed(5,6), dst.First());
            Claim.eq(closed(19,20), dst.Last());
        }

        public void part3()
        {
            var src = open(5,20);
            var dst = src.StepwisePartition(1);
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(open(5,6), dst.First());
            Claim.eq(leftclosed(19,20), dst.Last());
        }


        public void part4()
        {
            var src = leftopen(1,100);
            var dst = src.PartitionPoints(10);
            Claim.eq(10,dst.Length);
            Claim.eq(1, dst.First());
            Claim.eq(100, dst.Last());
        }

        public void part6()
        {
            var src = closed(1,103);
            var dst = src.Partition(13);            
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");   
            Claim.yea(dst.Last().RightClosed);
        }

        void points_check<T>(T min, T max, T step)
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
    }
}