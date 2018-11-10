using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Utility;
using FastReport;

namespace HengDaSponge
{
    public partial class FormMain : FormChild
    {
        public FormMain ( )
        {
            InitializeComponent( );
        }

        //HDSHD:单头 HDSHE:单身一  HDSHF:单身二
        List<SplitContainer> spList = new List<SplitContainer>( );List<TabPage> pageList = new List<TabPage>( );
        HengDaEntity.FormMainHeader _modelHeader = new HengDaEntity.FormMainHeader( );
        HengDaEntity.FormMainOne _modelOne = new HengDaEntity.FormMainOne( );
        HengDaEntity.FormMainTwo _modelTwo = new HengDaEntity.FormMainTwo( );
        HengDaBll.Bll.FormMainBll _bll = new HengDaBll.Bll.FormMainBll( );
        DataTable tableQuery,tableQueryFor,tableQueryOne,tableQueryTwo,queryC,queryL,tableQueryTre;bool result = false;string sign = "", str = ""; int num = 0;
        DataRow row;DataSet RDataset = new DataSet( );

        private void FormMain_Load ( object sender ,EventArgs e )
        {
            spList.Clear( );
            spList.AddRange( new SplitContainer[] { splitContainer1 ,splitContainer2 } );
            Ergodic.SpliClear( spList );
            Ergodic.SpliEnableFalse( spList );
            pageList.Clear( );
            pageList.AddRange( new TabPage[] { tabPageOne ,tabPageTwo } );
            Ergodic.TablePageEnableClear( pageList );
            Ergodic.TablePageEnableFalse( pageList );
            gridControl1.DataSource = null;
            gridControl2.DataSource = null;
            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.Editable = false;
            label9.Visible = false;
            queryCom( );
            choise( );
        }

