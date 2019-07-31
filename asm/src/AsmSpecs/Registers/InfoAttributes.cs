//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class InfoAttribute : Attribute
    {
        public InfoAttribute(string description, params object[] parameters)
        {
            Description = string.Format(description, parameters);
        }

        public string Description {get;}

        public override string ToString()
            => Description;
    }

}