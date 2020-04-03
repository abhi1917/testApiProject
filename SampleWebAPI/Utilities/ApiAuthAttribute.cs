using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace SampleWebAPI.Utilities
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ApiAuthAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            System.Diagnostics.Debug.WriteLine("From: "+actionContext.Request.Headers.UserAgent);
            System.Diagnostics.Debug.WriteLine("AuthToken: " + actionContext.Request.Headers.Authorization.Parameter);
        }
    }
}