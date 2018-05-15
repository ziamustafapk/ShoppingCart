using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ZeMShoppingCart.BusinessLogic;
using ZeMShoppingCart.Service.HelperClasses.Filters;

namespace ZeMShoppingCart.Service.Controllers
{
   // [EnableCors("*", "*", "*")]
    public class MemberController : ApiController
    {
        private readonly IMemberBusinessLogic _memberBusinessLogic;

        public MemberController(IMemberBusinessLogic memberBusinessLogic)
        {
            _memberBusinessLogic = memberBusinessLogic;
        }

        // GET: api/Member
        public HttpResponseMessage Get()
        {
            try
            {

                var result = _memberBusinessLogic.GetAllMembers();
                return Request.CreateResponse(HttpStatusCode.OK, result);

            }
            catch (Exception exception)
            {

                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                 exception.Message);
            }
        }

        [Route("api/Member/Email")]
        public HttpResponseMessage Emails()
        {
            try
            {

                var result = _memberBusinessLogic.GetAllMembersWithEmails();
                return Request.CreateResponse(HttpStatusCode.OK, result);

            }
            catch (Exception exception)
            {

                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    exception.Message);
            }
        }

        // GET: api/Member/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Member
        [ValidateModelStateFilter]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Member/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Member/5
        public void Delete(int id)
        {
        }
    }
}
