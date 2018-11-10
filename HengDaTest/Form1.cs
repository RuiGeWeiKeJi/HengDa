using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentMgr;

namespace HengDaTest
{
    public partial class Form1 : Form
    {
        public Form1 ( )
        {
            InitializeComponent( );
        }

        private void Form1_Load ( object sender ,EventArgs e )
        {
            DataTable da = SqlHelper.ExecuteDataTable( "SELECT QAA001 FROM SGMQAA" );
            comboBox1.DataSource = da;
            comboBox1.DisplayMember = "QAA001";
        }

        private void comboBox1_Click ( object sender ,EventArgs e )
        {
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
