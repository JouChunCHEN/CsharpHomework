namespace Lab_Csharp_Homework
{
    partial class Frm_HW05_StudentsGrade
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
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.labChi = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnRandomSave = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandomSave20 = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.labGradeTitle = new System.Windows.Forms.Label();
            this.labGrade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(75, 147);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(74, 29);
            this.txtMath.TabIndex = 15;
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(32, 151);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(57, 20);
            this.labMath.TabIndex = 14;
            this.labMath.Text = "數學：";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(75, 105);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(74, 29);
            this.txtEng.TabIndex = 13;
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(32, 109);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(57, 20);
            this.labEng.TabIndex = 12;
            this.labEng.Text = "英文：";
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(75, 63);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(74, 29);
            this.txtChi.TabIndex = 11;
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(32, 67);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(57, 20);
            this.labChi.TabIndex = 10;
            this.labChi.Text = "國文：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(75, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(74, 29);
            this.txtName.TabIndex = 9;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(32, 25);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 20);
            this.labName.TabIndex = 8;
            this.labName.Text = "姓名：";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveData.Location = new System.Drawing.Point(30, 187);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(122, 30);
            this.btnSaveData.TabIndex = 16;
            this.btnSaveData.Text = "加入學生資料";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnRandomSave
            // 
            this.btnRandomSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandomSave.Location = new System.Drawing.Point(30, 223);
            this.btnRandomSave.Name = "btnRandomSave";
            this.btnRandomSave.Size = new System.Drawing.Size(122, 30);
            this.btnRandomSave.TabIndex = 17;
            this.btnRandomSave.Text = "隨機儲存資料";
            this.btnRandomSave.UseVisualStyleBackColor = true;
            this.btnRandomSave.Click += new System.EventHandler(this.btnRandomSave_Click);
            // 
            // btnResult
            // 
            this.btnResult.Enabled = false;
            this.btnResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnResult.Location = new System.Drawing.Point(30, 259);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(122, 30);
            this.btnResult.TabIndex = 18;
            this.btnResult.Text = "各科統計";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(31, 361);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 30);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRandomSave20
            // 
            this.btnRandomSave20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandomSave20.Location = new System.Drawing.Point(31, 397);
            this.btnRandomSave20.Name = "btnRandomSave20";
            this.btnRandomSave20.Size = new System.Drawing.Size(122, 30);
            this.btnRandomSave20.TabIndex = 20;
            this.btnRandomSave20.Text = "隨機加入20筆";
            this.btnRandomSave20.UseVisualStyleBackColor = true;
            this.btnRandomSave20.Click += new System.EventHandler(this.btnRandomSave20_Click);
            // 
            // labResult
            // 
            this.labResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labResult.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(174, 293);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(449, 134);
            this.labResult.TabIndex = 21;
            // 
            // labGradeTitle
            // 
            this.labGradeTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labGradeTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labGradeTitle.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGradeTitle.Location = new System.Drawing.Point(0, 0);
            this.labGradeTitle.Name = "labGradeTitle";
            this.labGradeTitle.Padding = new System.Windows.Forms.Padding(3);
            this.labGradeTitle.Size = new System.Drawing.Size(446, 262);
            this.labGradeTitle.TabIndex = 22;
            this.labGradeTitle.Text = "姓名  國文  英文  數學  總分  平均  最低    最高  ";
            // 
            // labGrade
            // 
            this.labGrade.AutoSize = true;
            this.labGrade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labGrade.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGrade.Location = new System.Drawing.Point(3, 26);
            this.labGrade.Name = "labGrade";
            this.labGrade.Size = new System.Drawing.Size(2, 18);
            this.labGrade.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.labGrade);
            this.panel1.Controls.Add(this.labGradeTitle);
            this.panel1.Location = new System.Drawing.Point(174, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 262);
            this.panel1.TabIndex = 25;
            // 
            // Frm_HW05_StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnRandomSave20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnRandomSave);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "Frm_HW05_StudentsGrade";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "學生成績統計";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnRandomSave;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandomSave20;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labGradeTitle;
        private System.Windows.Forms.Label labGrade;
        private System.Windows.Forms.Panel panel1;
    }
}