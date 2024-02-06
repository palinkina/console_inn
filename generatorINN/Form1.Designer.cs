namespace generatorINN
{
    partial class INNGenForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button button;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INNGenForm));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            rBI = new RadioButton();
            rBJ = new RadioButton();
            button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button
            // 
            button.AutoSize = true;
            button.BackColor = SystemColors.GradientInactiveCaption;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderColor = Color.Black;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.MouseDownBackColor = Color.Red;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Arial", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.World);
            button.ForeColor = Color.Black;
            button.ImageAlign = ContentAlignment.TopCenter;
            button.Location = new Point(417, 422);
            button.Name = "button";
            button.Size = new Size(41, 39);
            button.TabIndex = 0;
            button.Text = "GEN\r\nINN\r\n";
            button.TextImageRelation = TextImageRelation.ImageAboveText;
            button.UseMnemonic = false;
            button.UseVisualStyleBackColor = false;
            button.Click += Button1_Click;
            button.MouseEnter += button_MouseEnter;
            button.MouseLeave += button_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(203, 251, 255);
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(397, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(203, 251, 255);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(428, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 56);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(203, 251, 255);
            groupBox1.Controls.Add(rBI);
            groupBox1.Controls.Add(rBJ);
            groupBox1.Location = new Point(294, 530);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(101, 48);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rBI
            // 
            rBI.AutoSize = true;
            rBI.Location = new Point(53, 22);
            rBI.Name = "rBI";
            rBI.Size = new Size(42, 19);
            rBI.TabIndex = 1;
            rBI.TabStop = true;
            rBI.Text = "I/IE";
            rBI.UseVisualStyleBackColor = true;
            rBI.CheckedChanged += rBI_CheckedChanged;
            // 
            // rBJ
            // 
            rBJ.AutoSize = true;
            rBJ.Location = new Point(6, 22);
            rBJ.Name = "rBJ";
            rBJ.Size = new Size(29, 19);
            rBJ.TabIndex = 0;
            rBJ.TabStop = true;
            rBJ.Text = "J";
            rBJ.UseVisualStyleBackColor = true;
            rBJ.CheckedChanged += rBJ_CheckedChanged;
            // 
            // INNGenForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(587, 581);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "INNGenForm";
            Text = "INNGenForm";
            Load += Form1_Load;
            KeyDown += INNGenForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton rBI;
        private RadioButton rBJ;
    }
}