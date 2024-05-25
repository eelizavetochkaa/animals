using System.Data;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace animals
{
    public partial class Form1 : Form
    {
        private List<Animals> animals = new List<Animals>();
        private OpenFileDialog openFileDialog;
        public Form1()
        {
            InitializeComponent();
            LoadAnimalsFromFile();
            PopulateDataGridView();
        }
        public void exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void LoadAnimalsFromFile()
        {
            string filePath = "animals.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 5)
                    {
                        Animals animal = new Animals
                        {
                            Number = Convert.ToInt32(parts[0].Trim()),
                            Type = Convert.ToInt32(parts[1].Trim()),
                            Name = parts[2].Trim(),
                            Health = Convert.ToInt32(parts[3].Trim()),
                            Number2 = Convert.ToInt32(parts[4].Trim()),
                        };
                        animals.Add(animal);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден");
            }
        }

        private void PopulateDataGridView()
        {
            dataGridView1.Columns.Add("Number", "Номер");
            dataGridView1.Columns.Add("Type", "Тип");
            dataGridView1.Columns.Add("Name", "Кличка");
            dataGridView1.Columns.Add("Health", "Здоровье");
            dataGridView1.Columns.Add("Number2", "Номер2");
            foreach (Animals animal in animals)
            {
                dataGridView1.Rows.Add(animal.Number, animal.Type, animal.Name, animal.Health, animal.Number2);
            }
        }

        private void aboutprogram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение создано на языке C# WindowsForms в приложении VisualStudio 2022");
        }
    }
}
