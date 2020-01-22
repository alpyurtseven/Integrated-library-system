namespace Proje1._1
{
    partial class StaffPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPanel));
            this.bunifuCustomDataGrid1 = new ns1.BunifuCustomDataGrid();
            this.usernumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbtadminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryotoDataSet = new Proje1._1.libraryotoDataSet();
            this.dbt_adminTableAdapter = new Proje1._1.libraryotoDataSetTableAdapters.dbt_adminTableAdapter();
            this.bftxt_UserNumber = new ns1.BunifuMaterialTextbox();
            this.bftxt_Name = new ns1.BunifuMaterialTextbox();
            this.bftxt_Surname = new ns1.BunifuMaterialTextbox();
            this.bftxt_Status = new ns1.BunifuMaterialTextbox();
            this.bftxt_Password = new ns1.BunifuMaterialTextbox();
            this.bffbtn_AddStaff = new ns1.BunifuFlatButton();
            this.bfbtn_Update = new ns1.BunifuFlatButton();
            this.bfbtn_Delete = new ns1.BunifuFlatButton();
            this.bfbtn_CleanTextBox = new ns1.BunifuFlatButton();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.bunifuImageButton5 = new ns1.BunifuImageButton();
            this.bunifuImageButton3 = new ns1.BunifuImageButton();
            this.bunifuImageButton4 = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtadminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryotoDataSet)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeColumns = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernumber,
            this.name,
            this.surname,
            this.status,
            this.password});
            this.bunifuCustomDataGrid1.DataSource = this.dbtadminBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 87);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCustomDataGrid1.MultiSelect = false;
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 10;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(786, 647);
            this.bunifuCustomDataGrid1.TabIndex = 1;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // usernumber
            // 
            this.usernumber.DataPropertyName = "kullanicino";
            this.usernumber.HeaderText = "Personel No";
            this.usernumber.MinimumWidth = 6;
            this.usernumber.Name = "usernumber";
            this.usernumber.ReadOnly = true;
            this.usernumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.usernumber.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "adi";
            this.name.HeaderText = "Adı";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "soyadi";
            this.surname.HeaderText = "Soyadı";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "statu";
            this.status.HeaderText = "Statü";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // password
            // 
            this.password.DataPropertyName = "sifre";
            this.password.HeaderText = "Şifre";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 85;
            // 
            // dbtadminBindingSource
            // 
            this.dbtadminBindingSource.DataMember = "dbt_admin";
            this.dbtadminBindingSource.DataSource = this.libraryotoDataSet;
            // 
            // libraryotoDataSet
            // 
            this.libraryotoDataSet.DataSetName = "libraryotoDataSet";
            this.libraryotoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbt_adminTableAdapter
            // 
            this.dbt_adminTableAdapter.ClearBeforeFill = true;
            // 
            // bftxt_UserNumber
            // 
            this.bftxt_UserNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxt_UserNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bftxt_UserNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.bftxt_UserNumber.HintForeColor = System.Drawing.Color.Empty;
            this.bftxt_UserNumber.HintText = "";
            this.bftxt_UserNumber.isPassword = false;
            this.bftxt_UserNumber.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.bftxt_UserNumber.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.bftxt_UserNumber.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.bftxt_UserNumber.LineThickness = 3;
            this.bftxt_UserNumber.Location = new System.Drawing.Point(795, 95);
            this.bftxt_UserNumber.Margin = new System.Windows.Forms.Padding(5);
            this.bftxt_UserNumber.Name = "bftxt_UserNumber";
            this.bftxt_UserNumber.Size = new System.Drawing.Size(493, 54);
            this.bftxt_UserNumber.TabIndex = 2;
            this.bftxt_UserNumber.Text = "Kullanıcı No";
            this.bftxt_UserNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bftxt_UserNumber.Enter += new System.EventHandler(this.bftxt_UserNumber_Enter);
            this.bftxt_UserNumber.Leave += new System.EventHandler(this.bftxt_UserNumber_Leave);
            // 
            // bftxt_Name
            // 
            this.bftxt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxt_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bftxt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.bftxt_Name.HintForeColor = System.Drawing.Color.Empty;
            this.bftxt_Name.HintText = "";
            this.bftxt_Name.isPassword = false;
            this.bftxt_Name.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.bftxt_Name.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.bftxt_Name.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.bftxt_Name.LineThickness = 3;
            this.bftxt_Name.Location = new System.Drawing.Point(795, 192);
            this.bftxt_Name.Margin = new System.Windows.Forms.Padding(5);
            this.bftxt_Name.Name = "bftxt_Name";
            this.bftxt_Name.Size = new System.Drawing.Size(493, 54);
            this.bftxt_Name.TabIndex = 3;
            this.bftxt_Name.Text = "Adı";
            this.bftxt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bftxt_Name.Enter += new System.EventHandler(this.bftxt_Name_Enter);
            this.bftxt_Name.Leave += new System.EventHandler(this.bftxt_Name_Leave);
            // 
            // bftxt_Surname
            // 
            this.bftxt_Surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxt_Surname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bftxt_Surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.bftxt_Surname.HintForeColor = System.Drawing.Color.Empty;
            this.bftxt_Surname.HintText = "";
            this.bftxt_Surname.isPassword = false;
            this.bftxt_Surname.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.bftxt_Surname.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.bftxt_Surname.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.bftxt_Surname.LineThickness = 3;
            this.bftxt_Surname.Location = new System.Drawing.Point(795, 292);
            this.bftxt_Surname.Margin = new System.Windows.Forms.Padding(5);
            this.bftxt_Surname.Name = "bftxt_Surname";
            this.bftxt_Surname.Size = new System.Drawing.Size(493, 54);
            this.bftxt_Surname.TabIndex = 4;
            this.bftxt_Surname.Text = "Soyadı";
            this.bftxt_Surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bftxt_Surname.Enter += new System.EventHandler(this.bftxt_Surname_Enter);
            this.bftxt_Surname.Leave += new System.EventHandler(this.bftxt_Surname_Leave);
            // 
            // bftxt_Status
            // 
            this.bftxt_Status.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxt_Status.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bftxt_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.bftxt_Status.HintForeColor = System.Drawing.Color.Empty;
            this.bftxt_Status.HintText = "";
            this.bftxt_Status.isPassword = false;
            this.bftxt_Status.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.bftxt_Status.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.bftxt_Status.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.bftxt_Status.LineThickness = 3;
            this.bftxt_Status.Location = new System.Drawing.Point(795, 394);
            this.bftxt_Status.Margin = new System.Windows.Forms.Padding(5);
            this.bftxt_Status.Name = "bftxt_Status";
            this.bftxt_Status.Size = new System.Drawing.Size(493, 54);
            this.bftxt_Status.TabIndex = 5;
            this.bftxt_Status.Text = "Statü";
            this.bftxt_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bftxt_Status.Enter += new System.EventHandler(this.bftxt_Status_Enter);
            this.bftxt_Status.Leave += new System.EventHandler(this.bftxt_Status_Leave);
            // 
            // bftxt_Password
            // 
            this.bftxt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxt_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bftxt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.bftxt_Password.HintForeColor = System.Drawing.Color.Empty;
            this.bftxt_Password.HintText = "";
            this.bftxt_Password.isPassword = false;
            this.bftxt_Password.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.bftxt_Password.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.bftxt_Password.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.bftxt_Password.LineThickness = 3;
            this.bftxt_Password.Location = new System.Drawing.Point(795, 490);
            this.bftxt_Password.Margin = new System.Windows.Forms.Padding(5);
            this.bftxt_Password.Name = "bftxt_Password";
            this.bftxt_Password.Size = new System.Drawing.Size(493, 54);
            this.bftxt_Password.TabIndex = 6;
            this.bftxt_Password.Text = "Şifre";
            this.bftxt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bftxt_Password.Enter += new System.EventHandler(this.bftxt_Password_Enter);
            this.bftxt_Password.Leave += new System.EventHandler(this.bftxt_Password_Leave);
            // 
            // bffbtn_AddStaff
            // 
            this.bffbtn_AddStaff.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.bffbtn_AddStaff.BackColor = System.Drawing.Color.DodgerBlue;
            this.bffbtn_AddStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bffbtn_AddStaff.BorderRadius = 0;
            this.bffbtn_AddStaff.ButtonText = "Ekle";
            this.bffbtn_AddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bffbtn_AddStaff.DisabledColor = System.Drawing.Color.Gray;
            this.bffbtn_AddStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.bffbtn_AddStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("bffbtn_AddStaff.Iconimage")));
            this.bffbtn_AddStaff.Iconimage_right = null;
            this.bffbtn_AddStaff.Iconimage_right_Selected = null;
            this.bffbtn_AddStaff.Iconimage_Selected = null;
            this.bffbtn_AddStaff.IconMarginLeft = 0;
            this.bffbtn_AddStaff.IconMarginRight = 0;
            this.bffbtn_AddStaff.IconRightVisible = true;
            this.bffbtn_AddStaff.IconRightZoom = 0D;
            this.bffbtn_AddStaff.IconVisible = true;
            this.bffbtn_AddStaff.IconZoom = 90D;
            this.bffbtn_AddStaff.IsTab = false;
            this.bffbtn_AddStaff.Location = new System.Drawing.Point(861, 588);
            this.bffbtn_AddStaff.Margin = new System.Windows.Forms.Padding(5);
            this.bffbtn_AddStaff.Name = "bffbtn_AddStaff";
            this.bffbtn_AddStaff.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bffbtn_AddStaff.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.bffbtn_AddStaff.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bffbtn_AddStaff.selected = false;
            this.bffbtn_AddStaff.Size = new System.Drawing.Size(199, 62);
            this.bffbtn_AddStaff.TabIndex = 7;
            this.bffbtn_AddStaff.Text = "Ekle";
            this.bffbtn_AddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bffbtn_AddStaff.Textcolor = System.Drawing.Color.White;
            this.bffbtn_AddStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bffbtn_AddStaff.Click += new System.EventHandler(this.bffbtn_AddStaff_Click);
            // 
            // bfbtn_Update
            // 
            this.bfbtn_Update.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.bfbtn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.bfbtn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbtn_Update.BorderRadius = 0;
            this.bfbtn_Update.ButtonText = "Güncelle";
            this.bfbtn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbtn_Update.DisabledColor = System.Drawing.Color.Gray;
            this.bfbtn_Update.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbtn_Update.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbtn_Update.Iconimage")));
            this.bfbtn_Update.Iconimage_right = null;
            this.bfbtn_Update.Iconimage_right_Selected = null;
            this.bfbtn_Update.Iconimage_Selected = null;
            this.bfbtn_Update.IconMarginLeft = 0;
            this.bfbtn_Update.IconMarginRight = 0;
            this.bfbtn_Update.IconRightVisible = true;
            this.bfbtn_Update.IconRightZoom = 0D;
            this.bfbtn_Update.IconVisible = true;
            this.bfbtn_Update.IconZoom = 90D;
            this.bfbtn_Update.IsTab = false;
            this.bfbtn_Update.Location = new System.Drawing.Point(1089, 662);
            this.bfbtn_Update.Margin = new System.Windows.Forms.Padding(5);
            this.bfbtn_Update.Name = "bfbtn_Update";
            this.bfbtn_Update.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bfbtn_Update.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.bfbtn_Update.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bfbtn_Update.selected = false;
            this.bfbtn_Update.Size = new System.Drawing.Size(199, 62);
            this.bfbtn_Update.TabIndex = 8;
            this.bfbtn_Update.Text = "Güncelle";
            this.bfbtn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbtn_Update.Textcolor = System.Drawing.Color.White;
            this.bfbtn_Update.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbtn_Update.Click += new System.EventHandler(this.bfbtn_Update_Click);
            // 
            // bfbtn_Delete
            // 
            this.bfbtn_Delete.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.bfbtn_Delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.bfbtn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbtn_Delete.BorderRadius = 0;
            this.bfbtn_Delete.ButtonText = "Sil";
            this.bfbtn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbtn_Delete.DisabledColor = System.Drawing.Color.Gray;
            this.bfbtn_Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbtn_Delete.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbtn_Delete.Iconimage")));
            this.bfbtn_Delete.Iconimage_right = null;
            this.bfbtn_Delete.Iconimage_right_Selected = null;
            this.bfbtn_Delete.Iconimage_Selected = null;
            this.bfbtn_Delete.IconMarginLeft = 0;
            this.bfbtn_Delete.IconMarginRight = 0;
            this.bfbtn_Delete.IconRightVisible = true;
            this.bfbtn_Delete.IconRightZoom = 0D;
            this.bfbtn_Delete.IconVisible = true;
            this.bfbtn_Delete.IconZoom = 90D;
            this.bfbtn_Delete.IsTab = false;
            this.bfbtn_Delete.Location = new System.Drawing.Point(1089, 588);
            this.bfbtn_Delete.Margin = new System.Windows.Forms.Padding(5);
            this.bfbtn_Delete.Name = "bfbtn_Delete";
            this.bfbtn_Delete.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bfbtn_Delete.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.bfbtn_Delete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bfbtn_Delete.selected = false;
            this.bfbtn_Delete.Size = new System.Drawing.Size(199, 62);
            this.bfbtn_Delete.TabIndex = 9;
            this.bfbtn_Delete.Text = "Sil";
            this.bfbtn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbtn_Delete.Textcolor = System.Drawing.Color.White;
            this.bfbtn_Delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbtn_Delete.Click += new System.EventHandler(this.bfbtn_Delete_Click);
            // 
            // bfbtn_CleanTextBox
            // 
            this.bfbtn_CleanTextBox.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.bfbtn_CleanTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.bfbtn_CleanTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbtn_CleanTextBox.BorderRadius = 0;
            this.bfbtn_CleanTextBox.ButtonText = "Temizle";
            this.bfbtn_CleanTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbtn_CleanTextBox.DisabledColor = System.Drawing.Color.Gray;
            this.bfbtn_CleanTextBox.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbtn_CleanTextBox.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbtn_CleanTextBox.Iconimage")));
            this.bfbtn_CleanTextBox.Iconimage_right = null;
            this.bfbtn_CleanTextBox.Iconimage_right_Selected = null;
            this.bfbtn_CleanTextBox.Iconimage_Selected = null;
            this.bfbtn_CleanTextBox.IconMarginLeft = 0;
            this.bfbtn_CleanTextBox.IconMarginRight = 0;
            this.bfbtn_CleanTextBox.IconRightVisible = true;
            this.bfbtn_CleanTextBox.IconRightZoom = 0D;
            this.bfbtn_CleanTextBox.IconVisible = true;
            this.bfbtn_CleanTextBox.IconZoom = 90D;
            this.bfbtn_CleanTextBox.IsTab = false;
            this.bfbtn_CleanTextBox.Location = new System.Drawing.Point(861, 662);
            this.bfbtn_CleanTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.bfbtn_CleanTextBox.Name = "bfbtn_CleanTextBox";
            this.bfbtn_CleanTextBox.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bfbtn_CleanTextBox.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.bfbtn_CleanTextBox.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bfbtn_CleanTextBox.selected = false;
            this.bfbtn_CleanTextBox.Size = new System.Drawing.Size(199, 62);
            this.bfbtn_CleanTextBox.TabIndex = 10;
            this.bfbtn_CleanTextBox.Text = "Temizle";
            this.bfbtn_CleanTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbtn_CleanTextBox.Textcolor = System.Drawing.Color.White;
            this.bfbtn_CleanTextBox.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbtn_CleanTextBox.Click += new System.EventHandler(this.bfbtn_CleanTextBox_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton5);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1333, 87);
            this.bunifuGradientPanel1.TabIndex = 26;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(1103, 0);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(70, 50);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 25;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 0;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(1263, 0);
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
            this.bunifuImageButton4.Location = new System.Drawing.Point(1183, 0);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(70, 50);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 24;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 0;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // StaffPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bfbtn_CleanTextBox);
            this.Controls.Add(this.bfbtn_Delete);
            this.Controls.Add(this.bfbtn_Update);
            this.Controls.Add(this.bffbtn_AddStaff);
            this.Controls.Add(this.bftxt_Password);
            this.Controls.Add(this.bftxt_Status);
            this.Controls.Add(this.bftxt_Surname);
            this.Controls.Add(this.bftxt_Name);
            this.Controls.Add(this.bftxt_UserNumber);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffPanel";
            this.Load += new System.EventHandler(this.StaffPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtadminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryotoDataSet)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private libraryotoDataSet libraryotoDataSet;
        private System.Windows.Forms.BindingSource dbtadminBindingSource;
        private libraryotoDataSetTableAdapters.dbt_adminTableAdapter dbt_adminTableAdapter;
        private ns1.BunifuMaterialTextbox bftxt_UserNumber;
        private ns1.BunifuMaterialTextbox bftxt_Name;
        private ns1.BunifuMaterialTextbox bftxt_Surname;
        private ns1.BunifuMaterialTextbox bftxt_Status;
        private ns1.BunifuMaterialTextbox bftxt_Password;
        private ns1.BunifuFlatButton bffbtn_AddStaff;
        private ns1.BunifuFlatButton bfbtn_Update;
        private ns1.BunifuFlatButton bfbtn_Delete;
        private ns1.BunifuFlatButton bfbtn_CleanTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuImageButton bunifuImageButton5;
        private ns1.BunifuImageButton bunifuImageButton3;
        private ns1.BunifuImageButton bunifuImageButton4;
    }
}