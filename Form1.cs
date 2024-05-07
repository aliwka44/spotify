using SpAdo.Helper;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace SpAdo
{
    public partial class Form1 : Form
    {
        const string connectionString = @"Server=DESKTOP-MPV3150\SQLEXPRESS;Database=Spotify;Trusted_Connection=True;";
        public Form1()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT *FROM Users", conn);
            var datas = command.ExecuteReader();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = name.Text;
            string surname = surname.Text;
            string gender = gender.Text.StartsWith("k") ? "Kishi" : "Qadin";
            string username = username.Text;

            string passwordVal = sqlhelper.HashPassword(password.Text);

            var result = sqlhelper.Execute($"INSERT INTO Users VALUES(N'{name}',N'{surname}',N'{gender}','{username}','{passwordVal}')");
            if (result == 0)
            {
                MessageBox.Show("error");
            }
            else
            {
                MessageBox.Show("Succesfull");
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
