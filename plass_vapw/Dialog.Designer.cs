using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace plass_vapw
{
    partial class Dialog
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
            OKButton = new Button();
            CancelButton = new Button();
            EventButton = new RadioButton();
            TimerButton = new RadioButton();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.ForeColor = Color.FromArgb(0, 192, 0);
            OKButton.Location = new Point(147, 71);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(50, 23);
            OKButton.TabIndex = 0;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.ForeColor = Color.Red;
            CancelButton.Location = new Point(12, 71);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // EventButton
            // 
            EventButton.AutoSize = true;
            EventButton.Checked = true;
            EventButton.Location = new Point(12, 12);
            EventButton.Name = "EventButton";
            EventButton.Size = new Size(59, 19);
            EventButton.TabIndex = 2;
            EventButton.TabStop = true;
            EventButton.Text = "Events";
            EventButton.UseVisualStyleBackColor = true;
            // 
            // TimerButton
            // 
            TimerButton.AutoSize = true;
            TimerButton.Location = new Point(12, 37);
            TimerButton.Name = "TimerButton";
            TimerButton.Size = new Size(55, 19);
            TimerButton.TabIndex = 3;
            TimerButton.Text = "Timer";
            TimerButton.UseVisualStyleBackColor = true;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(209, 103);
            Controls.Add(TimerButton);
            Controls.Add(EventButton);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Name = "EventForm";
            Text = "EventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OKButton;
        private Button CancelButton;
        private RadioButton EventButton;
        private RadioButton TimerButton;
    }
}