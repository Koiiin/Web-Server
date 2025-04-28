using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Task2_Lab4
{
    public partial class Form1 : Form
    {
        // Dictionary to hold user agent categories and their values
        private Dictionary<string, List<string>> userAgentCategories = new Dictionary<string, List<string>>();

        public Form1()
        {
            InitializeComponent();
            InitializeUserAgents();
        }

        private void InitializeUserAgents()
        {
            // Clear any existing items
            userAgent_cbox.Items.Clear();
            
            // Desktop Browser User Agents
            userAgentCategories.Add("Desktop Browsers", new List<string>
            {
                "Chrome (Windows) - Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Safari/537.36",
                "Firefox (Windows) - Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:124.0) Gecko/20100101 Firefox/124.0",
                "Edge (Windows) - Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Edge/123.0.0.0 Safari/537.36",
                "Safari (macOS) - Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.0 Safari/605.1.15",
                "Opera (Windows) - Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Safari/537.36 OPR/109.0.0.0",
                "Chrome (macOS) - Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Safari/537.36",
                "Firefox (macOS) - Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15; rv:124.0) Gecko/20100101 Firefox/124.0"
            });
            
            // Mobile Browser User Agents
            userAgentCategories.Add("Mobile Browsers", new List<string>
            {
                "Chrome (Android) - Mozilla/5.0 (Linux; Android 10) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Mobile Safari/537.36",
                "Safari (iOS) - Mozilla/5.0 (iPhone; CPU iPhone OS 17_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.0 Mobile/15E148 Safari/604.1",
                "Samsung Internet - Mozilla/5.0 (Linux; Android 12; SM-G991B) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Mobile Safari/537.36 SamsungBrowser/21.0",
                "Firefox (Android) - Mozilla/5.0 (Android 13; Mobile; rv:124.0) Gecko/124.0 Firefox/124.0",
                "Chrome (iPad) - Mozilla/5.0 (iPad; CPU OS 17_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) CriOS/123.0.0.0 Mobile/15E148 Safari/604.1"
            });
            
            // Tablet Browser User Agents
            userAgentCategories.Add("Tablet Browsers", new List<string>
            {
                "Chrome (Android Tablet) - Mozilla/5.0 (Linux; Android 12; SM-X906C) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Safari/537.36",
                "Safari (iPad) - Mozilla/5.0 (iPad; CPU OS 17_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.0 Mobile/15E148 Safari/604.1",
                "Firefox (Android Tablet) - Mozilla/5.0 (Android 13; Tablet; rv:124.0) Gecko/124.0 Firefox/124.0"
            });
            
            // Bot/Crawler User Agents
            userAgentCategories.Add("Bots/Crawlers", new List<string>
            {
                "Googlebot - Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)",
                "Bingbot - Mozilla/5.0 (compatible; bingbot/2.0; +http://www.bing.com/bingbot.htm)",
                "Yandex - Mozilla/5.0 (compatible; YandexBot/3.0; +http://yandex.com/bots)",
                "DuckDuckBot - DuckDuckBot/1.0; (+http://duckduckgo.com/duckduckbot.html)"
            });
            
            // Gaming Console User Agents
            userAgentCategories.Add("Gaming Consoles", new List<string>
            {
                "PlayStation 5 - Mozilla/5.0 (PlayStation 5 0.0) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/15.0 Safari/605.1.15",
                "Xbox Series X - Mozilla/5.0 (Windows NT 10.0; Win64; x64; Xbox; Xbox Series X) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36 Edge/120.0.0.0",
                "Nintendo Switch - Mozilla/5.0 (Nintendo Switch; WebApplet) AppleWebKit/609.4 (KHTML, like Gecko) NF/6.0.2.21.5 NintendoBrowser/5.1.0.22424"
            });

            // Add categories as group headers in the combobox
            foreach (var category in userAgentCategories)
            {
                userAgent_cbox.Items.Add("--- " + category.Key + " ---");
                foreach (var agent in category.Value)
                {
                    userAgent_cbox.Items.Add(agent);
                }
                userAgent_cbox.Items.Add(string.Empty); 
            }
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string url = link_lbl.Text.Trim();
                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Please enter a valid URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    url = "https://" + url;
                    link_lbl.Text = url;
                }

                if (userAgent_cbox.SelectedItem == null || 
                    userAgent_cbox.SelectedItem.ToString().StartsWith("---") || 
                    string.IsNullOrEmpty(userAgent_cbox.SelectedItem.ToString()))
                {
                    MessageBox.Show("Please select a valid User Agent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedItem = userAgent_cbox.SelectedItem.ToString();
                string userAgent = selectedItem;
                
                // Extract actual user agent string if it contains a description
                if (selectedItem.Contains(" - "))
                {
                    userAgent = selectedItem.Substring(selectedItem.IndexOf(" - ") + 3);
                }
                
                Cursor = Cursors.WaitCursor;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = userAgent; 
                request.Method = "GET";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string responseText = reader.ReadToEnd();
                    content_box.Text = responseText;
                    
                    DisplayHtml(responseText, userAgent);
                }

                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void DisplayHtml(string html, string userAgent)
        {
            try
            {
                string tempFile = Path.GetTempFileName() + ".html";
                File.WriteAllText(tempFile, html);

                if (webView21 != null)
                {
                    webView21.CoreWebView2InitializationCompleted += (s, e) =>
                    {
                        if (e.IsSuccess)
                        {
                            webView21.CoreWebView2.Settings.UserAgent = userAgent;
                            webView21.CoreWebView2.Navigate("file:///" + tempFile.Replace("\\", "/"));
                        }
                    };

                    if (webView21.CoreWebView2 != null)
                    {
                        webView21.CoreWebView2.Settings.UserAgent = userAgent;
                        webView21.CoreWebView2.Navigate("file:///" + tempFile.Replace("\\", "/"));
                    }
                    else
                    {
                        webView21.EnsureCoreWebView2Async(null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying HTML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