        #region Main
        protected override void add ( )
        {
            base.add( );

            Ergodic.SpliClear( spList );
            Ergodic.SpliEnableTrue( spList );
            Ergodic.TablePageEnableClear( pageList );
            Ergodic.TablePageEnableTrue( pageList );
            generateOrder( );
            textBox1.Text = _modelHeader.SHD001;
            ToolSelete.Enabled = toolAdd.Enabled = toolDelete.Enabled = toolUpdate.Enabled = toolExmine.Enabled = toolPrint.Enabled = false;
            toolSave.Enabled = toolCancel.Enabled = true;
            label9.Visible = false;
            refre( );
            gridView1.OptionsBehavior.Editable = true;
            gridView2.OptionsBehavior.Editable = true;   
            sign = "1";
        }
        protected override void delete ( )
        {
            base.delete( );

            if ( label9.Visible == true )
                MessageBox.Show( "本单已审核,不允许删除" );
            else
            {
                result = _bll.DeleteAll( _modelHeader.SHD001 );
                if ( result == true )
                {
                    MessageBox.Show( "成功删除数据" );
                    ToolSelete.Enabled = toolAdd.Enabled = true;
                    toolSave.Enabled = toolCancel.Enabled = toolDelete.Enabled = toolUpdate.Enabled = toolExmine.Enabled =toolPrint.Enabled= false;
                    Ergodic.SpliClear( spList );
                    Ergodic.SpliEnableFalse( spList );
                    Ergodic.TablePageEnableClear( pageList );
                    Ergodic.TablePageEnableFalse( pageList );
                    gridControl1.DataSource = null;
                    gridControl2.DataSource = null;
                    gridView1.OptionsBehavior.Editable = false;
                    gridView2.OptionsBehavior.Editable = false;
                    label9.Visible = false;
                }
                else
                    MessageBox.Show( "删除失败,请重试" );
            }
        }
        protected override void update ( )
        {
            base.update( );

            if ( label9.Visible == true )
                MessageBox.Show( "本单已审核,不允许更改" );
            else
            {
                Ergodic.SpliEnableTrue( spList );
                Ergodic.TablePageEnableTrue( pageList );
                gridView1.OptionsBehavior.Editable = true;
                gridView2.OptionsBehavior.Editable = true;
                ToolSelete.Enabled = toolAdd.Enabled = toolDelete.Enabled = toolUpdate.Enabled = toolExmine.Enabled =toolPrint.Enabled= false;
                toolSave.Enabled = toolCancel.Enabled = true;
                sign = "2";            
            }
        }
        protected override void save ( )
        {
            base.save( );

            gridView1.ClearColumnsFilter( );
            gridView2.ClearColumnsFilter( );
            gridView1.UpdateCurrentRow( );
            gridView2.UpdateCurrentRow( );
            tableQueryOne.AcceptChanges( );
            tableQueryTwo.AcceptChanges( );
            if ( tableQueryOne == null || tableQueryOne.Rows.Count < 1 )
            {
                MessageBox.Show( "单据必须有基本信息" );
                return;
            }
            result = _bll.Exists( _modelHeader.SHD001 );
            if ( result == true )
            {
                if ( sign == "1" )
                    generateOrder( );
            }
            variable( );
            result = _bll.Save( tableQueryOne ,tableQueryTwo ,_modelHeader );
            if ( result == true )
            {
                MessageBox.Show( "成功保存数据" );
                Ergodic.SpliEnableFalse( spList );
                Ergodic.TablePageEnableFalse( pageList );
                gridView1.OptionsBehavior.Editable = false;
                gridView2.OptionsBehavior.Editable = false;
                ToolSelete.Enabled = toolAdd.Enabled = toolDelete.Enabled = toolUpdate.Enabled = toolExmine.Enabled =toolPrint.Enabled= true;
                toolSave.Enabled = toolCancel.Enabled = false;
            }
            else
                MessageBox.Show( "保存数据失败,请重试" );
        }
        void variable ( )
        {
            if ( lookUpEdit1.EditValue != null )
                _modelHeader.SHD002 = lookUpEdit1.EditValue.ToString( );
            _modelHeader.SHD003 = comboBox1.Text;
            _modelHeader.SHD004 = comboBox2.Text;
            _modelHeader.SHD005 = comboBox3.Text;
            _modelHeader.SHD006 = dateTimePicker1.Value;
            _modelHeader.SHD007 = textBox5.Text;
            _modelHeader.SHD008 = textBox6.Text;
        }
        protected override void cancel ( )
        {
            base.cancel( );

            if ( sign == "1" )
            {
                Ergodic.SpliClear( spList );
                Ergodic.SpliEnableFalse( spList );
                Ergodic.TablePageEnableClear( pageList );
                Ergodic.TablePageEnableFalse( pageList );
                gridControl1.DataSource = null;
                gridControl2.DataSource = null;
                gridView1.OptionsBehavior.Editable = false;
                gridView2.OptionsBehavior.Editable = false;
                label9.Visible = false;
                ToolSelete.Enabled = toolAdd.Enabled = true;
                toolSave.Enabled = toolCancel.Enabled = toolDelete.Enabled = toolUpdate.Enabled = toolExmine.Enabled =toolPrint.Enabled= false;
            }
            else if ( sign == "2" )
            {
                Ergodic.SpliEnableFalse( spList );
                Ergodic.TablePageEnableFalse( pageList );
                gridView1.OptionsBehavior.Editable = false;
                gridView2.OptionsBehavior.Editable = false;
                label9.Visible = false;
                ToolSelete.Enabled = toolAdd.Enabled = toolDelete.Enabled = toolUpdate.Enabled = toolExmine.Enabled =toolPrint.Enabled= true;
                toolSave.Enabled = toolCancel.Enabled = false;
            }
        }
        protected override void examine ( )
        {
            base.examine( );

            if ( label9.Visible == true )
            {
                result = _bll.UpdateOfExamin( "F" ,_modelHeader.SHD001 );
                if ( result == true )
                {
                    Ergodic.SpliEnableFalse( spList );
                    Ergodic.TablePageEnableFalse( pageList );
                    gridView1.OptionsBehavior.Editable = false;
                    gridView2.OptionsBehavior.Editable = false;
                    label9.Visible = false;
                    toolExmine.Text = "审核";
                    ToolSelete.Enabled = toolAdd.Enabled = toolDelete.Enabled = toolUpdate.Enabled = toolExmine.Enabled =toolPrint.Enabled= true;
                    toolSave.Enabled = toolCancel.Enabled =  false;
                }
                else
                {
                    MessageBox.Show( "撤审失败" );
                    label9.Visible = true;
                }
            }
            else
            {
                result = _bll.UpdateOfExamin( "T" ,_modelHeader.SHD001 );
                if ( result == true )
                {
                    label9.Visible = true;
                    toolExmine.Text = "撤审";
                    ToolSelete.Enabled = toolAdd.Enabled = toolExmine.Enabled =toolPrint.Enabled= true;
                    toolUpdate.Enabled = toolDelete.Enabled = toolSave.Enabled = toolCancel.Enabled = false;                 
                }
                else
                {
                    MessageBox.Show( "审核失败" );
                    label9.Visible = false;
                }
            }
        }
        protected override void print ( )
        {
            base.print( );

            Report report = new Report( );
            createTable( );
            string file = "";
            file = /*Environment.CurrentDirectory;*/System.Windows.Forms.Application.StartupPath;
            report.Load( file + "\\HengDa.frx" );
            report.RegisterData( RDataset );
            report.Show( );
        }
        #endregion

