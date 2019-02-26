using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Protocols;
using System.IO;

namespace ReviewSys.Controllers
{
    public class ChildsController : Controller
    {
        // GET: Childs
        public ActionResult ClientManager()
        {
            return View();
        }
        public ActionResult FilesManager()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpLoadProcess(string id, string name, string type, string lastModifiedDate, int size, HttpPostedFileBase file)
        {
            //保存到临时文件夹
            string urlPath = "../UploadFiles";
            string filePathName = string.Empty;

            string localPath = Path.Combine(HttpRuntime.AppDomainAppPath, "UploadFiles");
            if (Request.Files.Count == 0)
            {
                return Json(new { jsonrpc = 2.0, error = new { code = 102, message = "保存失败" }, id = "id" });
            }

            string ex = Path.GetExtension(file.FileName);
            filePathName = Guid.NewGuid().ToString("N") + ex;
            if (!System.IO.Directory.Exists(localPath))
            {
                System.IO.Directory.CreateDirectory(localPath);
            }
            file.SaveAs(Path.Combine(localPath, filePathName));

            return Json(new
            {
                jsonrpc = "2.0",
                id = id,
                filePath = urlPath + "/" + filePathName//返回一个视图界面可直接使用的url
            });

        }
    }
}