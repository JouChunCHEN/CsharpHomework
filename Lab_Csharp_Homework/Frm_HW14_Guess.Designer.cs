namespace Lab_Csharp_Homework
{
    partial class Frm_HW14_Guess
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
            this.txtGuessNum = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labGuess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGuessNum
            // 
            this.txtGuessNum.Location = new System.Drawing.Point(17, 88);
            this.txtGuessNum.Name = "txtGuessNum";
            this.txtGuessNum.Size = new System.Drawing.Size(322, 22);
            this.txtGuessNum.TabIndex = 0;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(260, 12);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(78, 33);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Enter";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(260, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labGuess
            // 
            this.labGuess.AutoSize = true;
            this.labGuess.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGuess.Location = new System.Drawing.Point(14, 35);
            this.labGuess.Name = "labGuess";
            this.labGuess.Size = new System.Drawing.Size(218, 26);
            this.labGuess.TabIndex = 3;
            this.labGuess.Text = "Please input a number.";
            // 
            // Frm_HW14_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 129);
            this.ControlBox = false;
            this.Controls.Add(this.labGuess);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuessNum);
            this.Name = "Frm_HW14_Guess";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuessNum;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labGuess;
    }
}