        #region Eveng
        void queryCom ( )
        {
            lookUpEdit1.Properties.DataSource = _bll.GetDataTableOnlyes( );
            lookUpEdit1.Properties.DisplayMember = "DFA002";
            lookUpEdit1.Properties.ValueMember = "DFA001";
            queryC = _bll.GetDataTableOnly( );
            comboBox1.DataSource = queryC.DefaultView.ToTable( true ,"SHD003" );
            comboBox1.DisplayMember = "SHD003";
            comboBox2.DataSource = queryC.DefaultView.ToTable( true ,"SHD004" );
            comboBox2.DisplayMember = "SHD004";
            comboBox3.DataSource = queryC.DefaultView.ToTable( true ,"SHD005" );
            comboBox3.DisplayMember = "SHD005";
        }
        private void repositoryItemButtonEdit1_Click ( object sender ,EventArgs e )
        {
            List<string> strList = new List<string>( );
            if ( gridView1.RowCount > 1 )
            {
                for ( int i = 0 ; i < gridView1.RowCount-1 ; i++ )
                {
                    if ( !string.IsNullOrEmpty( gridView1.GetDataRow( i )["SHE004"].ToString( ) ) && !string.IsNullOrEmpty( gridView1.GetDataRow( i )["SHE005"].ToString( ) ) )
                        strList.Add( gridView1.GetDataRow( i )["SHE004"].ToString( ) + gridView1.GetDataRow( i )["SHE005"].ToString( ) );
                }
            } 
            num = gridView1.FocusedRowHandle;
            HengDaOther.FormMainChoise choise = new HengDaOther.FormMainChoise( );
            choise.StartPosition = FormStartPosition.CenterScreen;
            choise.strList = strList;
            choise.PassDataBetweenForm += new HengDaOther.FormMainChoise.PassDataBetweenFormHandler( choise_PassDataBetweenForm );
            choise.ShowDialog( );
        }
        private void choise_PassDataBetweenForm ( object sender ,PassDataWinFormEventArgs e )
        {
            gridView1.SetRowCellValue( num ,gridView1.Columns["SHE004"] ,e.ConOne );
            gridView1.SetRowCellValue( num ,gridView1.Columns["SHE005"] ,e.ConFor );
            gridView1.SetRowCellValue( num ,gridView1.Columns["SHE006"] ,e.ConTwo );
            if ( string.IsNullOrEmpty( e.ConTre ) )
                gridView1.SetRowCellValue( num ,gridView1.Columns["SHE008"] ,0 );
            else
                gridView1.SetRowCellValue( num ,gridView1.Columns["SHE008"] ,Convert.ToDecimal( e.ConTre ) );
        }
        private void gridView1_InitNewRow ( object sender ,DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e )
        {
            _modelOne.SHE001 = _modelHeader.SHD001;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue( e.RowHandle ,view.Columns["SHE001"] ,_modelOne.SHE001 );
            view.SetRowCellValue( e.RowHandle ,view.Columns["SHE002"] ,"0001" );
            if ( gridView1.RowCount > 1 )
            {
                _modelOne.SHE003 = "";
                for ( int i = 0 ; i < gridView1.RowCount ; i++ )
                {
                    if ( i == 0 )
                        _modelOne.SHE003 = gridView1.GetDataRow( i )["SHE003"].ToString( );
                    else if ( i > 0 && i < gridView1.RowCount - 1 )
                    {
                        if ( !string.IsNullOrEmpty( gridView1.GetDataRow( i )["SHE003"].ToString( ) ) && !string.IsNullOrEmpty( _modelOne.SHE003 ) && Convert.ToInt32( gridView1.GetDataRow( i )["SHE003"].ToString( ) ) > Convert.ToInt32( _modelOne.SHE003 ) )
                            _modelOne.SHE003 = gridView1.GetDataRow( i )["SHE003"].ToString( );
                    }
                }

                if ( !string.IsNullOrEmpty( _modelOne.SHE003 ) )
                {
                    if ( Convert.ToInt32( _modelOne.SHE003 ) < 9 )
                        _modelOne.SHE003 = "00" + ( Convert.ToInt32( _modelOne.SHE003 ) + 1 ).ToString( );
                    else if ( Convert.ToInt32( _modelOne.SHE003 ) >= 9 && Convert.ToInt32( _modelOne.SHE003 ) < 99 )
                        _modelOne.SHE003 = "0" + ( Convert.ToInt32( _modelOne.SHE003 ) + 1 ).ToString( );
                    else if ( Convert.ToInt32( _modelOne.SHE003 ) >= 99  )
                        _modelOne.SHE003 =  ( Convert.ToInt32( _modelOne.SHE003 ) + 1 ).ToString( );
                    view.SetRowCellValue( e.RowHandle ,view.Columns["SHE003"] ,_modelOne.SHE003 );
                }
                else
                    view.SetRowCellValue( e.RowHandle ,view.Columns["SHE003"] ,"001" );
            }
            else
                view.SetRowCellValue( e.RowHandle ,view.Columns["SHE003"] ,"001" );
        }
        private void gridView1_CellValueChanged ( object sender ,DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e )
        {
            if ( e.Column.FieldName == "SHE005" )
            {
                string de = /*e.Value.ToString( );*/gridView1.GetFocusedRowCellValue( "SHE005" ).ToString( );
                DataRow[] rows = tableQuery.Select( string.Format( "QAA001='{0}'" ,de ) );
                if ( rows != null && rows.Length > 0 )
                {
                    DataRow row = rows[0];

                    gridView1.SetRowCellValue( e.RowHandle ,"SHE004" ,row["DEA002"].ToString( ) );                 
                    gridView1.SetRowCellValue( e.RowHandle ,"SHE006" ,row["DEA003"].ToString( ) );
                    if ( string.IsNullOrEmpty( row["DEA960"].ToString( ) ) )
                        gridView1.SetRowCellValue( e.RowHandle ,"SHE008" ,0 );
                    else
                        gridView1.SetRowCellValue( e.RowHandle ,"SHE008" ,Convert.ToDecimal( row["DEA960"].ToString( ) ) );
                }
            }
            if ( e.Column.FieldName == "SHE004" )
            {
                str = gridView1.GetDataRow( e.RowHandle )["SHE004"].ToString( );
                queryOther( );
            }
        }
        private void gridView1_KeyDown ( object sender ,KeyEventArgs e )
        {
            if ( gridView1.OptionsBehavior.Editable == true )
            {
                if ( e.KeyCode == Keys.Delete )
                {
                    int num = gridView1.FocusedRowHandle;
                    int count = gridView1.RowCount;
                    if ( num < 0 || num > gridView1.RowCount )
                        return;
                    gridView1.DeleteRow( num );
                    if ( gridView1.RowCount == 1 )
                    {
                        tableQueryTwo.Clear( );
                        gridControl2.DataSource = null;
                        return;
                    }
                    str = "";
                    //str = "'" + gridView1.GetDataRow( num )["SHE004"].ToString( ) + "'";
                    for ( int i = 0 ; i < gridView1.RowCount-1 ; i++ )
                    {
                        if ( str == "" )
                            str = "'" + gridView1.GetDataRow( i )["SHE004"].ToString( ) + "'";
                        else
                            str = str + "," + "'" + gridView1.GetDataRow( i )["SHE004"].ToString( ) + "'";
                    }
                   
                    queryOtherOne( );
                }
            }
        }
        private void gridView1_CustomDrawRowIndicator ( object sender ,DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e )
        {
            if ( e.Info.IsRowIndicator && e.RowHandle > -1 )
            {
                e.Info.DisplayText = ( e.RowHandle + 1 ).ToString( );
            }
        }
        private void gridView2_CustomDrawRowIndicator ( object sender ,DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e )
        {
            if ( e.Info.IsRowIndicator && e.RowHandle > -1 )
            {
                e.Info.DisplayText = ( e.RowHandle + 1 ).ToString( );
            }
        }
        #endregion

