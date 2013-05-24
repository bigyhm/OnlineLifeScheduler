using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLifeScheduler
{
    public partial class OnlineLifeScheduler : Form
    {
        public string startWorkTime = string.Empty;
        public string endWorkTime = string.Empty;
        public string timeInTotal = string.Empty;

        public OnlineLifeScheduler()
        {
            InitializeComponent();
        }

        private void OnlineLifeScheduler_Load(object sender, EventArgs e)
        {            
            labelYear.Text = DateTime.Now.Year.ToString();
            labelMonth.Text = DateTime.Now.Month.ToString();
            labelDay.Text = DateTime.Now.Day.ToString();
            labelWeekDate.Text = DateTime.Now.DayOfWeek.ToString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timerClickTime_Tick(object sender, EventArgs e)
        {
            OnlineLifeScheduler_Load(sender, null);
        }

        private void buttonStartWork_Click(object sender, EventArgs e)
        {
            if (buttonStartWork.BackColor == Color.Gainsboro)
            {
                MessageBox.Show("You have already start your work, if you want to restart your work, please restart the App.");
            }
            else
            {
                buttonStartWork.BackColor = Color.Gainsboro;
                buttonStartWork.ForeColor = Color.Black;
                startWorkTime = DateTime.Now.ToLongTimeString();
                labelStartWorkTime.Text = startWorkTime;
            }
        }

        private void buttonEndWork_Click(object sender, EventArgs e)
        {
            if (startWorkTime == null || startWorkTime == string.Empty)
            {
                MessageBox.Show("Please click \"start work at\" button to set the start Work Time");
            }
            else
            {
                timerClickEvent.Start();
                DateTime startTime = DateTime.Parse(startWorkTime);
                DateTime endTime = new DateTime();

                try
                {
                    endTime = DateTime.Parse(comboBoxEndTime.Text.ToString());
                }
                catch
                {
                    timerClickEvent.Stop();
                    MessageBox.Show("Wrong Time format.");
                }
                if (endTime > DateTime.Now)
                {
                    string scheduledLeftTime = (endTime - DateTime.Now).ToString().Substring(0, 8);
                    timeInTotal = (endTime - DateTime.Parse(startWorkTime)).ToString().Substring(0, 8);
                    if (labelTimeInTotal.Text == "00:00:00" || labelTimeInTotal.Text != timeInTotal.ToString())
                    {
                        labelTimeInTotal.Text = timeInTotal;
                    }

                    if (scheduledLeftTime.Contains('-'))
                    {
                        labelTimeLeft.Text = "00:00:00";
                        labelTimeLeft.BackColor = Color.DarkRed;
                        labelTimeLeft.ForeColor = Color.White;
                    }
                    else
                    {
                        labelTimeLeft.Text = scheduledLeftTime;
                        if (DateTime.Parse(scheduledLeftTime) < DateTime.Parse("00:45:00")) 
                        {
                            labelTimeLeft.BackColor = Color.DarkRed;
                            labelTimeLeft.ForeColor = Color.White;
                        }
                    }

                    if (labelTimeLeft.Text == "00:00:00")
                    {
                        Process p = new Process();

                        p.StartInfo.FileName = "cmd.exe";

                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardInput = true;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.Verb = "runas";
                        p.Start();
                        p.StandardInput.WriteLine("shutdown.exe /s /f /t 0");

                        p.StandardInput.WriteLine("exit");

                        string strOutput = p.StandardOutput.ReadToEnd();
                        Console.WriteLine(strOutput);
                        Console.ReadKey();

                        p.WaitForExit();
                        p.Close();
                    }
                    if (DateTime.Now.ToLongTimeString().Substring(3, 5) == "00:00")
                    {
                        MessageBox.Show("Life has flowed an hour.");
                    }
                }
                else
                {
                    labelTimeLeft.Text = "00:00:00";
                }
            }
        }

        private void timerClickEvent_Tick(object sender, EventArgs e)
        {
            if (comboBoxEndTime.Text == string.Empty || comboBoxEndTime.Text == null)
            {
                comboBoxEndTime.Text = "23:59:59";
            }
            else
            {
                buttonEndWork_Click(sender, null);
            }
        }

        private void forceToShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cina = new OnlineLifeSchedulerSettings();
            cina.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact David.");
        }

        private void explationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Your computer will be forced to be down when time is up,if you have choose to use the Ice virus, the resources of your computer will be cost up and shutdown, your computer will be crashed.");
        }
    }
}
