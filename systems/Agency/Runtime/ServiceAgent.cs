//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public abstract class ServiceAgent : IServiceAgent
    {
        protected ServiceAgent(AgentContext Context, AgentIdentity Identity)
        {
            this.ServerId = Identity.ServerId;
            this.AgentId = Identity.AgentId;
            this.Context = Context;
            Context.Register(this);
            this.State = AgentState.Created;
        }

        AgentState _State;

        /// <summary>
        /// Identifies the server to which the agent belongs
        /// </summary>
        public uint ServerId {get;}

        /// <summary>
        /// Identifies the agent relative to the server
        /// </summary>
        /// <remarks>
        /// There are three special cases to note: 
        /// 1. The server itself is a service agent and will always be assigned and Id of 0
        /// 2. The server process, which more or less serves the same role as the Windows SCM,
        /// is always assigned an agent id of 1
        /// 3. The server complex, which serves as the bounding box for synthetic servers, agents,
        /// etc, is also a service agent. It will be assigned UInt32.MaxValue which will be considered
        /// an invalid id for any other agent
        /// </remarks>
        public uint AgentId {get;}

        public bool IsServer
            => AgentId == 0;
        
        public bool IsServerProcess
            => AgentId == 1;

        public bool IsComplex
            => AgentId == UInt32.MaxValue;

            
        /// <summary>
        /// Specifies the current agent status
        /// </summary>
        public AgentState State 
        {
            get => _State;
            
            protected set
            {
                if(_State == value)
                    return;

                var transition = new AgentTransition((ServerId,AgentId), 0ul, _State, value);
                _State = value;

                SystemEventWriter.Log.AgentTransitioned(transition);
                StateChanged?.BeginInvoke(in transition, new AsyncCallback(x =>{}), this);
            }
        }

        protected AgentContext Context {get;}

        public event OnAgentTransition StateChanged;

        void DoRun()
        {
            State = AgentState.Running;
            OnRun();
        }

        void DoStop()
        {
            State = AgentState.Stopping;
            OnStop();
            State = AgentState.Stopped;
        }

        void DoStart()
        {
            if(State == AgentState.Running)
                return;

            State = AgentState.Starting;
            OnStart();
            State = AgentState.Started;
            DoRun();
        }

        void DoTerminate()
        {            
            if(State == AgentState.Running)
                Stop().Wait();

            State = AgentState.Terminating;
            OnTerminate();
            State = AgentState.Terminated;
        }

        void DoConfigure(dynamic config)
        {
            if(State == AgentState.Created || State == AgentState.Stopped)
            {
                State = AgentState.Configuring;
                OnConfigure(config);
                State = AgentState.Configured;
            }
        }

        /// <summary>
        /// Terminates the agent,releasing any captured resources
        /// </summary>
        public async Task Terminate()
            => await Task.Factory.StartNew(DoTerminate);

        /// <summary>
        /// Configures the agent prior to a run
        /// </summary>
        /// <param name="config">The agent-specific configuration data</param>
        public async Task Configure(dynamic config)
             => await Task.Factory.StartNew(() => DoConfigure(config));

        /// <summary>
        /// Starts the agent from a running state
        /// </summary>
        public async Task Start()
            => await Task.Factory.StartNew(DoStart);   

        /// <summary>
        /// Starts the agent from a stopped state
        /// </summary>
        public async Task Stop()
            => await Task.Factory.StartNew(DoStop);

        /// <summary>
        /// Terminates the agent
        /// </summary>
        public virtual void Dispose() 
            => Terminate().Wait();            

        protected virtual void OnConfigure(dynamic config) {}

        protected virtual void OnRun() {}

        protected virtual void OnStop() {}

        /// <summary>
        /// Overridden to perform service-specific initialization for startup
        /// </summary>
        protected virtual void OnStart(){}

        /// <summary>
        /// Overridden to perform service-specific disposal/cleanup
        /// </summary>
        protected virtual void OnTerminate(){}

    }

    /// <summary>
    /// Defines an agent with a type-specific configuration
    /// </summary>
    /// <typeparam name="C"></typeparam>
    public abstract class ServiceAgent<C> : ServiceAgent, IServiceAgent<C>
    {
        protected ServiceAgent(AgentContext Context, AgentIdentity Identity)
            : base(Context, Identity)
        {

        }
        
        protected abstract Task Configure(C config);

        async Task IAppService<C>.Configure(C config)
        {
            await Configure(config);
            OnConfigured(config);
        }

        void OnConfigured(C config)
        {
            Configured?.BeginInvoke(config, new AsyncCallback(x => {}), this);
        }

        public event Action<C> Configured;

        protected override sealed void OnConfigure(dynamic config)
            => (this as IServiceAgent<C>).Configure((C)config);
    }

}