namespace ParkingApp.View
{
    partial class AboutForm
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
            this.aboutMainPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.textLabelAbout = new System.Windows.Forms.Label();
            this.subtitleAbout = new System.Windows.Forms.Label();
            this.aboutLabel3 = new System.Windows.Forms.Label();
            this.aboutMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutMainPanel
            // 
            this.aboutMainPanel.AutoScroll = true;
            this.aboutMainPanel.AutoSize = true;
            this.aboutMainPanel.BackColor = System.Drawing.Color.White;
            this.aboutMainPanel.Controls.Add(this.aboutLabel3);
            this.aboutMainPanel.Controls.Add(this.infoLabel);
            this.aboutMainPanel.Controls.Add(this.textLabelAbout);
            this.aboutMainPanel.Controls.Add(this.subtitleAbout);
            this.aboutMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutMainPanel.Location = new System.Drawing.Point(0, 0);
            this.aboutMainPanel.Name = "aboutMainPanel";
            this.aboutMainPanel.Padding = new System.Windows.Forms.Padding(25);
            this.aboutMainPanel.Size = new System.Drawing.Size(428, 482);
            this.aboutMainPanel.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.White;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoLabel.Location = new System.Drawing.Point(25, 266);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(378, 113);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Fill the date, license plate number and last four digits of the card number then " +
    "press Search. Clear button deletes the content on screen.";
            // 
            // textLabelAbout
            // 
            this.textLabelAbout.BackColor = System.Drawing.Color.White;
            this.textLabelAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.textLabelAbout.Location = new System.Drawing.Point(25, 153);
            this.textLabelAbout.Name = "textLabelAbout";
            this.textLabelAbout.Size = new System.Drawing.Size(378, 113);
            this.textLabelAbout.TabIndex = 8;
            this.textLabelAbout.Text = "Sample Parking Ticket program. It produces the output incase there is a ticket in" +
    " the JSON file.";
            this.textLabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtitleAbout
            // 
            this.subtitleAbout.BackColor = System.Drawing.Color.White;
            this.subtitleAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.subtitleAbout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtitleAbout.Location = new System.Drawing.Point(25, 25);
            this.subtitleAbout.Name = "subtitleAbout";
            this.subtitleAbout.Padding = new System.Windows.Forms.Padding(35);
            this.subtitleAbout.Size = new System.Drawing.Size(378, 128);
            this.subtitleAbout.TabIndex = 7;
            this.subtitleAbout.Text = "About";
            this.subtitleAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutLabel3
            // 
            this.aboutLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutLabel3.Location = new System.Drawing.Point(25, 379);
            this.aboutLabel3.Name = "aboutLabel3";
            this.aboutLabel3.Size = new System.Drawing.Size(378, 66);
            this.aboutLabel3.TabIndex = 10;
            this.aboutLabel3.Text = "You need to load a JSON file. In a real application, this would never be the case" +
    ".";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 482);
            this.Controls.Add(this.aboutMainPanel);
            this.Name = "AboutForm";
            this.Text = "About";
            this.aboutMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Panel aboutMainPanel;
        private Label textLabelAbout;
        private Label subtitleAbout;
        private Label infoLabel;
        private Label aboutLabel3;
    }
}