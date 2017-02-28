using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BTSCodeChallenge.BLL.BLLs;
using BTSCodeChallenge.BLL.ViewModels;

namespace BTSCodeChallenge.API.Controllers
{
    [EnableCors(origins: "http://localhost:58215", headers: "*", methods: "*")]
    public class PersonController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetPerson()
        {
            try
            {
                var person = PersonBLL.GetPerson();

                return Ok(person);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        public IHttpActionResult GetPerson(PersonVm person)
        {
            try
            {
                PersonBLL.SavePerson(person);

                return Ok("Save was successful!");
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
