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

    using static zcore;

    public abstract class PathComponent<T>
        where T : PathComponent<T>
    {
        public string Name {get;}

        protected PathComponent(string Name)
            => this.Name = Name;
        
        public override string ToString()
            => Name;

    }

    public class FileExtension : PathComponent<FileExtension>
    {
        public static FileExtension Define(string Name)
            => new FileExtension(Name);

        public FileExtension(string Name)
            : base(Name)
        {

        }
    }

    /// <summary>
    /// Defines a folder name in isolation without ascribing additional path content
    /// </summary>
    public class FolderName : PathComponent<FolderName>
    {
        public static FolderName Define(string Name)
            => new FolderName(Name);
        public FolderName(string Name)
            : base(Name)
        {

        }
    }


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


    /// <summary>
    /// Defines a file name in isolation without ascribing additional path content
    /// </summary>
    public class FileName : PathComponent<FileName>
    {        
        public static FileName Define(string Name)
            => new FileName(Name);
        public static FileName operator + (FileName lhs, FileExtension rhs)
            => FileName.Define(Path.Join(lhs.Name, rhs.Name));

        public FileName(string Name)
            : base(Name){}

        public Option<FileExtension> Extension
            => Path.HasExtension(Name) 
            ? FileExtension.Define(Path.GetExtension(Name)) 
            : none<FileExtension>();
    }

    public class FilePath : PathComponent<FilePath>
    {
        public static FilePath operator + (FilePath lhs, FileName rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));


        public static FilePath operator + (FilePath lhs, FolderName rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));

        public static FilePath operator + (FilePath lhs, FileExtension rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));

        public static FilePath operator + (FilePath lhs, FilePath rhs)
            => new FilePath(Path.Join(lhs.Name, rhs.Name));

        public FilePath Define(string Name)
            => new FilePath(Name);
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
    }
}