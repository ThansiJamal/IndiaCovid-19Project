using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndiaCovid_19Project.Models
{
    public class Summary
    {
        public int total { get; set; }
        public int confirmedCasesIndian { get; set; }
        public int confirmedCasesForeign { get; set; }
        public int discharged { get; set; }
        public int deaths { get; set; }
        public int confirmedButLocationUnidentified { get; set; }
    }
}