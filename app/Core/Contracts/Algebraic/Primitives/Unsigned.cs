//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Class
    {
        public interface Unsigned<T> : TypeClass
        {
            
        }

        public interface Unsigned<H,T> : TypeClass<H>, Unsigned<T>
            where H : Unsigned<H,T>, new()
        {
            
        }
    }

    partial class Struct
    {
        /// <summary>
        /// Characterizes a structural unsigned number
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underling primitive</typeparam>
        public interface Unsigned<S,T> : Structure<S,T>
            where S : Unsigned<S,T>, new()
            where T : new()
        {

        }
    }

}