
namespace SnakeGame
{
    partial class YouWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.GGBtn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "You win!!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GGBtn_Exit
            // 
            this.GGBtn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GGBtn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.GGBtn_Exit.Location = new System.Drawing.Point(50, 175);
            this.GGBtn_Exit.Name = "GGBtn_Exit";
            this.GGBtn_Exit.Size = new System.Drawing.Size(150, 38);
            this.GGBtn_Exit.TabIndex = 1;
            this.GGBtn_Exit.Text = "Exit";
            this.GGBtn_Exit.UseVisualStyleBackColor = true;
            this.GGBtn_Exit.Click += new System.EventHandler(this.GGBtn_Exit_Click);
            // 
            // YouWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(263, 257);
            this.Controls.Add(this.GGBtn_Exit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YouWin";
            this.Text = "YouWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GGBtn_Exit;
    }
}