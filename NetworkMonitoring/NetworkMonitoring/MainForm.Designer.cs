namespace NetworkMonitoring
{
    partial class MainFrom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mLBack = new MetroFramework.Controls.MetroLink();
            this.mLSettings = new MetroFramework.Controls.MetroLink();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mPanel
            // 
            this.mPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(40, 79);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(614, 390);
            this.mPanel.TabIndex = 9;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // mLBack
            // 
            this.mLBack.Image = global::NetworkMonitoring.Properties.Resources._1497490034_back_left_arrow_botton;
            this.mLBack.ImageSize = 28;
            this.mLBack.Location = new System.Drawing.Point(5, 21);
            this.mLBack.Name = "mLBack";
            this.mLBack.Size = new System.Drawing.Size(32, 33);
            this.mLBack.TabIndex = 8;
            this.mLBack.UseSelectable = true;
            this.mLBack.Click += new System.EventHandler(this.mLBack_Click);
            // 
            // mLSettings
            // 
            this.mLSettings.Image = global::NetworkMonitoring.Properties.Resources._1497489863_ic_settings_48px;
            this.mLSettings.ImageSize = 32;
            this.mLSettings.Location = new System.Drawing.Point(38, 22);
            this.mLSettings.Name = "mLSettings";
            this.mLSettings.Size = new System.Drawing.Size(32, 32);
            this.mLSettings.TabIndex = 7;
            this.mLSettings.UseSelectable = true;
            this.mLSettings.Click += new System.EventHandler(this.mLSettings_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 3600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 492);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mLBack);
            this.Controls.Add(this.mLSettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainFrom";
            this.Padding = new System.Windows.Forms.Padding(20, 111, 20, 20);
            this.Resizable = false;
            this.Text = "         NetworkMonitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink mLSettings;
        private MetroFramework.Controls.MetroLink mLBack;
        private MetroFramework.Controls.MetroPanel mPanel;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}

