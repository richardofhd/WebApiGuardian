using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebApi.Models
{
    public class News
    {

        public string type { get; set; }
        public string sectionId { get; set; }
        public string webTitle { get; set; }
        public string webPublicationDate { get; set; }
        public string id { get; set; }
        public string webUrl { get; set; }
        public string apiUrl { get; set; }
        public string sectionName { get; set; }
    }
}