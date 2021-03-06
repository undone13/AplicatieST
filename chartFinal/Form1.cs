using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace chartFinal
{
    public partial class Form1 : Form
    {
        List<Universitate> jsonData;
        TabPage tb_chart;
        ChartArea chartArea;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DATE PERSONALE----------------------------------------------------------------    

            string date = Properties.Resources.date_personale;
            string[] linii = date.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            Label nume_prenume = new Label()
            {
                Text = linii[0] + " " + linii[1],
                Location = new Point(10, 10),
                Size = new Size(300, 20)
            };
            Label nr_telefon = new Label()
            {
                Text = linii[2],
                Location = new Point(10, 30),
                Size = new Size(300, 20)
            };
            tab_date.Controls.Add(nume_prenume);
            tab_date.Controls.Add(nr_telefon);

            chart1.Enabled = false;
            chart1.Visible = false;
            //--------------------------------------------------------------------------------
        }

        //SCHIMBARE ORA---------------------------------------------------------------------
        RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart req = new ThreadStart(Thread);
            Thread reqThread = new Thread(req);
            reqThread.Start();
            SchimbareOra("h:mm tt");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ThreadStart req = new ThreadStart(Thread);
            Thread reqThread = new Thread(req);
            reqThread.Start();
            SchimbareOra("h:mm");
        }

        public void SchimbareOra(string format)
        {
            var nr = 0;
            regKey.SetValue("sShortTime", format);
            var winExp = Process.GetProcessesByName("explorer");
            foreach (var exp in winExp)
            {
                exp.Kill();
            }
        }
        public void Thread()
        {
            Label lbl = new Label();
            lbl.Location = new Point(180, 10);
            lbl.Text = System.DateTime.Now.ToString(regKey.GetValue("sShortTime").ToString());

            this.Invoke(new MethodInvoker(delegate ()
            {
                tab_ora.Controls.Add(lbl);
            }
            ));
        }

        //UNIVERSITATI------------------------------------------------------------------------

        public void ThreadUniversitati()
        {
            var client = new HttpClient();
            var ep = new Uri("http://universities.hipolabs.com/search?name=medic");
            var res = client.GetAsync(ep).Result;
            var JSON = res.Content.ReadAsStringAsync().Result;
            jsonData = JsonConvert.DeserializeObject<List<Universitate>>(JSON);

            if (res != null)
            {
                var dist = 0; var limit = 500;
                foreach (var item in jsonData)
                {
                    Label lb1 = new Label();
                    lb1.Text = item.name;
                    lb1.Location = new Point(10, dist + 10);
                    lb1.AutoSize = true;
                    lb1.Click += (s, e) =>
                    {
                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                        {
                            string url = item.web_pages[0];
                            url = url.Replace("&", "^&");
                            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                        }
                    };

                    Label lb2 = new Label();
                    lb2.Text = item.country;
                    lb2.Location = new Point(10, dist + 30);
                    lb2.AutoSize = true;
                    lb2.Click += (s, e) =>
                    {
                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                        {
                            string url = item.web_pages[0];
                            url = url.Replace("&", "^&");
                            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                        }
                    };

                    Label lb3 = new Label();
                    lb3.Text = item.alpha_two_code;
                    lb3.Location = new Point(10, dist + 50);
                    lb3.AutoSize = true;
                    lb3.Click += (s, e) =>
                    {
                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                        {
                            string url = item.web_pages[0];
                            url = url.Replace("&", "^&");
                            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                        }
                    };

                    dist += 80;
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        tab_univ.Controls.Add(lb1); tab_univ.Controls.Add(lb2); tab_univ.Controls.Add(lb3);
                    }
                    ));
                }
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            tab_univ.AutoScroll = true;
            ThreadStart req = new ThreadStart(ThreadUniversitati);
            Thread reqThread = new Thread(req);
            reqThread.Start();


            //CHART-----------------------------------------------------------------
            while(jsonData == null)
                System.Threading.Thread.Sleep(10);

            chart1.Enabled = true;
            chart1.Visible = true;
            

            string[] str = new string[jsonData.Count];
            string[] distStr = new string[jsonData.Count];


            for (int i = 0; i < jsonData.Count; i++)
            {
                str[i] = jsonData[i].country;
            }
            distStr = str.Distinct().ToArray();
            for (int i = 0; i < distStr.Length; i++)
            {
                int nr = str.Count(x => x == distStr[i]);
                chart1.Series[0].Points.AddXY(distStr[i].ToString(), nr);
            }

            chartArea = chart1.ChartAreas[chart1.Series[0].ChartArea];

            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = distStr.Length + 1;

            chartArea.CursorX.AutoScroll = true;

            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            int position = 0;
            int size = 5;
            chartArea.AxisX.ScaleView.Zoom(position, size);

            chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;


        }


        //-----------------------------------------------------------------------------------

        //TEXT FILE-------------------------------------------------------------------------

        private void button4_Click(object sender, EventArgs e)
        {
            if (jsonData != null)
            {
                string fileName = "date_universitati.txt";
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    foreach (var item in jsonData)
                    {
                        sw.WriteLine(item.name + "\t" + item.country + "\t" + item.alpha_two_code + "\t" + item.web_pages[0]);
                    }
                }
                Process.Start(fileName);
            }
            else
            {
                MessageBox.Show("Nu exista date");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string html = GetHtmlCode();
            if (html == "")
            {
                MessageBox.Show("Scrie ce vrei sa cauti in TextBox");
            }
            string text_anterior = textBox1.Text;
            List<string> urls = GetUrls(html);
            var dist = 5;
            int i = 0, coloana = 5;

            var panel1 = new Panel();
            panel1.Location = new Point(15, 44);
            panel1.Size = new Size(735, 348);
            tab_image.Controls.Add(panel1);

            foreach (var item in urls)
            {
                var pb = new PictureBox();
                SaveImage(item, "image" + i, ImageFormat.Png);

                if (coloana + 130 > panel1.Width)
                {
                    dist += 140;
                    coloana = 0;
                }
                pb.Load(item);
                pb.Size = new Size(130, 130);
                pb.Location = new Point(coloana, dist);
                pb.SizeMode = PictureBoxSizeMode.Normal;
                panel1.Controls.Add(pb);
                coloana += 140; i++;
            }
            panel1.AutoScroll = true;
        }
        private string GetHtmlCode()
        {
            if (textBox1.Text != "")
            {
                string url = "https://www.google.com/search?q=" + textBox1.Text + "&tbm=isch";
                string data = "";

                var request = (HttpWebRequest)WebRequest.Create(url);
                var response = (HttpWebResponse)request.GetResponse();

                using (Stream dataStream = response.GetResponseStream())
                {
                    if (dataStream == null)
                        return "";
                    using (var sr = new StreamReader(dataStream))
                    {
                        data = sr.ReadToEnd();
                    }
                }
                return data;
            }
            else
            {
                return "";
            }
        }
        private List<string> GetUrls(string html)
        {
            var urls = new List<string>();

            int ndx = html.IndexOf("src=\"https", StringComparison.Ordinal);

            while (ndx >= 0)
            {
                ndx = html.IndexOf("\"", ndx + 4, StringComparison.Ordinal);
                ndx++;
                int ndx2 = html.IndexOf("\"", ndx, StringComparison.Ordinal);
                string url = html.Substring(ndx, ndx2 - ndx);
                urls.Add(url);
                ndx = html.IndexOf("src=\"https", ndx2, StringComparison.Ordinal);
            }
            return urls;
        }

        private void SaveImage(string imageUrl, string filename, ImageFormat format)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageUrl);
            Bitmap bitmap; bitmap = new Bitmap(stream);

            if (bitmap != null)
            {
                bitmap.Save(filename, format);
            }

            stream.Flush();
            stream.Close();
            client.Dispose();
        }

    }

    public class Universitate
        {
            public string[] web_pages { get; set; }
            public string name { get; set; }
            public string country { get; set; }
            public string alpha_two_code { get; set; }
        }

}
