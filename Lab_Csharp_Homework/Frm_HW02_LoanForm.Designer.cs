namespace Lab_Csharp_Homework
{
    partial class Frm_HW02_LoanForm
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
            this.labLoan = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labPeriod = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labLoanTitle = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.BackColor = System.Drawing.Color.Transparent;
            this.labLoan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoan.Location = new System.Drawing.Point(59, 118);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(73, 20);
            this.labLoan.TabIndex = 0;
            this.labLoan.Text = "貸款金額";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.BackColor = System.Drawing.Color.Transparent;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(59, 155);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(81, 20);
            this.labRate.TabIndex = 1;
            this.labRate.Text = "年利率(%)";
            // 
            // labPeriod
            // 
            this.labPeriod.AutoSize = true;
            this.labPeriod.BackColor = System.Drawing.Color.Transparent;
            this.labPeriod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPeriod.Location = new System.Drawing.Point(59, 192);
            this.labPeriod.Name = "labPeriod";
            this.labPeriod.Size = new System.Drawing.Size(99, 20);
            this.labPeriod.TabIndex = 2;
            this.labPeriod.Text = "貸款期數(年)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 3;
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(191, 118);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(191, 22);
            this.txtLoan.TabIndex = 4;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(191, 156);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(191, 22);
            this.txtRate.TabIndex = 5;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(191, 194);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(191, 22);
            this.txtPeriod.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalc.Location = new System.Drawing.Point(61, 240);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(107, 40);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "試算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(191, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labLoanTitle
            // 
            this.labLoanTitle.AutoSize = true;
            this.labLoanTitle.BackColor = System.Drawing.Color.Transparent;
            this.labLoanTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanTitle.Location = new System.Drawing.Point(57, 65);
            this.labLoanTitle.Name = "labLoanTitle";
            this.labLoanTitle.Size = new System.Drawing.Size(206, 31);
            this.labLoanTitle.TabIndex = 10;
            this.labLoanTitle.Text = "本息平均攤還試算";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(61, 297);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 40);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Frm_HW02_LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab_Csharp_Homework.Properties.Resources.bgLoan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 426);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.labLoanTitle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labPeriod);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labLoan);
            this.Name = "Frm_HW02_LoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "貸款計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labLoanTitle;
        private System.Windows.Forms.Button btnReport;
        public System.Windows.Forms.TextBox txtLoan;
    }
}