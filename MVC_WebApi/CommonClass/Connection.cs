using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace MVC_WebApi.CommonClass
{
    public class Connection
    {
        private string URLRequest { get; set; }



        //Request a API's service
        public Connection()
        {

            this.URLRequest = ("http://content.guardianapis.com/search?api-key=f955c8aa-c85a-4094-afdc-11cca6059d97");
        }

        public Connection(string RequestNumber)
        {

            this.URLRequest = RequestNumber == null ? "http://content.guardianapis.com/search?api-key=f955c8aa-c85a-4094-afdc-11cca6059d97" :
                "http://content.guardianapis.com/search?q=" + RequestNumber + "&api-key=f955c8aa-c85a-4094-afdc-11cca6059d97";

            this.URLRequest = "http://content.guardianapis.com/search?" + (RequestNumber == null ? "" : "q=" + RequestNumber + "&") + "api-key=f955c8aa-c85a-4094-afdc-11cca6059d97";

        }


        public string GetJSON()
        {
            var result = "";
            try
            {

                using (WebClient wc = new System.Net.WebClient())              
                {
                    wc.Encoding = Encoding.UTF8;
                    result = wc.DownloadString(URLRequest);
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            return result;
        }
    }
}