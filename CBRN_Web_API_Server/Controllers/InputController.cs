using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CBRN_Project.MVVM.Models;
using CBRN_Web_API_Server.Models;

namespace CBRN_Web_API_Server.Controllers
{
    public class InputController : ApiController
    {

        public Input Post([FromBody] Input input)
        {
            //input.Icons = new List<Icon>();
            //input.Icons.Add(new Icon(22));
            //var model = new CBRN_Project.MVVM.Models.Chemical.ChemModel(new CBRN_Project.Data_Access.DataService(), input.MethParams, input.Icons);

            return input;
        }
    }
}
