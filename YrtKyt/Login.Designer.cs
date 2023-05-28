namespace YrtKyt
{
    partial class Login
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
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(62, 120);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(204, 20);
            this.password_textbox.TabIndex = 7;
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(62, 82);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(204, 20);
            this.username_textbox.TabIndex = 6;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(180, 162);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(86, 40);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "Kayıt Ol";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(62, 162);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(86, 40);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Giriş Yap";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 244);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
    }
}

