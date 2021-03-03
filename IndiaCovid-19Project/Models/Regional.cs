using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndiaCovid_19Project.Models
{
    public class Regional
    {
        public string loc { get; set; }
        public int confirmedCasesIndian { get; set; }
        public int confirmedCasesForeign { get; set; }
        public int discharged { get; set; }
        public int deaths { get; set; }
        public int totalConfirmed { get; set; }
    }
}