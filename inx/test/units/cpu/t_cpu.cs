//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class t_cpu<T> : UnitTest<T>
        where T : t_cpu<T>, new()
    {

        protected Cpu cpu;

        protected t_cpu()
        {
            cpu = Cpu.Init();
        }
    }

}