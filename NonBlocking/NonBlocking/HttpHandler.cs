using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonBlocking
{
    public class HttpHandler
    {
        public event EventHandler WebContentReturned;

        protected virtual void onWebContentReturned(HttpResponseArgs e)
        {
            //do stuff
            Console.WriteLine("do stuff");
            WebContentReturned?.Invoke(this, e);

            if (e.responseCode == 200)
            {

            }
        }
    }

    public class HttpResponseArgs : EventArgs
    {
        public string httpBody { get; set; }
        public int responseCode { get; set; }
    }
}
