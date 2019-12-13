using Landis.RasterIO;
using Landis.SpatialModeling;

namespace Landis.Raster.Erdas74
{
    /// <summary>
    /// Driver for ERDAS 7.4 version rasters (.gis and .lan)
    /// </summary>
    public class ErdasDriver : IDriver
    {
        public ErdasDriver()
        {
            this.Formats = new string[] { ".gis", ".lan" };
        }

        /// <summary>
		/// The list of raster formats that this driver recognizes.  A format
		/// is denoted by a filename extension, e.g., ".xyx".
		/// </summary>
		public string[] Formats
        {
            get;
            private set;
        }

        /// <summary>
        ///         
        /// </summary>
        public IInputRaster<T> OpenRaster<T>(string path)
            where T : Pixel, new()
        {
            // open image file for reading
            ErdasImageFile image = new ErdasImageFile(path, RWFlag.Read);

            // construct an InputRaster using that
            return new ErdasInputRaster<T>(image, path);
        }
        
        /// <summary>
        ///         
        /// </summary>
        public IOutputRaster<T> CreateRaster<T>(string path,
                                            Dimensions dimensions,
                                            IMetadata metadata)
            where T : Pixel, new()
        {
            // extract necessary parameters from pixel for image creation
            T desiredLayout = new T();
            
            int bandCount = desiredLayout.BandCount;

            System.TypeCode bandType = desiredLayout[0].TypeCode;
            
            // open image file for writing
            ErdasImageFile image
              = new
                ErdasImageFile(path,dimensions,bandCount,bandType,metadata);
                
            // construct an OutputRaster from that
            return new ErdasOutputRaster<T>(image, path, dimensions, metadata);
        }
    }
}
