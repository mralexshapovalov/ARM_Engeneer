using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;


namespace ARM_Engineer.Parts
{
    enum RowState
    {
        Exsted,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Parts : Form
    {
        DataBase dataBase=new DataBase();

        int selectedRow;

        public Parts()
        {
            InitializeComponent();
        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseEngineerDataSet.Table' table. You can move, or remove it, as needed.
            //  this.tableTableAdapter.Fill(this.dataBaseEngineerDataSet.Table);
            CreateColumns();
            RefreshDataGrid(dataGridView1);

        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Id", "id");
            dataGridView1.Columns.Add("Name", "Наименование");
            dataGridView1.Columns.Add("Articul", "Артикул");
            dataGridView1.Columns.Add("UnitMeasurement", "Единица измерения");
            dataGridView1.Columns.Add("Agregat", "Агрегат");
            dataGridView1.Columns.Add("Uzel", "Узел");
          
        }

        private void ReadSingleRow(DataGridView dataGridView,IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            string queryString = $"select * from Parts";

            SqlCommand command = new SqlCommand(queryString,dataBase.GetConnection());

            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();
        }

        private void Add_parts_Click(object sender, EventArgs e)
        {
            AddParts addParts = new AddParts();
            addParts.Show();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        private void Search(DataGridView  dataGridView)
        {
            dataGridView.Rows.Clear();

            string searchString = $"select * from Parts where concat (Id,Name,Articul,UnitMeasurement,Agregat,Uzel) like '%"+Search_textBox.Text+"%'";

            SqlCommand sqlCommand = new SqlCommand(searchString,dataBase.GetConnection());
            dataBase.openConnection();

            SqlDataReader sqlDataReader= sqlCommand.ExecuteReader();

            while(sqlDataReader.Read())
            {
                ReadSingleRow(dataGridView, sqlDataReader);
            }

            sqlDataReader.Close();

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            AddParts addParts = new AddParts();
            addParts.Show();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];


                addParts.Name_textBox.Text = row.Cells[1].Value.ToString();
                addParts.Articul_textBox.Text = row.Cells[2].Value.ToString();
                addParts.UnitMeasurement_tetxBox.Text = row.Cells[3].Value.ToString();
                addParts.Agregat_textBox.Text = row.Cells[4].Value.ToString();
                addParts.Uzel_textBox.Text = row.Cells[5].Value.ToString();


            }
        }
    }
}
