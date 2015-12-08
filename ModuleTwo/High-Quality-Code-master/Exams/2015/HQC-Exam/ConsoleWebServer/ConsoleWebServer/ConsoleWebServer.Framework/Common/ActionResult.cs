namespace ConsoleWebServer.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    public abstract class ActionResult : IActionResult
    {
        private readonly object model;

        protected ActionResult(HttpRequest request, object model)
        {
            this.model = model;
            this.Request = request;
            this.ResponseHeaders = new List<KeyValuePair<string, string>>();
        }

        public abstract string ContentType { get; }

        public HttpRequest Request { get; private set; }

        public List<KeyValuePair<string, string>> ResponseHeaders { get; private set; }

        public HttpStatusCode StatusCode
        {
            get
            {
                return HttpStatusCode.OK;
            }
        }

        protected object Model { get; private set; }

        public abstract string GetContent(); 

        public abstract HttpResponse GetResponse();
    }
}
