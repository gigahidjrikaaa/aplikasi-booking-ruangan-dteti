using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTETI_Room_Booker.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\Projek UAS PBO\aplikasi-booking-ruangan-dteti\DTETI Room Booker\DatabaseUser.mdf"";Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [TableUser](name,nim,prodi) values ('"+txtname.Text+"','"+txtnim.Text+"','"+txtprodi.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insert Succes");
            FormMainMenu menu = new FormMainMenu();
            menu.ShowDialog();
            this.Hide();

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
