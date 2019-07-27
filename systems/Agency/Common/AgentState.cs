//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Pow2;

    /// <summary>
    /// Defines the states in the agent lifecycle
    /// </summary>
    /// <remarks>
    /// The agent lifecycle goes as follows:
    /// 1. New/activate/etc instantiates the ageent which leaves it in a Created state
    /// 2. If configuration data is supplied as part of instantiation, then the agent will
    /// transition to the Configured state automatically
    /// 3. If not configured during activation the agent's Configuration operation must be
    /// invoked to leave the agent in the Configured state. 
    /// 4. Once in a configured state, the agent's Start operation can be invoked and, 
    /// assuming success, the transitions sequence is as follows:
    /// Starting -> Started -> Running. If a failure occurs preventing the agent from
    /// attaining the Running state, the transition sequence will follow
    /// Terminating -> Terminated -> Error
    /// 5. From the running state, either the agent or an external part, may transition to
    /// through Stopping -> Stopped sequence.
    /// </remarks>
    public enum AgentState : short
    {
        Created = T00,

        Configuring = T01,
        
        Configured = T02,
        
        Starting = T03,
        
        Started  = T04,

        Running = T05,

        Stopping = T06,

        Stopped = T07,

        Terminating = T08,

        Terminated = T09,

        Error = -1

    }


}