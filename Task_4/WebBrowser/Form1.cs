using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WebBrowser
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_Go_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Url.Text))
            {
                string url = txt_Url.Text;
                webBrowser1.Navigate(url);
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(txt_Url.Text);
                    response.EnsureSuccessStatusCode();

                    var headers = response.Headers.ToString();
                    rtb_Headers.Text = headers;

                    string html = await response.Content.ReadAsStringAsync();
                    rtb_Source.Text = html;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_View_Source_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtb_Source.Text))
            {
                Form sourceForm = new Form();
                sourceForm.Text = "Mã nguồn HTML";
                RichTextBox rtb = new RichTextBox
                {
                    Dock = DockStyle.Fill,
                    Text = rtb_Source.Text,
                    Multiline = true,
                    ScrollBars = RichTextBoxScrollBars.Both
                };
                sourceForm.Controls.Add(rtb);
                sourceForm.Size = new System.Drawing.Size(800, 600);
                sourceForm.Show();
            }
        }

        private void btn_Download_Source_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtb_Source.Text)) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Files (*.html)|*.html";
            sfd.Title = "Lưu mã nguồn HTML";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, rtb_Source.Text);
                MessageBox.Show("Lưu thành công!");
            }
        }
    }
}
