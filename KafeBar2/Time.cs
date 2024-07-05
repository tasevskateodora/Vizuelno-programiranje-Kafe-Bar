using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeBar2
{
    public partial class Time : Form
    {
        private Timer timer;
        private int timeRemaining;
        private const int totalTime = 10 * 60; 

        public Time()
        {
            InitializeComponent();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeRemaining > 0)
            {
                timeRemaining--;
                TimeSpan timeSpan = TimeSpan.FromSeconds(timeRemaining);
                lblTimer.Text = timeSpan.ToString(@"mm\:ss");
                pbTime.Value = timeRemaining;
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Нарачката пристигнува!");
            }
        }

        private void Time_Load(object sender, EventArgs e)
        {
            timeRemaining = totalTime; 
            pbTime.Maximum = totalTime;
            pbTime.Value = totalTime;
            pbTime.Step = 1; 
            pbTime.ForeColor = System.Drawing.Color.Green;
            pbTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

           
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += timer1_Tick;
            timer.Start();
        }
    }
}
