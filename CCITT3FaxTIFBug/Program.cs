namespace CCITT3FaxTIFBug
{
    using System.Drawing;
    using System.Drawing.Imaging;

    class Program
    {
        static void Main(string[] args)
        {
            var codecInfo = GetEncoder(ImageFormat.Tiff);
            var encoderParameters = GetEncoderParameters();
            var bitmap = new Bitmap("pattern.png");
            bitmap.Save("result.tif", codecInfo, encoderParameters);
        }

        private static EncoderParameters GetEncoderParameters()
        {
            var encoderParameters = new EncoderParameters(1);
            var encoderParameter = new EncoderParameter(Encoder.Compression, (long) EncoderValue.CompressionCCITT3);
            encoderParameters.Param[0] = encoderParameter;
            return encoderParameters;
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}