//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Linq;
    using System.Threading;
    using System.Collections.Generic;
 
    /// <summary>
    /// Specifies a state machine via scalar values
    /// </summary>
    /// <typeparam name="T">A scalar type of sufficient size to accomodate specified characteristics</typeparam>
     public class PrimalFsmSpec<T>
        where T : unmanaged
    {
        public PrimalFsmSpec(string classifier, T states, T events, T minSamples, T maxSamples, ulong maxReceipts)
        {
            this.Classifier = classifier;
            this.StateCount = states;
            this.EventCount = events;
            this.MinSampleSize = minSamples;
            this.MaxSampleSize = maxSamples;
            this.ReceiptLimit = maxReceipts;
            this.StartState = default;
            this.EndState = gmath.dec(states);
        }

        /// <summary>
        /// An identifier that defines a membership class that is propagaged to all machines predicated on the specification
        /// </summary>
        public string Classifier {get; private set;}

        /// <summary>
        /// The number of states the machine will support
        /// </summary>
        public T StateCount {get;private set;}

        /// <summary>
        /// The number of events the machine will recognize
        /// </summary>
        public T EventCount {get;private set;}

        /// <summary>
        /// The minimum number of events that will be sampled for each state
        /// </summary>
        public T MinSampleSize {get;private set;}

        /// <summary>
        /// The maximum number of events that will be sampled for each state
        /// </summary>
        public T MaxSampleSize {get;private set;}
        
        /// <summary>
        /// The maximum number of events that the machine will accept
        /// </summary>
        public ulong ReceiptLimit {get;private set;}

        /// <summary>
        /// The initial state as determined by the default value of the primal type, i.e. StartState = default
        /// </summary>
        public T StartState {get;private set;}
        
        /// <summary>
        /// The final state as determined by the state count, i.e. EndState := StateCount - 1
        /// </summary>
        public T EndState {get;private set;}

        /// <summary>
        /// Modifies the state count in-place
        /// </summary>
        /// <param name="count">The new state count</param>
        public PrimalFsmSpec<T> WithStateCount(T count)
        {
            this.StateCount = count;
            this.EndState = gmath.dec(count);
            return this;
        }

        /// <summary>
        /// Modifies the event count in-place
        /// </summary>
        /// <param name="count">The new state count</param>
        public PrimalFsmSpec<T> WithEventCount(T count)
        {
            this.EventCount = count;
            return this;
        }

        /// <summary>
        /// Modifies the classifier in-place
        /// </summary>
        /// <param name="count">The new state count</param>
        public PrimalFsmSpec<T> WithClassifier(string classifier)
        {
            this.Classifier = classifier;
            return this;
        }

        /// <summary>
        /// Modifies the min and max event sample sizes in-place
        /// </summary>
        /// <param name="Min">The min event sample size</param>
        /// <param name="Max">The max event sample size</param>
        public PrimalFsmSpec<T> WithSampleLimits(T Min, T Max)
        {
            this.MinSampleSize = Min;
            this.MaxSampleSize = Max;
            return this;
        }
    }
}
