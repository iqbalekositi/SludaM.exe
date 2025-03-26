namespace errortest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BackgroundImage = Properties.Resources.People_Playground_26_03_2025_13_38_13;
            pictureBox1.Location = new Point(543, 322);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 444);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 356);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "ERROR";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._21_01_2025_17_38_50;
            pictureBox2.Location = new Point(-355, -119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(609, 414);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(38, 374);
            button1.Name = "button1";
            button1.Size = new Size(273, 118);
            button1.TabIndex = 3;
            button1.Text = "close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.People_Playground_15_01_2025_10_54_50;
            pictureBox3.Location = new Point(522, -11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(681, 417);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(833, 480);
            ControlBox = false;
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox3;
    }
}
