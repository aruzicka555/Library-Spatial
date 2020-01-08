namespace Landis.SpatialModeling
{
	/// <summary>
	/// A PixelBand with a signed 16-bit integer value.
	/// </summary>
	public class PixelBandShort
		: PixelBand<short, Landis.Utilities.ByteMethods.Short>
	{
		/// <summary>
		/// Initializes a new instance with a default value of 0.
		/// </summary>
		public PixelBandShort()
			: base()
		{
		}

		//---------------------------------------------------------------------

		/// <summary>
		/// Initializes a new instance with a specific value.
		/// </summary>
		public PixelBandShort(short initialValue)
			: base(initialValue)
		{
		}
	}
}
