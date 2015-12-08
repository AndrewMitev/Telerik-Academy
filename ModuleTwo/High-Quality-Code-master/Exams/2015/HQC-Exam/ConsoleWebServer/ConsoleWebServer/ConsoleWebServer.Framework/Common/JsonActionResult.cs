namespace ConsoleWebServer.Framework
{
    using System;
    using System.Net;
    using Newtonsoft.Json;

    public class JsonActionResult : ActionResult, IActionResult
    {
        private const string ContentTypeConstant = "application/json";

        public JsonActionResult(HttpRequest request, object model)
            : base(request, model)
        {
        }

        public override string ContentType
        {
            get
            {
                return ContentTypeConstant;
            }
        }

        public override string GetContent()
        {
            return JsonConvert.SerializeObject(this.Model);
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