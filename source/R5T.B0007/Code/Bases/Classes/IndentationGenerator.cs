using System;


namespace R5T.B0007
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class IndentationGenerator : IIndentationGenerator
    {
        #region Static
        
        public static IndentationGenerator Instance { get; } = new();

        #endregion
    }
}