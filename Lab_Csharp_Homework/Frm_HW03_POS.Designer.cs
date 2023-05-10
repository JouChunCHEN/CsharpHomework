namespace Lab_Csharp_Homework
{
    partial class Frm_HW03_POS
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
            this.labMenu = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.labPayment = new System.Windows.Forms.Label();
            this.labList = new System.Windows.Forms.Label();
            this.btnMenuBear = new System.Windows.Forms.Button();
            this.labListShow = new System.Windows.Forms.Label();
            this.btnMenuTequila = new System.Windows.Forms.Button();
            this.btnMenuWhisky = new System.Windows.Forms.Button();
            this.btnMenuWine = new System.Windows.Forms.Button();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.btnPayCredit = new System.Windows.Forms.Button();
            this.labDisccount10off = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMenu
            // 
            this.labMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.Location = new System.Drawing.Point(27, 53);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(238, 352);
            this.labMenu.TabIndex = 1;
            this.labMenu.Text = "菜單 Menu";
            // 
            // labTotal
            // 
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.Location = new System.Drawing.Point(271, 53);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(238, 98);
            this.labTotal.TabIndex = 2;
            this.labTotal.Text = "總金額 Total Price";
            // 
            // labPayment
            // 
            this.labPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPayment.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPayment.Location = new System.Drawing.Point(271, 177);
            this.labPayment.Name = "labPayment";
            this.labPayment.Size = new System.Drawing.Size(238, 126);
            this.labPayment.TabIndex = 3;
            this.labPayment.Text = "付款方式 Payment";
            // 
            // labList
            // 
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(515, 53);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(262, 352);
            this.labList.TabIndex = 4;
            this.labList.Text = "購物清單 List";
            // 
            // btnMenuBear
            // 
            this.btnMenuBear.BackgroundImage = global::Lab_Csharp_Homework.Properties.Resources.beer;
            this.btnMenuBear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuBear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenuBear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuBear.Location = new System.Drawing.Point(39, 98);
            this.btnMenuBear.Name = "btnMenuBear";
            this.btnMenuBear.Size = new System.Drawing.Size(100, 136);
            this.btnMenuBear.TabIndex = 6;
            this.btnMenuBear.Text = "啤酒\r\nBeer\r\nNT120";
            this.btnMenuBear.UseVisualStyleBackColor = true;
            this.btnMenuBear.Click += new System.EventHandler(this.btnMenuBear_Click);
            // 
            // labListShow
            // 
            this.labListShow.BackColor = System.Drawing.SystemColors.Window;
            this.labListShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labListShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labListShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labListShow.Location = new System.Drawing.Point(528, 98);
            this.labListShow.Name = "labListShow";
            this.labListShow.Padding = new System.Windows.Forms.Padding(5);
            this.labListShow.Size = new System.Drawing.Size(237, 258);
            this.labListShow.TabIndex = 7;
            this.labListShow.Text = "尚未點餐";
            this.labListShow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnMenuTequila
            // 
            this.btnMenuTequila.BackgroundImage = global::Lab_Csharp_Homework.Properties.Resources.tequila;
            this.btnMenuTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuTequila.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenuTequila.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuTequila.Location = new System.Drawing.Point(155, 98);
            this.btnMenuTequila.Name = "btnMenuTequila";
            this.btnMenuTequila.Size = new System.Drawing.Size(100, 136);
            this.btnMenuTequila.TabIndex = 8;
            this.btnMenuTequila.Text = "龍舌蘭\r\nTequila\r\nNT180";
            this.btnMenuTequila.UseVisualStyleBackColor = true;
            this.btnMenuTequila.Click += new System.EventHandler(this.btnMenuTequila_Click);
            // 
            // btnMenuWhisky
            // 
            this.btnMenuWhisky.BackgroundImage = global::Lab_Csharp_Homework.Properties.Resources.whisky;
            this.btnMenuWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuWhisky.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenuWhisky.Location = new System.Drawing.Point(39, 257);
            this.btnMenuWhisky.Name = "btnMenuWhisky";
            this.btnMenuWhisky.Size = new System.Drawing.Size(100, 137);
            this.btnMenuWhisky.TabIndex = 9;
            this.btnMenuWhisky.Text = "威士忌\r\nWhisky\r\nNT350";
            this.btnMenuWhisky.UseVisualStyleBackColor = true;
            this.btnMenuWhisky.Click += new System.EventHandler(this.btnMenuWhisky_Click);
            // 
            // btnMenuWine
            // 
            this.btnMenuWine.BackgroundImage = global::Lab_Csharp_Homework.Properties.Resources.wine;
            this.btnMenuWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuWine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenuWine.Location = new System.Drawing.Point(155, 257);
            this.btnMenuWine.Name = "btnMenuWine";
            this.btnMenuWine.Size = new System.Drawing.Size(100, 137);
            this.btnMenuWine.TabIndex = 10;
            this.btnMenuWine.Text = "紅酒\r\nWine\r\nNT320";
            this.btnMenuWine.UseVisualStyleBackColor = true;
            this.btnMenuWine.Click += new System.EventHandler(this.btnMenuWine_Click);
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.BackColor = System.Drawing.SystemColors.ControlText;
            this.labTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTotalPrice.Location = new System.Drawing.Point(281, 98);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(214, 41);
            this.labTotalPrice.TabIndex = 11;
            this.labTotalPrice.Text = "NT$ 0";
            this.labTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPayCash
            // 
            this.btnPayCash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPayCash.Location = new System.Drawing.Point(284, 223);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(97, 56);
            this.btnPayCash.TabIndex = 12;
            this.btnPayCash.Text = "現金";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // btnPayCredit
            // 
            this.btnPayCredit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPayCredit.Location = new System.Drawing.Point(397, 222);
            this.btnPayCredit.Name = "btnPayCredit";
            this.btnPayCredit.Size = new System.Drawing.Size(97, 56);
            this.btnPayCredit.TabIndex = 13;
            this.btnPayCredit.Text = "信用卡";
            this.btnPayCredit.UseVisualStyleBackColor = true;
            this.btnPayCredit.Click += new System.EventHandler(this.btnPayCredit_Click);
            // 
            // labDisccount10off
            // 
            this.labDisccount10off.AutoSize = true;
            this.labDisccount10off.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDisccount10off.Location = new System.Drawing.Point(399, 284);
            this.labDisccount10off.Name = "labDisccount10off";
            this.labDisccount10off.Size = new System.Drawing.Size(98, 13);
            this.labDisccount10off.TabIndex = 14;
            this.labDisccount10off.Text = "信用卡享9折！";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(666, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 38);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Frm_HW03_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labDisccount10off);
            this.Controls.Add(this.btnPayCredit);
            this.Controls.Add(this.btnPayCash);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.btnMenuWine);
            this.Controls.Add(this.btnMenuWhisky);
            this.Controls.Add(this.btnMenuTequila);
            this.Controls.Add(this.labListShow);
            this.Controls.Add(this.btnMenuBear);
            this.Controls.Add(this.labList);
            this.Controls.Add(this.labPayment);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labMenu);
            this.Name = "Frm_HW03_POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frm_HW03_POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label labPayment;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Button btnMenuBear;
        private System.Windows.Forms.Label labListShow;
        private System.Windows.Forms.Button btnMenuTequila;
        private System.Windows.Forms.Button btnMenuWhisky;
        private System.Windows.Forms.Button btnMenuWine;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Button btnPayCredit;
        private System.Windows.Forms.Label labDisccount10off;
        private System.Windows.Forms.Button btnClear;
    }
}