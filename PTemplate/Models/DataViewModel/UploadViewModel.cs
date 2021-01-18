using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using PTemplate.Models.Enum;

namespace PTemplate.Models.DataViewModel
{
    public class UploadViewModel
    {
        [Required(ErrorMessage = "فایل را ارسال کنید.")]
        //[UploadFileExtensions(".png,.jpg,.jpeg,.gif", ErrorMessage = "Please upload an image file.")]
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }


        [Required(ErrorMessage = "کد فایل ارسال نشده است.")]
        [DataType(DataType.Text)]
        public string Iddatatype { get; set; }

        [Required(ErrorMessage = "کد پست ارسال نشده است.")]
        [DataType(DataType.Text)]
        public string idpost { get; set; }


        [Required(ErrorMessage = "کد فایل ارسال نشده است.")]
        [DataType(DataType.Text)]
        public string description { get; set; }

        [Required(ErrorMessage = "کد فایل ارسال نشده است.")]
 
        public bool isActive { get; set; }

        const int size = 200;
        const int quality = 75;

        public static void ResizeAndSaveImage(Stream stream, string filename)
        {
            using (Image<Rgba32> image = (SixLabors.ImageSharp.Image.Load<Rgba32>(ReadFully(stream))))
            {

                image.Mutate(x => x
                    .Resize(new ResizeOptions
                    {
                        Size = new SixLabors.Primitives.Size(size, size),
                        Mode = ResizeMode.Max
                    })

                 );

                //image.ExifProfile = null;
                //image.Quality = quality;
                image.Save(filename); // Automatic encoder selected based on extension.
            }

        }

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }


        public static  void Image_resize(Stream input_Stream, string output_Image_Path, TypsImgesize typs)

        {
            long quality = 100L;
            int new_Width = 200;
            int new_Height = 200;
            if (typs== TypsImgesize.Thumbnail)
            {
                new_Width = 200;
                new_Height = 200;
            }
            else if (typs == TypsImgesize.banner)
            {
                 new_Width = 545;
                new_Height = 598;
            }
            else if (typs == TypsImgesize.Slider)
            {
                new_Width = 1148;
                new_Height = 400;
            }
            else if (typs == TypsImgesize.Discription)
            {
                new_Width = 545;
                new_Height = 598;
            }
            else if (typs == TypsImgesize.imgepluse)
            {
                new_Width = 500;
                new_Height = 500;
            }
            else if (typs == TypsImgesize.imgepluseSmale)
            {
                new_Width = 350;
                new_Height = 350;
            }
            else if (typs == TypsImgesize.profile)
            {
                new_Width = 128;
                new_Height = 128;
            }


            //---------------< Image_resize() >---------------

            //*Resizes an Image in Asp.Net MVC Core 2

            //*Using Nuget CoreCompat.System.Drawing

            //using System.IO

            //using System.Drawing;             //CoreCompat

            //using System.Drawing.Drawing2D;   //CoreCompat

            //using System.Drawing.Imaging;     //CoreCompat





            Bitmap source_Bitmap = new Bitmap(input_Stream);



            double dblWidth_origial = source_Bitmap.Width;

            double dblHeigth_origial = source_Bitmap.Height;

            double relation_heigth_width = dblHeigth_origial / dblWidth_origial;

          //  int new_Height = (int)(new_Width * relation_heigth_width);
            //long new_Height = (long)(new_Height);



            //< create Empty Drawarea >

            var new_DrawArea = new Bitmap(new_Width, new_Height);

            //</ create Empty Drawarea >



            using (var graphic_of_DrawArea = Graphics.FromImage(new_DrawArea))

            {

                //< setup >

                graphic_of_DrawArea.CompositingQuality = CompositingQuality.HighSpeed;

                graphic_of_DrawArea.InterpolationMode = InterpolationMode.HighQualityBicubic;

                graphic_of_DrawArea.CompositingMode = CompositingMode.SourceCopy;

                //</ setup >



                //< draw into placeholder >

                //*imports the image into the drawarea

                graphic_of_DrawArea.DrawImage(source_Bitmap, 0, 0, new_Width, new_Height);

                //</ draw into placeholder >



                //--< Output as .Jpg >--

                using (var output = System.IO.File.Open(output_Image_Path, FileMode.Create))

                {

                    //< setup jpg >

                    var qualityParamId = Encoder.Quality;

                    var encoderParameters = new EncoderParameters(1);

                    encoderParameters.Param[0] = new EncoderParameter(qualityParamId, quality);

                    //</ setup jpg >



                    //< save Bitmap as Jpg >

                    var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);

                    new_DrawArea.Save(output, codec, encoderParameters);

                    //resized_Bitmap.Dispose();

                    output.Close();

                    //</ save Bitmap as Jpg >

                }

                //--</ Output as .Jpg >--

                graphic_of_DrawArea.Dispose();

            }

            source_Bitmap.Dispose();

            //---------------</ Image_resize() >---------------

        }


        public void siaeimage(int new_Width , int new_Height )
        {

        }

    }
}
