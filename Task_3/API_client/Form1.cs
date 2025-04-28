using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace API_client
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string baseUrl = "https://localhost:7195/api/mockdata";

        private async void btn_Load_Click(object sender, EventArgs e)
        {
            string url = $"{baseUrl}/photos";
            using (HttpClient client = new HttpClient()) {
                var response = await client.GetStringAsync(url);
                var photos = JsonConvert.DeserializeObject<List<Photo>>(response);
                dgv_Photos.DataSource = photos.Take(100).ToList();
            }
        }

        private async void btn_Load_Cmt_Click(object sender, EventArgs e)
        {
            string url = $"{baseUrl}/comments";
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                var comments = JsonConvert.DeserializeObject<List<Comment>>(response);
                dgv_Photos.DataSource = comments.Take(100).ToList();
            }
        }

        private void btn_Load_Users_Click(object sender, EventArgs e)
        {
            string url = $"{baseUrl}/users";
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetStringAsync(url).Result;
                var users = JsonConvert.DeserializeObject<List<User>>(response);
                dgv_Photos.DataSource = users.Take(100).ToList();
            }
        }
    }

    public class Photo { 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Thumbnail { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
