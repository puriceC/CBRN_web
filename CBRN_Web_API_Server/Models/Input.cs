using CBRN_Project.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBRN_Web_API_Server.Models
{
    public class Input
    {
        private List<Icon> icons;
        private MethParams methParams;

        public List<Icon> Icons { get => icons; set => icons = value; }
        public MethParams MethParams { get => methParams; set => methParams = value; }
    }
}