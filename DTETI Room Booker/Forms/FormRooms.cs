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

namespace DTETI_Room_Booker.Forms
{
    public partial class Rooms : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Astaga Ngoding\aplikasi-booking-ruangan-dteti\DTETI Room Booker\RoomDB.mdf"";Integrated Security=True");
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
                    getData(1);
                    break;
                case "conferenceRoom_2":
                    pictureRoom.Image = Properties.Resources.CR_Room_2;
                    break;
                case "conferenceRoom_3":
                    pictureRoom.Image = Properties.Resources.CR_Room_3;
                    break;
                case "conferenceRoom_4":
                    pictureRoom.Image = Properties.Resources.CR_Room_4;
                    break;
                case "meetingRoom_1":
                    pictureRoom.Image = Properties.Resources.MR_Room_1;
                    break;
                case "meetingRoom_2":
                    pictureRoom.Image = Properties.Resources.MR_Room_2;
                    break;
                case "meetingRoom_3":
                    pictureRoom.Image = Properties.Resources.MR_Room_3;
                    break;
                case "studyRoom_1":
                    pictureRoom.Image = Properties.Resources.SR_Room_1;
                    break;
                case "studyRoom_2":
                    pictureRoom.Image = Properties.Resources.SR_Room_2;
                    break;
                case "studyRoom_3":
                    pictureRoom.Image = Properties.Resources.SR_Room_3;
                    break;
                case "studyRoom_4":
                    pictureRoom.Image = Properties.Resources.SR_Room_4;
                    break;
                case "discussionRoom":
                    pictureRoom.Image = Properties.Resources.discussionRoom;
                    break;
                case "coffeeAndStudy":
                    pictureRoom.Image = Properties.Resources.Coffee_and_Study_Room;
                    break;
                case "computerRoom":
                    pictureRoom.Image = Properties.Resources.Computer_Room;
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
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT[Name], [Seats], [Description], [IsBooking] from [dbo].[Table] where [Id] = @id;";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Connection.Open();

                using(var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureRoom_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomName_Click(object sender, EventArgs e)
        {

        }
    }
}
