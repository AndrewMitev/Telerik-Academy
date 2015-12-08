namespace ConsoleWebServer.Framework
{
    using System.Net;

    /// <summary>
    ///  Interface for delivering adequate data. Implemented by ActionResult classes.
    /// </summary>
    public interface IActionResult
    {
        /// <summary>
        ///  Return JSON or object data according to inheritors.
        /// </summary>
        string ContentType { get; }

        /// <summary>
        ///  All inheritors must contain HttpRequest functionallity
        /// </summary>
        HttpRequest Request { get; }

        /// <summary>
        ///  Different status code of responce according to inheritors.
        /// </summary>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        ///  Return a responce according to user input. The responce is either object with data
        /// or JSON string serialized from a given object.
        /// </summary>
        /// <returns>parameter of type HttpResponse</returns>
        HttpResponse GetResponse();

        /// <summary>
        ///  Return different content according to inheritors.
        /// </summary>
        /// <returns></returns>
        string GetContent();
    }
}