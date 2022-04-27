using System;


namespace R5T.B0007
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Indentation : IIndentation
    {
        #region Static
        
        public static Indentation Instance { get; } = new();

        #endregion
    }
}