﻿//  Copyright 2005-2010 Portland State University, University of Wisconsin
//  Authors:  Srinivas S., Robert M. Scheller

namespace Landis.SpatialModeling
{
    public class FloatPixel : Pixel
    {
        public Band<float> MapCode = "The numeric code for each raster cell";

        public FloatPixel()
        {
            SetBands(MapCode);
        }
    }
}
