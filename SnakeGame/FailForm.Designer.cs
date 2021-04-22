
namespace SnakeGame
{
    partial class FailForm
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
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(53, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Failed!";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.Btn_Exit.Location = new System.Drawing.Point(209, 191);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(133, 41);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Return
            // 
            this.Btn_Return.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Return.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.Btn_Return.Location = new System.Drawing.Point(25, 191);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(133, 41);
            this.Btn_Return.TabIndex = 2;
            this.Btn_Return.Text = "Restart";
            this.Btn_Return.UseVisualStyleBackColor = true;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // FailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(369, 272);
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FailForm";
            this.Text = "FailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Return;
    }
}