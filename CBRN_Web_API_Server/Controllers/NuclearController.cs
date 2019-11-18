using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CBRN_Project.MVVM.Models;
using CBRN_Web_API_Server.Models;
using CBRN_Project.MVVM.Models.Chemical;
using CBRN_Project.Data_Access;


namespace CBRN_Web_API_Server.Controllers
{
    public class NuclearController : ApiController
    {
        private IEnumerable<KeyValuePair<int, DailyReport>> NuclearWrapper(Input i) { return new KeyValuePair<int, DailyReport>[0]; }
        public IEnumerable<KeyValuePair<int, DailyReport>> GetReport([FromBody] Input input)
        {
            return NuclearWrapper(input);
        }
    }
}
