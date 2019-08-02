//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Concurrent;
    using System.Collections.Generic;


    public abstract class AppService : IAppService
    {
        protected AppService(IContext AppContext)
        {
            this.AppContext = AppContext;
        }

        protected IContext AppContext {get;}

        protected virtual void OnConfigure(dynamic config) {}

        public virtual void Dispose() {}

        public virtual async Task Configure(dynamic config)
        {
            await Task.Factory.StartNew(() => {});
        }
    }

    public abstract class AppService<TContract,TConfig> : AppService, IAppService<TContract,TConfig>
        where TContract : IAppService
    {
        protected AppService(IContext AppContext)
            : base(AppContext)
        {

        }

        public event Action<TConfig> Configured;


        protected abstract Task Configure(TConfig config);

        async Task IAppService<TConfig>.Configure(TConfig config)
        {
            await Configure(config);
            OnConfigured(config);
        }

        void OnConfigured(TConfig config)
        {
            Configured?.BeginInvoke(config, new AsyncCallback(x => {}), this);
        }

        public override sealed async Task Configure(dynamic config)
        {
            await Configure((TConfig)config);
        }
    }
}