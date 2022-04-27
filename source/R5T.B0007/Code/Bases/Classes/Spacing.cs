using System;


namespace R5T.B0007
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Spacing : ISpacing
    {
        #region Static
        
        public static Spacing Instance { get; } = new();

        #endregion
    }
}