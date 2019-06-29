//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    public static class Suite
    {
        public static readonly string Version = Assembly.GetExecutingAssembly().AssemblyVersion().ToString(3);
    }


}