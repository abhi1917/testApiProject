using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace SampleWebAPI.Utilities
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LogApiAttribute:ActionFilterAttribute
    {

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            System.Diagnostics.Debug.WriteLine("Request "+actionContext.Request.RequestUri+" begins at "+ DateTime.Now);
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            System.Diagnostics.Debug.WriteLine("Request " + actionExecutedContext.Request.RequestUri + " ends at " + DateTime.Now);
        }
    }
}