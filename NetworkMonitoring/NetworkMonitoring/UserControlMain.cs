using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using MetroFramework.Controls;
using System.Data.Entity;

namespace NetworkMonitoring
{
    public partial class UserControlMain : MetroFramework.Controls.MetroUserControl
    {
        MainFrom instance;
        List<ComputerInfo> ComputerInfos = new List<ComputerInfo>();
        public UserControlMain(MainFrom Instance, List<ComputerInfo> computerInfos)
        {
            instance = Instance;
            InitializeComponent();
            metroButton1.BackColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            this.ComputerInfos = computerInfos;          
            CreateUI();
        }

        private void UserControlMain_Load(object sender, EventArgs e)
        {
            

        }


        void CreateUI()
        {
            mPanelIpInfos.Controls.Clear();
            int y = 37;
            foreach (var c in ComputerInfos)
            {               

                MetroFramework.Controls.MetroLink mL = new MetroFramework.Controls.MetroLink();
                mL.Name = "mL" + c.Id;
                mL.Text = c.IpAddress;
                mL.Location = new Point(70, y);
                mL.Size = new Size(184, 29);
                mL.TextAlign = ContentAlignment.MiddleLeft;
                mL.FontSize = MetroFramework.MetroLinkSize.Tall;
                mL.Click += metroLink_Click;
                mPanelIpInfos.Controls.Add(mL);

                PictureBox pB = new PictureBox();
                pB.Name = "pB"+ c.Id;
                pB.Location = new Point(400, y+2);
                pB.Size = new Size(24, 24);
                if (c.Status == Status.online)
                {
                    pB.Image = new Bitmap(System.IO.Directory.GetCurrentDirectory()+ "\\Status-online-icon.png");
                }
                else
                {
                    pB.Image = new Bitmap(System.IO.Directory.GetCurrentDirectory() + "\\Status-offline-icon.png");
                }
                mPanelIpInfos.Controls.Add(pB);

                MetroFramework.Controls.MetroLabel mLabel = new MetroFramework.Controls.MetroLabel();
                mLabel.Name = "mLabel" + c.Id;
                mLabel.Text = c.Status.ToString();
                mLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
                mLabel.TextAlign = ContentAlignment.MiddleLeft;
                mLabel.Location = new Point(455,y);
                mPanelIpInfos.Controls.Add(mLabel);
                y += 35;        
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            mPanelIpInfos.Controls.Clear();          
            MetroProgressSpinner progressSpinner = new MetroProgressSpinner();
            progressSpinner.Location = new Point(209, 25);
            progressSpinner.Size = new Size(165, 165);
            progressSpinner.Style = instance.metroStyleManager1.Style;
            mPanelIpInfos.Controls.Add(progressSpinner);
            backgroundWorker1.RunWorkerAsync();
            MetroLabel mLabel = new MetroLabel();
            mLabel.Location = new Point(255, 200);
            mLabel.Text = "Wait please";
            mPanelIpInfos.Controls.Add(mLabel);
        }

        private void metroLink_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroLink ml= (MetroFramework.Controls.MetroLink)sender;

            instance.MetroContainer.Controls.Clear();
            UserControlPortScaner userControlPortScaner = new UserControlPortScaner(ml.Text, instance);
            userControlPortScaner.Dock = DockStyle.Fill;
            instance.MetroContainer.Controls.Add(userControlPortScaner);
            instance.MetroContainer.Controls["UserControlPortScaner"].BringToFront();
            instance.MetroBack.Visible = true;
            instance.MetroSettings.Visible = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var c in ComputerInfos)
            {
                
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
            CreateUI();
            this.Refresh();
        }
    }
}
