using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
               http.GetDatFromUrl(textBoxUrl1.Text);
           });

            Task.Run(() =>
            {
                var http = new HttpHandler(textBoxOutput2);
                http.WebContentReturned += HttpHandler_WebContentReturned;
                http.GetDatFromUrl(textBoxUrl2.Text);
            });
        }

        private void SetOutputEmpty()
        {
            textBoxOutput1.Text = string.Empty;
            textBoxOutput2.Text = string.Empty;
        }

        private delegate void WebContentReturnHandler(TextBox txt, HttpResponseArgs e);

        private void HttpHandler_WebContentReturned(object sender, EventArgs e)
        {
            var textbox = (sender as HttpHandler);
            if (textbox != null)
            {
                Invoke(new WebContentReturnHandler(SetTextBox), textbox.OutputTextbox, e);
            }
        }

        protected virtual void SetTextBox(TextBox sender, HttpResponseArgs e)
        {
            (sender).Text = e.HttpBody;
        }
    }
}
