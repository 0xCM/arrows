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
    /// Represents a fully-qualified path to a file on the local machine
    /// </summary>
    public class FilePath : PathComponent<FilePath>
    {
        public static readonly FilePath Empty = Define(string.Empty);

        public static FilePath Define(string Name)
            => new FilePath(Name);

        public static FilePath operator + (FilePath lhs, FileName rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));

        public static FilePath operator + (FilePath lhs, FolderName rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));

        public static FilePath operator + (FilePath lhs, FileExtension rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));

        public static FilePath operator + (FilePath lhs, FilePath rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));

        public FilePath(string Name)
            : base(Name)
        {

        }

        public FileName FileName
            => FileName.Define(Path.GetFileName(Name));

        public FolderPath FolderPath
            => FolderPath.Define(Path.GetDirectoryName(Name));

        public FolderName FolderName
            => FolderName.Define(Directory.GetParent(FolderPath.Name).Name);

        public Option<FileExtension> Extension
            => FileName.Extension;
        
        public bool Rooted
            => Path.IsPathRooted(Name);
        
        public FilePath RenameFile(FileName src)
            => FolderPath + src;
    
        
    }

}