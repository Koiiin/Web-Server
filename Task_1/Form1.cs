using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;

namespace Task_1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            // Gọi khi Form1_Load:
            html_content_listview.View = View.Details;
            html_content_listview.Columns.Add("Header", 200);
            html_content_listview.Columns.Add("Value", 400);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string input_url = url_box.Text.Trim();

                if (!input_url.StartsWith("http"))
                {
                    input_url = "http://" + input_url; // thêm http nếu thiếu
                }

                WebRequest myWebRequest = WebRequest.Create(input_url);
                WebResponse myWebResponse = myWebRequest.GetResponse();

                html_content_listview.Items.Clear(); 

                for (int i = 0; i < myWebResponse.Headers.Count; i++)
                {
                    string header = myWebResponse.Headers.GetKey(i);
                    string value = myWebResponse.Headers.Get(i);
                    //html_content_listview.Items.Add(header + ": " + value);

                    ListViewItem item = new ListViewItem(header);
                    item.SubItems.Add(value);
                    html_content_listview.Items.Add(item);
                }

                // Đọc nội dung HTML
                Stream dataStream = myWebResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                
                html_tb.Text = responseFromServer;

                myWebResponse.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
