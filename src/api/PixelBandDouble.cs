namespace Landis.SpatialModeling
{
	/// <summary>
	/// A PixelBand with a 64-bit floating-point value.
	/// </summary>
	public class PixelBandDouble
		: PixelBand<double, Landis.Utilities.ByteMethods.Double>
	{
		/// <summary>
		/// Initializes a new instance with a default value of 0.
		/// </summary>
		public PixelBandDouble()
			: base()
		{
		}

		//---------------------------------------------------------------------

		/// <summary>
		/// Initializes a new instance with a specific value.
		/// </summary>
		public PixelBandDouble(double initialValue)
			: base(initialValue)
		{
		}
	}
}
