﻿//  Copyright 2005-2010 Portland State University, University of Wisconsin
//  Authors:  Srinivas S., Robert M. Scheller

namespace Landis.SpatialModeling
{
    public class ShortPixel : Pixel
    {
        public Band<short> MapCode = "The numeric code for each raster cell";

        public ShortPixel()
        {
            SetBands(MapCode);
        }
    }
}
