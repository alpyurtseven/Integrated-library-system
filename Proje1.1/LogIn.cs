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
    public partial class LogIn : Form
    {
        public static bool status=false;
        public LogIn()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dr;

        //Login Screen Textbox events
        private void bfmTxt_username_Enter(object sender, EventArgs e)
        {
            if(bfmTxt_username.Text=="Kullanıcı Adı")
            {
                bfmTxt_username.Text = "";
            }
           
        }

        private void bfmTxt_username_Leave(object sender, EventArgs e)
        {
            if (bfmTxt_username.Text == "")
            {
                bfmTxt_username.Text = "Kullanıcı Adı";
            }
        }

        private void bfmTxt_Password_Enter(object sender, EventArgs e)
        {
            if (bfmTxt_Password.Text == "Şifre")
            {
                bfmTxt_Password.Text = "";
            }
        }

        private void bfmTxt_Password_Leave(object sender, EventArgs e)
        {
            if (bfmTxt_Password.Text == "")
            {
                bfmTxt_Password.Text = "Şifre";
            }
        } 
        void LogInW()
        {
            connection= new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM dbt_admin where kullanicino='" + bfmTxt_username.Text + "' AND sifre='" + bfmTxt_Password.Text + "'";
            dr = command.ExecuteReader();
            bool conresult = dr.Read();
            string statu;  
            if (conresult)
            {
                while (conresult)
                {

                    statu = dr["statu"].ToString();
                    if (statu == "1")
                    {
                        MainWindow mw = new MainWindow();
                        mw.Show();
                        this.Hide();
                        break;
                    }
                    else if (statu == "2")
                    {
                       
                        LibPanel lp = new LibPanel();
                        lp.Show();
                        this.Hide();
                       
                        break;
                    }
                    else if (statu == "3")
                    {
                        status = true;
                        Eav eav = new Eav();
                        eav.Show();
                        this.Hide();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
                
            }
            connection.Close();
        }
        private void bffbtn_Login_Click(object sender, EventArgs e)
        {
            LogInW();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {

        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
