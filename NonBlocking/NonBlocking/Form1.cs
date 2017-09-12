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
            Task taskA = Task.Run(() =>
            {
                Console.WriteLine("Hello from taskA.");
                HttpHandler http1 = new HttpHandler();
            });

            taskA.Start();
        }

      
    }
}
