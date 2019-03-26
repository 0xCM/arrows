//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static zcore;

    public interface Category
    {
        
    }

    /// <summary>
    /// Characterizes a category C
    /// </summary>
    /// <typeparam name="C">The category type</typeparam>
    public interface Category<C> : Category
    {

    }

    public interface Obj
    {

    }

    /// <summary>
    /// Characterizes an object in a category C
    /// </summary>
    /// <typeparam name="C">The type of the defining category</typeparam>
    public interface Obj<C> : Obj
        where C : Category
    {

    }

    /// <summary>
    /// Characterizes an object of type O in an category C
    /// </summary>
    /// <typeparam name="C">The category type</typeparam>
    /// <typeparam name="O">The object type</typeparam>
    public interface Obj<C,O> : Obj<C>
        where C : Category<C>
        
    {
        
    }

    /// <summary>
    /// Characterizes a morphism of type A->B in a category C
    /// </summary>
    /// <typeparam name="C">The category in which the morhphism is defined</typeparam>
    /// <typeparam name="A">The source object type</typeparam>
    /// <typeparam name="B">The target object type</typeparam>
    public interface Mor<C,A,B>
        where C : Category<C>        
    {
        Obj<C,B> apply(Obj<C,A> a);
    }

    /// <summary>
    /// Characterizes the image of a functor of type F:C -> D
    /// </summary>
    /// <typeparam name="C">The source category type</typeparam>
    /// <typeparam name="D">The target category tyep</typeparam>
    /// <typeparam name="F">The functor type</typeparam>
    public interface Img<C,D,F>
        where C : Category<C>
        where D : Category<D>
        where F : Functor<C,D>
    {

    }

    public interface Functor<C,D>
        where C : Category<C>
        where D : Category<D>
    {
        Obj<D,Y> fmap<X,Y>(Obj<C,X> oc);            

    }

    public interface NaturalTransformation<C,D>
        where C : Category<C>
        where D : Category<D>
    {
        Functor<C,D> F {get;}

        Functor<C,D> G {get;}

        //Mor<X,Y,D> component (C x);

    }


}
