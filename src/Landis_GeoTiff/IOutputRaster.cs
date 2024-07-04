using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landis_GeoTiff
{
    public interface IOutputRaster<T> : System.IDisposable
        where T : struct
    {
        T BufferPixel { get; set; }
        void WriteBufferPixel();

        Dimensions Dimensions { get; set; }

        public void SaveAs(string fileName);
    }
}
