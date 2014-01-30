using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleSurveyAPI.Controllers
{
    public class SurveyController : ApiController
    {
        public HttpResponseMessage Get(int id)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

            if (id == 1)
            {
                response.Content = new StringContent("First");
            }
            else if (id == 42)
            {
                response.Content = new StringContent("<span>Hitchickers</span>");
            }
            else
            {
                response.Content = new StringContent("<span>Unknown</span>");            
            }

            return response;
        }
    }
}
