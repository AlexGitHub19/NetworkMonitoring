using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Net;
using System.Net.NetworkInformation;
using System.Data.Entity;

namespace NetworkMonitoring
{
    public partial class MainFrom : MetroForm
    {
        List<ComputerInfo> ComputerInfos;
        static MainFrom instance;
        public static MainFrom Instance
        {           
            get
            {
                if (instance == null)
                {
                    instance = new MainFrom();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public Timer Timer
        {
            get { return timer1; }
            set { timer1 = value; }
        }
        public MetroPanel MetroContainer
        {
            get { return mPanel; }
            set { mPanel = value; }

        }
        public MetroLink MetroBack
        {
            get { return mLBack; }
            set { mLBack = value; }
        }
        public MetroLink MetroSettings
        {
            get { return mLSettings; }
            set { mLSettings = value; }
        }
        
        public MainFrom()
        {          
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            ComputerInfos = new List<ComputerInfo>();
            try
            {
                ComputerInfos = new Context().ComputerInfos.ToList();
            }
            catch (Exception exeption)
            {

            }         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mLBack.Visible = false;
            
            try
            {
                ComputerInfos = new Context().ComputerInfos.ToList();
            }
            catch (Exception exeption)
            {

            }        
            MetroProgressSpinner progressSpinner= new MetroProgressSpinner();
            progressSpinner.Location = new Point(209, 65);
            progressSpinner.Size = new Size(165, 165);
            progressSpinner.Style = metroStyleManager1.Style;
            mPanel.Controls.Add(progressSpinner);
            MetroLabel mLabel = new MetroLabel();
            mLabel.Location = new Point(255,260);
            mLabel.Text = "Wait please";
            mPanel.Controls.Add(mLabel);
            backgroundWorker1.RunWorkerAsync();
        }

        private void mLBack_Click(object sender, EventArgs e)
        {
            mPanel.Controls.Clear();
            List<ComputerInfo> ComputerInfos = new List<ComputerInfo>();
            try
            {
                ComputerInfos = new Context().ComputerInfos.ToList();
            }
            catch (Exception exeption)
            {

            }
            UserControlMain userControlMain = new UserControlMain(this, ComputerInfos);
            userControlMain.Dock = DockStyle.Fill;
            mPanel.Controls.Add(userControlMain);
            mPanel.Controls["UserControlMain"].BringToFront();
            mLBack.Visible = false;
            mLSettings.Visible = true;
        }

        private void mLSettings_Click(object sender, EventArgs e)
        {
            mPanel.Controls.Clear();
            UserControlSettings userControlSettings = new UserControlSettings(this);
            userControlSettings.Dock = DockStyle.Fill;
            mPanel.Controls.Add(userControlSettings);          
            mPanel.Controls["UserControlSettings"].BringToFront();
            mLBack.Visible = true;         
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var c in ComputerInfos)
            {
                c.Status = Status.offline;
                try
                {
                    string ipAddress = c.IpAddress;
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(ipAddress);
                    if (reply.Status == IPStatus.Success)
                    {
                        c.Status = Status.online;
                        Context context = new Context();
                        context.Entry(c).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    else
                    {
                        c.Status = Status.offline;
                        Context context = new Context();
                        context.Entry(c).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                }
                catch (PingException exeption)
                {
                }
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mPanel.Controls.Clear();
            UserControlMain userControlMain = new UserControlMain(this, ComputerInfos);
            userControlMain.Dock = DockStyle.Fill;
            mPanel.Controls.Add(userControlMain);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mPanel.Controls.Clear();
            MetroProgressSpinner progressSpinner = new MetroProgressSpinner();
            progressSpinner.Location = new Point(209, 65);
            progressSpinner.Size = new Size(165, 165);
            progressSpinner.Style = metroStyleManager1.Style;
            mPanel.Controls.Add(progressSpinner);
            MetroLabel mLabel = new MetroLabel();
            mLabel.Location = new Point(255, 260);
            mLabel.Text = "Wait please";
            mPanel.Controls.Add(mLabel);
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
