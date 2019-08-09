//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;


    /// <summary>
    /// Defines common messages that are issued during setup/execution
    /// </summary>
    static class FsmMessages
    {
        public static AppMsg Transition<S>(string machine, S s1, S s2)
            => appMsg($"{machine} Transitioned {s1} -> {s2}", SeverityLevel.HiliteCL);

        public static AppMsg Completed(string machine, FsmStats stats, bool asPlanned)
            => appMsg($"{machine} executed for {stats.Runtime.Ms} ms and completed" 
            + (asPlanned ? $" as planned after receiving {stats.ReceiptCount} events and experiencing {stats.TransitionCount} transitions" : " abnormally"), 
                SeverityLevel.HiliteBL);
        
        public static AppMsg Receipt<E>(string machine, E input, ulong receipts)
            => appMsg($"{machine} received event {input.ToString().PadLeft(6)} | Total Receipts: {receipts}", SeverityLevel.Babble);

        public static AppMsg Error(string machine, Exception error)
            => errorMsg($"{machine} encountered an error: {error}");

        public static AppMsg ReceiptAfterFinish(string machine)
            => appMsg($"{machine} continuing to receive input after finished has been signaled", SeverityLevel.Warning);

        public static AppMsg ReceiptBeforeStart(string machine)
            => appMsg($"{machine} received input before start", SeverityLevel.Warning);

    }


}