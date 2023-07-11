//  Copyright 2005-2010 Portland State University, University of Wisconsin
//  Authors:  Srinivas S., Robert M. Scheller

namespace Landis.SpatialModeling
{
    public class DoublePixel : SingleBandPixel<double>
    {
        public DoublePixel()
            : base()
        {
        }

        public DoublePixel(double band0)
            : base(band0)
        {
        }
    }
}
