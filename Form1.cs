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
    }
}