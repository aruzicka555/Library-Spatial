namespace Landis_GeoTiff
{
    public interface IInputRaster<T> : System.IDisposable
        where T : struct
    {
        T BufferPixel { get; }
        T ReadBufferPixel();

        Dimensions Dimensions { get; }
    }
}