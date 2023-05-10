namespace Lab_Csharp_Homework
{
    partial class Frm_HW06_StudentGrade_List
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labGrade = new System.Windows.Forms.Label();
            this.labGradeTitle = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.btnSearchData = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnInsertData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.labChi = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnRemoveData = new System.Windows.Forms.Button();
            this.txtSearchMin = new System.Windows.Forms.TextBox();
            this.labSerch = new System.Windows.Forms.Label();
            this.labRange = new System.Windows.Forms.Label();
            this.txtSearchMax = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.labGrade);
            this.panel1.Controls.Add(this.labGradeTitle);
            this.panel1.Location = new System.Drawing.Point(170, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 263);
            this.panel1.TabIndex = 41;
            // 
            // labGrade
            // 
            this.labGrade.AutoSize = true;
            this.labGrade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labGrade.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGrade.Location = new System.Drawing.Point(3, 25);
            this.labGrade.Name = "labGrade";
            this.labGrade.Size = new System.Drawing.Size(2, 18);
            this.labGrade.TabIndex = 24;
            // 
            // labGradeTitle
            // 
            this.labGradeTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labGradeTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labGradeTitle.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGradeTitle.Location = new System.Drawing.Point(0, 0);
            this.labGradeTitle.Name = "labGradeTitle";
            this.labGradeTitle.Padding = new System.Windows.Forms.Padding(3);
            this.labGradeTitle.Size = new System.Drawing.Size(449, 262);
            this.labGradeTitle.TabIndex = 40;
            this.labGradeTitle.Text = "姓名  國文  英文  數學  總分  平均  最低    最高  ";
            // 
            // labResult
            // 
            this.labResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labResult.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(170, 297);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(449, 134);
            this.labResult.TabIndex = 39;
            // 
            // btnSearchData
            // 
            this.btnSearchData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchData.Location = new System.Drawing.Point(27, 401);
            this.btnSearchData.Name = "btnSearchData";
            this.btnSearchData.Size = new System.Drawing.Size(122, 30);
            this.btnSearchData.TabIndex = 38;
            this.btnSearchData.Text = "Search";
            this.btnSearchData.UseVisualStyleBackColor = true;
            this.btnSearchData.Click += new System.EventHandler(this.btnSearchData_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(26, 299);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 30);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "清除所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnResult
            // 
            this.btnResult.Enabled = false;
            this.btnResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnResult.Location = new System.Drawing.Point(497, 439);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(122, 30);
            this.btnResult.TabIndex = 36;
            this.btnResult.Text = "各科統計";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnInsertData
            // 
            this.btnInsertData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertData.Location = new System.Drawing.Point(26, 227);
            this.btnInsertData.Name = "btnInsertData";
            this.btnInsertData.Size = new System.Drawing.Size(122, 30);
            this.btnInsertData.TabIndex = 35;
            this.btnInsertData.Text = "插入儲存資料";
            this.btnInsertData.UseVisualStyleBackColor = true;
            this.btnInsertData.Click += new System.EventHandler(this.btnInsertData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveData.Location = new System.Drawing.Point(26, 191);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(122, 30);
            this.btnSaveData.TabIndex = 34;
            this.btnSaveData.Text = "加入學生資料";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(71, 151);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(74, 29);
            this.txtMath.TabIndex = 33;
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(28, 155);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(57, 20);
            this.labMath.TabIndex = 32;
            this.labMath.Text = "數學：";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(71, 109);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(74, 29);
            this.txtEng.TabIndex = 31;
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(28, 113);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(57, 20);
            this.labEng.TabIndex = 30;
            this.labEng.Text = "英文：";
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(71, 67);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(74, 29);
            this.txtChi.TabIndex = 29;
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(28, 71);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(57, 20);
            this.labChi.TabIndex = 28;
            this.labChi.Text = "國文：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(71, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(74, 29);
            this.txtName.TabIndex = 27;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(28, 29);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 20);
            this.labName.TabIndex = 26;
            this.labName.Text = "姓名：";
            // 
            // btnRemoveData
            // 
            this.btnRemoveData.Enabled = false;
            this.btnRemoveData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveData.Location = new System.Drawing.Point(26, 263);
            this.btnRemoveData.Name = "btnRemoveData";
            this.btnRemoveData.Size = new System.Drawing.Size(122, 30);
            this.btnRemoveData.TabIndex = 42;
            this.btnRemoveData.Text = "移除資料";
            this.btnRemoveData.UseVisualStyleBackColor = true;
            this.btnRemoveData.Click += new System.EventHandler(this.btnRemoveData_Click);
            // 
            // txtSearchMin
            // 
            this.txtSearchMin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchMin.Location = new System.Drawing.Point(26, 366);
            this.txtSearchMin.Name = "txtSearchMin";
            this.txtSearchMin.Size = new System.Drawing.Size(51, 29);
            this.txtSearchMin.TabIndex = 43;
            this.txtSearchMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labSerch
            // 
            this.labSerch.AutoSize = true;
            this.labSerch.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSerch.Location = new System.Drawing.Point(26, 345);
            this.labSerch.Name = "labSerch";
            this.labSerch.Size = new System.Drawing.Size(124, 13);
            this.labSerch.TabIndex = 44;
            this.labSerch.Text = "搜尋國文成績範圍：";
            // 
            // labRange
            // 
            this.labRange.AutoSize = true;
            this.labRange.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRange.Location = new System.Drawing.Point(82, 366);
            this.labRange.Name = "labRange";
            this.labRange.Size = new System.Drawing.Size(18, 24);
            this.labRange.TabIndex = 45;
            this.labRange.Text = "-";
            // 
            // txtSearchMax
            // 
            this.txtSearchMax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchMax.Location = new System.Drawing.Point(101, 366);
            this.txtSearchMax.Name = "txtSearchMax";
            this.txtSearchMax.Size = new System.Drawing.Size(47, 29);
            this.txtSearchMax.TabIndex = 46;
            this.txtSearchMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_HW06_StudentGrade_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 481);
            this.Controls.Add(this.txtSearchMax);
            this.Controls.Add(this.labRange);
            this.Controls.Add(this.labSerch);
            this.Controls.Add(this.txtSearchMin);
            this.Controls.Add(this.btnRemoveData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnSearchData);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnInsertData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "Frm_HW06_StudentGrade_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "學生成績統計_List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labGrade;
        private System.Windows.Forms.Label labGradeTitle;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button btnSearchData;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnInsertData;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnRemoveData;
        private System.Windows.Forms.TextBox txtSearchMin;
        private System.Windows.Forms.Label labSerch;
        private System.Windows.Forms.Label labRange;
        private System.Windows.Forms.TextBox txtSearchMax;
    }
}