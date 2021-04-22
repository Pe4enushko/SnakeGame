
namespace SnakeGame
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pb_Field = new System.Windows.Forms.PictureBox();
            this.Btn_Retry = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Pause = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SnakeMovingTimer = new System.Windows.Forms.Timer(this.components);
            this.Decoration1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_Field
            // 
            this.Pb_Field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pb_Field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(10)))));
            this.Pb_Field.Location = new System.Drawing.Point(30, 12);
            this.Pb_Field.Name = "Pb_Field";
            this.Pb_Field.Size = new System.Drawing.Size(380, 380);
            this.Pb_Field.TabIndex = 0;
            this.Pb_Field.TabStop = false;
            this.Pb_Field.SizeChanged += new System.EventHandler(this.Pb_Field_SizeChanged);
            this.Pb_Field.Click += new System.EventHandler(this.Pb_Field_Click);
            // 
            // Btn_Retry
            // 
            this.Btn_Retry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Retry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Retry.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Retry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.Btn_Retry.Location = new System.Drawing.Point(444, 41);
            this.Btn_Retry.Name = "Btn_Retry";
            this.Btn_Retry.Size = new System.Drawing.Size(161, 38);
            this.Btn_Retry.TabIndex = 1;
            this.Btn_Retry.TabStop = false;
            this.Btn_Retry.Text = "Retry";
            this.Btn_Retry.UseCompatibleTextRendering = true;
            this.Btn_Retry.UseVisualStyleBackColor = true;
            this.Btn_Retry.Click += new System.EventHandler(this.Btn_Retry_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Start.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.Btn_Start.Location = new System.Drawing.Point(444, 94);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(161, 38);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.TabStop = false;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseCompatibleTextRendering = true;
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pause.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.Btn_Pause.Location = new System.Drawing.Point(444, 147);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(161, 38);
            this.Btn_Pause.TabIndex = 3;
            this.Btn_Pause.TabStop = false;
            this.Btn_Pause.Text = "Pause";
            this.Btn_Pause.UseCompatibleTextRendering = true;
            this.Btn_Pause.UseVisualStyleBackColor = true;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.Btn_Exit.Location = new System.Drawing.Point(444, 354);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(161, 38);
            this.Btn_Exit.TabIndex = 4;
            this.Btn_Exit.TabStop = false;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseCompatibleTextRendering = true;
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SnakeMovingTimer
            // 
            this.SnakeMovingTimer.Interval = 250;
            this.SnakeMovingTimer.Tick += new System.EventHandler(this.SnakeMovingTimer_Tick);
            // 
            // Decoration1
            // 
            this.Decoration1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Decoration1.BackColor = System.Drawing.Color.ForestGreen;
            this.Decoration1.Location = new System.Drawing.Point(14, -1);
            this.Decoration1.Name = "Decoration1";
            this.Decoration1.Size = new System.Drawing.Size(411, 406);
            this.Decoration1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(499, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(499, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(443, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(555, 264);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(485, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mouse control";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(21)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(664, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Pause);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Btn_Retry);
            this.Controls.Add(this.Pb_Field);
            this.Controls.Add(this.Decoration1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Retry;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Pause;
        private System.Windows.Forms.Button Btn_Exit;
        public System.Windows.Forms.PictureBox Pb_Field;
        private System.Windows.Forms.Timer SnakeMovingTimer;
        private System.Windows.Forms.Panel Decoration1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}

