namespace EGGS_PROGECTS
{
    partial class LOGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(529, 73);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المستخدم:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(529, 170);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة المرور :";
            // 
            // btncancel
            // 
            this.btncancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btncancel.Animated = true;
            this.btncancel.BorderRadius = 15;
            this.btncancel.BorderThickness = 2;
            this.btncancel.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncancel.CheckedState.Parent = this.btncancel;
            this.btncancel.CustomImages.Parent = this.btncancel;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.FillColor = System.Drawing.Color.White;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btncancel.HoverState.Parent = this.btncancel;
            this.btncancel.Image = global::EGGS_PROGECTS.Properties.Resources.logout_48px;
            this.btncancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncancel.ImageSize = new System.Drawing.Size(35, 37);
            this.btncancel.Location = new System.Drawing.Point(134, 249);
            this.btncancel.Name = "btncancel";
            this.btncancel.ShadowDecoration.Parent = this.btncancel;
            this.btncancel.Size = new System.Drawing.Size(188, 66);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "إلغاء التسجيل";
            this.btncancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnlogin.Animated = true;
            this.btnlogin.BorderRadius = 15;
            this.btnlogin.BorderThickness = 2;
            this.btnlogin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlogin.CheckedState.Parent = this.btnlogin;
            this.btnlogin.CustomImages.Parent = this.btnlogin;
            this.btnlogin.FillColor = System.Drawing.Color.White;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnlogin.HoverState.Parent = this.btnlogin;
            this.btnlogin.Image = global::EGGS_PROGECTS.Properties.Resources.login_rounded_48px;
            this.btnlogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlogin.ImageSize = new System.Drawing.Size(35, 37);
            this.btnlogin.Location = new System.Drawing.Point(477, 249);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
            this.btnlogin.Size = new System.Drawing.Size(188, 66);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "تسجيل الدخول";
            this.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // txtpass
            // 
            this.txtpass.BorderColor = System.Drawing.Color.Black;
            this.txtpass.BorderRadius = 10;
            this.txtpass.BorderThickness = 2;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.Parent = this.txtpass;
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.FocusedState.Parent = this.txtpass;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.HoverState.Parent = this.txtpass;
            this.txtpass.IconRightOffset = new System.Drawing.Point(300, 0);
            this.txtpass.IconRightSize = new System.Drawing.Size(35, 30);
            this.txtpass.Location = new System.Drawing.Point(177, 158);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtpass.PlaceholderText = "******";
            this.txtpass.SelectedText = "";
            this.txtpass.ShadowDecoration.Parent = this.txtpass;
            this.txtpass.Size = new System.Drawing.Size(349, 55);
            this.txtpass.TabIndex = 1;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtname
            // 
            this.txtname.BorderColor = System.Drawing.Color.Black;
            this.txtname.BorderRadius = 10;
            this.txtname.BorderThickness = 2;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.Parent = this.txtname;
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.FocusedState.Parent = this.txtname;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.IconRightOffset = new System.Drawing.Point(300, 0);
            this.txtname.IconRightSize = new System.Drawing.Size(45, 40);
            this.txtname.Location = new System.Drawing.Point(177, 66);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtname.PlaceholderText = "Name";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(349, 55);
            this.txtname.TabIndex = 0;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2CirclePictureBox3.Image = global::EGGS_PROGECTS.Properties.Resources.customer_48px;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(108, 66);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.ShadowDecoration.Parent = this.guna2CirclePictureBox3;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(62, 55);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 86;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2CirclePictureBox1.Image = global::EGGS_PROGECTS.Properties.Resources.password_48px;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(108, 158);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(62, 55);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 87;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(752, 362);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2CirclePictureBox3);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2Button btncancel;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}