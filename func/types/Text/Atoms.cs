//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    /// <summary>
    /// Defines an atom sequence container
    /// </summary>
    public readonly struct Atoms : ISeq<Atoms, Atom>
    {
        public static Atoms FromType<T>()
            => Contain(
                type<AsciSym>().Literals().Values<string>()
                .Union(type<AsciSym>().Literals().Values<char>().Select(x => x.ToString()))                  
                .Select(Atom.Define));
        
        public static Atoms Contain(IEnumerable<Atom> src)
            => new Atoms(src);

        public static Atoms Many(params Atom[] src)
            => new Atoms(src);

        public static Atoms operator + (Atoms lhs, Atoms rhs)
            => lhs.Concat(rhs);
                
        public Atoms(IEnumerable<Atom> src)
            => Content = src;
        
        public IEnumerable<Atom> Content {get;}

        public Atoms Concat(Atoms rhs)
            => Contain(Content.Concat(rhs.Content));
    }

}