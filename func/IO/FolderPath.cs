//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections;
    using System.IO;

    using static zfunc;


    /// <summary>
    /// Represents a fully-qualified path to a folder on the local machine
    /// </summary>
    /// <typeparam name="FolderPath"></typeparam>
    public class FolderPath : PathComponent<FolderPath>
    {
        public static FolderPath operator + (FolderPath lhs, FolderName rhs)
            => FolderPath.Define(Path.Join(lhs.Name, rhs.Name));

        public static FilePath operator + (FolderPath lhs, FileName rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));

        public static FolderPath Define(string Name)
            => new FolderPath(Name);
        public FolderPath(string Name)
            : base(Name)
        {

        }
    }

}