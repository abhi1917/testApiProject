using SampleWebAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebAPI.Controllers
{
    [ApiAuth]
    [LogApi]
    [ApiException]
    public class TestController : ApiController
    {

        public IEnumerable<string> GetTest()
        {
            return new string[] { "test", "sample" };
        }


        public void PostTest([FromBody]string value)
        {
        }
    }
}