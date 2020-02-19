using System;
using System.IO;
using System.Net;
using System.Text;

namespace dotnet_crawler_poc
{
    class Initial
    {
        static public string GetHtml()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("");
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            Stream resStream = res.GetResponseStream();
            StreamReader streamReader = new StreamReader(resStream, Encoding.UTF8);

            return streamReader.ReadToEnd();
        }
    }
}
