using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ZeMShoppingCart.BusinessLogic;
using ZeMShoppingCart.ExceptionManager;
using ZeMShoppingCart.Service.HelperClasses.Filters;
using ZeMShoppingCart.ViewModel;

namespace ZeMShoppingCart.Service.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api")]
    public class MemberController : ApiController
    {
        private readonly IMemberBusinessLogic _memberBusinessLogic;

        public MemberController(IMemberBusinessLogic memberBusinessLogic)
        {
            _memberBusinessLogic = memberBusinessLogic;
        }


        [HttpGet]
        [Route("Member")]
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
                CustomExceptions.WriteExceptionMessageToFile(exception);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                 exception.Message);
            }
        }


        // GET: api/Member/5
        [HttpGet]
        [Route("Member/{id}")]
        public  HttpResponseMessage Get(int id)
        {
            try
            {
                var result = _memberBusinessLogic.GetMemberById(id);
                return Request.CreateResponse(HttpStatusCode.OK, result);

            }
            catch (Exception exception)
            {
                CustomExceptions.WriteExceptionMessageToFile(exception);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    exception.Message);
            }
        }

        // POST: api/Member
         
        [BasicAuthentication]
        [ValidateModelStateFilter]
        [HttpPost]
        [Route("Member")]
        public IHttpActionResult Post([FromBody]MemberViewModel memberViewModel)
        {
            try
            {
                if (memberViewModel == null)
                {
                    return BadRequest();  
                }
             var result =  _memberBusinessLogic.CreateMember(memberViewModel);
                return Ok(result);
            }
            catch (Exception exception)
            {
                CustomExceptions.WriteExceptionMessageToFile(exception);
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
