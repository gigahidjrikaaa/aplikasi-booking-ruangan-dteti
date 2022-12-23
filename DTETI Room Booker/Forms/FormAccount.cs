using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DTETI_Room_Booker.Forms
{
    public partial class FormAccount : Form
    {
        
        public FormAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
   
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\Projek UAS PBO\aplikasi-booking-ruangan-dteti\DTETI Room Booker\DatabaseUser.mdf"";Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader sr = null;
            cmd.Connection = con;
            cmd.CommandText = "Select Top(1) id from TableUser order by id desc";
            con.Open();
            sr = cmd.ExecuteReader();
            if (sr.Read())
            {
                getData(Int32.Parse(sr.GetValue(0).ToString()));
            }
            con.Close();
            
        }

        private void getData(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\Projek UAS PBO\aplikasi-booking-ruangan-dteti\DTETI Room Booker\DatabaseUser.mdf"";Integrated Security=True");
            using (SqlCommand cmd = con.CreateCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT[name], [nim], [prodi] from [dbo].[TableUser] where [Id] = @id;";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {

                    while (reader.Read())
                    {
                        nameProfile.Text = reader["name"].ToString();
                        nimProfile.Text = reader["nim"].ToString();
                        prodiProfile.Text = reader["prodi"].ToString();

                    }
                }
            }
        }
    }
}
