//  Copyright 2005-2010 Portland State University, University of Wisconsin
//  Authors:  Srinivas S., Robert M. Scheller

namespace Landis.SpatialModeling
{
    public class UShortPixel : Pixel
    {
        public Band<ushort> MapCode = "The numeric code for each raster cell";

        public UShortPixel()
        {
            SetBands(MapCode);
        }
    }
}
