//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zfunc;


    /// <summary>
    /// Defines a file extension
    /// </summary>
    public class FileExtension : PathComponent<FileExtension>
    {
        public static FileExtension Define(string Name)
            => new FileExtension(Name);

        public FileExtension(string Name)
            : base(Name)
        {

        }
    }

}