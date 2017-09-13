using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonBlocking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxUrl1.Text = "https://www.google.co.th/";
            textBoxUrl2.Text = "https://www.blognone.com/";
        }

        private void GetContent_Click(object sender, EventArgs e)
        {
            SetOutputEmpty();

            Task.Run(() =>
            {
                var http = new HttpHandler(textBoxOutput1);
                http.WebContentReturned += HttpHandler_WebContentReturned;
                http.GetDataFromUrl(textBoxUrl1.Text);

                //               http.OnWebContentReturned(new HttpResponseArgs
                //               {
                //                   HttpBody = http.GetContentAsync(textBoxUrl1.Text).Result,
                //                   ResponseCode = 200
                //               });
            });

            Task.Run(() =>
            {
                var http = new HttpHandler(textBoxOutput2);
                http.WebContentReturned += HttpHandler_WebContentReturned;
                http.GetDataFromUrl(textBoxUrl2.Text);
            });
        }

        private void SetOutputEmpty()
        {
            textBoxOutput1.Text = string.Empty;
            textBoxOutput2.Text = string.Empty;
        }

        //private delegate void WebContentReturnHandler(TextBox txt, HttpResponseArgs e);

        //private void HttpHandler_WebContentReturned(object sender, EventArgs e)
        //{
        //    var textbox = (sender as HttpHandler);
        //    if (textbox == null) return;
        //    Invoke(new WebContentReturnHandler(SetTextBox), textbox.OutputTextbox, e);
        //}
        //protected virtual void SetTextBox(TextBox sender, HttpResponseArgs e)
        //{
        //    (sender).Text = e.HttpBody;
        //}

        private void HttpHandler_WebContentReturned(object sender, EventArgs e)
        {
            var textbox = sender as HttpHandler;
            if (textbox == null) return;
            Invoke(Action, textbox.OutputTextbox, e);
        }

        protected Action<TextBox, HttpResponseArgs> Action = (textBox, httpResponseArgs) =>
        {
            textBox.Text = httpResponseArgs.ResponseCode == 200 ? httpResponseArgs.HttpBody : string.Empty;
        };
    }
}