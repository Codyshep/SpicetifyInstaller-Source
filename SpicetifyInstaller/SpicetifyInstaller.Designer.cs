namespace SpicetifyInstaller
{
    partial class SpicetifyInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpicetifyInstaller));
            this.Install = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.Install2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Install
            // 
            this.Install.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Install.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(3)))));
            this.Install.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Install.Font = new System.Drawing.Font("Nexa Heavy", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Install.Location = new System.Drawing.Point(12, 443);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(175, 41);
            this.Install.TabIndex = 0;
            this.Install.Text = "Install Pt.1";
            this.Install.UseVisualStyleBackColor = false;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.outputTextBox.ForeColor = System.Drawing.Color.White;
            this.outputTextBox.Location = new System.Drawing.Point(12, 12);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(374, 426);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // Install2
            // 
            this.Install2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Install2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Install2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(3)))));
            this.Install2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Install2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Install2.Font = new System.Drawing.Font("Nexa Heavy", 8.249999F, System.Drawing.FontStyle.Bold);
            this.Install2.Location = new System.Drawing.Point(216, 443);
            this.Install2.Name = "Install2";
            this.Install2.Size = new System.Drawing.Size(170, 41);
            this.Install2.TabIndex = 2;
            this.Install2.Text = "Install Pt.2";
            this.Install2.UseVisualStyleBackColor = false;
            this.Install2.Click += new System.EventHandler(this.Install2_Click);
            // 
            // SpicetifyInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(398, 496);
            this.Controls.Add(this.Install2);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.Install);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpicetifyInstaller";
            this.Opacity = 0.9D;
            this.Text = "SpicetifyInstaller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button Install2;
    }
}

