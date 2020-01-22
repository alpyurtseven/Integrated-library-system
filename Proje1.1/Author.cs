using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje1._1
{
    public partial class Author : Form
    {

        SqlConnection connection;
        SqlCommand command;
        public Author()
        {
            InitializeComponent();
        }

        private void gbAddAuthor_Enter(object sender, EventArgs e)
        {

        }
        void AddData()
        {
            try
            {
                connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                string sorgu = "INSERT INTO dbt_yazarlar(adi,soyadi) values(@name,@surname)";
                command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@name", bftxt_Name.Text);
                command.Parameters.AddWithValue("@surname", bftxt_Surname.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Yazar Eklendi");
            }catch(SqlException exp)
            {
                MessageBox.Show("Hatalı Giriş" + Environment.NewLine + exp.ToString());
            }
            
        }
        bool f=true;
        void Search()
        {
            try
            {


                connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                connection.Open();
                string sorgu = "Select yazarno from dbt_yazarlar where adi='" + bftxt_Name.Text + "' and soyadi='" + bftxt_Surname.Text + "'";
                command = new SqlCommand(sorgu, connection);

                SqlDataReader read = command.ExecuteReader();
                bool control = true;
                while (read.Read())
                {
                    control = false;
                    f = true;
                    MessageBox.Show("Yazar Numarası :" + read["yazarno"].ToString());
                }
                if (control)
                {
                    f = false;
                    control = false;
                }


                connection.Close();
            }catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
            }
        }
        private void bfbtn_AddAuthor_Click(object sender, EventArgs e)
        {
            AddData();
            
        }

        private void bfbtn_Search_Click(object sender, EventArgs e)
        {
            Search();
            if (f)
            {
                bfbtn_AddAuthor.Enabled = false;
            }
            else
            {
                bfbtn_AddAuthor.Enabled = true;
            }
        }

        private void gbAddAuthor_Enter_1(object sender, EventArgs e)
        {
            bfbtn_AddAuthor.Enabled = false;
        }

        private void Author_Load(object sender, EventArgs e)
        {
            int AnaFormWidth = 1200; //
            
            this.DesktopLocation = new Point(AnaFormWidth, 0);
            this.Size = new System.Drawing.Size(400, 300);
   
        }

        private void bftxt_Name_Enter(object sender, EventArgs e)
        {
            if (bftxt_Name.Text=="Adı")
            {
                bftxt_Name.Text = "";
            }
        }

        private void bftxt_Name_Leave(object sender, EventArgs e)
        {
            if (bftxt_Name.Text == "")
            {
                bftxt_Name.Text = "Adı";
            }
        }

        private void bftxt_Surname_Enter(object sender, EventArgs e)
        {
            if (bftxt_Surname.Text=="Soyadı")
            {
                bftxt_Surname.Text = "";
            }
        }

        private void bftxt_Surname_Leave(object sender, EventArgs e)
        {
            if (bftxt_Surname.Text == "")
            {
                bftxt_Surname.Text = "Soyadı";
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
