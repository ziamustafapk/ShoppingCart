using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZeMShoppingCart.BusinessLogic;
using ZeMShoppingCart.Service.HelperClasses.Filters;
using ZeMShoppingCart.ViewModel;

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
        [Route("api/Member")]
        public IHttpActionResult Post([FromBody]MemberViewModel memberViewModel)
        {
            try
            {
                if (memberViewModel == null)
                {
                    return BadRequest();
                }
               

                
                return Ok(memberViewModel);
            }
            catch (Exception exception)
            {
                return InternalServerError(exception);
            }
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
