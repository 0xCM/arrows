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

    public interface Formattable
    {
        string format();
        
    }

    public interface Formatter<T>
    {
        string format(T value);
    }

    public interface Formatter<T,O> : Formatter<T>
    {
        string format(T value, O options);
    }


}