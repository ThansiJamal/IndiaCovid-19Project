using IndiaCovid_19Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IndiaCovid_19Project.Controllers
{
    public class LatestCovidController : Controller
    {
        // GET: LatestCovid
        public ActionResult GetStatesLatestCase()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetStatesLatestCase(Regional regional)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("https://api.rootnet.in/covid19-in/stats/latest");
            LatestCase response = JsonConvert.DeserializeObject<LatestCase>(downloadString);
            List<Regional> regionals = new List<Regional>();
            regionals.AddRange(response.data.regional);
            foreach (Regional item in regionals)
            {
                if (regional.loc == item.loc)
                {
                    regional.loc = item.loc;
                    regional.confirmedCasesIndian = item.confirmedCasesIndian;
                    regional.confirmedCasesForeign = item.confirmedCasesForeign;
                    regional.deaths = item.deaths;
                    regional.discharged = item.discharged;
                    regional.totalConfirmed = item.totalConfirmed;
                    break;
                }
            }
            return View("StatesLatestCovidCases", regional);
        }
    }
}