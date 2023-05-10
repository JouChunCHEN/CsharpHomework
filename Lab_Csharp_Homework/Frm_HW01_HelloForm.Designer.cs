namespace Lab_Csharp_Homework
{
    partial class Frm_HW01_HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEngName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labEngName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labStar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSayHello.FlatAppearance.BorderSize = 0;
            this.btnSayHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSayHello.Location = new System.Drawing.Point(47, 236);
            this.btnSayHello.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(157, 67);
            this.btnSayHello.TabIndex = 0;
            this.btnSayHello.Text = "Say Hello!";
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.Color.Peru;
            this.btnSayHi.FlatAppearance.BorderSize = 0;
            this.btnSayHi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Location = new System.Drawing.Point(227, 236);
            this.btnSayHi.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(157, 67);
            this.btnSayHi.TabIndex = 1;
            this.btnSayHi.Text = "Say Hi!";
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(227, 63);
            this.txtName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtEngName
            // 
            this.txtEngName.Location = new System.Drawing.Point(227, 104);
            this.txtEngName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEngName.Name = "txtEngName";
            this.txtEngName.Size = new System.Drawing.Size(157, 22);
            this.txtEngName.TabIndex = 3;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(227, 145);
            this.txtGender.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(157, 22);
            this.txtGender.TabIndex = 4;
            // 
            // txtStar
            // 
            this.txtStar.Location = new System.Drawing.Point(227, 184);
            this.txtStar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(157, 22);
            this.txtStar.TabIndex = 5;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labName.Location = new System.Drawing.Point(51, 59);
            this.labName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 6;
            this.labName.Text = "姓名：";
            // 
            // labEngName
            // 
            this.labEngName.AutoSize = true;
            this.labEngName.BackColor = System.Drawing.Color.Transparent;
            this.labEngName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEngName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labEngName.Location = new System.Drawing.Point(51, 101);
            this.labEngName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labEngName.Name = "labEngName";
            this.labEngName.Size = new System.Drawing.Size(153, 24);
            this.labEngName.TabIndex = 7;
            this.labEngName.Text = "English Name：";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Transparent;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labGender.Location = new System.Drawing.Point(51, 143);
            this.labGender.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(67, 24);
            this.labGender.TabIndex = 8;
            this.labGender.Text = "性別：";
            // 
            // labStar
            // 
            this.labStar.AutoSize = true;
            this.labStar.BackColor = System.Drawing.Color.Transparent;
            this.labStar.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labStar.Location = new System.Drawing.Point(51, 185);
            this.labStar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labStar.Name = "labStar";
            this.labStar.Size = new System.Drawing.Size(67, 24);
            this.labStar.TabIndex = 9;
            this.labStar.Text = "星座：";
            // 
            // Frm_HW01_HelloForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab_Csharp_Homework.Properties.Resources.bgHello;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 487);
            this.Controls.Add(this.labStar);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labEngName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtStar);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEngName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Frm_HW01_HelloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "你好，C#！";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEngName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labEngName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labStar;
    }
}

