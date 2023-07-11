//  Copyright 2005-2010 Portland State University, University of Wisconsin
//  Authors:  Srinivas S., Robert M. Scheller

namespace Landis.SpatialModeling
{
    public class BytePixel : SingleBandPixel<byte>
    {
        public BytePixel()
            : base()
        {
        }

        public BytePixel(byte band0)
            : base(band0)
        {
        }
    }
}
