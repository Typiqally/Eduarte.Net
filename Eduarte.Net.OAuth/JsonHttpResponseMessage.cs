using System.Net;
using System.Net.Http;

namespace Eduarte.Net.OAuth
{
	public class JsonHttpResponseMessage<T>
	{
		public JsonHttpResponseMessage(HttpResponseMessage responseMessage, T data)
		{
			StatusCode = responseMessage.StatusCode;
			Data = data;
		}

		public HttpStatusCode StatusCode { get; }

		public T Data { get; }
	}
}