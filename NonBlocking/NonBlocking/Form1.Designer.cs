namespace NonBlocking
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxOutput2 = new System.Windows.Forms.TextBox();
            this.textBoxOutput1 = new System.Windows.Forms.TextBox();
            this.GetContent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUrl2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUrl1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxOutput2
            // 
            this.textBoxOutput2.Location = new System.Drawing.Point(297, 54);
            this.textBoxOutput2.Multiline = true;
            this.textBoxOutput2.Name = "textBoxOutput2";
            this.textBoxOutput2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput2.Size = new System.Drawing.Size(275, 167);
            this.textBoxOutput2.TabIndex = 15;
            // 
            // textBoxOutput1
            // 
            this.textBoxOutput1.Location = new System.Drawing.Point(12, 54);
            this.textBoxOutput1.Multiline = true;
            this.textBoxOutput1.Name = "textBoxOutput1";
            this.textBoxOutput1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput1.Size = new System.Drawing.Size(275, 167);
            this.textBoxOutput1.TabIndex = 14;
            // 
            // GetContent
            // 
            this.GetContent.Location = new System.Drawing.Point(497, 225);
            this.GetContent.Name = "GetContent";
            this.GetContent.Size = new System.Drawing.Size(75, 23);
            this.GetContent.TabIndex = 13;
            this.GetContent.Text = "Get Content";
            this.GetContent.UseVisualStyleBackColor = true;
            this.GetContent.Click += new System.EventHandler(this.GetContent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Url 2";
            // 
            // textBoxUrl2
            // 
            this.textBoxUrl2.Location = new System.Drawing.Point(297, 28);
            this.textBoxUrl2.Name = "textBoxUrl2";
            this.textBoxUrl2.Size = new System.Drawing.Size(275, 20);
            this.textBoxUrl2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Url 1";
            // 
            // textBoxUrl1
            // 
            this.textBoxUrl1.Location = new System.Drawing.Point(12, 28);
            this.textBoxUrl1.Name = "textBoxUrl1";
            this.textBoxUrl1.Size = new System.Drawing.Size(275, 20);
            this.textBoxUrl1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.textBoxOutput2);
            this.Controls.Add(this.textBoxOutput1);
            this.Controls.Add(this.GetContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUrl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrl1);
            this.Name = "Form1";
            this.Text = "Non-Blocking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutput2;
        private System.Windows.Forms.TextBox textBoxOutput1;
        private System.Windows.Forms.Button GetContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUrl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUrl1;
    }
}

