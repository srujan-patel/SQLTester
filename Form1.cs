using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTester
{
    public partial class testerForm : Form
    {

        OleDbConnection connection;

        public testerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = Helper.ConVal("Books");
            connection =new OleDbConnection(conString);
            connection.Open();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = null; ;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable booksTable=new DataTable();

            try
            {
                cmd = new OleDbCommand(commandText.Text, connection);
                adapter.SelectCommand= cmd;
                adapter.Fill(booksTable); //holds the result of the query


                recordGridView.DataSource= booksTable; //populate the gridview
                countLabel.Text=booksTable.Rows.Count.ToString(); //counts the number of rows



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmd.Dispose();//delete the object
            adapter.Dispose();
            booksTable.Dispose();


        }

        private void frmClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close(); //close the connection when the form is closing
            connection.Dispose(); //delete the objects
        }
    }
}