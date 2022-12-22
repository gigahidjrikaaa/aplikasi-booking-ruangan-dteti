using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WhatsappContactLibNETF;

namespace DTETI_Room_Booker.Forms
{
    public partial class FormContact : Form
    {
        private string number1 = "+6281234567890";
        public FormContact()
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

        private void lblContact1_Click(object sender, EventArgs e)
        {
            //WhatsappContactLib.sendWhatsapp(number1, txtBoxMessage1.Text);
        }

        private void btnSend1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend2_Click(object sender, EventArgs e)
        {

        }

        private void btnSend3_Click(object sender, EventArgs e)
        {

        }

        private void btnSend1_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = ThemeColor.PrimaryColor;
        }

        private void btnSend1_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = ThemeColor.SecondaryColor;
        }
    }
}
