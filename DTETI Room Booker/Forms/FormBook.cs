using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTETI_Room_Booker.Forms
{
    public partial class FormBook : Form
    {
        public FormBook()
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
        private int state = 0;
        private List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple", "Orange", "Black", "White" };
        private void button1_Click(object sender, EventArgs e)
        {
            state++;
            Button btn = (Button)sender;
            btn.BackColor = Color.FromName(colors[state % colors.Count]);
        }

        
    }
}
