using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTETI_Room_Booker
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Form activeForm;
        
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private Color SelectThemeColor()
        {
            string color = ThemeColor.ColorList[0];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = Color.Orange;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Orange;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), (object)btnHome);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);
        }
        private void btnFAQ_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFAQ(), sender);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBook(), sender);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Rooms(), sender);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormContact(), sender);
        }
    }
}