        #region OtherMethod
        void generateOrder ( )
        {
            tableQueryFor = _bll.GetDataTableOfOddNum( );
            if ( tableQueryFor != null && tableQueryFor.Rows.Count > 0 )
            {
                _modelHeader.SHD001 = tableQueryFor.Rows[0]["SHD001"].ToString( );
                if ( !string.IsNullOrEmpty( _modelHeader.SHD001 ) )
                {
                    if ( _modelHeader.SHD001.Substring( 0 ,8 ) == DateTime.Now.ToString( "yyyyMMdd" ) )
                        _modelHeader.SHD001 = ( Convert.ToInt64( _modelHeader.SHD001 ) + 1 ).ToString( );
                    else
                        _modelHeader.SHD001 = DateTime.Now.ToString( "yyyyMMdd" ) + "001";
                }
                else
                    _modelHeader.SHD001 = DateTime.Now.ToString( "yyyyMMdd" ) + "001";
            }
            else
                _modelHeader.SHD001 = DateTime.Now.ToString( "yyyyMMdd" ) + "001";

            //try
            //{
            //    _bll.AddOfOdd( _modelHeader.SHD001 );
            //}
            //catch { }
        }
        void choise ( )
        {
            tableQuery = _bll . GetDataTableOfChoise ( );
            repositoryItemSearchLookUpEdit1 . DataSource = tableQuery;
            repositoryItemSearchLookUpEdit1 . DisplayMember = "QAA001";
            repositoryItemSearchLookUpEdit1 . PopupFormSize = new System . Drawing . Size ( 1000 ,400 );
            
            //repositoryItemSearchLookUpEdit1View.Columns["QAA002"].Visible = false;
            //repositoryItemSearchLookUpEdit1View.Columns["DEA002"].Caption = "料件编号";
            //repositoryItemSearchLookUpEdit1View.Columns["DEA003"].Caption = "单位";
            //repositoryItemSearchLookUpEdit1View.Columns["DEA960"].Caption = "单价";
            //repositoryItemSearchLookUpEdit1View.Columns["QAA001"].Caption = "款号";
        }
        void refre ( )
        {
            tableQueryOne = _bll.GetDataTableOfOne( _modelHeader.SHD001 );
            gridControl1.DataSource = tableQueryOne;
            tableQueryTwo = _bll.GetDataTableOfTwo( _modelHeader.SHD001 );
            gridControl2.DataSource = tableQueryTwo;
        }
        void queryOther ( )
        {
            tableQueryTre = _bll.GetDataTableOfTwos( str );
            if ( tableQueryTre != null && tableQueryTre.Rows.Count > 0 )
            {
                for ( int i = 0 ; i < tableQueryTre.Rows.Count ; i++ )
                {
                    _modelTwo.SHF001 = _modelHeader.SHD001;
                    _modelTwo.SHF002 = "002";
                    _modelTwo.SHF004 = string.IsNullOrEmpty( tableQueryTre.Rows[i]["SHF004"].ToString( ) ) == true ? 0 : Convert.ToInt32( tableQueryTre.Rows[i]["SHF004"].ToString( ) );
                    _modelTwo.SHF005 = string.IsNullOrEmpty( tableQueryTre.Rows[i]["SHF005"].ToString( ) ) == true ? 0 : Convert.ToDecimal( tableQueryTre.Rows[i]["SHF005"].ToString( ) );
                    _modelTwo.SHF006 = string.IsNullOrEmpty( tableQueryTre.Rows[i]["SHF006"].ToString( ) ) == true ? 0 : Convert.ToInt32( tableQueryTre.Rows[i]["SHF006"].ToString( ) );
                    _modelTwo.SHF007 = tableQueryTre.Rows[i]["SHF007"].ToString( );
                    if ( tableQueryTwo.Select( "SHF007='" + _modelTwo.SHF007 + "'" ).Length > 0 )
                    {
                        row = tableQueryTwo.Select( "SHF007='" + _modelTwo.SHF007 + "'" )[0];
                        if ( !string.IsNullOrEmpty( tableQueryTwo.Select( "SHF007='" + _modelTwo.SHF007 + "'" )[0]["SHF004"].ToString( ) ) )
                        {
                            if ( _modelTwo.SHF004 > Convert.ToInt32( tableQueryTwo.Select( "SHF007='" + _modelTwo.SHF007 + "'" )[0]["SHF004"].ToString( ) ) )
                            {
                                row.BeginEdit( );
                                row["SHF001"] = _modelTwo.SHF001;
                                row["SHF002"] = _modelTwo.SHF002;
                                row["SHF004"] = _modelTwo.SHF004;
                                row["SHF005"] = _modelTwo.SHF005;
                                row["SHF006"] = _modelTwo.SHF006;
                                row.EndEdit( );
                            }
                        }
                        else
                        {
                            row.BeginEdit( );
                            row["SHF001"] = _modelTwo.SHF001;
                            row["SHF002"] = _modelTwo.SHF002;
                            row["SHF004"] = _modelTwo.SHF004;
                            row["SHF005"] = _modelTwo.SHF005;
                            row["SHF006"] = _modelTwo.SHF006;
                            row.EndEdit( );
                        }

                        if ( string.IsNullOrEmpty( tableQueryTwo.Select( "SHF007='" + _modelTwo.SHF007 + "'" )[0]["SHF003"].ToString( ) ) )
                        {
                            if ( !string.IsNullOrEmpty( tableQueryTwo.Compute( "max(SHF003)" ,null ).ToString( ) ) )
                            {
                                if ( Convert.ToInt32( tableQueryTwo.Compute( "max(SHF003)" ,null ).ToString( ) ) < 9 )
                                    _modelTwo.SHF003 = "00" + ( Convert.ToInt32( tableQueryTwo.Compute( "max(SHF003)" ,null ).ToString( ) ) + 1 ).ToString( );
                                else
                                    _modelTwo.SHF003 = "0" + ( Convert.ToInt32( tableQueryTwo.Compute( "max(SHF003)" ,null ).ToString( ) ) + 1 ).ToString( );
                            }
                            else
                                _modelTwo.SHF003 = "001";
                            row.BeginEdit( );
                            row["SHF003"] = _modelTwo.SHF003;
                            row.EndEdit( );
                        }
                    }
                    else
                    {
                        if ( tableQueryTwo != null && tableQueryTwo.Rows.Count > 0 )
                        {
                            if ( !string.IsNullOrEmpty( tableQueryTwo.Compute( "max(SHF003)" ,null ).ToString( ) ) )
                            {
                                if ( Convert.ToInt32( tableQueryTwo.Compute( "max(SHF003)" ,null ).ToString( ) ) < 9 )
                                    _modelTwo.SHF003 = "00" + ( Convert.ToInt32( tableQueryTwo.Compute( "max(SHF003)" ,null ).ToString( ) ) + 1 ).ToString( );
                                else
                                    _modelTwo.SHF003 = "0" + ( Convert.ToInt32( tableQueryTwo.Compute( "max(SHF003)" ,null ).ToString( ) ) + 1 ).ToString( );
                            }
                            else
                                _modelTwo.SHF003 = "001";

                            _modelTwo.SHF008 = "";
                            row = tableQueryTwo.NewRow( );
                            row["SHF001"] = _modelTwo.SHF001;
                            row["SHF002"] = _modelTwo.SHF002;
                            row["SHF003"] = _modelTwo.SHF003;
                            row["SHF004"] = _modelTwo.SHF004;
                            row["SHF005"] = _modelTwo.SHF005;
                            row["SHF006"] = _modelTwo.SHF006;
                            row["SHF007"] = _modelTwo.SHF007;
                            row["SHF008"] = _modelTwo.SHF008;
                            tableQueryTwo.Rows.Add( row );
                        }
                        else
                        {
                            _modelTwo.SHF003 = "001";
                            _modelTwo.SHF008 = "";
                            row = tableQueryTwo.NewRow( );
                            row["SHF001"] = _modelTwo.SHF001;
                            row["SHF002"] = _modelTwo.SHF002;
                            row["SHF003"] = _modelTwo.SHF003;
                            row["SHF004"] = _modelTwo.SHF004;
                            row["SHF005"] = _modelTwo.SHF005;
                            row["SHF006"] = _modelTwo.SHF006;
                            row["SHF007"] = _modelTwo.SHF007;
                            row["SHF008"] = _modelTwo.SHF008;
                            tableQueryTwo.Rows.Add( row );
                        }
                    }
                }
                gridControl2.DataSource = tableQueryTwo;
            }
        }
        void queryOtherOne ( )
        {
            if ( str == "" )
                return;
            tableQueryTre = _bll.GetDataTableOfTwoes( str );
            if ( tableQueryTre != null && tableQueryTre.Rows.Count > 0 )
            {
                List<string> intList = new List<string>( );
                for ( int k = 0 ; k < tableQueryTwo.Rows.Count ; k++ )
                {
                    _modelTwo.SHF007 = tableQueryTwo.Rows[k]["SHF007"].ToString( );
                    //row = tableQueryTwo.Select( "SHF007='" + _modelTwo.SHF007 + "'" )[0];
                    if ( tableQueryTre.Select( "SHF007='" + _modelTwo.SHF007 + "'" ).Length < 1 )
                    {
                        if ( !intList.Contains( _modelTwo.SHF007 ) )
                            intList.Add( _modelTwo.SHF007 );
                    }
                }
                if ( intList.Count > 0 )
                {
                    foreach ( string str in intList )
                    {
                        row = tableQueryTwo.Select( "SHF007='" + str + "'" )[0];
                        tableQueryTwo.Rows.Remove( row );
                    }
                }

                for ( int i = 0 ; i < tableQueryTre.Rows.Count ; i++ )
                {
                    _modelTwo.SHF007 = tableQueryTre.Rows[i]["SHF007"].ToString( );
                    _modelTwo.SHF004 = string.IsNullOrEmpty( tableQueryTre.Rows[i]["SHF004"].ToString( ) ) == true ? 0 : Convert.ToInt32( tableQueryTre.Rows[i]["SHF004"].ToString( ) );
                    if ( tableQueryTwo.Select( "SHF007='" + _modelTwo.SHF007 + "'" ).Length > 0 )
                    {
                        row = tableQueryTwo.Select( "SHF007='" + _modelTwo.SHF007 + "'" )[0];
                        row.BeginEdit( );
                        row["SHF004"] = _modelTwo.SHF004;
                        row.EndEdit( );
                    }
                }

            }
        }
        void createTable ( )
        {
            RDataset = new DataSet( );
            DataTable printOne = _bll.GetDataTablePrintOne( _modelHeader.SHD001 );
            DataTable printTwo = _bll.GetDataTablePrintTwo( _modelHeader.SHD001 );
            DataTable printTre = _bll.GetDataTablePrintTre( _modelHeader.SHD001 );
            printOne.TableName = "HDSHD";
            printTwo.TableName = "HDSHE";
            printTre.TableName = "HDSHF";
            RDataset.Tables.AddRange( new DataTable[] { printOne ,printTwo ,printTre } );
        }
        #endregion

