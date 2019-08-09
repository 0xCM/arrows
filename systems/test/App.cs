//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Linq;
    using System.Threading;
    using static zfunc;

    public class App : TestApp<App>
    {            
        AgentContext AgentContext;

        Option<ServerComplex> Complex;

        void ManageServerComplex()
        {
            Terminal.Get().SetTerminationHandler(OnTerminate);
            
            cyan($"Starting server complex");
            ServerComplex.Start(AgentContext).ContinueWith(complex => 
                {
                    Complex = complex.Result;
                    magenta("Server complex started");

                });

            var control = AgentControl.FromContext(this);
            control.Configure(AgentContext).ContinueWith(_ => 
            {
                inform($"There are {control.SummaryStats.AgentCount.ToString()} agents in play");
            });

            
            readKey("Press any key to terminate the application");            
        }

        void OnTerminate()
        {
            if(Complex)
            {                          

                Complex.OnSome(c => {
                    cyan($"Shutting down server complex");
                    c.Stop().Wait();
                    magenta($"Server complex shut down complete");                    
                });
            }
        }   

        protected override void RunTests(params string[] filters)
        {
            this.AgentContext = new AgentContext(Random);
            //ManageServerComplex();

            base.RunTests();
        
        }

        public static void Main(params string[] args)
            => Run(args);
    }
}