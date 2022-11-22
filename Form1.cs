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
        Button[] buttons = new Button[26];
        OleDbConnection connection;
        string sqlQuery = "SELECT a.Author, t.Title, p.Name " +
                    "FROM Authors as a, Titles as t, Publishers as p, Title_Author as ta " +
                    "WHERE a.AU_ID = ta.AU_ID " +
                    "AND t.ISBN = ta.ISBN " +
                    "AND t.PubID = p.PubID";

        public testerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = Helper.ConVal("Books");
            connection =new OleDbConnection(conString);
            connection.Open();
            
            int btnWidth, btnLeft, btnTop;
            int btnHeight = 30;

            btnWidth = ClientSize.Width / 13; //less than the actual width because integer is used
            btnLeft= ClientSize.Width - (btnWidth*13);
            btnTop = commandText.Top + commandText.Height+ 16;

            for(int i=0; i< 26; i++)
            {
                buttons[i] =new Button();
                buttons[i].Text = ((char)(65+i)).ToString();
                buttons[i].Width= btnWidth;
                buttons[i].Height= btnHeight;
                buttons[i].Left= btnLeft;
                buttons[i].Top= btnTop;

                Controls.Add(buttons[i]);
                buttons[i].Click += new EventHandler(btnSqlClick);
                btnLeft += btnWidth;

                if (i == 12)
                {
                    btnLeft = ClientSize.Width - (btnWidth * 13);//reset it to the start
                    btnTop +=btnHeight;
                }

            }


        }

        private void frmClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close(); //close the connection when the form is closing
            connection.Dispose(); //delete the objects
        }

        private void btnSqlClick(object sender, EventArgs e)
        {
            OleDbCommand cmd = null; ;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable booksTable = new DataTable();
            
            Button clickedButton = (Button)sender;

         const string showRecords = "ShowRecords";

            string sqlStatement;
            switch (clickedButton.Text)
            {
                case showRecords:
                    sqlStatement = sqlQuery;
                    break;
                default:
                    sqlStatement = sqlQuery + " AND a.Author like '" + clickedButton.Text + "%' ";
                    break;


            }
            try
            {
                cmd = new OleDbCommand(sqlStatement, connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(booksTable); //holds the result of the query


                recordGridView.DataSource = booksTable; //populate the gridview
                countLabel.Text = booksTable.Rows.Count.ToString(); //counts the number of rows



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmd.Dispose();//delete the object
            adapter.Dispose();
            booksTable.Dispose();


        }

        private void executeButton_Click(object sender, EventArgs e)
        {

            OleDbCommand cmd = null; ;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable booksTable = new DataTable();

            try
            {
                cmd = new OleDbCommand(commandText.Text, connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(booksTable); //holds the result of the query


                recordGridView.DataSource = booksTable; //populate the gridview
                countLabel.Text = booksTable.Rows.Count.ToString(); //counts the number of rows



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmd.Dispose();//delete the object
            adapter.Dispose();
            booksTable.Dispose();


        }
    }
}