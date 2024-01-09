using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using System.ServiceModel.Syndication;
using System.Windows.Forms.VisualStyles;
using Microsoft.Web.WebView2.WinForms;

namespace CozyRSS
{
    public partial class MainForm : Form
    {
        XmlDocument xml;
        public MainForm()
        {
            InitializeComponent();
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParseOPML(@"C:\Users\segfa\Desktop\feeds_2024-01-08.opml.xml");
            /*
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog.FileName);
            }
            */
        }

        private void ParseOPML(String fileName)
        {
            feedList.Nodes.Clear();
            xml = new XmlDocument();
            xml.Load(fileName);

            var outlines = xml.GetElementsByTagName("outline");
            TreeNode currentNode = null;

            TreeNode allFeeds = new TreeNode("All Feeds");
            feedList.Nodes.Add(allFeeds);

            foreach (XmlElement node in outlines)
            {
                if (node.Attributes.Count == 1)
                {
                    currentNode = new TreeNode(node.Attributes["text"].Value, 0, 1);
                    feedList.Nodes.Add(currentNode);
                }
                else
                {
                    TreeNode feedNode = new TreeNode(node.Attributes["text"].Value, 2, 2);
                    currentNode.Nodes.Add(feedNode);
                }
            }
        }

        private string DownloadFeed(string url)
        {
            Console.WriteLine(url);
            WebClient client = new WebClient();
            string content = client.DownloadString(url);

            return content;
        }

        private void PopulateFeedList(string uri)
        {
            using (XmlReader reader = XmlReader.Create(uri))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);

                foreach (SyndicationItem item in feed.Items)
                {
                    string blog = feed.Title.Text;
                    string subject = item.Title.Text;
                    // string summary = item.Summary.Text;
                    string link = item.Links[0].Uri.ToString();
                    string published = item.PublishDate.ToString("dd/MM/yy H:mm:ss");

                    string[] row = { " ", blog, subject, published, link };
                    feedGrid.Rows.Add(row);
                }
            }
        }

        private void feedList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var outlines = xml.GetElementsByTagName("outline");

            foreach (XmlElement node in outlines)
            {
                if (node.Attributes["xmlUrl"] != null)
                {
                    if (e.Node.Text == "All Feeds")
                    {
                        var feed = node.Attributes["xmlUrl"].Value;
                        PopulateFeedList(feed);
                    }
                    else
                    {
                        if (node.Attributes["text"].Value == e.Node.Text)
                        {
                            var feed = node.Attributes["xmlUrl"].Value;
                            PopulateFeedList(feed);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void feedGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string title = feedGrid.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            string link = feedGrid.Rows[e.RowIndex].Cells["Link"].Value.ToString();
            CreateTab(title, link);
        }

        private void CreateTab(string title, string url)
        {
            TabPage newTab = new TabPage(title);

            WebView2 browser = new WebView2();
            browser.Dock = DockStyle.Fill;
            newTab.Controls.Add(browser);
            mainTabs.Controls.Add(newTab);
            mainTabs.SelectedTab = newTab;
            browser.Source = new Uri(url);
        }
    }
}
