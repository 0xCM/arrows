// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2019
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Numerics;
//     using System.Linq;
//     using System.Collections.Generic;
//     using System.Runtime.CompilerServices;    

//     using static zcore;
//     using static primops;


//     public static class Divisors
//     {
//         public static IReadOnlyList<ulong> divisors(ulong src)
//         {
//             var result = new List<ulong>();
            
//             if(src != 0UL &&  src != 1UL)
//             {
//                 var upper = src/2UL + 1UL;
//                 var current = 2UL;

//                 while(current < upper)
//                 {
//                     if(src % current == 0UL)
//                         result.Add(current);

//                     current = ++current;
//                 }
//             }    
//             return result;
//         }        

//         public static DivisorIndex<ulong> divisors(Interval<ulong> interval)
//         {
//             var results = from n in algorithms.range(interval).AsParallel()
//                           let d = divisors(n)
//                           select DivisorList.define(n, d);

//             return DivisorIndex.define(interval, results.ToList());
//         }

//         public static IEnumerable<DivisorIndex<ulong>> divisors(Interval<ulong> interval, ulong step)
//         {
//             var min = interval.leftclosed ? interval.left : interval.left + 1UL;
//             var max = interval.rightclosed ? interval.right : interval.right - 1UL;

//             for(var i=min; i < max; i = i + step)
//             {
//                 var divMin = i + 1UL;
//                 var divMax = i + step;
//                 var next = Interval.closed(divMin, divMax);
//                 yield return divisors(next);
//             }
//         }
//     }

//     public static partial class algorithms
//     {
//         public static IEnumerable<DivisorIndex<T>> divisors<T>(Interval<T> interval, T step)
//                 where T : struct, IEquatable<T>            
//                     => Divisors<T>.divisors(interval, step);

//         public static IReadOnlyList<T> divisors<T>(T src)
//             where T : struct, IEquatable<T>       
//                 => Divisors<T>.divisors(src);     
                
//         readonly struct Divisors<T>
//             where T : struct, IEquatable<T>
//         {
//             static readonly Operative.PrimOps<T> Ops = primops.typeops<T>();
//             static readonly Operative.Algorithms<T> Alg = Z0.Algorithms<T>.Inhabitant;

//             static readonly T Zero = Ops.zero;

//             static readonly T One = Ops.one;

//             static readonly T Two = Ops.inc(Ops.one);

//             /// <summary>
//             /// Computes the divisors of a number
//             /// </summary>
//             /// <param name="src">The source number</param>
//             /// <typeparam name="T">The numeric type</typeparam>
//             public static IReadOnlyList<T> divisors(T src)
//             {            
//                 var result = new List<T>();
                
//                 if(Ops.neq(src,Zero) && Ops.neq(src,One))
//                 {
//                     var upper = Ops.inc(Ops.div(src,Two));
//                     var current = Two;

//                     while(Ops.lt(current, upper))
//                     {
//                         if(Ops.eq(Ops.mod(src, current), Zero))
//                             result.Add(current);

//                         current = Ops.inc(current);
//                     }
//                 }    
//                 return result;
//             }        

//             /// <summary>
//             /// Computes the divisors for each number in a specified interval
//             /// </summary>
//             /// <param name="min">The minimum dividend</param>
//             /// <param name="max">The maximum dividend</param>
//             /// <typeparam name="T"></typeparam>
//             /// <typeparam name="T">The numeric type</typeparam>
//             public static DivisorIndex<T> divisors(Interval<T> interval)
//             {
//                 var results = from n in range(interval).AsParallel()
//                             let d = divisors(n)
//                             select DivisorList.define(n, d);

//                 return DivisorIndex.define(interval, results.ToList());
//             }

//             /// <summary>
//             /// Computes a divisor index stream
//             /// </summary>
//             /// <param name="step"></param>
//             /// <param name="min"></param>
//             /// <param name="max"></param>
//             /// <typeparam name="T"></typeparam>
//             public static IEnumerable<DivisorIndex<T>> divisors(Interval<T> interval, T step)
//             {
//                 var min = interval.leftclosed ? interval.left : Ops.inc(interval.left);
//                 var max = interval.rightclosed ? interval.right : Ops.dec(interval.right);
//                 for(var i=min; Ops.lt(i,max); i = Ops.add(i, step))
//                 {
//                     var divMin = Ops.add(i, One);
//                     var divMax = Ops.add(i, step);
//                     var next = Interval.closed(divMin, divMax);
//                     yield return divisors(next);
//                 }
//             }



//         }

//         public static IEnumerable<T> range<T>(Interval<T> src)
//             where T : struct, IEquatable<T>
//         {
//             var first = src.leftclosed ? src.left : inc(src.left);
//             var last = src.rightclosed ? src.right : dec(src.right);
//             return range(first,last);
//         }
//         public static IEnumerable<T> range<T>(T first, T last)
//             where T : struct, IEquatable<T>
//         {
//             var current = first;
//             if(lt(first, last))
//             {
//                 while(lteq(current, last))
//                 {
//                     yield return current;
//                     current = inc(current);
//                 }                
//             }
//             else
//             {
//                 while(gteq(current, last))
//                 {
//                     yield return current;
//                     current = dec(current);
                    
//                 }
//             }
//         }        
//     }    
// }


