using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Collections;

namespace VK_MUSIC_APP
{
    public partial class Form1 : Form
    {
        public static string count_audio = "";
        public Form1()
        {
            InitializeComponent();
            //pictureBox1.LoadAsync("http://cs416919.vk.me/v416919340/40de/7lDHW7H1jkk.jpg");
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sETTINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings fSettings = new Settings();
            fSettings.ShowDialog();
        }

        public static string GetMethod(string postUrl)
        {
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(postUrl);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            String sLine = objReader.ReadToEnd();
            return sLine;
        }

        public static List<Hashtable> XML_PARSE(String XML_DATA)
        {
            Hashtable dict_audio = new Hashtable();
            StringBuilder output = new StringBuilder();
            List<Hashtable> lAudioUser;
            lAudioUser = new List<Hashtable>();
            string sTemp = "";
            // Create an XmlReader
            using (XmlReader reader = XmlReader.Create(new StringReader(XML_DATA)))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            sTemp = reader.Name;
                            break;
                        case XmlNodeType.Text:
                            if (sTemp == "count")
                            {
                                count_audio = reader.Value;
                            }
                            else
                                if (sTemp != "id" && sTemp != "owner_id")
                                    dict_audio.Add(sTemp, reader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            if (reader.Name == "audio")
                            {
                                lAudioUser.Add(dict_audio);
                                dict_audio.Clear();
                            }
                            break;
                    }
                }
            }
            return lAudioUser;
        }
    }
}
