namespace Proje1._1
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pbox_ıconlogin = new System.Windows.Forms.PictureBox();
            this.bffbtn_Login = new ns1.BunifuFlatButton();
            this.bfmTxt_username = new ns1.BunifuMaterialTextbox();
            this.bfmTxt_Password = new ns1.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.bunifuImageButton3 = new ns1.BunifuImageButton();
            this.bunifuImageButton4 = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ıconlogin)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_ıconlogin
            // 
            this.pbox_ıconlogin.Image = ((System.Drawing.Image)(resources.GetObject("pbox_ıconlogin.Image")));
            this.pbox_ıconlogin.Location = new System.Drawing.Point(160, 74);
            this.pbox_ıconlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbox_ıconlogin.Name = "pbox_ıconlogin";
            this.pbox_ıconlogin.Size = new System.Drawing.Size(80, 80);
            this.pbox_ıconlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ıconlogin.TabIndex = 3;
            this.pbox_ıconlogin.TabStop = false;
            // 
            // bffbtn_Login
            // 
            this.bffbtn_Login.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.bffbtn_Login.BackColor = System.Drawing.Color.DodgerBlue;
            this.bffbtn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bffbtn_Login.BorderRadius = 0;
            this.bffbtn_Login.ButtonText = "Giriş Yap";
            this.bffbtn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bffbtn_Login.DisabledColor = System.Drawing.Color.Gray;
            this.bffbtn_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.bffbtn_Login.Iconimage = ((System.Drawing.Image)(resources.GetObject("bffbtn_Login.Iconimage")));
            this.bffbtn_Login.Iconimage_right = null;
            this.bffbtn_Login.Iconimage_right_Selected = null;
            this.bffbtn_Login.Iconimage_Selected = null;
            this.bffbtn_Login.IconMarginLeft = 0;
            this.bffbtn_Login.IconMarginRight = 0;
            this.bffbtn_Login.IconRightVisible = true;
            this.bffbtn_Login.IconRightZoom = 0D;
            this.bffbtn_Login.IconVisible = true;
            this.bffbtn_Login.IconZoom = 90D;
            this.bffbtn_Login.IsTab = false;
            this.bffbtn_Login.Location = new System.Drawing.Point(160, 295);
            this.bffbtn_Login.Margin = new System.Windows.Forms.Padding(5);
            this.bffbtn_Login.Name = "bffbtn_Login";
            this.bffbtn_Login.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bffbtn_Login.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.bffbtn_Login.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bffbtn_Login.selected = false;
            this.bffbtn_Login.Size = new System.Drawing.Size(192, 52);
            this.bffbtn_Login.TabIndex = 3;
            this.bffbtn_Login.Text = "Giriş Yap";
            this.bffbtn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bffbtn_Login.Textcolor = System.Drawing.Color.White;
            this.bffbtn_Login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bffbtn_Login.Click += new System.EventHandler(this.bffbtn_Login_Click);
            // 
            // bfmTxt_username
            // 
            this.bfmTxt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bfmTxt_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bfmTxt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bfmTxt_username.HintForeColor = System.Drawing.Color.Empty;
            this.bfmTxt_username.HintText = "";
            this.bfmTxt_username.isPassword = false;
            this.bfmTxt_username.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.bfmTxt_username.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.bfmTxt_username.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.bfmTxt_username.LineThickness = 5;
            this.bfmTxt_username.Location = new System.Drawing.Point(45, 173);
            this.bfmTxt_username.Margin = new System.Windows.Forms.Padding(5);
            this.bfmTxt_username.Name = "bfmTxt_username";
            this.bfmTxt_username.Size = new System.Drawing.Size(307, 44);
            this.bfmTxt_username.TabIndex = 99;
            this.bfmTxt_username.Text = "Kullanıcı Adı";
            this.bfmTxt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bfmTxt_username.Enter += new System.EventHandler(this.bfmTxt_username_Enter);
            this.bfmTxt_username.Leave += new System.EventHandler(this.bfmTxt_username_Leave);
            // 
            // bfmTxt_Password
            // 
            this.bfmTxt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bfmTxt_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bfmTxt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bfmTxt_Password.HintForeColor = System.Drawing.Color.Empty;
            this.bfmTxt_Password.HintText = "";
            this.bfmTxt_Password.isPassword = true;
            this.bfmTxt_Password.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.bfmTxt_Password.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.bfmTxt_Password.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.bfmTxt_Password.LineThickness = 5;
            this.bfmTxt_Password.Location = new System.Drawing.Point(45, 225);
            this.bfmTxt_Password.Margin = new System.Windows.Forms.Padding(5);
            this.bfmTxt_Password.Name = "bfmTxt_Password";
            this.bfmTxt_Password.Size = new System.Drawing.Size(307, 44);
            this.bfmTxt_Password.TabIndex = 100;
            this.bfmTxt_Password.Text = "Şifre";
            this.bfmTxt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bfmTxt_Password.Enter += new System.EventHandler(this.bfmTxt_Password_Enter);
            this.bfmTxt_Password.Leave += new System.EventHandler(this.bfmTxt_Password_Leave);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton4);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(400, 55);
            this.bunifuGradientPanel1.TabIndex = 26;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(330, 0);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(70, 50);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 23;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 0;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton4.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(250, 0);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(70, 50);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 24;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 0;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 405);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bfmTxt_Password);
            this.Controls.Add(this.bfmTxt_username);
            this.Controls.Add(this.bffbtn_Login);
            this.Controls.Add(this.pbox_ıconlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ıconlogin)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbox_ıconlogin;
        private ns1.BunifuFlatButton bffbtn_Login;
        private ns1.BunifuMaterialTextbox bfmTxt_username;
        private ns1.BunifuMaterialTextbox bfmTxt_Password;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuImageButton bunifuImageButton3;
        private ns1.BunifuImageButton bunifuImageButton4;
    }
}

