using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIServices.Controllers
{
    public class VersionController : ApiController
    {
        public string Get()
        {

            return "Current Version: Version 1.1" +
                "<br />  Change Log:" +
                "<br /> <br /> Version 1 -   Added Incoming Call API (api/incoming). The API calls a view (Get_IncomingCall) from the Database [Gabriel_Blacklist] that brings back the Incoming Calls Data. " +
                "<br /> <br /> Version 1.1 - Added Law Classification API (api/Legal or api/Legal?Jurisdiction=state). This API returns the laws associated with a state or federal based on the user request.";




        }
    }
}
