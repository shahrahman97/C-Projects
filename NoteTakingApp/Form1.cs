using System.Data;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            txtTitleBox.Clear();
            txtMessageBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Title", typeof(string));
            dataTable.Columns.Add("Message", typeof(string));

            dataGridView1.DataSource = dataTable;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add(txtTitleBox.Text, txtMessageBox.Text);
            txtTitleBox.Clear();
            txtMessageBox.Clear();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitleBox.Text = dataTable.Rows[index].ItemArray[0].ToString();
                txtMessageBox.Text = dataTable.Rows[index].ItemArray[1].ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                dataTable.Rows[index].Delete();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}