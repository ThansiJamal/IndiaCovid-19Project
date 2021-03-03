using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndiaCovid_19Project.Models
{
    public class Data
    {
        public Summary summary { get; set; }
        public List<UnofficialSummary> UnofficialSummary { get; set; }
        public List<Regional> regional { get; set; }
    }
}