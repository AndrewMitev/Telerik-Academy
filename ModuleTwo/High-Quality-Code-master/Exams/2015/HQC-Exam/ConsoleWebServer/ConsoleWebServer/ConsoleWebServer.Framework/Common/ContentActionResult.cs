namespace ConsoleWebServer.Framework
{
    using System;
    using System.Net;

    public class ContentActionResult : ActionResult, IActionResult
    {
        public const string ContentTypeConstant = "text/plain; charset=utf-8";

        public ContentActionResult(HttpRequest request, object model)
            : base(request, model)
        {
        }

        public override string ContentType
        {
            get
            {
                return this.ContentType;
            }
        }

        public override string GetContent()
        {
            return this.Model.ToString();
        }

        public override HttpResponse GetResponse()
        {
            var response = new HttpResponse(this);
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }
}