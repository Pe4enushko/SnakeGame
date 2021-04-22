
namespace SnakeGame
{
    partial class StartMenu
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
            this.Btn_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Start.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.Btn_Start.Location = new System.Drawing.Point(69, 125);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(161, 38);
            this.Btn_Start.TabIndex = 5;
            this.Btn_Start.TabStop = false;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseCompatibleTextRendering = true;
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(301, 305);
            this.Controls.Add(this.Btn_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Btn_Start;
    }
}