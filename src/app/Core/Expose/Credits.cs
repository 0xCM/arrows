//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using Core;
    using static Credit;

    /// <summary>
    /// Defines the the bibliography for this work
    /// </summary>
    public static class BibEntries
    {

        public static readonly Resource Y1999ABC = Resource.define(1999,"ABC","The ABC's", "Smith");
            
    }

    public static class BibKeys
    {
        public const string Y1999ABC = nameof(BibEntries.Y1999ABC);
    }
}
