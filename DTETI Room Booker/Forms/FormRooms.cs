﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            ConferenceRoom.BackColor = Color.Gray;
            ConferenceRoom.ForeColor = Color.White;
        }

        private void selectedRoom(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Gray;
            button.ForeColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
    }
}
