// Contributors:
//   James Domingo, Green Code LLC

using System;

namespace Landis.SpatialModeling
{
    public abstract class Pixel
        : IPixel
    {
        private IPixelBand[] bands;

        //---------------------------------------------------------------------

        public int BandCount
        {
            get
            {
                return bands.Length;
            }
        }

        //---------------------------------------------------------------------

        public IPixelBand this[int index]
        {
            get
            {
                return bands[index];
            }
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Sets the pixel's bands.
        /// </summary>
        /// <param name="band0">
        /// The first band.
        /// </param>
        /// <param name="otherBands">
        /// Other optional bands.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// One or more of the bands is null.
        /// </exception>
        protected void SetBands(IPixelBand band0,
                                params IPixelBand[] otherBands)
        {
            if (band0 == null)
                throw new ArgumentNullException("band 0 is null");
            if (otherBands == null)
                //  The method was called as SetBands(band0, null)
                throw new ArgumentNullException("band 1 is null");
            int bandIndex = 0;
            foreach (IPixelBand band in otherBands)
            {
                bandIndex++;
                if (band == null)
                    throw new ArgumentNullException(string.Format("band {0} is null",
                                                                  bandIndex));
            }

            bands = new IPixelBand[1 + otherBands.Length];
            bands[0] = band0;
            otherBands.CopyTo(bands, 1);
        }
    }
}
