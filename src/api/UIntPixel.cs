//  Copyright 2005-2010 Portland State University, University of Wisconsin
//  Authors:  Srinivas S., Robert M. Scheller

namespace Landis.SpatialModeling
{
    public class UIntPixel : SingleBandPixel<uint>
    {
        public UIntPixel()
            : base()
        {
        }

        public UIntPixel(uint band0)
            : base(band0)
        {
        }
    }
}
