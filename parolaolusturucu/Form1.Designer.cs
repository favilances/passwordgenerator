namespace parolaolusturucu
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
            this.passwordLengthSlider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.passwordCopy = new Guna.UI2.WinForms.Guna2Button();
            this.passwordLenghtText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // passwordLengthSlider
            // 
            this.passwordLengthSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLengthSlider.LargeChange = 2;
            this.passwordLengthSlider.Location = new System.Drawing.Point(17, 98);
            this.passwordLengthSlider.Maximum = 20;
            this.passwordLengthSlider.Minimum = 8;
            this.passwordLengthSlider.Name = "passwordLengthSlider";
            this.passwordLengthSlider.Size = new System.Drawing.Size(183, 23);
            this.passwordLengthSlider.TabIndex = 11;
            this.passwordLengthSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.passwordLengthSlider.Value = 20;
            this.passwordLengthSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.passwordLengthSlider_Scroll);
            // 
            // passwordCopy
            // 
            this.passwordCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordCopy.Animated = true;
            this.passwordCopy.BorderRadius = 15;
            this.passwordCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passwordCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passwordCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passwordCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passwordCopy.FillColor = System.Drawing.Color.Green;
            this.passwordCopy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.passwordCopy.ForeColor = System.Drawing.Color.White;
            this.passwordCopy.Location = new System.Drawing.Point(17, 127);
            this.passwordCopy.Name = "passwordCopy";
            this.passwordCopy.PressedColor = System.Drawing.Color.Green;
            this.passwordCopy.Size = new System.Drawing.Size(183, 62);
            this.passwordCopy.TabIndex = 13;
            this.passwordCopy.Text = "Oluşturulan Parolayı Kopyala";
            this.passwordCopy.Click += new System.EventHandler(this.passwordCopy_Click);
            // 
            // passwordLenghtText
            // 
            this.passwordLenghtText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLenghtText.AutoSize = true;
            this.passwordLenghtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.passwordLenghtText.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLenghtText.Location = new System.Drawing.Point(13, 73);
            this.passwordLenghtText.Name = "passwordLenghtText";
            this.passwordLenghtText.Size = new System.Drawing.Size(197, 22);
            this.passwordLenghtText.TabIndex = 12;
            this.passwordLenghtText.Text = "Parola Uzunluğu : 20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "pass";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(17, 206);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Favilances.com.tr";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(223, 297);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordCopy);
            this.Controls.Add(this.passwordLenghtText);
            this.Controls.Add(this.passwordLengthSlider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(239, 336);
            this.MinimumSize = new System.Drawing.Size(239, 336);
            this.Name = "Form1";
            this.Text = "Parola Oluşturucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TrackBar passwordLengthSlider;
        private Guna.UI2.WinForms.Guna2Button passwordCopy;
        private System.Windows.Forms.Label passwordLenghtText;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

