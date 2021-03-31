using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PhoneService.MiddleWare
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;
        public SimpleMiddleware(RequestDelegate next)//что вызвать дальше
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context) //тело
        {
            Console.WriteLine("Start");
            await _next(context);
            Console.WriteLine("stop");
        }

    }
}
