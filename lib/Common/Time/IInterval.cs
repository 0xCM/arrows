//-------------------------------------------------------------------------------------------
// OSS developed by Chris Moore and licensed via MIT: https://opensource.org/licenses/MIT
// This license grants rights to merge, copy, distribute, sell or otherwise do with it 
// as you like. But please, for the love of Zeus, don't clutter it with regions.
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zcore;

    /// Delineates a contiguous interval between comparable inclusive lower and upper bounds of the same data type
    /// </summary>
    /// <typeparam name="T">The data type</typeparam>
    public interface IRange<out T> : IInterval<T>
        where T : IComparable
    {


    }

    /// <summary>
    /// Represents the content of a contiguous interval between comparable lower and upper bounds of the same type
    /// </summary>
    public interface IInterval 
    {
        /// <summary>
        /// The first endpoint
        /// </summary>
        object Min { get; }

        /// <summary>
        /// The second endpoint
        /// </summary>
        object Max { get; }

        /// <summary>
        /// Specifies whether the left endpoint is included in the interval
        /// </summary>
        bool LeftInclusive { get; }

        /// <summary>
        /// Specifies whether the right endpoint is included in the interval
        /// </summary>
        bool RightInclusive { get; }
    }

    /// <summary>
    /// Represents the content of a contiguous interval between comparable lower and upper bounds of the same type
    /// </summary>
    public interface IInterval<out T> : IInterval
    {
        /// <summary>
        /// The inclusive lower bound
        /// </summary>
        new T Min { get; }

        /// <summary>
        /// The inclusive upper bound
        /// </summary>
        new T Max { get; }

    }

    /// <summary>
    /// Defines inclusive lower and upper bounds for a comparable set of values
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public struct Range<T> : IInterval<T>
        where T : IComparable
    {
        public Range(T Min, T Max)
        {
            this.Min = Min;
            this.Max = Max;
        }

        /// <summary>
        /// The minimum value in the range
        /// </summary>
        public T Min { get; }

        /// <summary>
        /// The maximum value in the range
        /// </summary>
        public T Max { get; }

        bool IInterval.LeftInclusive
            => true;

        bool IInterval.RightInclusive
            => true;

        object IInterval.Min
            => Min;

        object IInterval.Max
            => Max;

        /// <summary>
        /// Tests whether a value is in the range
        /// </summary>
        /// <param name="candidate">The value to test</param>
        /// <returns></returns>
        public bool In(T candidate)
            => candidate.CompareTo(Min) >= 0 
                && candidate.CompareTo(Max) <= 0;

        public override string ToString()
            => $"[{Min}, {Max}]";
    }

}