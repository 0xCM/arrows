// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace MsInfer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


     /// <summary>
    /// This class provides mathematical constants and special functions, 
    /// analogous to System.Math.
    /// It cannot be instantiated and consists of static members only.
    /// </summary>
    /// <remarks>
    /// <para>
    /// In order to provide the highest accuracy, some routines return their results in log form or logit form.
    /// These transformations expand the domain to cover the full range of double-precision values, ensuring 
    /// all bits of the representation are utilized.  A good example of this is the NormalCdf function, whose 
    /// value lies between 0 and 1.  Numbers between 0 and 1 use only a small fraction of the capacity of a 
    /// double-precision number.  The function NormalCdfLogit transforms the result p according to log(p/(1-p)), 
    /// providing full use of the range from -Infinity to Infinity and (potentially) much higher precision.
    /// </para><para>
    /// To get maximal use out of these transformations, you want to stay in the expanded form as long as 
    /// possible.  Every time you transform into a smaller domain, you lose precision.  Thus helper functions 
    /// are provided which allow you to perform common tasks directly in the log form and logit form. 
    /// For logs, you have addition.  For logit, you have averaging. 
    /// </para>
    /// </remarks>
    partial class MMath
    {

        /// <summary>
        /// Returns the log of the sum of exponentials of a list of doubles
        /// </summary>
        /// <param name="list"></param>    
        /// <returns></returns>
        public static double LogSumExpSparse(IEnumerable<double> list)
        {
            if (!(list is ISparseEnumerable<double>))
                return LogSumExp(list);
            double max = list.EnumerableReduce(double.NegativeInfinity,
                                               (res, i) => Math.Max(res, i), (res, i, count) => Math.Max(res, i));
            var iter = (list as ISparseEnumerable<double>).GetSparseEnumerator();
            if ((!iter.MoveNext() && iter.CommonValueCount == 0) || Double.IsNegativeInfinity(max))
                return Double.NegativeInfinity; // log(0)
            if (Double.IsPositiveInfinity(max))
                return Double.PositiveInfinity;
            // at this point, max is finite
            double Z = Math.Exp(iter.Current - max);
            while (iter.MoveNext())
            {
                Z += Math.Exp(iter.Current - max);
            }
            Z += Math.Exp(iter.CommonValue - max) * iter.CommonValueCount;
            return Math.Log(Z) + max;
        }


        // Integrate using quadrature nodes and weights
        private static double Integrate(Converter<double, double> f, Vector nodes, Vector weights)
        {
            return weights.Inner(nodes, x => f(x));
        }




    }

}