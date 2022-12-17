using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace DTETI_Room_Booker.Forms
{
    public partial class Rooms : Form
    {
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
            label4.Text = "hello isnsa sajdnsa sjdsa jdns jsdns dsdnsada sjsdbsa aij said jiasdiasd jasd asdjias dias diasjd makan nasi goreng";
        }

        private void selectedRoom(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            roomSelectSetting(button, null);

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

        
    }
}
