// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFrame.cs" company="">
//   
// </copyright>
// <summary>
//   The Frame interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BowlingKata1
{
    /// <summary>
    /// The Frame interface.
    /// </summary>
    public interface IFrame
    {
        /// <summary>
        /// Takes a turn.
        /// </summary>
        /// <param name="frame">
        /// The frame that contains the throw.
        /// </param>
        /// <returns>
        /// Returns the result of the throw<see cref="int"/>.
        /// </returns>
        int TakeTurn(IFrame frame);
    }
}
