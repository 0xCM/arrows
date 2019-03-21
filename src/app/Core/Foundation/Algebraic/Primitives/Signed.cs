//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    partial class Class
    {    
        public interface Signed<T> : TypeClass
        {

        }

        public interface Signed<H,T> : TypeClass<H>, Signed<T>
            where H : Signed<H,T>, new()
        {


        }

    }

    partial class Struct
    {
        /// <summary>
        /// Characterizes a structure that carries a sign
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underling primitive</typeparam>
        public interface Signed<S,T> : Structure<S,T>
            where S : Signed<S,T>, new()
            where T : new()
        {
        }


    }


}