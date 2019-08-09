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
     public class PrimalFsmSpec<T>
        where T : struct
    {
        public PrimalFsmSpec(string Classifier, T StateCount, T EventCount, T MinEventSampleSize, T MaxEventSampleSize, ulong ReceiptLimit)
        {
            this.Classifier = Classifier;
            this.StateCount = StateCount;
            this.EventCount = EventCount;
            this.MinEventSampleSize = MinEventSampleSize;
            this.MaxEventSampleSize = MaxEventSampleSize;
            this.ReceiptLimit = ReceiptLimit;
            this.StartState = default;
            this.EndState = gmath.dec(StateCount);
        }

        /// <summary>
        /// An identifier that defines a membership class that will be
        /// propagaged to all machines predicated on the specification
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
        public T MinEventSampleSize {get;private set;}

        /// <summary>
        /// The maximum number of events that will be sampled for each state
        /// </summary>
        public T MaxEventSampleSize {get;private set;}
        
        public ulong ReceiptLimit {get;private set;}

        public T StartState {get;private set;}
        
        public T EndState {get;private set;}

        public PrimalFsmSpec<T> WithStateCount(T StateCount)
        {
            this.StateCount = StateCount;
            this.EndState = gmath.dec(StateCount);
            return this;
        }

        public PrimalFsmSpec<T> WithEventCount(T EventCount)
        {
            this.EventCount = EventCount;
            return this;
        }

        public PrimalFsmSpec<T> WithClassifier(string Classifier)
        {
            this.Classifier = Classifier;
            return this;
        }

        public PrimalFsmSpec<T> WithEventSampleLimits(T Min, T Max)
        {
            this.MinEventSampleSize = Min;
            this.MaxEventSampleSize = Max;
            return this;
        }


    }

}
