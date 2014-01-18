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
        /// Records the result of a try, or throw.
        /// </summary>
        /// <param name="result">
        /// The number of pins knocked down in a single try.
        /// </param>
        void RecordATry(int result);
    }
}
