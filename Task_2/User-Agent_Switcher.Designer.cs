namespace Task2_Lab4
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
            this.userAgent_cbox = new System.Windows.Forms.ComboBox();
            this.link_lbl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.content_box = new System.Windows.Forms.RichTextBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // userAgent_cbox
            // 
            this.userAgent_cbox.FormattingEnabled = true;
            this.userAgent_cbox.Location = new System.Drawing.Point(118, 44);
            this.userAgent_cbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userAgent_cbox.Name = "userAgent_cbox";
            this.userAgent_cbox.Size = new System.Drawing.Size(754, 21);
            this.userAgent_cbox.TabIndex = 0;
            // 
            // link_lbl
            // 
            this.link_lbl.Location = new System.Drawing.Point(118, 18);
            this.link_lbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.link_lbl.Name = "link_lbl";
            this.link_lbl.Size = new System.Drawing.Size(754, 20);
            this.link_lbl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link";
            // 
            // enter_btn
            // 
            this.enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.Location = new System.Drawing.Point(30, 76);
            this.enter_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(78, 30);
            this.enter_btn.TabIndex = 4;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // content_box
            // 
            this.content_box.Location = new System.Drawing.Point(9, 110);
            this.content_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.content_box.Name = "content_box";
            this.content_box.Size = new System.Drawing.Size(373, 382);
            this.content_box.TabIndex = 5;
            this.content_box.Text = "";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(386, 110);
            this.webView21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(483, 382);
            this.webView21.TabIndex = 6;
            this.webView21.ZoomFactor = 1D;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "User Agent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.content_box);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link_lbl);
            this.Controls.Add(this.userAgent_cbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "User-Agent Switcher";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userAgent_cbox;
        private System.Windows.Forms.TextBox link_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.RichTextBox content_box;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label label2;
    }
}

