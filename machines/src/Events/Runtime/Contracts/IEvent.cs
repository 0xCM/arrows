//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    /// <summary>
    /// Bears witness to an occurence of something of identifiable interest 
    /// at a unique point in spacetime. The (Location,Timestamp,EventKind) triplet
    /// confers upon the event a logical identity that identifies it across all spacetime.
    /// The implicit invariant that this construct confers upon an event source, which has
    /// a fixed location, is that the source many not produce two events of the same kind
    /// at the same moment in time, relative to timestamp resolution
    /// </summary>
    public interface IEvent
    {
        /// <summary>
        /// Specifies an event classifer that can be used to agregate/distinguish 
        /// sorts of events
        /// </summary>
        /// <remarks>
        /// Note that the intent is not to provide a means of payload type classification
        /// The kind and payload are orthogonal from the abstraction POV, but may
        /// indeed be related at the implementation level.
        /// </remarks>
        ulong EventKind {get;}

        /// <summary>
        /// Identifies the server that originated the event
        /// </summary>
        uint ServerId {get;}

        /// <summary>
        /// Identifies the server-owned agent that originated the event
        /// </summary>
        uint AgentId {get;}
        
        /// <summary>
        /// A value that uniquely identifies the logical event source, predicated
        /// on server and agent identity
        /// </summary>
        ulong LocationId {get;}

        /// <summary>
        /// The time of occurrence, expressed as number of elapsed units
        /// from some fixed point in time
        /// </summary>
        ulong Timestamp {get;}

    }

    /// <summary>
    /// Bears witness to an occurence of something of interest 
    /// at unique point in spacetime along with a data payload
    /// that describes what occurred
    /// </summary>
    public interface IEvent<T> : IEvent
    {
        T Payload {get;}
    
    }
}