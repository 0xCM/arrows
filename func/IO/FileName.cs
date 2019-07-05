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


    public abstract class PathComponent<T>
        where T : PathComponent<T>
    {
        public string Name {get;}

        protected PathComponent(string Name)
            => this.Name = Name;
        
        public override string ToString()
            => Name;
        
        public bool Nonempty
            => nonempty(Name);

    }

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


    /// <summary>
    /// Defines a file name along with the extension in isolation 
    /// and without ascribing additional path content
    /// </summary>
    public class FileName : PathComponent<FileName>
    {        
        public static FileName Timestamped(FileName src)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            var timestamped = src.Rename($"{src.NameBody}-{elapsed}");
            return timestamped;            
        }

        public static FilePath Timestamped(FilePath src)
            => src.RenameFile(Timestamped(src.FileName));
        
        public static FileName Define(string Name)
            => new FileName(Name);
        public static FileName operator + (FileName lhs, FileExtension rhs)
            => FileName.Define($"{lhs.Name}.{rhs.Name}");

        public FileName(string Name)
            : base(Name)
            {

            }

        public Option<FileExtension> Extension
            => Path.HasExtension(Name) 
            ? FileExtension.Define(Path.GetExtension(Name)) 
            : none<FileExtension>();

        public string NameBody 
            => Path.GetFileNameWithoutExtension(Name);
        
        public FileName Rename(string newName)
        {
            var ext = Extension.MapValueOrElse(x =>  x.Name, () => string.Empty);
            var renamed = FileName.Define($"{newName}{ext}");
            return renamed;            
        }
    }
}