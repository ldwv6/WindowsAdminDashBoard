using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpdateStatus.Models
{
    public class ItassetCollectAPI 
    {
        public string seq { get; set; }
        public string app { get; set; }
        public string job { get; set; }
        public string data { get; set; }
        public DateTime create_dt { get; set; }
    }

    public class CollectionGetUpdateStatus
    {        
        public string UUID { get; set; }
        public string NTLastUpdateDate { get; set; }
        public string HostName { get; set; }
        public string LastBootUp { get; set; }   
    }
}