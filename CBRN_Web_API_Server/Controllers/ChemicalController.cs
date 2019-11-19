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
    public class ChemicalController : ApiController
    {
        public IEnumerable<KeyValuePair<int, DailyReport>> GetChemical([FromBody] Input input)
        {
            ChemModel model = new ChemModel(new DataService(), input.MethParams, input.Icons);
            return model.MakeReport();
        }
    }
}
