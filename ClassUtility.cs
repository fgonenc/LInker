using NLog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Linker
{
    static class ClassUtility
    {
        static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static bool DoesUrlRespond(string url)
        {
            try
            {
                WebRequest req = WebRequest.Create(url);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }

        public static Image GetFavIcon(string url)
        {
            Image urlFavIco = null;
            try
            {
                if (DoesUrlRespond(url))
                {
                    Uri thisUrl = new Uri(url);
                    if (thisUrl.HostNameType == UriHostNameType.Dns)
                    {
                        string iconUrl = "http://" + thisUrl.Host + "/favicon.ico";
                        WebRequest req = WebRequest.Create(iconUrl);
                        WebResponse resp = req.GetResponse();
                        urlFavIco = Image.FromStream(resp.GetResponseStream());
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("No favicon."+ ex.Message);
                return Properties.Resources.nofavicon;
            }

            return urlFavIco;
        }
    }
}
