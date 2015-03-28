using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace SalesforceClient
{
    public static class RequestHelper
    {
        public static void SetBody(HttpWebRequest request, string requestBody)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            try
            {
                if (!string.IsNullOrEmpty(requestBody))
                {
                    using (Stream stream = request.GetRequestStream())
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            writer.Write(requestBody);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                string error = string.Format("Set body content into resquest failed. Error: {0}", e.Message);
                throw new Exception(error, e);
            }
        }

        public static string GetResponse(HttpWebRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            try
            {
                string resonse = null;
                HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = webResponse.GetResponseStream())
                {
                    using (StreamReader streamReader = new StreamReader(responseStream))
                    {
                        resonse = streamReader.ReadToEnd();
                    }
                }

                return resonse;
            }
            catch (Exception e)
            {
                string error = string.Format("Get response failed. Error: {0}", e.Message);
                throw new Exception(error, e);
            }
        }
    }
}
