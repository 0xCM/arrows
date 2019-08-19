//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    /// <summary>
    /// Characterizes a parser
    /// </summary>
    /// <typeparam name="T">The type of value the parser can parse</typeparam>
    public interface IParser<T>
    {
        /// <summary>
        /// Attempts to parse a string to hydrate the target type; if unsuccessful,
        /// returns none
        /// </summary>
        /// <param name="src">The source text</param>
        Option<T> TryParse(string src);


        /// <summary>
        /// Parses string to hydrate the target type, if possible; otherwise, raises an error
        /// </summary>
        /// <param name="src">The source text</param>
        T Parse(string src);
    }



}