using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Framework.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        public IEnumerable<T> FindServices<T>()
        {
            return HttpContext.RequestServices.GetServices<T>();
        }

        public T FindService<T>()
        {
            return HttpContext.RequestServices.GetService<T>();
        }

        protected virtual IActionResult InvokeHttp404()
        {
            Response.StatusCode = 404;
            return new EmptyResult();
        }
    }
}
