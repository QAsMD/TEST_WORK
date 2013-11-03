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
        public static string sURL_GEN = "https://api.vk.com/method/audio.get.xml?owner_id=21881340&need_user=1&v=5.2&access_token=08e6ca4bc5e7b95b15b732d61cedbad6b2e6f6ec98c066759722849c1bd01fa76b961ca82add0295a9115";
        public Form1()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sETTINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings fSettings = new Settings();
            fSettings.ShowDialog();
            var htCollect_Audio = XML_PARSE(GetMethod(sURL_GEN));


        }

        public string GetMethod(string postUrl)
        {
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(postUrl);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            String sLine = objReader.ReadToEnd();
            return sLine;
        }

        public Hashtable[] XML_PARSE(String XML_DATA)
        {
            XmlReader reader = XmlReader.Create(new StringReader(XML_DATA));
            //List<Hashtable> lAudioUser = new List<Hashtable>();
            int i = 0;
            string sTemp = "";
            // Create an XmlReader
            reader.ReadToFollowing("count");
            reader.Read();
            Hashtable[] dict_audio = new Hashtable[Convert.ToInt32(reader.Value)];
            lab_CountAudio.Text = Convert.ToString(reader.Value);
            //reader.ReadToFollowing("photo");
            //reader.Read();
            //pictureBox1.LoadAsync(reader.Value);
            //reader.ReadToFollowing("name");
            //reader.Read();
            //lab_NameUser.Text = reader.Value;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        sTemp = reader.Name;
                        break;
                    case XmlNodeType.Text:
                        if (sTemp != "id" && sTemp != "owner_id")
                        {
                            if (dict_audio[i] == null)
                                dict_audio[i] = new Hashtable();
                            dict_audio[i].Add(sTemp, reader.Value);
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name == "audio")
                        {
                            i++;
                        }
                        break;
                }
            }
            return dict_audio;
        }
        public string api_method(string sMethod_API, string sID_User, string sAccess_Token)
        {
            string sURL_API = "";
            Hashtable ht_API_METHODS = new Hashtable();
            ht_API_METHODS.Add("audio.get", "https://api.vk.com/method/audio.get.xml?owner_id=%uid_user&need_user=1&v=5.2&access_token=%token");
            ht_API_METHODS.Add("users.get", "https://api.vk.com/method/users.get.xml?&fields=photo_200&uid=%uid_user");
            sURL_API = Convert.ToString(ht_API_METHODS[sMethod_API]);
            sURL_API = sURL_API.Replace("%uid_user", sID_User);
            if (sMethod_API == "audio.get")
                sURL_API = sURL_API.Replace("%token", sAccess_Token);
            return sURL_API;
        }
    }
}
