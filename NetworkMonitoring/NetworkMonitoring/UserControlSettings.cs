using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NetworkMonitoring
{
    public partial class UserControlSettings : UserControl
    {
        bool timerIsEnabled;
        static MainFrom instance;
        public UserControlSettings(MainFrom Instance)
        {
            timerIsEnabled = false;
            InitializeComponent();
            instance = Instance;         
            metroLabelStatus.Text = String.Empty;
            metroLabelDeleteStatus.Text = String.Empty;
            toolTip1.SetToolTip(this.metroLabel2, "Current period: "+ instance.Timer.Interval/1000/60+" minutes");

            metroLabelEnterPeriod.Visible = false;
            numericUpDownPeriod.Visible = false;
            metroLabelMin.Visible = false;
            metroButtonEnable.Visible = false;

            mComboBoxIpList.DataSource = new Context().ComputerInfos.ToList();
            mComboBoxIpList.DisplayMember = "IpAddress";
            mComboBoxIpList.ValueMember = "IpAddress";

            mTSettings.Style = instance.metroStyleManager1.Style;
            metroToggle1.Style = instance.metroStyleManager1.Style;
            mComboBoxColor.BackColor = Color.White;
            metroButtonEnable.BackColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            mButtonAddIp.BackColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            mButtonDeleteIp.BackColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            metroLabelStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            metroLabelDeleteStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            metroButtonEnable.BackColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
        }

        private void mComboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            instance.metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(mComboBoxColor.SelectedIndex);
            mTSettings.Style = instance.metroStyleManager1.Style;
            metroToggle1.Style = instance.metroStyleManager1.Style;
            metroButtonEnable.BackColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            mButtonAddIp.BackColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            mButtonDeleteIp.BackColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            metroLabelStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            metroLabelDeleteStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            metroButtonEnable.ForeColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            this.Refresh();
        }

        private void mButtonAddIp_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            ComputerInfo compInfo = new ComputerInfo();
            Regex regIP = new Regex(@"\b(([01]?\d?\d|2[0-4]\d|25[0-5])\.){3}([01]?\d?\d|2[0-4]\d|25[0-5])\b");
            if (regIP.IsMatch(mTextBoxIp.Text))
            {
                compInfo.IpAddress = mTextBoxIp.Text;
                compInfo.Status = Status.offline;
                context.ComputerInfos.Add(compInfo);
                context.SaveChanges();
                mComboBoxIpList.DataSource = new Context().ComputerInfos.ToList();
                metroLabelStatus.Location = new Point(255, 103);
                metroLabelStatus.Text = "Sucess!";
                mTextBoxIp.Text = String.Empty;
                metroLabelStatus.Visible = true;
            }
            else
            {
                metroLabelStatus.Location = new Point(233,103);
                metroLabelStatus.Text = "Not Sucess!!!";
                metroLabelStatus.Visible = true;
            }
        }

        private void mButtonDeleteIp_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            ComputerInfo compInfo = context.ComputerInfos.First(c => c.IpAddress == mComboBoxIpList.Text);
            if (compInfo != null)
            {
                context.ComputerInfos.Remove(compInfo);
                context.SaveChanges();
                mComboBoxIpList.DataSource = new Context().ComputerInfos.ToList();
                metroLabelDeleteStatus.Location = new Point(255, 103);
                metroLabelDeleteStatus.Text = "Sucess!";
                metroLabelDeleteStatus.Visible = true;
            }
            else
            {
                metroLabelDeleteStatus.Location = new Point(233, 103);
                metroLabelDeleteStatus.Text = "Not Sucess!!!";
                metroLabelDeleteStatus.Visible = true;

            }
        }

        private void metroToggle1_CheckStateChanged(object sender, EventArgs e)
        {
            if (timerIsEnabled == false)
            {
                if (metroToggle1.Checked == true)
                {
                    metroLabelEnterPeriod.Visible = true;
                    numericUpDownPeriod.Visible = true;
                    metroLabelMin.Visible = true;
                    metroButtonEnable.Visible = true;
                    metroToggle1.Checked = false;
                }

            }
            else
            {
                if (metroToggle1.Checked == false)
                {
                    instance.Timer.Enabled = false;
                    timerIsEnabled = false;
                }

            }
           
        }

        private void metroButtonEnable_Click(object sender, EventArgs e)
        {
            metroLabelEnterPeriod.Visible = false;
            numericUpDownPeriod.Visible = false;
            metroLabelMin.Visible = false;
            metroButtonEnable.Visible = false;
            timerIsEnabled = true;
            if (numericUpDownPeriod.Value != 0)
            {
                instance.Timer.Interval = (int)numericUpDownPeriod.Value * 1000 * 60;
            }          
            instance.Timer.Enabled = true;
            metroToggle1.Checked = true;
            toolTip1.RemoveAll();
            toolTip1.SetToolTip(this.metroLabel2, "Current period: " + instance.Timer.Interval / 1000 / 60 + " minutes");
        }
    }
}
