using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonBlocking
{
    public class HttpHandler
    {
        public TextBox OutputTextbox { get; }

        public HttpHandler(TextBox output)
        {
            OutputTextbox = output;
        }

        public event EventHandler WebContentReturned;

        protected virtual void OnWebContentReturned(HttpResponseArgs e)
        {
            //Console.WriteLine("onWebContentReturned");
            WebContentReturned?.Invoke(this, e);
        }

        internal void GetDatFromUrl(string url)
        {
            //Console.WriteLine("GetData : " + url);

            var uriBuilder = new UriBuilder(url);
            var request = (HttpWebRequest)WebRequest.Create(uriBuilder.Uri);

            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var readStream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(response.CharacterSet)))
                    {
                        OnWebContentReturned(new HttpResponseArgs()
                        {
                            HttpBody = readStream.ReadToEnd(),
                            ResponseCode = response.StatusCode.GetHashCode()
                        });
                    }
                }
            }
            catch (Exception e)
            {
                OnWebContentReturned(new HttpResponseArgs()
                {
                    ResponseCode = HttpStatusCode.InternalServerError.GetHashCode(),
                    HttpBody = e.Message
                });
            }
        }
    }
}
