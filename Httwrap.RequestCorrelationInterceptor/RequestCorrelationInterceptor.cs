using System;
using System.Net.Http;
using Httwrap.Interception;

namespace Httwrap.RequestCorrelationInterceptor
{
    public class RequestCorrelationInterceptor : IHttpInterceptor
    {
        public void OnRequest(HttpRequestMessage request)
        {
            if (System.Diagnostics.Trace.CorrelationManager.ActivityId != Guid.Empty)
            {
                request.Headers.Add("correlationId", System.Diagnostics.Trace.CorrelationManager.ActivityId.ToString());
            }
        }

        public void OnResponse(HttpRequestMessage request, HttpResponseMessage response)
        {
        }
    }
}