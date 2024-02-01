using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

public class CRMAppApiKeyAuthenticationAttribute : ActionFilterAttribute
{
    private const string InvalidToken = "Invalid Authorization-Token";
    private const string MissingToken = "Missing Authorization-Token";

    public override void OnActionExecuting(HttpActionContext actionContext)
    {
        IEnumerable<string> apiKeyHeaderValues = null;

        if (actionContext.Request.Headers.TryGetValues("X-CRMAppApiKey", out apiKeyHeaderValues))
        {
            string[] apiKeyHeaderValue = apiKeyHeaderValues.First().Split(':');

            if (apiKeyHeaderValue.Length == 2)
            {
                var appID = apiKeyHeaderValue[0];
                var appKey = apiKeyHeaderValue[1];

                if (IsValidCredentials(appID, appKey))
                {
                    var userNameClaim = new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Name, appID);
                    var identity = new System.Security.Claims.ClaimsIdentity(new[] { userNameClaim }, "CRMAppApiKey");
                    var principal = new System.Security.Claims.ClaimsPrincipal(identity);
                    Thread.CurrentPrincipal = principal;

                    if (HttpContext.Current != null)
                    {
                        HttpContext.Current.User = principal;
                    }

                    base.OnActionExecuting(actionContext);
                    return;
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, InvalidToken);
                    return;
                }
            }
        }

        actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, MissingToken);
    }

    private bool IsValidCredentials(string appID, string appKey)
    {
        return appID.Equals("ApisCRMX123") && appKey.Equals("0887647826");
    }
}
