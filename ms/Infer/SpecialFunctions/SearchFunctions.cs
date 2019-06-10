// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace MsInfer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    partial class MMath
    {

        /// <summary>
        /// Returns the maximum of a list of doubles
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static double Max(IEnumerable<double> list)
        {
            IEnumerator<double> iter = list.GetEnumerator();
            if (!iter.MoveNext())
                return Double.NaN;
            double Z = iter.Current;
            while (iter.MoveNext())
            {
                Z = Math.Max(Z, iter.Current);
            }
            return Z;
        }

        /// <summary>
        /// Returns the minimum of a list of doubles
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static double Min(IEnumerable<double> list)
        {
            IEnumerator<double> iter = list.GetEnumerator();
            if (!iter.MoveNext())
                return Double.NaN;
            double Z = iter.Current;
            while (iter.MoveNext())
            {
                Z = Math.Min(Z, iter.Current);
            }
            return Z;
        }

        /// <summary>
        /// Returns the index of the minimum element, or -1 if empty.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int IndexOfMinimum<T>(IList<T> list)
            where T : IComparable<T>
        {
            if (list.Count == 0)
                return -1;
            T min = list[0];
            int pos = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (min.CompareTo(list[i]) > 0)
                {
                    min = list[i];
                    pos = i;
                }
            }
            return pos;
        }

        /// <summary>
        /// Returns the index of the maximum element, or -1 if empty.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int IndexOfMaximum<T>(IList<T> list)
            where T : IComparable<T>
        {
            if (list.Count == 0)
                return -1;
            T max = list[0];
            int pos = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (max.CompareTo(list[i]) < 0)
                {
                    max = list[i];
                    pos = i;
                }
            }
            return pos;
        }

        /// <summary>
        /// Returns the index of the maximum element, or -1 if empty.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int IndexOfMaximumDouble(IList<double> list)
        {
            return IndexOfMaximum<double>(list);
        }



    }

}