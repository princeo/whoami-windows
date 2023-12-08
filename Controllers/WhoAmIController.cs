using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace app.Controllers
{
    [Route("")]
    public class WhoAmIController : Controller
    {
        [HttpGet]
        public string Get()
        {
            StringBuilder sb = new StringBuilder();

            var host = Environment.GetEnvironmentVariable("COMPUTERNAME");
            sb.AppendLine("I am " + host);

            foreach (KeyValuePair<string, StringValues> pair in Request.Headers)
            {
                sb.Append(pair.Key);
                sb.Append(" : ");
                sb.AppendLine($"{pair.Value}");
            }
            return  sb.ToString();
        }
    }
}
