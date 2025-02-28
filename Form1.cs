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

using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrugStore
{
    public partial class Form1 : Form
    {
        List<Med> medList = new List<Med>();
        List<Med> medCategory = new List<Med>();
        List<Med> medForm = new List<Med>();
        List<Med> searchList = new List<Med>();

        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Apteka;Integrated Security=True;";
        string currentCategory = "";

        public Form1()
        {
            InitializeComponent();
        }



        public static List<Med> GetMedications(string query)
        {
            List<Med> medications = new List<Med>();

            using (SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=Apteka;Integrated Security=True;"))
            {

                connection.Open();


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Med med = new Med();
                            med.name = reader.GetString(reader.GetOrdinal("Name"));
                            med.category = reader.GetString(reader.GetOrdinal("Category"));
                            med.form = reader.GetString(reader.GetOrdinal("Form"));
                            med.visual = reader.GetString(reader.GetOrdinal("Visual"));

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
                pic.Image = System.Drawing.Image.FromFile(med.visual);
                panel.Controls.Add(pic);
                Label label = new Label();
                label.Font = new Font(label.Font.FontFamily, 6, label.Font.Style);
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
            medList =  GetMedications($"SELECT Name, Category, Form, Visual FROM Medicaments");
            LoadVisual(medList);
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (treeView1.SelectedNode.Text != "")
            {
                if (treeView1.SelectedNode.Text == "Все")
                {
                    LoadVisual(medList);
                }
                else
                {
                    medCategory.Clear();
                    currentCategory = treeView1.SelectedNode.Text;
                    foreach (Med med in medList)
                    {
                        if (med.category == currentCategory)
                        {
                            medCategory.Add(med);

                        }
                    }

                    LoadVisual(medCategory);
                }


               
            }
           

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView2.SelectedNode.Text != "")
            {
                if (treeView2.SelectedNode.Text == "Все")
                {
                    medForm.Clear();
                    foreach (Med med in medList)
                    {
                        if (med.category == currentCategory)
                        {
                            medForm.Add(med);

                        }
                    }
                    LoadVisual(medForm);
                }
                else
                {
                    medForm.Clear();
                    foreach (Med med in medList)
                    {
                        if (med.category == currentCategory && med.form == treeView2.SelectedNode.Text)
                        {
                            medForm.Add(med);

                        }
                    }

                    LoadVisual(medForm);
                }


              
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                searchList.Clear();
                string text = textBox1.Text;

                foreach (Med med in medList)
                {
                    if (med.name.Contains(text) || med.category.Contains(text) || med.form.Contains(text))
                    {
                        searchList.Add(med);
                    }
                }
            
                LoadVisual(searchList);
            }
            else
            {
                LoadVisual(medList);
            }
        }
    }


}
