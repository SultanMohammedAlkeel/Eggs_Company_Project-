namespace EGGS_PROGECTS
{
    partial class users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            this.pnldgv = new System.Windows.Forms.Panel();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlfields = new System.Windows.Forms.Panel();
            this.cmblicense = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUUpass = new System.Windows.Forms.TextBox();
            this.txtUpass = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.btncancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnnew = new Guna.UI2.WinForms.Guna2Button();
            this.search = new Bunifu.Framework.UI.BunifuTextbox();
            this.pnldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlfields.SuspendLayout();
            this.pnlcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnldgv
            // 
            this.pnldgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnldgv.Controls.Add(this.dgv);
            this.pnldgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldgv.Location = new System.Drawing.Point(379, 103);
            this.pnldgv.Name = "pnldgv";
            this.pnldgv.Size = new System.Drawing.Size(857, 577);
            this.pnldgv.TabIndex = 11;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(853, 573);
            this.dgv.TabIndex = 0;
            this.dgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 45;
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv.ThemeStyle.RowsStyle.Height = 28;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // pnlfields
            // 
            this.pnlfields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlfields.Controls.Add(this.btncancel);
            this.pnlfields.Controls.Add(this.btnsave);
            this.pnlfields.Controls.Add(this.guna2CirclePictureBox3);
            this.pnlfields.Controls.Add(this.guna2CirclePictureBox4);
            this.pnlfields.Controls.Add(this.guna2CirclePictureBox2);
            this.pnlfields.Controls.Add(this.guna2CirclePictureBox1);
            this.pnlfields.Controls.Add(this.cmblicense);
            this.pnlfields.Controls.Add(this.label8);
            this.pnlfields.Controls.Add(this.label7);
            this.pnlfields.Controls.Add(this.label6);
            this.pnlfields.Controls.Add(this.label5);
            this.pnlfields.Controls.Add(this.txtUUpass);
            this.pnlfields.Controls.Add(this.txtUpass);
            this.pnlfields.Controls.Add(this.txtUname);
            this.pnlfields.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlfields.Enabled = false;
            this.pnlfields.Location = new System.Drawing.Point(0, 103);
            this.pnlfields.Name = "pnlfields";
            this.pnlfields.Size = new System.Drawing.Size(379, 577);
            this.pnlfields.TabIndex = 9;
            // 
            // cmblicense
            // 
            this.cmblicense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmblicense.FormattingEnabled = true;
            this.cmblicense.Items.AddRange(new object[] {
            "YEMEN",
            "USA",
            "EGEPT",
            "SA"});
            this.cmblicense.Location = new System.Drawing.Point(18, 382);
            this.cmblicense.Name = "cmblicense";
            this.cmblicense.Size = new System.Drawing.Size(264, 37);
            this.cmblicense.TabIndex = 3;
            this.cmblicense.SelectedIndexChanged += new System.EventHandler(this.cmbcountry_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 30);
            this.label8.TabIndex = 33;
            this.label8.Text = "اسم المستخدم";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(162, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 30);
            this.label7.TabIndex = 34;
            this.label7.Text = "كلمة المرور";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 30);
            this.label6.TabIndex = 35;
            this.label6.Text = "تاكيد كلمة المرور";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 30);
            this.label5.TabIndex = 36;
            this.label5.Text = "نوع الترخيص";
            // 
            // txtUUpass
            // 
            this.txtUUpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUUpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUUpass.Location = new System.Drawing.Point(18, 280);
            this.txtUUpass.Name = "txtUUpass";
            this.txtUUpass.Size = new System.Drawing.Size(264, 35);
            this.txtUUpass.TabIndex = 2;
            // 
            // txtUpass
            // 
            this.txtUpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpass.Location = new System.Drawing.Point(18, 173);
            this.txtUpass.Name = "txtUpass";
            this.txtUpass.Size = new System.Drawing.Size(264, 35);
            this.txtUpass.TabIndex = 1;
            // 
            // txtUname
            // 
            this.txtUname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.Location = new System.Drawing.Point(18, 69);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(264, 35);
            this.txtUname.TabIndex = 0;
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlcontrol.Controls.Add(this.btndelete);
            this.pnlcontrol.Controls.Add(this.btnupdate);
            this.pnlcontrol.Controls.Add(this.btnnew);
            this.pnlcontrol.Controls.Add(this.search);
            this.pnlcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlcontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(1236, 103);
            this.pnlcontrol.TabIndex = 10;
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Animated = true;
            this.btncancel.BorderRadius = 15;
            this.btncancel.BorderThickness = 2;
            this.btncancel.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncancel.CheckedState.Parent = this.btncancel;
            this.btncancel.CustomImages.Parent = this.btncancel;
            this.btncancel.FillColor = System.Drawing.Color.White;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btncancel.HoverState.Parent = this.btncancel;
            this.btncancel.Image = global::EGGS_PROGECTS.Properties.Resources.cancel_48px;
            this.btncancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncancel.ImageSize = new System.Drawing.Size(35, 37);
            this.btncancel.Location = new System.Drawing.Point(9, 454);
            this.btncancel.Name = "btncancel";
            this.btncancel.ShadowDecoration.Parent = this.btncancel;
            this.btncancel.Size = new System.Drawing.Size(126, 69);
            this.btncancel.TabIndex = 48;
            this.btncancel.Text = "إلغاء";
            this.btncancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Animated = true;
            this.btnsave.BorderRadius = 15;
            this.btnsave.BorderThickness = 2;
            this.btnsave.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsave.CheckedState.Parent = this.btnsave;
            this.btnsave.CustomImages.Parent = this.btnsave;
            this.btnsave.FillColor = System.Drawing.Color.White;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnsave.HoverState.Parent = this.btnsave;
            this.btnsave.Image = global::EGGS_PROGECTS.Properties.Resources.save_48px;
            this.btnsave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsave.ImageSize = new System.Drawing.Size(35, 37);
            this.btnsave.Location = new System.Drawing.Point(236, 454);
            this.btnsave.Name = "btnsave";
            this.btnsave.ShadowDecoration.Parent = this.btnsave;
            this.btnsave.Size = new System.Drawing.Size(126, 69);
            this.btnsave.TabIndex = 47;
            this.btnsave.Text = "حفظ";
            this.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.guna2CirclePictureBox3.Image = global::EGGS_PROGECTS.Properties.Resources.identity_theft_48px;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(288, 348);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.ShadowDecoration.Parent = this.guna2CirclePictureBox3;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(70, 70);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 46;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.guna2CirclePictureBox4.Image = global::EGGS_PROGECTS.Properties.Resources.password_reset_48px;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(288, 243);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.ShadowDecoration.Parent = this.guna2CirclePictureBox4;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(70, 70);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox4.TabIndex = 45;
            this.guna2CirclePictureBox4.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2CirclePictureBox2.Image = global::EGGS_PROGECTS.Properties.Resources.password_48px;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(288, 136);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(70, 70);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 44;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2CirclePictureBox1.Image = global::EGGS_PROGECTS.Properties.Resources.customer_48px1;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(288, 32);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(70, 70);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 43;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.Animated = true;
            this.btndelete.BorderRadius = 15;
            this.btndelete.BorderThickness = 2;
            this.btndelete.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndelete.CheckedState.Parent = this.btndelete;
            this.btndelete.CustomImages.Parent = this.btndelete;
            this.btndelete.Enabled = false;
            this.btndelete.FillColor = System.Drawing.Color.White;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btndelete.HoverState.Parent = this.btndelete;
            this.btndelete.Image = global::EGGS_PROGECTS.Properties.Resources.delete_48px;
            this.btndelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndelete.ImageSize = new System.Drawing.Size(35, 37);
            this.btndelete.Location = new System.Drawing.Point(774, 14);
            this.btndelete.Name = "btndelete";
            this.btndelete.ShadowDecoration.Parent = this.btndelete;
            this.btndelete.Size = new System.Drawing.Size(136, 66);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "حذف";
            this.btndelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnupdate
            // 
            this.btnupdate.Animated = true;
            this.btnupdate.BorderRadius = 15;
            this.btnupdate.BorderThickness = 2;
            this.btnupdate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.Enabled = false;
            this.btnupdate.FillColor = System.Drawing.Color.White;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Image = global::EGGS_PROGECTS.Properties.Resources.update_file_48px;
            this.btnupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnupdate.ImageSize = new System.Drawing.Size(35, 37);
            this.btnupdate.Location = new System.Drawing.Point(934, 14);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(136, 66);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // btnnew
            // 
            this.btnnew.Animated = true;
            this.btnnew.BorderRadius = 15;
            this.btnnew.BorderThickness = 2;
            this.btnnew.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnnew.CheckedState.Parent = this.btnnew;
            this.btnnew.CustomImages.Parent = this.btnnew;
            this.btnnew.FillColor = System.Drawing.Color.White;
            this.btnnew.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnnew.ForeColor = System.Drawing.Color.Black;
            this.btnnew.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnnew.HoverState.Parent = this.btnnew;
            this.btnnew.Image = global::EGGS_PROGECTS.Properties.Resources.New_48px;
            this.btnnew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnnew.ImageSize = new System.Drawing.Size(35, 37);
            this.btnnew.Location = new System.Drawing.Point(1086, 14);
            this.btnnew.Name = "btnnew";
            this.btnnew.ShadowDecoration.Parent = this.btnnew;
            this.btnnew.Size = new System.Drawing.Size(136, 66);
            this.btnnew.TabIndex = 5;
            this.btnnew.Text = "جديد";
            this.btnnew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click_1);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Icon = ((System.Drawing.Image)(resources.GetObject("search.Icon")));
            this.search.Location = new System.Drawing.Point(36, 15);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(534, 66);
            this.search.TabIndex = 4;
            this.search.text = "البحث ";
            this.search.OnTextChange += new System.EventHandler(this.search_OnTextChange);
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 680);
            this.Controls.Add(this.pnldgv);
            this.Controls.Add(this.pnlfields);
            this.Controls.Add(this.pnlcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "users";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.users_Load);
            this.pnldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlfields.ResumeLayout(false);
            this.pnlfields.PerformLayout();
            this.pnlcontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnldgv;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private System.Windows.Forms.Panel pnlfields;
        private Guna.UI2.WinForms.Guna2Button btncancel;
        private Guna.UI2.WinForms.Guna2Button btnsave;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.ComboBox cmblicense;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUUpass;
        private System.Windows.Forms.TextBox txtUpass;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Panel pnlcontrol;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btnnew;
        private Bunifu.Framework.UI.BunifuTextbox search;
    }
}