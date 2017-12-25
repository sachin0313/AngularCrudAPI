using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Models
{
    public class ModeChangeModel
    {
        public string party_name { get; set; }
        public string ourref { get; set; }
        public string styleno { get; set; }
        public Nullable<short> lotno { get; set; }
        public Nullable<double> totalqty { get; set; }
        public Nullable<System.DateTime> delvdate { get; set; }
        public string mode { get; set; }
        public string shipmentmode { get; set; }
        public Nullable<double> totalSalesPrice { get; set; }
        public Nullable<double> salesprice { get; set; }
        public Nullable<double> discount { get; set; }
        public Nullable<double> avgrateperpc { get; set; }
        public string apprval { get; set; }
        public string productimage { get; set; }
        public string reason { get; set; }
        public string revised_mode { get; set; }
        public string remarks { get; set; }
        public int requested_by { get; set; }
        public int requested_to{get;set;}
        public string currency{get;set;}
        
        
        
    }
}
