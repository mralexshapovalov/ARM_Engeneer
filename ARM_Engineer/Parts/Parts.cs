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

        int selectionRow;

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

        }
    }
}
