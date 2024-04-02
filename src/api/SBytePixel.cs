//  Copyright 2005-2010 Portland State University, University of Wisconsin
//  Authors:  Srinivas S., Robert M. Scheller

namespace Landis.SpatialModeling
{
    public class SBytePixel : Pixel
    {
        public Band<sbyte> MapCode = "The numeric code for each raster cell";

        public SBytePixel()
        {
            SetBands(MapCode);
        }
    }
}
