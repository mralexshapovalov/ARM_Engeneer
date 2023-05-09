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


        public Parts()
        {
            InitializeComponent();
        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseEngineerDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dataBaseEngineerDataSet.Table);

        }

        private void ReadSingleRow(DataGridView dataGridView,IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetInt32(0),  RowState.ModifiedNew);
            dataGridView.Rows.Add(record.GetString(1), RowState.ModifiedNew);
            dataGridView.Rows.Add(record.GetString(2), RowState.ModifiedNew);
            dataGridView.Rows.Add(record.GetString(3), RowState.ModifiedNew);
            dataGridView.Rows.Add(record.GetString(4), RowState.ModifiedNew);
            dataGridView.Rows.Add(record.GetString(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            string queryString = $"select * from DataBaseEngineer";

            SqlCommand command =new SqlCommand(queryString,...)
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
