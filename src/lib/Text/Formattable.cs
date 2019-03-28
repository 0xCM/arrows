//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections;
    
    partial class Traits
    {

        public interface Formattable
        {
            string format();
            
        }
        public interface Formattable<T>
        {
            string format(T value);
        }

        public interface Formattable<T,O> : Formattable<T>
        {
            string format(T value, O options);
        }

    }

}