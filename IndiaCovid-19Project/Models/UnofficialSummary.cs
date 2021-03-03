using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndiaCovid_19Project.Models
{
    public class UnofficialSummary
    {
        public string source { get; set; }
        public int total { get; set; }
        public int recovered { get; set; }
        public int deaths { get; set; }
        public int active { get; set; }
    }
}