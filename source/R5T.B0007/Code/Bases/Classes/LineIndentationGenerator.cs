using System;


namespace R5T.B0007
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class LineIndentationGenerator : ILineIndentationGenerator
    {
        #region Static
        
        public static LineIndentationGenerator Instance { get; } = new();

        #endregion
    }
}