using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrugStore
{
    public partial class Form1 : Form
    {
        List<Med> medList = new List<Med>();

        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Apteka;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }


        public static List<Med> GetMedicationsFromDatabase()
        {
            List<Med> medications = new List<Med>();

            // Строка подключения к базе данных
        

            // SQL-запрос
            string query = "SELECT Name, Category, Form, Visual FROM Medicaments";

            // Подключение к базе данных
            using (SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=Apteka;Integrated Security=True;"))
            {
                // Открытие соединения
                connection.Open();

                // Выполнение SQL-запроса
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Чтение данных
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Создание объекта Med и заполнение его данными
                            Med med = new Med();
                             med.name = reader.GetString(reader.GetOrdinal("Name"));
                            med.category = reader.GetString(reader.GetOrdinal("Category"));
                            med.form = reader.GetString(reader.GetOrdinal("Form"));
                            med.visual = reader.GetString(reader.GetOrdinal("Visual"));

                            // Добавление объекта в список
                            medications.Add(med);
                        }
                    }
                }
            }

            return medications;
        }

        void LoadVisual(List<Med> meds)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Med med in meds)
            {
                Panel panel = new Panel();
                panel.Size = new Size(200, 250);
                panel.BorderStyle = BorderStyle.FixedSingle;
                PictureBox pic = new PictureBox();
                pic.Size = new Size(115, 115);
                pic.Location = new Point(36, 0);
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = Image.FromFile(med.visual);
                panel.Controls.Add(pic);
                Label label = new Label();
                label.Font = new Font(label.Font.FontFamily, 7, label.Font.Style);
                label.Size = new Size(200, 50);
                label.Location = new Point(2, 120);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = $"Название : {med.name}\nКатегория : {med.category}\nФорма : {med.form}";
                panel.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadVisual(GetMedicationsFromDatabase());
        }
    }


}
