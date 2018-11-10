using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelectAll;
using Utility;

namespace HengDaOther
{
    public partial class FormMainQuery : FormBase
    {
        public FormMainQuery ( )
        {
            InitializeComponent( );
        }

        HengDaBll.Bll.FormMainBll _bll = new HengDaBll.Bll.FormMainBll( );
        public delegate void PassDataBetweenFormHandler ( object sender ,PassDataWinFormEventArgs e );
        public event PassDataBetweenFormHandler PassDataBetweenForm;
        DataTable tableQuery;

        private void FormMainQuery_Load ( object sender ,EventArgs e )
        {
            GridViewMoHuSelect.SetFilter( gridView1 );
            assignMent( );

            userControl11.OnPageChanged += new EventHandler( userControl11_OnPageChanged );
        }

        void userControl11_OnPageChanged ( object sender ,EventArgs e )
        {
            pageToDataTable( );
        }

        //Bind data source
        void assignMent ( )
        {
            DataTable only = _bll.GetDataTableOnly( );
            lookUpEdit1.Properties.DataSource = only.DefaultView.ToTable( true ,"SHD001" );
            lookUpEdit1.Properties.DisplayMember = "SHD001";
            lookUpEdit2.Properties.DataSource = _bll.GetDataTableOnlys( );
            lookUpEdit2.Properties.DisplayMember = "DFA002";
            lookUpEdit2.Properties.ValueMember = "DFA001";
            lookUpEdit3.Properties.DataSource = only.DefaultView.ToTable( true ,"SHD003" );
            lookUpEdit3.Properties.DisplayMember = "SHD003";
            lookUpEdit4.Properties.DataSource = only.DefaultView.ToTable( true ,"SHD004" );
            lookUpEdit4.Properties.DisplayMember = "SHD004";
            lookUpEdit5.Properties.DataSource = only.DefaultView.ToTable( true ,"SHD005" );
            lookUpEdit5.Properties.DisplayMember = "SHD005";
            lookUpEdit6.Properties.DataSource = only.DefaultView.ToTable( true ,"SHD006" );
            lookUpEdit6.Properties.DisplayMember = "SHD006";
        }

        //query
        string strWhere = "1=1";
        private void button1_Click ( object sender ,EventArgs e )
        {
            strWhere = "1=1";
            if ( !string.IsNullOrEmpty( lookUpEdit1.Text ) )
                strWhere = strWhere + " AND SHD001='" + lookUpEdit1.Text + "'";
            if (lookUpEdit2.EditValue!=null && !string.IsNullOrEmpty( lookUpEdit2.EditValue.ToString( ) ) )
                strWhere = strWhere + " AND SHD002='" + lookUpEdit2.EditValue.ToString( ) + "'";
            if ( !string.IsNullOrEmpty( lookUpEdit3.Text ) )
                strWhere = strWhere + " AND SHD003='" + lookUpEdit3.Text + "'";
            if ( !string.IsNullOrEmpty( lookUpEdit4.Text ) )
                strWhere = strWhere + " AND SHD004='" + lookUpEdit4.Text + "'";
            if ( !string.IsNullOrEmpty( lookUpEdit5.Text ) )
                strWhere = strWhere + " AND SHD005='" + lookUpEdit5.Text + "'";
            if ( !string.IsNullOrEmpty( lookUpEdit6.Text ) )
                strWhere = strWhere + " AND SHD006='" + lookUpEdit6.Text + "'";
            pageToDataTable( );
        }

        //Bind data source and pageChange
        void pageToDataTable ( )
        {
            int count = _bll.GetCount( strWhere );
            userControl11.DrawCount( count );
            pageByChange( );
        }
        void pageByChange ( )
        {
            if ( userControl11.pageIndex <= 1 )
                tableQuery = _bll.GetDataTableByChange( strWhere ,0 ,userControl11.pageSize );
            else
                tableQuery = _bll.GetDataTableByChange( strWhere ,userControl11.pageSize * ( userControl11.pageIndex - 1 ) + 1 ,userControl11.pageSize * ( userControl11.pageIndex - 1 ) + userControl11.pageSize );
            gridControl1.DataSource = tableQuery;
        }

        //Clear
        private void button2_Click ( object sender ,EventArgs e )
        {
            lookUpEdit1.EditValue = lookUpEdit2.EditValue = lookUpEdit3.EditValue = lookUpEdit4.EditValue = lookUpEdit5.EditValue = lookUpEdit6.EditValue = null;
            lookUpEdit1.ItemIndex = lookUpEdit2.ItemIndex = lookUpEdit3.ItemIndex = lookUpEdit4.ItemIndex = lookUpEdit5.ItemIndex = lookUpEdit6.ItemIndex = -1;
        }

        //Value
        string cn1 = "", cn2 = "";
        private void gridView1_DoubleClick ( object sender ,EventArgs e )
        {
            if ( gridView1.FocusedRowHandle >= 0 && gridView1.FocusedRowHandle <= gridView1.RowCount - 1 )
            {
                cn1 = gridView1.GetRowCellValue( gridView1.FocusedRowHandle ,"SHD001" ).ToString( );
                cn2 = gridView1.GetRowCellValue( gridView1.FocusedRowHandle ,"SHD009" ).ToString( );
                PassDataWinFormEventArgs args = new PassDataWinFormEventArgs( cn1 ,cn2 );
                if ( PassDataBetweenForm != null )
                {
                    PassDataBetweenForm( this ,args );
                }
                this.Close( );
            }
        }

        private void dateTimePicker1_ValueChanged ( object sender ,EventArgs e )
        {
            textBox1.Text = dateTimePicker1.Value.ToString( "yyyy年MM月dd日" );
        }
        private void textBox1_KeyPress ( object sender ,KeyPressEventArgs e )
        {
            if ( e.KeyChar == 8 )
                textBox1.Text = "";
            else
                e.Handled = true;
        }
    }
}
