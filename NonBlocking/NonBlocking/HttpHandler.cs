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
        }
    }

    public class HttpResponseArgs : EventArgs
    {
        public string httpBody { get; set; }
        public int responseCode { get; set; }
    }
}
