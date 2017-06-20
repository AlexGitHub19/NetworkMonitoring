namespace NetworkMonitoring
{
    partial class UserControlSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mTSettings = new MetroFramework.Controls.MetroTabControl();
            this.mTIpSettings = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabelDeleteStatus = new MetroFramework.Controls.MetroLabel();
            this.mButtonDeleteIp = new MetroFramework.Controls.MetroButton();
            this.mComboBoxIpList = new MetroFramework.Controls.MetroComboBox();
            this.mLDeleteIp = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabelStatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mButtonAddIp = new MetroFramework.Controls.MetroButton();
            this.mTextBoxIp = new MetroFramework.Controls.MetroTextBox();
            this.mLAddIp = new MetroFramework.Controls.MetroLabel();
            this.mTSystemSettings = new MetroFramework.Controls.MetroTabPage();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mComboBoxColor = new MetroFramework.Controls.MetroComboBox();
            this.mLabelChangeColor = new MetroFramework.Controls.MetroLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metroLabelEnterPeriod = new MetroFramework.Controls.MetroLabel();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.metroLabelMin = new MetroFramework.Controls.MetroLabel();
            this.metroButtonEnable = new MetroFramework.Controls.MetroButton();
            this.mTSettings.SuspendLayout();
            this.mTIpSettings.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.mTSystemSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // mTSettings
            // 
            this.mTSettings.Controls.Add(this.mTIpSettings);
            this.mTSettings.Controls.Add(this.mTSystemSettings);
            this.mTSettings.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.mTSettings.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mTSettings.Location = new System.Drawing.Point(3, 3);
            this.mTSettings.Multiline = true;
            this.mTSettings.Name = "mTSettings";
            this.mTSettings.SelectedIndex = 1;
            this.mTSettings.Size = new System.Drawing.Size(590, 365);
            this.mTSettings.TabIndex = 0;
            this.mTSettings.UseSelectable = true;
            // 
            // mTIpSettings
            // 
            this.mTIpSettings.BackColor = System.Drawing.SystemColors.Control;
            this.mTIpSettings.Controls.Add(this.metroPanel2);
            this.mTIpSettings.Controls.Add(this.metroPanel1);
            this.mTIpSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTIpSettings.HorizontalScrollbarBarColor = true;
            this.mTIpSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.mTIpSettings.HorizontalScrollbarSize = 10;
            this.mTIpSettings.Location = new System.Drawing.Point(4, 44);
            this.mTIpSettings.Name = "mTIpSettings";
            this.mTIpSettings.Size = new System.Drawing.Size(582, 317);
            this.mTIpSettings.TabIndex = 0;
            this.mTIpSettings.Text = "IpSettings                                       ";
            this.mTIpSettings.VerticalScrollbarBarColor = true;
            this.mTIpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.mTIpSettings.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroLabelDeleteStatus);
            this.metroPanel2.Controls.Add(this.mButtonDeleteIp);
            this.metroPanel2.Controls.Add(this.mComboBoxIpList);
            this.metroPanel2.Controls.Add(this.mLDeleteIp);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 170);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(582, 136);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabelDeleteStatus
            // 
            this.metroLabelDeleteStatus.AutoSize = true;
            this.metroLabelDeleteStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelDeleteStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelDeleteStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.metroLabelDeleteStatus.Location = new System.Drawing.Point(233, 103);
            this.metroLabelDeleteStatus.Name = "metroLabelDeleteStatus";
            this.metroLabelDeleteStatus.Size = new System.Drawing.Size(115, 25);
            this.metroLabelDeleteStatus.TabIndex = 8;
            this.metroLabelDeleteStatus.Text = "Not Sucess!!!";
            this.metroLabelDeleteStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabelDeleteStatus.UseCustomForeColor = true;
            // 
            // mButtonDeleteIp
            // 
            this.mButtonDeleteIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.mButtonDeleteIp.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mButtonDeleteIp.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mButtonDeleteIp.ForeColor = System.Drawing.SystemColors.Control;
            this.mButtonDeleteIp.Location = new System.Drawing.Point(320, 61);
            this.mButtonDeleteIp.Name = "mButtonDeleteIp";
            this.mButtonDeleteIp.Size = new System.Drawing.Size(139, 35);
            this.mButtonDeleteIp.Style = MetroFramework.MetroColorStyle.Blue;
            this.mButtonDeleteIp.TabIndex = 6;
            this.mButtonDeleteIp.Text = "Delete Ip";
            this.mButtonDeleteIp.UseCustomBackColor = true;
            this.mButtonDeleteIp.UseCustomForeColor = true;
            this.mButtonDeleteIp.UseSelectable = true;
            this.mButtonDeleteIp.Click += new System.EventHandler(this.mButtonDeleteIp_Click);
            // 
            // mComboBoxIpList
            // 
            this.mComboBoxIpList.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mComboBoxIpList.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.mComboBoxIpList.FormattingEnabled = true;
            this.mComboBoxIpList.ItemHeight = 29;
            this.mComboBoxIpList.Location = new System.Drawing.Point(121, 61);
            this.mComboBoxIpList.Name = "mComboBoxIpList";
            this.mComboBoxIpList.Size = new System.Drawing.Size(139, 35);
            this.mComboBoxIpList.TabIndex = 3;
            this.mComboBoxIpList.UseSelectable = true;
            // 
            // mLDeleteIp
            // 
            this.mLDeleteIp.AutoSize = true;
            this.mLDeleteIp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLDeleteIp.Location = new System.Drawing.Point(228, 11);
            this.mLDeleteIp.Name = "mLDeleteIp";
            this.mLDeleteIp.Size = new System.Drawing.Size(79, 25);
            this.mLDeleteIp.TabIndex = 2;
            this.mLDeleteIp.Text = "Delete Ip";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabelStatus);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.mButtonAddIp);
            this.metroPanel1.Controls.Add(this.mTextBoxIp);
            this.metroPanel1.Controls.Add(this.mLAddIp);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 16);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(582, 136);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabelStatus
            // 
            this.metroLabelStatus.AutoSize = true;
            this.metroLabelStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.metroLabelStatus.Location = new System.Drawing.Point(234, 103);
            this.metroLabelStatus.Name = "metroLabelStatus";
            this.metroLabelStatus.Size = new System.Drawing.Size(115, 25);
            this.metroLabelStatus.TabIndex = 7;
            this.metroLabelStatus.Text = "Not Sucess!!!";
            this.metroLabelStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabelStatus.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(178, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 6;
            // 
            // mButtonAddIp
            // 
            this.mButtonAddIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.mButtonAddIp.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mButtonAddIp.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mButtonAddIp.ForeColor = System.Drawing.SystemColors.Control;
            this.mButtonAddIp.Location = new System.Drawing.Point(320, 56);
            this.mButtonAddIp.Name = "mButtonAddIp";
            this.mButtonAddIp.Size = new System.Drawing.Size(139, 30);
            this.mButtonAddIp.Style = MetroFramework.MetroColorStyle.Blue;
            this.mButtonAddIp.TabIndex = 5;
            this.mButtonAddIp.Text = "Add Ip";
            this.mButtonAddIp.UseCustomBackColor = true;
            this.mButtonAddIp.UseCustomForeColor = true;
            this.mButtonAddIp.UseSelectable = true;
            this.mButtonAddIp.Click += new System.EventHandler(this.mButtonAddIp_Click);
            // 
            // mTextBoxIp
            // 
            // 
            // 
            // 
            this.mTextBoxIp.CustomButton.Image = null;
            this.mTextBoxIp.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.mTextBoxIp.CustomButton.Name = "";
            this.mTextBoxIp.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTextBoxIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextBoxIp.CustomButton.TabIndex = 1;
            this.mTextBoxIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextBoxIp.CustomButton.UseSelectable = true;
            this.mTextBoxIp.CustomButton.Visible = false;
            this.mTextBoxIp.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mTextBoxIp.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.mTextBoxIp.Lines = new string[0];
            this.mTextBoxIp.Location = new System.Drawing.Point(121, 56);
            this.mTextBoxIp.MaxLength = 32767;
            this.mTextBoxIp.Name = "mTextBoxIp";
            this.mTextBoxIp.PasswordChar = '\0';
            this.mTextBoxIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextBoxIp.SelectedText = "";
            this.mTextBoxIp.SelectionLength = 0;
            this.mTextBoxIp.SelectionStart = 0;
            this.mTextBoxIp.ShortcutsEnabled = true;
            this.mTextBoxIp.Size = new System.Drawing.Size(139, 30);
            this.mTextBoxIp.TabIndex = 3;
            this.mTextBoxIp.UseSelectable = true;
            this.mTextBoxIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextBoxIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLAddIp
            // 
            this.mLAddIp.AutoSize = true;
            this.mLAddIp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLAddIp.Location = new System.Drawing.Point(240, 12);
            this.mLAddIp.Name = "mLAddIp";
            this.mLAddIp.Size = new System.Drawing.Size(98, 25);
            this.mLAddIp.TabIndex = 2;
            this.mLAddIp.Text = "Add new Ip";
            // 
            // mTSystemSettings
            // 
            this.mTSystemSettings.Controls.Add(this.metroLabelMin);
            this.mTSystemSettings.Controls.Add(this.metroButtonEnable);
            this.mTSystemSettings.Controls.Add(this.numericUpDownPeriod);
            this.mTSystemSettings.Controls.Add(this.metroLabelEnterPeriod);
            this.mTSystemSettings.Controls.Add(this.metroToggle1);
            this.mTSystemSettings.Controls.Add(this.metroLabel2);
            this.mTSystemSettings.Controls.Add(this.mComboBoxColor);
            this.mTSystemSettings.Controls.Add(this.mLabelChangeColor);
            this.mTSystemSettings.HorizontalScrollbarBarColor = true;
            this.mTSystemSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.mTSystemSettings.HorizontalScrollbarSize = 10;
            this.mTSystemSettings.Location = new System.Drawing.Point(4, 44);
            this.mTSystemSettings.Name = "mTSystemSettings";
            this.mTSystemSettings.Size = new System.Drawing.Size(582, 317);
            this.mTSystemSettings.TabIndex = 1;
            this.mTSystemSettings.Text = "SystemSettings                                ";
            this.mTSystemSettings.VerticalScrollbarBarColor = true;
            this.mTSystemSettings.VerticalScrollbarHighlightOnWheel = false;
            this.mTSystemSettings.VerticalScrollbarSize = 10;
            // 
            // metroToggle1
            // 
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle1.Location = new System.Drawing.Point(480, 119);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(83, 26);
            this.metroToggle1.TabIndex = 8;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckStateChanged += new System.EventHandler(this.metroToggle1_CheckStateChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(21, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(433, 26);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Enable timer for periodic checking computer statusses";
            // 
            // mComboBoxColor
            // 
            this.mComboBoxColor.FormattingEnabled = true;
            this.mComboBoxColor.ItemHeight = 23;
            this.mComboBoxColor.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.mComboBoxColor.Location = new System.Drawing.Point(158, 51);
            this.mComboBoxColor.Name = "mComboBoxColor";
            this.mComboBoxColor.Size = new System.Drawing.Size(121, 29);
            this.mComboBoxColor.TabIndex = 3;
            this.mComboBoxColor.UseSelectable = true;
            this.mComboBoxColor.SelectedIndexChanged += new System.EventHandler(this.mComboBoxColor_SelectedIndexChanged);
            // 
            // mLabelChangeColor
            // 
            this.mLabelChangeColor.AutoSize = true;
            this.mLabelChangeColor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabelChangeColor.Location = new System.Drawing.Point(21, 55);
            this.mLabelChangeColor.Name = "mLabelChangeColor";
            this.mLabelChangeColor.Size = new System.Drawing.Size(114, 25);
            this.mLabelChangeColor.TabIndex = 2;
            this.mLabelChangeColor.Text = "Change color";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // metroLabelEnterPeriod
            // 
            this.metroLabelEnterPeriod.AutoSize = true;
            this.metroLabelEnterPeriod.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelEnterPeriod.Location = new System.Drawing.Point(259, 171);
            this.metroLabelEnterPeriod.Name = "metroLabelEnterPeriod";
            this.metroLabelEnterPeriod.Size = new System.Drawing.Size(109, 25);
            this.metroLabelEnterPeriod.TabIndex = 9;
            this.metroLabelEnterPeriod.Text = "Enter period:";
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPeriod.Location = new System.Drawing.Point(378, 172);
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(48, 24);
            this.numericUpDownPeriod.TabIndex = 10;
            // 
            // metroLabelMin
            // 
            this.metroLabelMin.AutoSize = true;
            this.metroLabelMin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMin.Location = new System.Drawing.Point(428, 171);
            this.metroLabelMin.Name = "metroLabelMin";
            this.metroLabelMin.Size = new System.Drawing.Size(41, 25);
            this.metroLabelMin.TabIndex = 12;
            this.metroLabelMin.Text = "min";
            // 
            // metroButtonEnable
            // 
            this.metroButtonEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.metroButtonEnable.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonEnable.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButtonEnable.ForeColor = System.Drawing.SystemColors.Control;
            this.metroButtonEnable.Location = new System.Drawing.Point(486, 171);
            this.metroButtonEnable.Name = "metroButtonEnable";
            this.metroButtonEnable.Size = new System.Drawing.Size(77, 25);
            this.metroButtonEnable.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonEnable.TabIndex = 11;
            this.metroButtonEnable.Text = "Enable";
            this.metroButtonEnable.UseCustomBackColor = true;
            this.metroButtonEnable.UseCustomForeColor = true;
            this.metroButtonEnable.UseSelectable = true;
            this.metroButtonEnable.Click += new System.EventHandler(this.metroButtonEnable_Click);
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.mTSettings);
            this.Name = "UserControlSettings";
            this.Size = new System.Drawing.Size(614, 390);
            this.mTSettings.ResumeLayout(false);
            this.mTIpSettings.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.mTSystemSettings.ResumeLayout(false);
            this.mTSystemSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTSettings;
        private MetroFramework.Controls.MetroTabPage mTIpSettings;
        private MetroFramework.Controls.MetroTabPage mTSystemSettings;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel mLDeleteIp;
        private MetroFramework.Controls.MetroTextBox mTextBoxIp;
        private MetroFramework.Controls.MetroLabel mLAddIp;
        private MetroFramework.Controls.MetroButton mButtonAddIp;
        private MetroFramework.Controls.MetroComboBox mComboBoxIpList;
        private MetroFramework.Controls.MetroButton mButtonDeleteIp;
        public MetroFramework.Controls.MetroComboBox mComboBoxColor;
        private MetroFramework.Controls.MetroLabel mLabelChangeColor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelStatus;
        private MetroFramework.Controls.MetroLabel metroLabelDeleteStatus;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private MetroFramework.Controls.MetroLabel metroLabelEnterPeriod;
        private MetroFramework.Controls.MetroLabel metroLabelMin;
        private MetroFramework.Controls.MetroButton metroButtonEnable;
    }
}
