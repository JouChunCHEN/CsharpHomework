namespace Lab_Csharp_Homework
{
    partial class Frm_HW12_DrawPanint
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
            this.trackBarBrush = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labBar = new System.Windows.Forms.Label();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrush)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarBrush
            // 
            this.trackBarBrush.Location = new System.Drawing.Point(717, 128);
            this.trackBarBrush.Maximum = 100;
            this.trackBarBrush.Minimum = 1;
            this.trackBarBrush.Name = "trackBarBrush";
            this.trackBarBrush.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBrush.Size = new System.Drawing.Size(45, 245);
            this.trackBarBrush.TabIndex = 0;
            this.trackBarBrush.Value = 1;
            this.trackBarBrush.Scroll += new System.EventHandler(this.trackBarBrush_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labBar);
            this.panel1.Controls.Add(this.picColor);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.trackBarBrush);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // labBar
            // 
            this.labBar.AutoSize = true;
            this.labBar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBar.Location = new System.Drawing.Point(717, 380);
            this.labBar.Name = "labBar";
            this.labBar.Size = new System.Drawing.Size(18, 20);
            this.labBar.TabIndex = 3;
            this.labBar.Text = "1";
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.Black;
            this.picColor.Location = new System.Drawing.Point(696, 65);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(75, 46);
            this.picColor.TabIndex = 2;
            this.picColor.TabStop = false;
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnColor.Location = new System.Drawing.Point(696, 27);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 32);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Frm_HW12_DrawPanint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_HW12_DrawPanint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "小畫家";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrush)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarBrush;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label labBar;
        private System.Windows.Forms.PictureBox picColor;
    }
}