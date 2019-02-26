using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewSys.Models
{
    public class InfoModels
    {
        public string BlogName { get; set; }
        public string BlogAddress { get; set; }
        public HttpPostedFileBase BlogPhoto { get; set; }
    }
}