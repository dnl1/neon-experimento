using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace SampleRestfulAPI.Controllers
{
    public abstract class BaseController:ApiController
    {
        protected IHttpActionResult Created<T>(T content)
        {
            return base.Created("api", content);
        }

        protected IHttpActionResult UnprocessableEntity(string message)
        {
            ResponseMessageResult response = new ResponseMessageResult(
                Request.CreateErrorResponse(
                    (HttpStatusCode)422,
                    new HttpError(message)
                )
            );

            return response;
        }
    }
}