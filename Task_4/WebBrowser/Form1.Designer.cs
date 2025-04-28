namespace WebBrowser
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
            this.components = new System.ComponentModel.Container();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Go = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_View_Source = new System.Windows.Forms.Button();
            this.btn_Download_Source = new System.Windows.Forms.Button();
            this.rtb_Source = new System.Windows.Forms.RichTextBox();
            this.rtb_Headers = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(12, 4);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(723, 20);
            this.txt_Url.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(741, 4);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(71, 22);
            this.btn_Go.TabIndex = 2;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 47);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1189, 800);
            this.webBrowser1.TabIndex = 3;
            // 
            // btn_View_Source
            // 
            this.btn_View_Source.Location = new System.Drawing.Point(818, 4);
            this.btn_View_Source.Name = "btn_View_Source";
            this.btn_View_Source.Size = new System.Drawing.Size(71, 22);
            this.btn_View_Source.TabIndex = 4;
            this.btn_View_Source.Text = "View Source";
            this.btn_View_Source.UseVisualStyleBackColor = true;
            this.btn_View_Source.Click += new System.EventHandler(this.btn_View_Source_Click);
            // 
            // btn_Download_Source
            // 
            this.btn_Download_Source.Location = new System.Drawing.Point(892, 4);
            this.btn_Download_Source.Name = "btn_Download_Source";
            this.btn_Download_Source.Size = new System.Drawing.Size(71, 22);
            this.btn_Download_Source.TabIndex = 5;
            this.btn_Download_Source.Text = "Download Source";
            this.btn_Download_Source.UseVisualStyleBackColor = true;
            this.btn_Download_Source.Click += new System.EventHandler(this.btn_Download_Source_Click);
            // 
            // rtb_Source
            // 
            this.rtb_Source.Location = new System.Drawing.Point(1221, 47);
            this.rtb_Source.Name = "rtb_Source";
            this.rtb_Source.Size = new System.Drawing.Size(211, 384);
            this.rtb_Source.TabIndex = 6;
            this.rtb_Source.Text = "";
            // 
            // rtb_Headers
            // 
            this.rtb_Headers.Location = new System.Drawing.Point(1221, 452);
            this.rtb_Headers.Name = "rtb_Headers";
            this.rtb_Headers.Size = new System.Drawing.Size(211, 395);
            this.rtb_Headers.TabIndex = 7;
            this.rtb_Headers.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.rtb_Headers);
            this.Controls.Add(this.rtb_Source);
            this.Controls.Add(this.btn_Download_Source);
            this.Controls.Add(this.btn_View_Source);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.txt_Url);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_View_Source;
        private System.Windows.Forms.Button btn_Download_Source;
        private System.Windows.Forms.RichTextBox rtb_Source;
        private System.Windows.Forms.RichTextBox rtb_Headers;
    }
}

