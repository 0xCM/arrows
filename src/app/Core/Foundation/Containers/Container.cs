namespace Core
{
    using System;
    using System.Collections.Generic;

    public interface Container
    {
        
    }

    public interface Container<T> : Container
    {
        IEnumerable<T> content {get;}
    }



}