using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CBRN_Project.MVVM.Models;
using CBRN_Web_API_Server.Models;
using CBRN_Project.Data_Access;
using CBRN_Project.MVVM.Models.Engine.Radiological;


namespace CBRN_Web_API_Server.Controllers
{
    public class RadiologicalController : ApiController
    {
        public IEnumerable<KeyValuePair<int, DailyReport>> GetRadiological([FromBody] Input input)
        {
            RadiologicalAgent.CalculateRadiologicalChallenge(input.Icons, input.MethParams);
            return DailyReport.TableToDictionry(RadiologicalAgent.OutputTable);
        }
    }
}
