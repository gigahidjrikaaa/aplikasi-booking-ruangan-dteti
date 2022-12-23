using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTETI_Room_Booker.Forms
{
    public partial class FormFAQ : Form
    {
        public FormFAQ()
        {
            InitializeComponent();
            LoadTheme();
            LoadListQuestion(listView2);
            LoadListAnswer(listView1);
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
        public void LoadListQuestion(ListView listView)
        {
            string conn = "https://localhost:7045/api/Questions";
            var client = new RestClient(conn);
            var request = new RestRequest();
            var response = client.Execute(request);
            listView.Scrollable = true;
            listView.View = View.Details;
            ColumnHeader header = new ColumnHeader();
            header.Text = "Questions";
            header.Name = "list";
            header.Width = listView.Width;
            listView.Columns.Add(header);
            listView.Items.Clear();

            var result = JsonConvert.DeserializeObject<List<Questions>>(response.Content);
            foreach(var item in result)
            {
                listView.Items.Add(item.question);
            }
            
            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void LoadListAnswer(ListView listView)
        {
            string conn = "https://localhost:7045/api/Questions";
            var client = new RestClient(conn);
            var request = new RestRequest();
            var response = client.Execute(request);
            listView.Scrollable = true;
            listView.View = View.Details;
            ColumnHeader header = new ColumnHeader();
            header.Text = "Answer";
            header.Name = "list";
            header.Width = listView.Width;
            listView.Columns.Add(header);
            listView.Items.Clear();

            var result = JsonConvert.DeserializeObject<List<Questions>>(response.Content);
            foreach (var item in result)
            {
                listView.Items.Add(item.answer);
            }

            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("https://localhost:7045/api/Questions");
            Questions questions = new Questions();
            var request = new RestRequest("api/Questions").AddJsonBody(questions);
            var response = client.ExecutePostAsync<Questions>(request);
        }

        private void btnSend_MouseDown(object sender, MouseEventArgs e)
        {
            Button thisButton = (Button)sender;
            thisButton.BackColor = ThemeColor.SecondaryColor;
        }

        private void btnSend_MouseUp(object sender, MouseEventArgs e)
        {
            Button thisButton = (Button)sender;
            thisButton.BackColor = ThemeColor.PrimaryColor;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class Questions
        {
            public int id { get; set; }
            public string question { get; set; }
            public string answer { get; set; }
            public string name { get; set; }
            public Questions()
            {

            }
            public Questions(int id, string question, string answer, string name)
            {
                this.id = id;
                this.question = question;
                this.answer = answer;
                this.name = name;
            }
        }
    }
}
