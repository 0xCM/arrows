//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Caracterizes an association between two types for which there
    /// exists a notion of unique succession
    /// </summary>
    /// <typeparam name="A1">The source type</typeparam>
    /// <typeparam name="A2">The type of the successor</typeparam>
    /// <remarks>
    /// Given a universe U that contain A and B, along with a strict partial order <,
    /// reification codifies that A < B
    /// </remarks>
    public interface ISuccessive<A1,A2> 
    {
        /// <summary>
        /// Given an A-value, computes the next B-value
        /// </summary>
        /// <param name="a">The source vlue</param>
        A2 Next();
    }

    /// <summary>
    /// Caracterizes an association between two types for which there
    /// exists a notion of unique antecedant
    /// </summary>
    /// <typeparam name="A1">The source type</typeparam>
    /// <typeparam name="A2">The type of the successor</typeparam>
    /// <remarks>
    /// Given a universe U that contain A and B, along with a strict partial order <,
    /// reification codifies that B < A
    /// </remarks>
    public interface IAntecedant<A1,A2>
    {
        /// <summary>
        /// Given an A-value, computes the prior B-value
        /// </summary>
        /// <param name="a">The source vlue</param>
        A2 Prior();
    }

    /// <summary>
    /// Characterizes a bidirectional association between types for which
    /// the exists notions successors and antecedants
    /// </summary>
    /// <typeparam name="A">The type that succeeds B</typeparam>
    /// <typeparam name="B">The type that precedes A</typeparam>
    public interface IAdjacency<A,B> : ISuccessive<B,A>, IAntecedant<A,B>
    {

    }

}