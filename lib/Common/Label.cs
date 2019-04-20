//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Encapsulates a finite sequence of unicode characters to convey
    /// semantic/descriptive information
    /// </summary>
    public readonly struct Label
    {
        public static readonly Label Empty = new Label(string.Empty);
        
        public static implicit operator Label(string name)
            => new Label(name);

        public static implicit operator string(Label l)
            => l.name;

        /// <summary>
        /// The label name
        /// </summary>
        /// <value></value>
        public string name {get;}

        /// <summary>
        /// Returns true if the label is the empty label
        /// </summary>
        /// <returns></returns>
        public bool empty() => name == string.Empty;

        public Label(string name)
            => this.name = name ?? string.Empty;

        public override string ToString()
            => name;
    }

}
