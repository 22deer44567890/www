using CefSharp.DevTools.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Vk_bot
{
    public partial class friends_add : Form
    {
         public string access_token;

        public friends_add()
        {
            InitializeComponent();
        }

        private void friends_add_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Api;
            Api = "https://api.vk.com/method/users.get?" + "fields=photo_100&" + access_token + "&v=5.199";


            WebClient client = new WebClient();
            client.DownloadData(Api);
            string Anwer = Encoding.UTF8.GetString(client.DownloadData(Api));
            string ruguest = "https://api.vk.com/method/friends.getSuggestions?" +
                                      "count=100&" +
                                      access_token +
                                       "&v=5.199";

            string Answer = Encoding.UTF8.GetString(client.DownloadData(ruguest));

            Friends_getSuggestions Friends_getSuggestions = JsonConvert.DeserializeObject<Friends_getSuggestions>(Answer);
            progressBar1.Maximum = Friends_getSuggestions.response.items.Count;

            for (int index = 0; index < Friends_getSuggestions.response.items.Count; index++)
            {
               
                    for (int j = 0; j < 1; j++) 
                    {
                        button1.Enabled = false;
                        Thread.Sleep(20);
                        Application.DoEvents();
                    }
                progressBar1.Value = index;
                ListViewItem peopleItem = new ListViewItem();
                peopleItem.ImageIndex = index;// индокс аватарки пользователя
                peopleItem.SubItems.Add(Friends_getSuggestions.response.items[index].first_name);// имя пользователя
                peopleItem.SubItems.Add(Friends_getSuggestions.response.items[index].last_name);// фамилия пользователя 

                Api = "https://api.vk.com/method/friends.add?" + "user_id=" +
                        Friends_getSuggestions.response.items[index].id.ToString() +"&"+
                                       access_token +
                                       "&v=5.199";
                Answer = Encoding.UTF8.GetString(client.DownloadData(Api));
                textBox1.Text += Answer + "\r\n\r\n\r\n\r\n";
                peopleItem.Text = Friends_getSuggestions.response.items[index].id.ToString(); //айди польлователей которые можешь добавить

                listView1.Items.Add(peopleItem);

            } 
            button1.Enabled = true;
            progressBar1.Value = progressBar1.Maximum;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Api;
            Api = "https://api.vk.com/method/friends.get?" + access_token + "&v=5.199";
            WebClient client = new WebClient();
            client.DownloadData(Api);
            string Anwer = Encoding.UTF8.GetString(client.DownloadData(Api));
            Friends_Get_id Friends_getSuggestions = JsonConvert.DeserializeObject<Friends_Get_id>(Anwer);

            int TotalCount = 0;

            for (int i = 0; i < Friends_getSuggestions.response.items.Count; ++i)
            {
                for (int j = 0; j < 1; j++)
                {
                    button2.Enabled = false;
                    Thread.Sleep(20);
                    Application.DoEvents();
                }

                Api = "https://api.vk.com/method/wall.get?owner_id="+ Friends_getSuggestions.response.items[i] + "&" + access_token + "&v=5.199";
                client.DownloadData(Api);
                Anwer = Encoding.UTF8.GetString(client.DownloadData(Api));
                list_of_posts List_of_posts = JsonConvert.DeserializeObject<list_of_posts>(Anwer);
                for (int j = 0; j < List_of_posts.response.items.Count; ++i)
                {
                    Api = "https://api.vk.com/method/likes.add?type=post" 
                        + "&owner_id="+ Friends_getSuggestions.response.items[i] 
                        + "&item_id="+ List_of_posts.response.items[j].id +"&"
                        + access_token +
                        
                                       "&v=5.199";
                 
                    client.DownloadData(Api);
                    Anwer = Encoding.UTF8.GetString(client.DownloadData(Api));
                    TotalCount++;
                    textBox1.Text += Anwer + "\r\n\r\n\r\n\r\n";
                    Application.DoEvents();
                    
                    Thread.Sleep(100);
                    Application.DoEvents();
                    if(TotalCount>10)
                    {
                        return;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        
