using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ARM_Engineer.Parts
{
    public partial class AddParts : Form
    {
      
        DataBase dataBase=new DataBase();

        public AddParts()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Uzel_Label_Click(object sender, EventArgs e)
        {

        }

        private void Articul_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddParts_Load(object sender, EventArgs e)
        {

        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            AddParts addParts = new AddParts();
            dataBase.openConnection();

            var name = Name_textBox.Text;
            var articul=Articul_textBox.Text;
            var unitMeasurement = UnitMeasurement_tetxBox.Text;
            var agregat = Agregat_textBox.Text;
            var uzel = Uzel_textBox.Text;

            var addQuery = $"insert into Parts (Name,Articul,UnitMeasurement,Agregat,Uzel) values " +
                                           $"('{name}','{articul}','{unitMeasurement}','{agregat}','{uzel}')";

            var commmand = new SqlCommand(addQuery, dataBase.GetConnection());

            commmand.ExecuteNonQuery();
            MessageBox.Show("Запись успешно Создана!","Успех",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataBase.clouseConnection();

            this.Close();
        }

        private void Cancle_button_Click(object sender, EventArgs e)
        {

            this.Close();
        }

    }

           
    
}
