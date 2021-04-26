using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware
{
    public class MyMiddleware
    {
        private RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            
            var userAgent = context.Request.Headers["User-Agent"].ToString();

            if (userAgent.Contains("Edge") || userAgent.Contains("Edg/") || userAgent.Contains("Trident/")) // Edge, EdgeChromium i IE
            {
                return context.Response.WriteAsync("Przegladarka nie jest obslugiwana");
            }
            else return _next(context);
        }
    }
    }

