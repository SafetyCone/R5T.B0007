using System;


namespace R5T.B0007
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SpacingOperator : ISpacingOperator
    {
        #region Static
        
        public static SpacingOperator Instance { get; } = new();

        #endregion
    }
}