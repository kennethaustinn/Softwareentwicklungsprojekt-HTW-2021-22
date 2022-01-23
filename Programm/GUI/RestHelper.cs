using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace GUI
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RestHelper
    {
       
       public string userName { get; set; }
       public string password { get; set; }
       public string endPoint { get; set; }
       public httpVerb httpMethod { get; set; }

       public RestHelper()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        //Die HttpWebRequest-Klasse ermöglicht dem Benutzer die direkte Interaktion mit Servern über HTTP.
        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            //hier kommen die Informationen
            request.Method = httpMethod.ToString();

            string authHeader = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(userName + ":" + password));
            request.Headers.Add("Authorization", authHeader.ToString() + "" + authHeader);

            //Überprüft die Response, ob die erhaltene Information richtig ist oder nicht
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("Error" + response.StatusCode.ToString());
                }

                //die ResponseStream verarbeiten
                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }//ende der verarbeitung von Responsestream
            }

            return strResponseValue;
        }//ende der Verwendung von Stream
       

    }
}
