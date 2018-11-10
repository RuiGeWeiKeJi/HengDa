using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace HengDaOther
{
    public partial class FormMainChoise : Form
    {
        public FormMainChoise ( )
        {
            InitializeComponent( );
        }

        public delegate void PassDataBetweenFormHandler ( object sender ,PassDataWinFormEventArgs e );
        public event PassDataBetweenFormHandler PassDataBetweenForm;
        string cn1 = "", cn2 = "", cn3 = "", cn4 = "", cn5 = "";
        DataTable tableQuery; HengDaBll.Bll.FormMainBll _bll = new HengDaBll.Bll.FormMainBll( );
        public List<string> strList;

        private void FormMainChoise_Load ( object sender ,EventArgs e )
        {
            GridViewMoHuSelect.SetFilter( gridView1 );
            query( );
        }

        void query ( )
        {
            tableQuery = _bll.GetDataTableOfChoise(  );
            //tableQuery.Columns.Add( "check" ,typeof( System.Boolean ) );
            gridControl1.DataSource = tableQuery;
        }

        private void gridView1_DoubleClick ( object sender ,EventArgs e )
        {
            int num = gridView1.FocusedRowHandle;
            cn1 = gridView1.GetDataRow( num )["DEA002"].ToString( );
            cn2 = gridView1.GetDataRow( num )["DEA003"].ToString( );
            cn3 = gridView1.GetDataRow( num )["DEA960"].ToString( );
            cn4 = gridView1.GetDataRow( num )["QAA001"].ToString( );
            PassDataWinFormEventArgs args = new PassDataWinFormEventArgs( cn1 ,cn2 ,cn3 ,cn4  );
            if ( PassDataBetweenForm != null )
            {
                PassDataBetweenForm( this ,args );
            }
            this.Close( );
        }
    }
}
