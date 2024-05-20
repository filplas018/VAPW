
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

            Timer = new System.Windows.Forms.Timer(components);

            // UpdateInfoLabel
            // 
            UpdateInfoLabel = new Label();

            UpdateInfoLabel.AutoSize = true;
            UpdateInfoLabel.Location = new Point(12, 9);
            UpdateInfoLabel.Name = "UpdateInfoLabel";
            UpdateInfoLabel.Size = new Size(0, 15);
            UpdateInfoLabel.TabIndex = 15;

            this.labelStavStanice = new System.Windows.Forms.Label();
            this.labelVstupniSemafor = new System.Windows.Forms.Label();
            this.labelVystupniSemafor = new System.Windows.Forms.Label();
            this.labelCarLocation = new System.Windows.Forms.Label();
            this.labelChargeLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStavStanice
            // 
            this.labelStavStanice.AutoSize = true;
            this.labelStavStanice.Location = new System.Drawing.Point(13, 13);
            this.labelStavStanice.Name = "labelStavStanice";
            this.labelStavStanice.Size = new System.Drawing.Size(83, 17);
            this.labelStavStanice.TabIndex = 0;
            this.labelStavStanice.Text = "Stav Stanice:";
            // 
            // labelVstupniSemafor
            // 
            this.labelVstupniSemafor.AutoSize = true;
            this.labelVstupniSemafor.Location = new System.Drawing.Point(13, 43);
            this.labelVstupniSemafor.Name = "labelVstupniSemafor";
            this.labelVstupniSemafor.Size = new System.Drawing.Size(118, 17);
            this.labelVstupniSemafor.TabIndex = 1;
            this.labelVstupniSemafor.Text = "Vstupní Semafor:";
            // 
            // labelVystupniSemafor
            // 
            this.labelVystupniSemafor.AutoSize = true;
            this.labelVystupniSemafor.Location = new System.Drawing.Point(13, 73);
            this.labelVystupniSemafor.Name = "labelVystupniSemafor";
            this.labelVystupniSemafor.Size = new System.Drawing.Size(118, 17);
            this.labelVystupniSemafor.TabIndex = 2;
            this.labelVystupniSemafor.Text = "Výstupní Semafor:";
            // 
            // labelCarLocation
            // 
            this.labelCarLocation.AutoSize = true;
            this.labelCarLocation.Location = new System.Drawing.Point(13, 103);
            this.labelCarLocation.Name = "labelCarLocation";
            this.labelCarLocation.Size = new System.Drawing.Size(94, 17);
            this.labelCarLocation.TabIndex = 3;
            this.labelCarLocation.Text = "Car Location:";
            // 
            // labelChargeLevel
            // 
            this.labelChargeLevel.AutoSize = true;
            this.labelChargeLevel.Location = new System.Drawing.Point(13, 133);
            this.labelChargeLevel.Name = "labelChargeLevel";
            this.labelChargeLevel.Size = new System.Drawing.Size(98, 17);
            this.labelChargeLevel.TabIndex = 4;
            this.labelChargeLevel.Text = "Charge Level:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChargeLevel);
            this.Controls.Add(this.labelCarLocation);
            this.Controls.Add(this.labelVystupniSemafor);
            this.Controls.Add(this.labelVstupniSemafor);
            this.Controls.Add(this.labelStavStanice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStavStanice;
        private System.Windows.Forms.Label labelVstupniSemafor;
        private System.Windows.Forms.Label labelVystupniSemafor;
        private System.Windows.Forms.Label labelCarLocation;
        private System.Windows.Forms.Label labelChargeLevel;
        private Label UpdateInfoLabel;
        private System.Windows.Forms.Timer Timer;


    }
}
