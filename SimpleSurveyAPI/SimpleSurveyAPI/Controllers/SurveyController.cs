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
        public string Get(int id)
        {
            if (id == 1)
            {
                return "<span>First</span>";
            }

            if (id == 42)
            {
                return "<span>Hitchickers</span>";
            }

            return "<span>Unknown</span>";
        }
    }
}
