using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;

namespace RoboHash_Generator
{
    public partial class RobotImageGenerator : Form
    {
        public RobotImageGenerator()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using(HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync("https://robohash.org/"+textBox1.Text))
                {
                    if (textBox1.Text != null || textBox1.Text != "")
                    {
                        textBox1.Text = Dns.GetHostName().ToString();
                    }
                    if (rbBackground1.Checked)
                    {
                        if (rbRobot1.Checked)
                            pictureBox1.Load("https://robohash.org/" + textBox1.Text + "?set=set1&size=250x250&bgset=bg1");
                        if (rbRobot2.Checked)
                            pictureBox1.Load("https://robohash.org/" + textBox1.Text + "?set=set2&size=250x250&bgset=bg1");
                        if (rbRobot3.Checked)
                            pictureBox1.Load("https://robohash.org/" + textBox1.Text + "?set=set3&size=250x250&bgset=bg1");
                    }
                    else if (rbBackground2.Checked)
                    {
                        if (rbRobot1.Checked)
                            pictureBox1.Load("https://robohash.org/" + textBox1.Text + "?set=set1&size=250x250&bgset=bg2");
                        if (rbRobot2.Checked)
                            pictureBox1.Load("https://robohash.org/" + textBox1.Text + "?set=set2&size=250x250&bgset=bg2");
                        if (rbRobot3.Checked)
                            pictureBox1.Load("https://robohash.org/" + textBox1.Text + "?set=set3&size=250x250&bgset=bg2");
                    }
                    else if (rbBackground3.Checked)
                    {
                        if (rbRobot1.Checked)
                            pictureBox1.Load("https://robohash.org/" + textBox1.Text + "?set=set1&size=250x250");
                        if (rbRobot2.Checked)
                            pictureBox1.Load("https://robohash.org/" + textBox1.Text + "?set=set2&size=250x250");
                        if (rbRobot3.Checked)
                            pictureBox1.Load("https://robohash.org/" + textBox1.Text + "?set=set3&size=250x250");
                    }
                }
            }
        }

        private void RobotImageGenerator_Load(object sender, EventArgs e)
        {
            rbRobot1.Checked = true; rbBackground3.Checked = true;
            textBox1.Text = Dns.GetHostName();
        }
    }
}