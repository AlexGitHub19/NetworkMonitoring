namespace NetworkMonitoring
{
    partial class UserControlMain
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
            this.mLabelIpAddresses = new MetroFramework.Controls.MetroLabel();
            this.mPanelIpInfos = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // mLabelIpAddresses
            // 
            this.mLabelIpAddresses.AutoSize = true;
            this.mLabelIpAddresses.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabelIpAddresses.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mLabelIpAddresses.Location = new System.Drawing.Point(246, 17);
            this.mLabelIpAddresses.Name = "mLabelIpAddresses";
            this.mLabelIpAddresses.Size = new System.Drawing.Size(112, 25);
            this.mLabelIpAddresses.TabIndex = 1;
            this.mLabelIpAddresses.Text = "Ip addresses";
            // 
            // mPanelIpInfos
            // 
            this.mPanelIpInfos.AutoScroll = true;
            this.mPanelIpInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanelIpInfos.HorizontalScrollbar = true;
            this.mPanelIpInfos.HorizontalScrollbarBarColor = true;
            this.mPanelIpInfos.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelIpInfos.HorizontalScrollbarSize = 10;
            this.mPanelIpInfos.Location = new System.Drawing.Point(3, 51);
            this.mPanelIpInfos.Name = "mPanelIpInfos";
            this.mPanelIpInfos.Size = new System.Drawing.Size(608, 287);
            this.mPanelIpInfos.TabIndex = 2;
            this.mPanelIpInfos.VerticalScrollbar = true;
            this.mPanelIpInfos.VerticalScrollbarBarColor = true;
            this.mPanelIpInfos.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelIpInfos.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.Window;
            this.metroButton1.Location = new System.Drawing.Point(246, 344);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 33);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Refresh";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // UserControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mPanelIpInfos);
            this.Controls.Add(this.mLabelIpAddresses);
            this.Name = "UserControlMain";
            this.Size = new System.Drawing.Size(614, 390);
            this.Load += new System.EventHandler(this.UserControlMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mLabelIpAddresses;
        private MetroFramework.Controls.MetroPanel mPanelIpInfos;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
