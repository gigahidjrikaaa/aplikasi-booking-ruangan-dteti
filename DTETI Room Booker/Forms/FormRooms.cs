using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace DTETI_Room_Booker.Forms
{
    public partial class Rooms : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Astaga Ngoding\aplikasi-booking-ruangan-dteti\DTETI Room Booker\RoomDB.mdf""; Integrated Security=True");
        public Rooms()
        {
            InitializeComponent();
            LoadTheme();
            
        }
        public void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void Rooms_Load(object sender, EventArgs e)
        {

            selectedRoom(conferenceRoom_1, null);
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(30);
        }

        private void selectedRoom(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            roomSelectSetting(button, null);
            switch (button.Name) {
                case "conferenceRoom_1":
                    pictureRoom.Image = Properties.Resources.CR_Room_1;
                    getData(11);
                    break;
                case "conferenceRoom_2":
                    pictureRoom.Image = Properties.Resources.CR_Room_2;
                    getData(12);
                    break;
                case "conferenceRoom_3":
                    pictureRoom.Image = Properties.Resources.CR_Room_3;
                    getData(13);
                    break;
                case "conferenceRoom_4":
                    pictureRoom.Image = Properties.Resources.CR_Room_4;
                    getData(14);
                    break;
                case "meetingRoom_1":
                    pictureRoom.Image = Properties.Resources.MR_Room_1;
                    getData(8);
                    break;
                case "meetingRoom_2":
                    pictureRoom.Image = Properties.Resources.MR_Room_2;
                    getData(9);
                    break;
                case "meetingRoom_3":
                    pictureRoom.Image = Properties.Resources.MR_Room_3;
                    getData(10);
                    break;
                case "studyRoom_1":
                    pictureRoom.Image = Properties.Resources.SR_Room_1;
                    getData(4);
                    break;
                case "studyRoom_2":
                    pictureRoom.Image = Properties.Resources.SR_Room_2;
                    getData(5);
                    break;
                case "studyRoom_3":
                    pictureRoom.Image = Properties.Resources.SR_Room_3;
                    getData(6);
                    break;
                case "studyRoom_4":
                    pictureRoom.Image = Properties.Resources.SR_Room_4;
                    getData(7);
                    break;
                case "discussionRoom":
                    pictureRoom.Image = Properties.Resources.discussionRoom;
                    getData(3);
                    break;
                case "coffeeAndStudy":
                    pictureRoom.Image = Properties.Resources.Coffee_and_Study_Room;
                    getData(1);
                    break;
                case "computerRoom":
                    pictureRoom.Image = Properties.Resources.Computer_Room;
                    getData(2);
                    break;
                default:
                    pictureRoom.Image = Properties.Resources.Help_1;
                    break;

            }
        }

        private void RoomDescription(object sender, EventArgs e) 
        {   
            
            pictureRoom.Image = Properties.Resources.SR_Room_4;
            pictureRoom.SizeMode = PictureBoxSizeMode.StretchImage;
            roomName.Text = "Discussion Room";
        }

        private void roomSelectSetting(object sender, EventArgs e)
        {
            foreach(Control room in panelRoom.Controls)
            {
                room.BackColor = Color.WhiteSmoke;
                room.ForeColor = Color.Black;
            }

            Control click = (Control)sender;
            click.BackColor = Color.Gray;
            click.ForeColor = Color.White;
        }

        private void getData(int id)
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT[Name], [Seats], [Description], [IsBooking] from [dbo].[Table] where [Id] = @id;";
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
                        roomName.Text = reader["Name"].ToString();
                        roomCapacity.Text = reader["Seats"].ToString();
                        roomExplanation.Text = reader["Description"].ToString();

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programming\Projek UAS PBO\aplikasi-booking-ruangan-dteti\DTETI Room Booker\DatabaseBookings.mdf"";Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [TableUser](RoomName,isBooked,Date) values ('" + txtname.Text + "','" + txtnim.Text + "','" + txtprodi.Text + "')";
            cmd.ExecuteNonQuery();
            
            con.Close();*/
            MessageBox.Show("Succes Booking");
        }
    }
}
