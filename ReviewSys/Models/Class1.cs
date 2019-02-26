using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewSys.Models
{
    public class FilesModel
    {
        public string FileName { get; set; }
        public string FileAddress { get; set; }
        public HttpPostedFileBase File { get; set; }
    }
}