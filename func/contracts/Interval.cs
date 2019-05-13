//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Characterizes a contiguous segment of homogenous values that lie within
    /// left and right boundaries 
    /// </summary>
    /// <remarks>
    /// Note that extended real numbers may also serve as endpoints,
    /// enabling representations such as (-∞,3] and (-3, ∞).
    /// </remarks>
    public interface IInterval<T>
        where T : struct, IEquatable<T>
    {
    
        /// <summary>
        ///  The interval's left endpoint
        /// </summary>
        T Left {get;}

        /// <summary>
        ///  Specifies whether the left endpoint itself is contained in the interval
        /// </summary>
        bool LeftClosed {get;}

        /// <summary>
        ///  The interval's right endpoint
        /// </summary>
        T Right {get;}

        /// <summary>
        ///  Specifies whether the right endpoint itself is contained in the interval
        /// </summary>
        bool RightClosed {get;}

        IntervalKind Kind {get;}

        /// <summary>
        /// Presents the interval in canonical/general form
        /// </summary>
        Interval<T> AsCanonical();

    }

    public interface IInterval<S,T> : IInterval<T>
        where T : struct, IEquatable<T>
            where S : IInterval<S,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a discrete interval
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    public interface IDiscreteInterval<T> : IInterval<T> 
        where T : struct, IEquatable<T>
    {

    }

 
    /// <summary>
    /// Characterizes an interval that does not contain its upper bound
    /// </summary>
    public interface IRightOpenInterval<T> : IInterval<T> 
        where T : struct, IEquatable<T>
    {

    }

    /// <summary>
    /// Characterizes an interval that contains its lower bound
    /// </summary>
    public interface ILeftClosedInterval<T> : IInterval<T> 
        where T : struct, IEquatable<T>
    {

    }

    /// <summary>
    /// Characterizes an interval that does not contain its lower bound
    /// </summary>
    public interface ILeftOpenInterval<T> : IInterval<T> 
        where T : struct, IEquatable<T>
    {

    }

    /// <summary>
    /// Characterizes an interval that contains its upper bound
    /// </summary>
    public interface IRightClosedInterval<T> : IInterval<T>
        where T : struct, IEquatable<T>
    {

    }

    /// <summary>
    /// Characterizes an interval that contains neither  of its endpoints
    /// </summary>
    public interface IOpenInterval<T> : ILeftOpenInterval<T>, IRightOpenInterval<T> 
        where T : struct, IEquatable<T>
    {

    }

    public interface IOpenInterval<S,T> : IOpenInterval<T>, IInterval<S,T>
        where S : IOpenInterval<S,T>, new()
        where T : struct, IEquatable<T>
    {

    }

    /// <summary>
    /// Characterizes an interval that contains its endpoints
    /// </summary>
    public interface IClosedInterval<T> : ILeftClosedInterval<T>, IRightClosedInterval<T> 
        where T : struct, IEquatable<T>
    {

    }

    public interface IClosedInterval<S,T> : IClosedInterval<T>, IInterval<S,T>
        where S : IClosedInterval<S,T>, new()
        where T : struct, IEquatable<T>
    {

    }


}