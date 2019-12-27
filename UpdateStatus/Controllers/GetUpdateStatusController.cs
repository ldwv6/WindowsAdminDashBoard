using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UpdateStatus.Models;

namespace UpdateStatus.Controllers
{
    public class GetUpdateStatusController : Controller
    {
        // GET: GetUpdateStatus
        public ActionResult Index()
        {
            List<CollectionGetUpdateStatus> UpdateStatus = new List<CollectionGetUpdateStatus>(); 
            HttpClient httpClient = new HttpClient();
        
            using (HttpResponseMessage message = httpClient.GetAsync("http://itmgmt.inpark.kr/itasset/collection-getUpdateStatus").Result)
            {
                var obj = message.Content.ReadAsStringAsync().Result;
                var ITAssetInfoArray = JsonConvert.DeserializeObject<List<ItassetCollectAPI>>(obj);

                foreach (var s in ITAssetInfoArray)
                {
                    var UpdateStatusArray = JsonConvert.DeserializeObject<CollectionGetUpdateStatus>(s.data.Trim());
                    UpdateStatus.Add(UpdateStatusArray);
                }
                return View(UpdateStatus);
            }
        }
    }


}