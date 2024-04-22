namespace NMBSTracker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FromStation = new System.Windows.Forms.ComboBox();
            this.ToStation = new System.Windows.Forms.ComboBox();
            this.DepartHour = new System.Windows.Forms.ComboBox();
            this.DepartMinute = new System.Windows.Forms.ComboBox();
            this.DelayNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LblVersion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Intervals = new System.Windows.Forms.ComboBox();
            this.LblTrainFrom = new System.Windows.Forms.Label();
            this.LblTrainTo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FromStation
            // 
            this.FromStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.FromStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FromStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.FromStation.FormattingEnabled = true;
            this.FromStation.Location = new System.Drawing.Point(75, 16);
            this.FromStation.Name = "FromStation";
            this.FromStation.Size = new System.Drawing.Size(173, 21);
            this.FromStation.TabIndex = 0;
            // 
            // ToStation
            // 
            this.ToStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ToStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ToStation.FormattingEnabled = true;
            this.ToStation.Location = new System.Drawing.Point(75, 43);
            this.ToStation.Name = "ToStation";
            this.ToStation.Size = new System.Drawing.Size(173, 21);
            this.ToStation.TabIndex = 1;
            // 
            // DepartHour
            // 
            this.DepartHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.DepartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartHour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepartHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.DepartHour.FormattingEnabled = true;
            this.DepartHour.Location = new System.Drawing.Point(75, 73);
            this.DepartHour.Name = "DepartHour";
            this.DepartHour.Size = new System.Drawing.Size(75, 21);
            this.DepartHour.TabIndex = 2;
            // 
            // DepartMinute
            // 
            this.DepartMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.DepartMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartMinute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepartMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.DepartMinute.FormattingEnabled = true;
            this.DepartMinute.Location = new System.Drawing.Point(173, 73);
            this.DepartMinute.Name = "DepartMinute";
            this.DepartMinute.Size = new System.Drawing.Size(75, 21);
            this.DepartMinute.TabIndex = 3;
            // 
            // DelayNotification
            // 
            this.DelayNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("DelayNotification.Icon")));
            this.DelayNotification.Text = "DelayNotification";
            this.DelayNotification.Visible = true;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 60000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "From: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label3.Location = new System.Drawing.Point(156, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label4.Location = new System.Drawing.Point(23, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time:";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BtnSave.Location = new System.Drawing.Point(12, 207);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(236, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BtnReset.Location = new System.Drawing.Point(12, 233);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(236, 23);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Test";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LblVersion
            // 
            this.LblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.LblVersion.Location = new System.Drawing.Point(-3, -1);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(272, 14);
            this.LblVersion.TabIndex = 10;
            this.LblVersion.Text = "V1.0.0.0";
            this.LblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label5.Location = new System.Drawing.Point(10, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Interval:";
            // 
            // Intervals
            // 
            this.Intervals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.Intervals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Intervals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Intervals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Intervals.FormattingEnabled = true;
            this.Intervals.Location = new System.Drawing.Point(75, 100);
            this.Intervals.Name = "Intervals";
            this.Intervals.Size = new System.Drawing.Size(173, 21);
            this.Intervals.TabIndex = 12;
            this.Intervals.SelectedIndexChanged += new System.EventHandler(this.Intervals_SelectedIndexChanged);
            // 
            // LblTrainFrom
            // 
            this.LblTrainFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTrainFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.LblTrainFrom.Location = new System.Drawing.Point(0, 147);
            this.LblTrainFrom.Name = "LblTrainFrom";
            this.LblTrainFrom.Size = new System.Drawing.Size(125, 55);
            this.LblTrainFrom.TabIndex = 13;
            this.LblTrainFrom.Text = "Searching for train...";
            this.LblTrainFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTrainTo
            // 
            this.LblTrainTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTrainTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.LblTrainTo.Location = new System.Drawing.Point(135, 147);
            this.LblTrainTo.Name = "LblTrainTo";
            this.LblTrainTo.Size = new System.Drawing.Size(125, 55);
            this.LblTrainTo.TabIndex = 14;
            this.LblTrainTo.Text = "Searching for train...";
            this.LblTrainTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label6.Location = new System.Drawing.Point(-3, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "From";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label7.Location = new System.Drawing.Point(133, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "To";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblTrainTo);
            this.Controls.Add(this.LblTrainFrom);
            this.Controls.Add(this.Intervals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartMinute);
            this.Controls.Add(this.DepartHour);
            this.Controls.Add(this.ToStation);
            this.Controls.Add(this.FromStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "NMBS Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FromStation;
        private System.Windows.Forms.ComboBox ToStation;
        private System.Windows.Forms.ComboBox DepartHour;
        private System.Windows.Forms.ComboBox DepartMinute;
        private System.Windows.Forms.NotifyIcon DelayNotification;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Intervals;
        private System.Windows.Forms.Label LblTrainFrom;
        private System.Windows.Forms.Label LblTrainTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

