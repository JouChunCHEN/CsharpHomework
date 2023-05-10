namespace Lab_Csharp_Homework
{
    partial class Frm_HW04_StructForm
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.labChi = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.groupScore = new System.Windows.Forms.GroupBox();
            this.labSubject = new System.Windows.Forms.Label();
            this.labDataList = new System.Windows.Forms.Label();
            this.btnShowSubject = new System.Windows.Forms.Button();
            this.groupScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(42, 67);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(115, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 33);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(115, 118);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(162, 33);
            this.txtChi.TabIndex = 3;
            this.txtChi.Text = "0";
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(42, 122);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(67, 24);
            this.labChi.TabIndex = 2;
            this.labChi.Text = "國文：";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(115, 173);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(162, 33);
            this.txtEng.TabIndex = 5;
            this.txtEng.Text = "0";
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(42, 177);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(67, 24);
            this.labEng.TabIndex = 4;
            this.labEng.Text = "英文：";
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(115, 228);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(162, 33);
            this.txtMath.TabIndex = 7;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(42, 232);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(67, 24);
            this.labMath.TabIndex = 6;
            this.labMath.Text = "數學：";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveData.Location = new System.Drawing.Point(46, 298);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(96, 44);
            this.btnSaveData.TabIndex = 8;
            this.btnSaveData.Text = "儲存";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowData.Location = new System.Drawing.Point(158, 298);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(119, 44);
            this.btnShowData.TabIndex = 9;
            this.btnShowData.Text = "顯示儲存內容";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // groupScore
            // 
            this.groupScore.Controls.Add(this.labSubject);
            this.groupScore.Controls.Add(this.labDataList);
            this.groupScore.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupScore.Location = new System.Drawing.Point(346, 30);
            this.groupScore.Name = "groupScore";
            this.groupScore.Size = new System.Drawing.Size(288, 311);
            this.groupScore.TabIndex = 10;
            this.groupScore.TabStop = false;
            this.groupScore.Text = "成績";
            // 
            // labSubject
            // 
            this.labSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labSubject.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSubject.Location = new System.Drawing.Point(14, 214);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(258, 83);
            this.labSubject.TabIndex = 1;
            // 
            // labDataList
            // 
            this.labDataList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labDataList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDataList.Location = new System.Drawing.Point(14, 31);
            this.labDataList.Name = "labDataList";
            this.labDataList.Size = new System.Drawing.Size(258, 171);
            this.labDataList.TabIndex = 0;
            // 
            // btnShowSubject
            // 
            this.btnShowSubject.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowSubject.Location = new System.Drawing.Point(475, 347);
            this.btnShowSubject.Name = "btnShowSubject";
            this.btnShowSubject.Size = new System.Drawing.Size(159, 44);
            this.btnShowSubject.TabIndex = 11;
            this.btnShowSubject.Text = "最高分/最低分科目";
            this.btnShowSubject.UseVisualStyleBackColor = true;
            this.btnShowSubject.Click += new System.EventHandler(this.btnShowSubject_Click);
            // 
            // Frm_HW04_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 438);
            this.Controls.Add(this.btnShowSubject);
            this.Controls.Add(this.groupScore);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "Frm_HW04_StructForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "學生成績";
            this.groupScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.GroupBox groupScore;
        private System.Windows.Forms.Label labSubject;
        private System.Windows.Forms.Label labDataList;
        private System.Windows.Forms.Button btnShowSubject;
    }
}