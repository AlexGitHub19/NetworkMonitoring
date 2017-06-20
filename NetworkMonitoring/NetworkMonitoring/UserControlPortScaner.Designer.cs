namespace NetworkMonitoring
{
    partial class UserControlPortScaner
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
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            this.mLabelChoose = new MetroFramework.Controls.MetroLabel();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mButtonStart = new MetroFramework.Controls.MetroButton();
            this.metroLabelIp = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownStart.Location = new System.Drawing.Point(128, 72);
            this.numericUpDownStart.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(70, 24);
            this.numericUpDownStart.TabIndex = 0;
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownEnd.Location = new System.Drawing.Point(251, 72);
            this.numericUpDownEnd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(63, 24);
            this.numericUpDownEnd.TabIndex = 1;
            // 
            // mLabelChoose
            // 
            this.mLabelChoose.AutoSize = true;
            this.mLabelChoose.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabelChoose.Location = new System.Drawing.Point(164, 25);
            this.mLabelChoose.Name = "mLabelChoose";
            this.mLabelChoose.Size = new System.Drawing.Size(254, 25);
            this.mLabelChoose.TabIndex = 2;
            this.mLabelChoose.Text = "Choose range for port scanning";
            // 
            // listBoxResult
            // 
            this.listBoxResult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 18;
            this.listBoxResult.Location = new System.Drawing.Point(31, 102);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(545, 238);
            this.listBoxResult.TabIndex = 3;
            this.listBoxResult.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxResult_DrawItem);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // mButtonStart
            // 
            this.mButtonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.mButtonStart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mButtonStart.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mButtonStart.ForeColor = System.Drawing.SystemColors.Window;
            this.mButtonStart.Location = new System.Drawing.Point(376, 71);
            this.mButtonStart.Name = "mButtonStart";
            this.mButtonStart.Size = new System.Drawing.Size(100, 25);
            this.mButtonStart.TabIndex = 4;
            this.mButtonStart.Text = "Scan";
            this.mButtonStart.UseCustomBackColor = true;
            this.mButtonStart.UseCustomForeColor = true;
            this.mButtonStart.UseSelectable = true;
            this.mButtonStart.Click += new System.EventHandler(this.mButtonStart_Click);
            // 
            // metroLabelIp
            // 
            this.metroLabelIp.AutoSize = true;
            this.metroLabelIp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelIp.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelIp.Location = new System.Drawing.Point(230, 0);
            this.metroLabelIp.Name = "metroLabelIp";
            this.metroLabelIp.Size = new System.Drawing.Size(29, 25);
            this.metroLabelIp.TabIndex = 5;
            this.metroLabelIp.Text = "Ip";
            // 
            // UserControlPortScaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.metroLabelIp);
            this.Controls.Add(this.mButtonStart);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.mLabelChoose);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.numericUpDownStart);
            this.Name = "UserControlPortScaner";
            this.Size = new System.Drawing.Size(614, 390);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
        private MetroFramework.Controls.MetroLabel mLabelChoose;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroButton mButtonStart;
        private MetroFramework.Controls.MetroLabel metroLabelIp;
    }
}
