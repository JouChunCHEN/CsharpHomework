namespace Lab_Csharp_Homework
{
    partial class Frm_HW15_Alarm
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
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.labTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlarmTime = new System.Windows.Forms.MaskedTextBox();
            this.checkSet = new System.Windows.Forms.CheckBox();
            this.labAlarmTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(61, 56);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(0, 32);
            this.labTime.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlarmTime);
            this.groupBox1.Controls.Add(this.checkSet);
            this.groupBox1.Controls.Add(this.labAlarmTime);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(169, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // txtAlarmTime
            // 
            this.txtAlarmTime.BeepOnError = true;
            this.txtAlarmTime.Location = new System.Drawing.Point(140, 84);
            this.txtAlarmTime.Mask = "90時90分90秒";
            this.txtAlarmTime.Name = "txtAlarmTime";
            this.txtAlarmTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlarmTime.Size = new System.Drawing.Size(129, 29);
            this.txtAlarmTime.TabIndex = 2;
            // 
            // checkSet
            // 
            this.checkSet.AutoSize = true;
            this.checkSet.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSet.Location = new System.Drawing.Point(159, 128);
            this.checkSet.Name = "checkSet";
            this.checkSet.Size = new System.Drawing.Size(91, 27);
            this.checkSet.TabIndex = 3;
            this.checkSet.Text = "Set Alarm";
            this.checkSet.UseVisualStyleBackColor = true;
            this.checkSet.CheckedChanged += new System.EventHandler(this.checkSet_CheckedChanged);
            // 
            // labAlarmTime
            // 
            this.labAlarmTime.AutoSize = true;
            this.labAlarmTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAlarmTime.Location = new System.Drawing.Point(16, 84);
            this.labAlarmTime.Name = "labAlarmTime";
            this.labAlarmTime.Size = new System.Drawing.Size(95, 25);
            this.labAlarmTime.TabIndex = 2;
            this.labAlarmTime.Text = "Alarm Time:";
            // 
            // Frm_HW15_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 370);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_HW15_Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "小鬧鐘";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkSet;
        private System.Windows.Forms.Label labAlarmTime;
        private System.Windows.Forms.MaskedTextBox txtAlarmTime;
    }
}