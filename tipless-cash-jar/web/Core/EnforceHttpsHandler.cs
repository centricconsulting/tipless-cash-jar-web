using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace tiplessCashJar.web.Core
{
    public class EnforceHttpsHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            object httpContextBaseObject;
            if (request.Properties.TryGetValue("MS_HttpContext", out httpContextBaseObject))
            {
                var httpContextBase = httpContextBaseObject as HttpContextBase;

                if (httpContextBase != null && httpContextBase.Request.IsLocal)
                {
                    return base.SendAsync(request, cancellationToken);
                }
            }
            if (request.RequestUri.Scheme != Uri.UriSchemeHttps)
            {
                return Task<HttpResponseMessage>.Factory.StartNew(
                    () =>
                    {
                        var response = new HttpResponseMessage(HttpStatusCode.Forbidden)
                        {
                            Content = new StringContent("HTTPS Required")
                        };
                        return response;
                    });
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}