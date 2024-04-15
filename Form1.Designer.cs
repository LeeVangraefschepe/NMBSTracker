﻿namespace NMBSTracker
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
            this.SuspendLayout();
            // 
            // FromStation
            // 
            this.FromStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromStation.FormattingEnabled = true;
            this.FromStation.Location = new System.Drawing.Point(75, 17);
            this.FromStation.Name = "FromStation";
            this.FromStation.Size = new System.Drawing.Size(121, 21);
            this.FromStation.TabIndex = 0;
            // 
            // ToStation
            // 
            this.ToStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToStation.FormattingEnabled = true;
            this.ToStation.Location = new System.Drawing.Point(75, 44);
            this.ToStation.Name = "ToStation";
            this.ToStation.Size = new System.Drawing.Size(121, 21);
            this.ToStation.TabIndex = 1;
            // 
            // DepartHour
            // 
            this.DepartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartHour.FormattingEnabled = true;
            this.DepartHour.Location = new System.Drawing.Point(75, 74);
            this.DepartHour.Name = "DepartHour";
            this.DepartHour.Size = new System.Drawing.Size(50, 21);
            this.DepartHour.TabIndex = 2;
            // 
            // DepartMinute
            // 
            this.DepartMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartMinute.FormattingEnabled = true;
            this.DepartMinute.Location = new System.Drawing.Point(146, 74);
            this.DepartMinute.Name = "DepartMinute";
            this.DepartMinute.Size = new System.Drawing.Size(50, 21);
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
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "From: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(22, 104);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(174, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(22, 130);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(174, 23);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Test";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 171);
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
    }
}

