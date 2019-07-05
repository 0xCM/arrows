namespace Z0
{
    using System;

    public class Settings
    {
        /// <summary>
        /// Gets the root development directory where the topmost solution resides
        /// </summary>
        public static string SlnDir 
            => @"J:\dev\projects\z0\"; 

        /// <summary>
        /// Gets the source directory for a specified project
        /// </summary>
        /// <param name="ProjectFolder">The folder in which the project resides</param>
        public static string ProjectDir(string ProjectFolder)
            => SlnDir + ProjectFolder + "\\";
    }

}