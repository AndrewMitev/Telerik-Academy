using System;
using System.Drawing;
using System.IO;
using System.Web;

namespace Handler
{
    public class CustomHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            HttpRequest request = context.Request;

            response.ContentType = "image/png";
            var imageAsText = request.Params[0];
            byte[] bytes = Convert.FromBase64String(imageAsText);
            using (Bitmap image = (Bitmap)Image.FromStream(new MemoryStream(bytes)))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.WriteTo(response.OutputStream);
                }
            }
        }
    }
}
