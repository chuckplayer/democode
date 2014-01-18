// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGame.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IGame type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BowlingKata1
{
    using System.Collections.Generic;

    /// <summary>
    /// The Game interface.
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Calculates the score for the frame.
        /// </summary>
        /// <param name="frame">
        /// The frame.
        /// </param>
        /// <returns>
        /// Returns the calculated score for a given frame.<see cref="int"/>
        /// </returns>
        int CalculateFrameScore(IFrame frame);

        /// <summary>
        /// The calculate game score.
        /// </summary>
        /// <param name="frames">
        /// The frames.
        /// </param>
        /// <returns>
        /// The calculated score for the game. <see cref="int"/>.
        /// </returns>
        int CalculateGameScore(List<IFrame> frames);
    }
}
