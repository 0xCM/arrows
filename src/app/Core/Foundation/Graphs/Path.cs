namespace Core.Contracts
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a path with any number of components
    /// </summary>
    public interface Path
    {
        IEnumerable<Arrow> components {get;}
    }

    /// <summary>
    /// Characterizes a path with 2 components
    /// </summary>
    /// <typeparam name="S">The path's source type</typeparam>
    /// <typeparam name="A1">The type over which head and tail arrows meet</typeparam>
    /// <typeparam name="T">The path's target type</typeparam>
    public interface Path<S,A1,T> : Path
    {
        /// <summary>
        /// The first segment of the path
        /// </summary>
        /// <value></value>
        Arrow<S,A1> head {get;}

        /// <summary>
        /// The last segment of the path
        /// </summary>
        /// <value></value>
        Arrow<A1,T> tail {get;}
    }

    /// <summary>
    /// Characterizes a path with 3 components
    /// </summary>
    /// <typeparam name="S">The path's source type</typeparam>
    /// <typeparam name="A1">The interior source type</typeparam>
    /// <typeparam name="A2">The interior target type</typeparam>
    /// <typeparam name="T">The path's target type</typeparam>
    public interface Path<S,A1,A2,T> : Path
    {
        /// <summary>
        /// The first segment of the path
        /// </summary>
        Arrow<S,A1> head {get;}

        /// <summary>
        /// The path's interior segment
        /// </summary>
        Arrow<A1,A2> center {get;}
        
        /// <summary>
        /// The last segment of the path
        /// </summary>
        /// <value></value>
        Arrow<A2,T> tail {get;}
    }

    /// <summary>
    /// Characterizes a path with 4 components
    /// </summary>
    /// <typeparam name="S">The path's source type</typeparam>
    /// <typeparam name="A1">The first interior type</typeparam>
    /// <typeparam name="A2">The second target type</typeparam>
    /// <typeparam name="A3">The third interior type</typeparam>
    /// <typeparam name="T">The path's target type</typeparam>
    public interface Path<S,A1,A2,A3,T> : Path
    {
        /// <summary>
        /// The first segment of the path
        /// </summary>
        Arrow<S,A1> head {get;}

        /// <summary>
        /// The path's interior segments
        /// </summary>
        Path<A1,A2,A3> center {get;}

        /// <summary>
        /// The last segment of the path
        /// </summary>
        /// <value></value>
        Arrow<A3,T> tail {get;}
    }

    public interface Path<S,A1,A2,A3,A4,T> : Path
    {
        /// <summary>
        /// The first segment of the path
        /// </summary>
        Arrow<S,A1> head {get;}

        /// <summary>
        /// The path's interior segments
        /// </summary>
        Path<A1,A2,A3,A4> center {get;}

        /// <summary>
        /// The last segment of the path
        /// </summary>
        /// <value></value>
        Arrow<A4,T> tail {get;}
    }


}