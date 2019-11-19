using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CBRN_Project.MVVM.Models;
using CBRN_Web_API_Server.Models;
using CBRN_Project.Data_Access;
using CBRN_Project.MVVM.Models.Engine.Nuclear;


namespace CBRN_Web_API_Server.Controllers
{
    public class NuclearController : ApiController
    {
        public IEnumerable<KeyValuePair<int, DailyReport>> GetNuclear([FromBody] Input input)
        {
            NuclearAgent.CalculateNucChallenge(input.Icons);
            return DailyReport.TableToDictionry(NuclearAgent.OutputTable);
        }
    }
}
