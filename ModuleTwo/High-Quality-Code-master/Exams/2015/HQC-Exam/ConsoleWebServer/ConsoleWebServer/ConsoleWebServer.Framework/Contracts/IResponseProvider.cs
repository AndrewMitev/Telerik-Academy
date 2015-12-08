namespace ConsoleWebServer.Framework
{
    /// <summary>
    ///  Interface for the ResponseProvider.
    /// </summary>
    public interface IResponseProvider
    {
        /// <summary>
        ///  Method required for the processing of the request.
        /// </summary>
        /// <param name="requestAsString">request in the form of string</param>
        /// <returns>HttpResponse object</returns>
        HttpResponse GetResponse(string requestAsString);
    }
}