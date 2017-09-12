using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public async Task<string> GetContentAsync(string url)
        {
            using (var client = new HttpClient())
            {
                using (var r = await client.GetAsync(new Uri(url)))
                {
                    return await r.Content.ReadAsStringAsync();
                }
            }
        }
        internal void GetDataFromUrl(string url)
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