        #region Query
        protected override void select ( )
        {
            base.select( );

            _modelHeader = new HengDaEntity.FormMainHeader( );
            HengDaOther.FormMainQuery query = new HengDaOther.FormMainQuery( );
            query.StartPosition = FormStartPosition.CenterScreen;
            query.PassDataBetweenForm += new HengDaOther.FormMainQuery.PassDataBetweenFormHandler( query_PassDataBetweenForm );
            query.ShowDialog( );

            if ( _modelHeader.SHD001 != null && _modelHeader.SHD001 != string.Empty )
                autoQuery( );
        }
        void autoQuery ( )
        {
            Ergodic.SpliClear( spList );
            Ergodic.SpliEnableFalse( spList );
            Ergodic.TablePageEnableClear( pageList );
            Ergodic.TablePageEnableFalse( pageList );
            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.Editable = false;

            _modelHeader = _bll.GetDataTable( _modelHeader.SHD001 );
            if ( _modelHeader == null )
                return;
            textBox1.Text = _modelHeader.SHD001;
            comboBox1.Text = _modelHeader.SHD003;
            comboBox2.Text = _modelHeader.SHD004;
            comboBox3.Text = _modelHeader.SHD005;
            if ( _modelHeader.SHD006 > DateTime.MinValue && _modelHeader.SHD006 < DateTime.MaxValue )
                dateTimePicker1.Value = _modelHeader.SHD006;
            textBox5.Text = _modelHeader.SHD007;
            textBox6.Text = _modelHeader.SHD008;
            if ( _modelHeader.SHD002 != null )
            {
                queryL = _bll.GetDataTableL( _modelHeader.SHD002 );
                if ( queryL != null && queryL.Rows.Count > 0 )
                    lookUpEdit1.Text = queryL.Rows[0]["DFA002"].ToString( );
            }
            refre( );
        }
        private void query_PassDataBetweenForm ( object sender ,PassDataWinFormEventArgs e )
        {
            _modelHeader.SHD001 = e.ConOne;
            if ( e.ConTwo.Trim( ) == "T" )
            {
                label9.Visible = true;
                toolExmine.Text = "撤审";
                ToolSelete.Enabled = toolAdd.Enabled = toolExmine.Enabled =toolPrint.Enabled= true;
                toolUpdate.Enabled = toolDelete.Enabled = toolSave.Enabled = toolCancel.Enabled = false;
            }
            else
            {
                label9.Visible = false;
                toolExmine.Text = "审核";
                ToolSelete.Enabled = toolAdd.Enabled = toolDelete.Enabled = toolUpdate.Enabled = toolExmine.Enabled =toolPrint.Enabled= true;
                toolSave.Enabled = toolCancel.Enabled = false;
            }
        }
        #endregion
    }
}

