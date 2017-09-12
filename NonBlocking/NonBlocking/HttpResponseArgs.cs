using System;

namespace NonBlocking
{
    public class HttpResponseArgs : EventArgs
    {
        public string HttpBody { get; set; }
        public int ResponseCode { get; set; }
    }
}