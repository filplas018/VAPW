
using System.Resources;

namespace plass_vapw
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Timer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            panel1 = new Panel();
            StandardlButton = new RadioButton();
            FastButton = new RadioButton();
            SuperFastButton = new RadioButton();
            textBox1 = new TextBox();
            Start = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(800, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 143);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.MenuHighlight;
            progressBar1.ForeColor = SystemColors.Desktop;
            progressBar1.Location = new Point(255, 254);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(271, 29);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Location = new Point(557, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(61, 59);
            panel1.TabIndex = 2;
            // 
            // StandardlButton
            // 
            StandardlButton.AutoSize = true;
            StandardlButton.Location = new Point(229, 68);
            StandardlButton.Name = "StandardlButton";
            StandardlButton.Size = new Size(80, 24);
            StandardlButton.TabIndex = 3;
            StandardlButton.TabStop = true;
            StandardlButton.Text = "Normal";
            StandardlButton.UseVisualStyleBackColor = true;
            StandardlButton.CheckedChanged += NormalButton_CheckedChanged;
            // 
            // FastButton
            // 
            FastButton.AutoSize = true;
            FastButton.Location = new Point(366, 68);
            FastButton.Name = "FastButton";
            FastButton.Size = new Size(55, 24);
            FastButton.TabIndex = 4;
            FastButton.TabStop = true;
            FastButton.Text = "Fast";
            FastButton.UseVisualStyleBackColor = true;
            FastButton.CheckedChanged += FastButton_CheckedChanged;
            // 
            // SuperFastButton
            // 
            SuperFastButton.AutoSize = true;
            SuperFastButton.Location = new Point(486, 68);
            SuperFastButton.Name = "SuperFastButton";
            SuperFastButton.Size = new Size(93, 24);
            SuperFastButton.TabIndex = 5;
            SuperFastButton.TabStop = true;
            SuperFastButton.Text = "SuperFast";
            SuperFastButton.UseVisualStyleBackColor = true;
            SuperFastButton.CheckedChanged += SuperFastButton_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.YellowGreen;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(321, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 34);
            textBox1.TabIndex = 6;
            textBox1.Text = "Charging Mode";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Start
            // 
            Start.Location = new Point(12, 21);
            Start.Name = "Start";
            Start.Size = new Size(94, 29);
            Start.TabIndex = 7;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += StartButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(649, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(textBox2);
            Controls.Add(Start);
            Controls.Add(textBox1);
            Controls.Add(SuperFastButton);
            Controls.Add(FastButton);
            Controls.Add(StandardlButton);
            Controls.Add(panel1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.Timer Timer;

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Panel panel1;
        private RadioButton StandardlButton;
        private RadioButton FastButton;
        private RadioButton SuperFastButton;
        private TextBox textBox1;
        private Button Start;
        private TextBox textBox2;
    }
}
