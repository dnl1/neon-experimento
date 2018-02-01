using SampleRestfulAPI.Business;
using SampleRestfulAPI.Exceptions;
using SampleRestfulAPI.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace SampleRestfulAPI.Controllers
{
    public class UsersController : BaseController
    {
        private UserBusiness _userBusiness;

        public UsersController()
        {
            _userBusiness = new UserBusiness();
        }

        // GET: User
        [HttpGet]
        public IHttpActionResult Index()
        {
            IHttpActionResult retorno;

            try
            {
                IEnumerable<User> users = _userBusiness.GetAll();
                retorno = Ok(users);
            }
            catch (Exception ex)
            {
                retorno = InternalServerError(ex);
            }

            return retorno;
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult retorno;

            try
            {
                User user = _userBusiness.Get(id);
                retorno = Ok(user);
            }
            catch (Exception ex)
            {
                retorno = InternalServerError(ex);
            }

            return retorno;
        }

        [HttpPost]
        public IHttpActionResult Create([FromBody] User user)
        {
            IHttpActionResult retorno;

            try
            {
                user = _userBusiness.Create(user);
                retorno = Created(user);
            }
            catch (ValidateException ex)
            {
                retorno = UnprocessableEntity(ex.Message);
            }
            catch (Exception ex)
            {
                retorno = InternalServerError(ex);
            }

            return retorno;
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] User user)
        {
            IHttpActionResult retorno;

            try
            {
                user = _userBusiness.Update(user);
                retorno = Ok(user);
            }
            catch (ValidateException ex)
            {
                retorno = UnprocessableEntity(ex.Message);
            }
            catch (Exception ex)
            {
                retorno = InternalServerError(ex);
            }

            return retorno;
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            IHttpActionResult retorno;

            try
            {
                _userBusiness.Delete(id);
                retorno = Ok();
            }
            catch (Exception ex)
            {
                retorno = InternalServerError(ex);
            }

            return retorno;
        }
    }
}