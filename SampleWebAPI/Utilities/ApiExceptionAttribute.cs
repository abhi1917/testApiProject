using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace SampleWebAPI.Utilities
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ApiExceptionAttribute:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            System.Diagnostics.Debug.WriteLine("Exception " + actionExecutedContext.Exception.Message);
        }
    }
}