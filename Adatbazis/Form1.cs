using Adatbazis.Models;

namespace Adatbazis
{
    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();
        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = studentContext.Students.ToList();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var eredmény = from x in studentContext.Students
                           where x.Name.StartsWith(textBox1.Text) 
                           select x;
            dataGridView1.DataSource = eredmény.ToList();
        }
    }
}