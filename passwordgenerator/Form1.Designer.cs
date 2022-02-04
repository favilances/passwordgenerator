
namespace passwordgenerator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.discordButton = new Guna.UI2.WinForms.Guna2Button();
            this.websiteButton = new Guna.UI2.WinForms.Guna2Button();
            this.tittleLogos = new System.Windows.Forms.PictureBox();
            this.titleText = new System.Windows.Forms.Label();
            this.passwordLenghtText = new System.Windows.Forms.Label();
            this.passwordCopy = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordLengthSlider = new Guna.UI2.WinForms.Guna2TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tittleLogos)).BeginInit();
            this.SuspendLayout();
            // 
            // discordButton
            // 
            this.discordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.discordButton.Animated = true;
            this.discordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.discordButton.BorderRadius = 15;
            this.discordButton.CheckedState.Parent = this.discordButton;
            this.discordButton.CustomImages.Parent = this.discordButton;
            this.discordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.discordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.discordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.discordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.discordButton.DisabledState.Parent = this.discordButton;
            this.discordButton.FillColor = System.Drawing.Color.Black;
            this.discordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.discordButton.ForeColor = System.Drawing.Color.White;
            this.discordButton.HoverState.Parent = this.discordButton;
            this.discordButton.Location = new System.Drawing.Point(12, 399);
            this.discordButton.Name = "discordButton";
            this.discordButton.ShadowDecoration.Parent = this.discordButton;
            this.discordButton.Size = new System.Drawing.Size(119, 39);
            this.discordButton.TabIndex = 0;
            this.discordButton.Text = "DISCORD";
            this.discordButton.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // websiteButton
            // 
            this.websiteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.websiteButton.Animated = true;
            this.websiteButton.BorderRadius = 15;
            this.websiteButton.CheckedState.Parent = this.websiteButton;
            this.websiteButton.CustomImages.Parent = this.websiteButton;
            this.websiteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.websiteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.websiteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.websiteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.websiteButton.DisabledState.Parent = this.websiteButton;
            this.websiteButton.FillColor = System.Drawing.Color.Black;
            this.websiteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.websiteButton.ForeColor = System.Drawing.Color.White;
            this.websiteButton.HoverState.Parent = this.websiteButton;
            this.websiteButton.Location = new System.Drawing.Point(137, 399);
            this.websiteButton.Name = "websiteButton";
            this.websiteButton.ShadowDecoration.Parent = this.websiteButton;
            this.websiteButton.Size = new System.Drawing.Size(119, 39);
            this.websiteButton.TabIndex = 1;
            this.websiteButton.Text = "WEB SİTE";
            this.websiteButton.Click += new System.EventHandler(this.websiteButton_Click);
            // 
            // tittleLogos
            // 
            this.tittleLogos.Image = global::passwordgenerator.Properties.Resources.icons8_password_50px_3;
            this.tittleLogos.Location = new System.Drawing.Point(12, 12);
            this.tittleLogos.Name = "tittleLogos";
            this.tittleLogos.Size = new System.Drawing.Size(48, 47);
            this.tittleLogos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tittleLogos.TabIndex = 2;
            this.tittleLogos.TabStop = false;
            this.tittleLogos.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.titleText.ForeColor = System.Drawing.SystemColors.Control;
            this.titleText.Location = new System.Drawing.Point(66, 24);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(193, 22);
            this.titleText.TabIndex = 3;
            this.titleText.Text = "Password Generator";
            // 
            // passwordLenghtText
            // 
            this.passwordLenghtText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLenghtText.AutoSize = true;
            this.passwordLenghtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.passwordLenghtText.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLenghtText.Location = new System.Drawing.Point(328, 213);
            this.passwordLenghtText.Name = "passwordLenghtText";
            this.passwordLenghtText.Size = new System.Drawing.Size(197, 22);
            this.passwordLenghtText.TabIndex = 6;
            this.passwordLenghtText.Text = "Parola Uzunluğu : 20";
            this.passwordLenghtText.Click += new System.EventHandler(this.passwordLenghtText_Click);
            // 
            // passwordCopy
            // 
            this.passwordCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordCopy.Animated = true;
            this.passwordCopy.BorderRadius = 15;
            this.passwordCopy.CheckedState.Parent = this.passwordCopy;
            this.passwordCopy.CustomImages.Parent = this.passwordCopy;
            this.passwordCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passwordCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passwordCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passwordCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passwordCopy.DisabledState.Parent = this.passwordCopy;
            this.passwordCopy.FillColor = System.Drawing.Color.Green;
            this.passwordCopy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.passwordCopy.ForeColor = System.Drawing.Color.White;
            this.passwordCopy.HoverState.Parent = this.passwordCopy;
            this.passwordCopy.Location = new System.Drawing.Point(250, 295);
            this.passwordCopy.Name = "passwordCopy";
            this.passwordCopy.PressedColor = System.Drawing.Color.Green;
            this.passwordCopy.ShadowDecoration.Parent = this.passwordCopy;
            this.passwordCopy.Size = new System.Drawing.Size(301, 39);
            this.passwordCopy.TabIndex = 7;
            this.passwordCopy.Text = "Parolayı Kopyala";
            this.passwordCopy.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(338, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "PASS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLengthSlider
            // 
            this.passwordLengthSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLengthSlider.HoverState.Parent = this.passwordLengthSlider;
            this.passwordLengthSlider.LargeChange = 2;
            this.passwordLengthSlider.Location = new System.Drawing.Point(251, 249);
            this.passwordLengthSlider.Maximum = 20;
            this.passwordLengthSlider.Minimum = 8;
            this.passwordLengthSlider.Name = "passwordLengthSlider";
            this.passwordLengthSlider.Size = new System.Drawing.Size(300, 23);
            this.passwordLengthSlider.TabIndex = 10;
            this.passwordLengthSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.passwordLengthSlider.Value = 20;
            this.passwordLengthSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.passwordLengthSlider_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordLengthSlider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordCopy);
            this.Controls.Add(this.passwordLenghtText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.tittleLogos);
            this.Controls.Add(this.websiteButton);
            this.Controls.Add(this.discordButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator - by favilances";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tittleLogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button discordButton;
        private Guna.UI2.WinForms.Guna2Button websiteButton;
        private System.Windows.Forms.PictureBox tittleLogos;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label passwordLenghtText;
        private Guna.UI2.WinForms.Guna2Button passwordCopy;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar passwordLengthSlider;
    }
}

