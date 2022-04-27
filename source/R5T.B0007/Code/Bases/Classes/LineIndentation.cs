using System;


namespace R5T.B0007
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class LineIndentation : ILineIndentation
    {
        #region Static
        
        public static LineIndentation Instance { get; } = new();

        #endregion
    }
}