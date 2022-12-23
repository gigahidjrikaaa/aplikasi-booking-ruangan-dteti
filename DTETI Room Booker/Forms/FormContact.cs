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
        private string number1 = "+6281227360323"; //Giga
        private string number2 = "+6281232749996"; //Difta
        private string number3 = "+6281227360323"; //Daffa
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

        private void SendWhatsapp(string number, string message)
        {
            try
            {
                if (number == "")
                {
                    MessageBox.Show("No number assigned to this person. Please contact your admin.");
                }
                if (number.Length <= 0)
                {
                    number = "+62" + number;
                }
                number = number.Replace(" ", "");
                number = number.Replace("-", "");
                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + number + "&text=" + message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblContact1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSend1_Click(object sender, EventArgs e)
        {
            SendWhatsapp(number1, txtBoxMessage1.Texts);
        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            SendWhatsapp(number2, txtBoxMessage2.Texts);
        }

        private void btnSend3_Click(object sender, EventArgs e)
        {
            SendWhatsapp(number3, txtBoxMessage3.Texts);
        }

        private void btnSend1_MouseDown(object sender, MouseEventArgs e)
        {
            Button thisButton = (Button) sender;
            thisButton.BackColor = ThemeColor.SecondaryColor;
        }

        private void btnSend1_MouseUp(object sender, MouseEventArgs e)
        {
            Button thisButton = (Button)sender;
            thisButton.BackColor = ThemeColor.PrimaryColor;
        }

        private void txtBoxMessage1_Load(object sender, EventArgs e)
        {

        }

    }
}
