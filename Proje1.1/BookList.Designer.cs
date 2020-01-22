namespace Proje1._1
{
    partial class BookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dbtkitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryotoDataSet7 = new Proje1._1.libraryotoDataSet7();
            this.dbt_kitaplarTableAdapter = new Proje1._1.libraryotoDataSet7TableAdapters.dbt_kitaplarTableAdapter();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.bunifuImageButton5 = new ns1.BunifuImageButton();
            this.bunifuImageButton3 = new ns1.BunifuImageButton();
            this.bunifuImageButton4 = new ns1.BunifuImageButton();
            this.bfDG_Books = new ns1.BunifuCustomDataGrid();
            this.kitapidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitleikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baskinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryotoDataSet7)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bfDG_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // dbtkitaplarBindingSource
            // 
            this.dbtkitaplarBindingSource.DataMember = "dbt_kitaplar";
            this.dbtkitaplarBindingSource.DataSource = this.libraryotoDataSet7;
            // 
            // libraryotoDataSet7
            // 
            this.libraryotoDataSet7.DataSetName = "libraryotoDataSet7";
            this.libraryotoDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbt_kitaplarTableAdapter
            // 
            this.dbt_kitaplarTableAdapter.ClearBeforeFill = true;
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1232, 87);
            this.bunifuGradientPanel1.TabIndex = 40;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(1002, 0);
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
            this.bunifuImageButton3.Location = new System.Drawing.Point(1162, 0);
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
            this.bunifuImageButton4.Location = new System.Drawing.Point(1082, 0);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(70, 50);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 24;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 0;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bfDG_Books
            // 
            this.bfDG_Books.AllowUserToAddRows = false;
            this.bfDG_Books.AllowUserToDeleteRows = false;
            this.bfDG_Books.AllowUserToResizeColumns = false;
            this.bfDG_Books.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfDG_Books.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bfDG_Books.AutoGenerateColumns = false;
            this.bfDG_Books.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bfDG_Books.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bfDG_Books.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bfDG_Books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bfDG_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bfDG_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapidDataGridViewTextBoxColumn,
            this.yazarnoDataGridViewTextBoxColumn,
            this.adıDataGridViewTextBoxColumn,
            this.ciltDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.sayfasayisiDataGridViewTextBoxColumn,
            this.dilDataGridViewTextBoxColumn,
            this.nitleikDataGridViewTextBoxColumn,
            this.baskinoDataGridViewTextBoxColumn,
            this.erisimDataGridViewTextBoxColumn});
            this.bfDG_Books.DataSource = this.dbtkitaplarBindingSource;
            this.bfDG_Books.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bfDG_Books.DoubleBuffered = true;
            this.bfDG_Books.EnableHeadersVisualStyles = false;
            this.bfDG_Books.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.bfDG_Books.HeaderBgColor = System.Drawing.Color.LightSkyBlue;
            this.bfDG_Books.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.bfDG_Books.Location = new System.Drawing.Point(0, 87);
            this.bfDG_Books.Margin = new System.Windows.Forms.Padding(4);
            this.bfDG_Books.MultiSelect = false;
            this.bfDG_Books.Name = "bfDG_Books";
            this.bfDG_Books.ReadOnly = true;
            this.bfDG_Books.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bfDG_Books.RowHeadersVisible = false;
            this.bfDG_Books.RowHeadersWidth = 10;
            this.bfDG_Books.Size = new System.Drawing.Size(1232, 645);
            this.bfDG_Books.TabIndex = 41;
            // 
            // kitapidDataGridViewTextBoxColumn
            // 
            this.kitapidDataGridViewTextBoxColumn.DataPropertyName = "kitapid";
            this.kitapidDataGridViewTextBoxColumn.HeaderText = "Kitap Id";
            this.kitapidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapidDataGridViewTextBoxColumn.Name = "kitapidDataGridViewTextBoxColumn";
            this.kitapidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapidDataGridViewTextBoxColumn.Width = 150;
            // 
            // yazarnoDataGridViewTextBoxColumn
            // 
            this.yazarnoDataGridViewTextBoxColumn.DataPropertyName = "yazarno";
            this.yazarnoDataGridViewTextBoxColumn.HeaderText = "Yazar No";
            this.yazarnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarnoDataGridViewTextBoxColumn.Name = "yazarnoDataGridViewTextBoxColumn";
            this.yazarnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.yazarnoDataGridViewTextBoxColumn.Width = 180;
            // 
            // adıDataGridViewTextBoxColumn
            // 
            this.adıDataGridViewTextBoxColumn.DataPropertyName = "adı";
            this.adıDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adıDataGridViewTextBoxColumn.Name = "adıDataGridViewTextBoxColumn";
            this.adıDataGridViewTextBoxColumn.ReadOnly = true;
            this.adıDataGridViewTextBoxColumn.Width = 205;
            // 
            // ciltDataGridViewTextBoxColumn
            // 
            this.ciltDataGridViewTextBoxColumn.DataPropertyName = "cilt";
            this.ciltDataGridViewTextBoxColumn.HeaderText = "Cilt Numarası";
            this.ciltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ciltDataGridViewTextBoxColumn.Name = "ciltDataGridViewTextBoxColumn";
            this.ciltDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciltDataGridViewTextBoxColumn.Width = 130;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durumu";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.ReadOnly = true;
            this.durumDataGridViewTextBoxColumn.Width = 130;
            // 
            // sayfasayisiDataGridViewTextBoxColumn
            // 
            this.sayfasayisiDataGridViewTextBoxColumn.DataPropertyName = "sayfasayisi";
            this.sayfasayisiDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayısı";
            this.sayfasayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sayfasayisiDataGridViewTextBoxColumn.Name = "sayfasayisiDataGridViewTextBoxColumn";
            this.sayfasayisiDataGridViewTextBoxColumn.ReadOnly = true;
            this.sayfasayisiDataGridViewTextBoxColumn.Width = 130;
            // 
            // dilDataGridViewTextBoxColumn
            // 
            this.dilDataGridViewTextBoxColumn.DataPropertyName = "dil";
            this.dilDataGridViewTextBoxColumn.HeaderText = "Dil";
            this.dilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dilDataGridViewTextBoxColumn.Name = "dilDataGridViewTextBoxColumn";
            this.dilDataGridViewTextBoxColumn.ReadOnly = true;
            this.dilDataGridViewTextBoxColumn.Width = 150;
            // 
            // nitleikDataGridViewTextBoxColumn
            // 
            this.nitleikDataGridViewTextBoxColumn.DataPropertyName = "nitleik";
            this.nitleikDataGridViewTextBoxColumn.HeaderText = "Nitelik";
            this.nitleikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nitleikDataGridViewTextBoxColumn.Name = "nitleikDataGridViewTextBoxColumn";
            this.nitleikDataGridViewTextBoxColumn.ReadOnly = true;
            this.nitleikDataGridViewTextBoxColumn.Width = 130;
            // 
            // baskinoDataGridViewTextBoxColumn
            // 
            this.baskinoDataGridViewTextBoxColumn.DataPropertyName = "baskino";
            this.baskinoDataGridViewTextBoxColumn.HeaderText = "Baskı Numarası";
            this.baskinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baskinoDataGridViewTextBoxColumn.Name = "baskinoDataGridViewTextBoxColumn";
            this.baskinoDataGridViewTextBoxColumn.ReadOnly = true;
            this.baskinoDataGridViewTextBoxColumn.Width = 130;
            // 
            // erisimDataGridViewTextBoxColumn
            // 
            this.erisimDataGridViewTextBoxColumn.DataPropertyName = "erisim";
            this.erisimDataGridViewTextBoxColumn.HeaderText = "Erişim Tarihi";
            this.erisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.erisimDataGridViewTextBoxColumn.Name = "erisimDataGridViewTextBoxColumn";
            this.erisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.erisimDataGridViewTextBoxColumn.Width = 200;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1232, 732);
            this.Controls.Add(this.bfDG_Books);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookList";
            this.Text = "BookList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbtkitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryotoDataSet7)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bfDG_Books)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private libraryotoDataSet7 libraryotoDataSet7;
        private System.Windows.Forms.BindingSource dbtkitaplarBindingSource;
        private libraryotoDataSet7TableAdapters.dbt_kitaplarTableAdapter dbt_kitaplarTableAdapter;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuImageButton bunifuImageButton5;
        private ns1.BunifuImageButton bunifuImageButton3;
        private ns1.BunifuImageButton bunifuImageButton4;
        private ns1.BunifuCustomDataGrid bfDG_Books;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitleikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baskinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn erisimDataGridViewTextBoxColumn;
    }
}