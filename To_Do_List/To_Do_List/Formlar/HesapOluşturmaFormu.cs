using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace To_Do_List.Formlar
{
    public partial class HesapOluşturmaFormu : Form
    {
        public HesapOluşturmaFormu()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server = localHost; port = 5432; Database = todoListDB; userID = postgres; password = password");
        private void btn_kayıtOl_Click(object sender, EventArgs e)
        {

            if (tb_ad.Text == "")
            {
                errorProvider1.SetError(tb_ad, "İSİM ALANI BOŞ GEÇİLEMEZ");
            }
            else if (tb_soyad.Text == "")
            {
                errorProvider1.SetError(tb_soyad, "SOYAD ALANI BOŞ GEÇİLEMEZ");
            }
            else if (tb_mail.Text == "")
            {
                errorProvider1.SetError(tb_mail, "MAIL ALANI BOŞ GEÇİLEMEZ");
            }
            else if (tb_sifre.Text == "")
            {
                errorProvider1.SetError(tb_sifre, "SİFRE ALANI BOŞ GEÇİLEMEZ");
            }
            else
            {
                connection.Open();
                string sqlSorgum = "INSERT INTO users(user_name,user_surname,user_mail,user_password) VALUES (@p1,@p2,@p3,@p4)";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlSorgum, connection);
                npgsqlCommand.Parameters.AddWithValue("@p1", tb_ad.Text);
                npgsqlCommand.Parameters.AddWithValue("@p2", tb_soyad.Text);
                npgsqlCommand.Parameters.AddWithValue("@p3", tb_mail.Text);
                npgsqlCommand.Parameters.AddWithValue("@p4", tb_sifre.Text);
                npgsqlCommand.ExecuteNonQuery();
                MessageBox.Show("HESABINIZ BAŞARIYLA OLUŞTURULDU", "HESAP OLUŞTURULDU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
        }

        private void ll_girisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            girisFormu.Show();
            this.Hide();
        }

        private void HesapOluşturmaFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
