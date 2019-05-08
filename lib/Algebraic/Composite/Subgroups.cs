//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    
    partial class Operative
    {        


        /// <summary>
        /// Characterizes normal subgroup operations
        /// </summary>
        /// <typeparam name="T">The type over which operations are defined</typeparam>
        public interface INormalSubgroupOps<T> : IGroupOps<T>
            where T : INormalSubgroupOps<T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a coset
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface ICosetOps<T>
            where T : IGroupOps<T>, new()
        {
            /// <summary>
            /// The distinguished group element with which to compose each subgroup element
            /// </summary>
            /// <returns></returns>
            T actor {get;}

            /// <summary>
            /// The subgroup to be acted upon
            /// </summary>
            /// <returns></returns>
            IGroupOps<T> subgroup {get;}

        }


        /// <summary>
        /// Characterizes a coset formed by a left-action
        /// </summary>
        public interface ILeftCosetOps<T> : ICosetOps<T>
            where T : IGroupOps<T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a coset formed by a right-action
        /// </summary>
        public interface IRightCosetOps<T> : ICosetOps<T>
            where T : IGroupOps<T>, new()
        {
            
        }

    }

    partial class Structures
    {
        /// <summary>
        /// Characterizes normal subgroup structure
        /// </summary>
        /// <typeparam name="S">The structural type</typeparam>
        public interface INormalSubgroup<S> : IGroup<S>
            where S : INormalSubgroup<S>, new()
        {

        }

    }

}