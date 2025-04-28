namespace API_client
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.dgv_Photos = new System.Windows.Forms.DataGridView();
            this.btn_Load_Cmt = new System.Windows.Forms.Button();
            this.btn_Load_Users = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Photos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(586, 28);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(94, 46);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load Photos";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // dgv_Photos
            // 
            this.dgv_Photos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Photos.Location = new System.Drawing.Point(30, 12);
            this.dgv_Photos.Name = "dgv_Photos";
            this.dgv_Photos.Size = new System.Drawing.Size(509, 498);
            this.dgv_Photos.TabIndex = 1;
            // 
            // btn_Load_Cmt
            // 
            this.btn_Load_Cmt.Location = new System.Drawing.Point(586, 108);
            this.btn_Load_Cmt.Name = "btn_Load_Cmt";
            this.btn_Load_Cmt.Size = new System.Drawing.Size(94, 46);
            this.btn_Load_Cmt.TabIndex = 2;
            this.btn_Load_Cmt.Text = "Load Comments";
            this.btn_Load_Cmt.UseVisualStyleBackColor = true;
            this.btn_Load_Cmt.Click += new System.EventHandler(this.btn_Load_Cmt_Click);
            // 
            // btn_Load_Users
            // 
            this.btn_Load_Users.Location = new System.Drawing.Point(586, 199);
            this.btn_Load_Users.Name = "btn_Load_Users";
            this.btn_Load_Users.Size = new System.Drawing.Size(94, 46);
            this.btn_Load_Users.TabIndex = 3;
            this.btn_Load_Users.Text = "Load Users";
            this.btn_Load_Users.UseVisualStyleBackColor = true;
            this.btn_Load_Users.Click += new System.EventHandler(this.btn_Load_Users_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 522);
            this.Controls.Add(this.btn_Load_Users);
            this.Controls.Add(this.btn_Load_Cmt);
            this.Controls.Add(this.dgv_Photos);
            this.Controls.Add(this.btn_Load);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Photos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.DataGridView dgv_Photos;
        private System.Windows.Forms.Button btn_Load_Cmt;
        private System.Windows.Forms.Button btn_Load_Users;
    }
}

