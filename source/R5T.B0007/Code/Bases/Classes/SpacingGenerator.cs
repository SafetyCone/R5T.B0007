using System;


namespace R5T.B0007
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SpacingGenerator : ISpacingGenerator
    {
        #region Static
        
        public static SpacingGenerator Instance { get; } = new();

        #endregion
    }
}