namespace Landis.SpatialModeling
{
	/// <summary>
	/// A PixelBand with a 32-bit floating-point value.
	/// </summary>
	public class PixelBandFloat
		: PixelBand<float, Landis.Utilities.ByteMethods.Float>
	{
		/// <summary>
		/// Initializes a new instance with a default value of 0.
		/// </summary>
		public PixelBandFloat()
			: base()
		{
		}

		//---------------------------------------------------------------------

		/// <summary>
		/// Initializes a new instance with a specific value.
		/// </summary>
		public PixelBandFloat(float initialValue)
			: base(initialValue)
		{
		}
	}
}
