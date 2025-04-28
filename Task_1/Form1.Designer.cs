namespace Task_1
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
            this.url_box = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.html_content_listview = new System.Windows.Forms.ListView();
            this.html_tb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // url_box
            // 
            this.url_box.Location = new System.Drawing.Point(23, 29);
            this.url_box.Name = "url_box";
            this.url_box.Size = new System.Drawing.Size(301, 20);
            this.url_box.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(345, 29);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(65, 24);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // html_content_listview
            // 
            this.html_content_listview.HideSelection = false;
            this.html_content_listview.Location = new System.Drawing.Point(345, 70);
            this.html_content_listview.Name = "html_content_listview";
            this.html_content_listview.Size = new System.Drawing.Size(354, 327);
            this.html_content_listview.TabIndex = 4;
            this.html_content_listview.UseCompatibleStateImageBehavior = false;
            // 
            // html_tb
            // 
            this.html_tb.Location = new System.Drawing.Point(20, 70);
            this.html_tb.Name = "html_tb";
            this.html_tb.Size = new System.Drawing.Size(303, 326);
            this.html_tb.TabIndex = 5;
            this.html_tb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 431);
            this.Controls.Add(this.html_tb);
            this.Controls.Add(this.html_content_listview);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.url_box);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url_box;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ListView html_content_listview;
        private System.Windows.Forms.RichTextBox html_tb;
    }
}

