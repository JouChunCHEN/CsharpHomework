namespace Lab_Csharp_Homework
{
    partial class Frm_HW08_MyClac
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
            this.labNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.labNum2 = new System.Windows.Forms.Label();
            this.labLine = new System.Windows.Forms.Label();
            this.labAnswerTitle = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivided = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.labAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum1.Location = new System.Drawing.Point(29, 88);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(70, 24);
            this.labNum1.TabIndex = 0;
            this.labNum1.Text = "Num1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.Location = new System.Drawing.Point(105, 85);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(144, 33);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum2.Location = new System.Drawing.Point(105, 135);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(144, 33);
            this.txtNum2.TabIndex = 3;
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum2.Location = new System.Drawing.Point(29, 138);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(70, 24);
            this.labNum2.TabIndex = 2;
            this.labNum2.Text = "Num2:";
            // 
            // labLine
            // 
            this.labLine.AutoSize = true;
            this.labLine.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLine.Location = new System.Drawing.Point(29, 183);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(230, 21);
            this.labLine.TabIndex = 4;
            this.labLine.Text = "====================";
            // 
            // labAnswerTitle
            // 
            this.labAnswerTitle.AutoSize = true;
            this.labAnswerTitle.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswerTitle.Location = new System.Drawing.Point(18, 219);
            this.labAnswerTitle.Name = "labAnswerTitle";
            this.labAnswerTitle.Size = new System.Drawing.Size(81, 24);
            this.labAnswerTitle.TabIndex = 5;
            this.labAnswerTitle.Text = "Answer:";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.Location = new System.Drawing.Point(263, 36);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(44, 42);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.Location = new System.Drawing.Point(263, 93);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(44, 42);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDivided
            // 
            this.btnDivided.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDivided.Location = new System.Drawing.Point(263, 207);
            this.btnDivided.Name = "btnDivided";
            this.btnDivided.Size = new System.Drawing.Size(44, 42);
            this.btnDivided.TabIndex = 9;
            this.btnDivided.Text = "/";
            this.btnDivided.UseVisualStyleBackColor = true;
            this.btnDivided.Click += new System.EventHandler(this.btnDivided_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMultiply.Location = new System.Drawing.Point(263, 150);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(44, 42);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // labAnswer
            // 
            this.labAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAnswer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswer.Location = new System.Drawing.Point(105, 219);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(144, 30);
            this.labAnswer.TabIndex = 11;
            // 
            // Frm_HW08_MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 284);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivided);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.labAnswerTitle);
            this.Controls.Add(this.labLine);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.labNum1);
            this.Name = "Frm_HW08_MyClac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "我的計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label labNum2;
        private System.Windows.Forms.Label labLine;
        private System.Windows.Forms.Label labAnswerTitle;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivided;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label labAnswer;
    }
}