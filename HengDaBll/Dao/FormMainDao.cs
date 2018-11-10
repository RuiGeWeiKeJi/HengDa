using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using StudentMgr;
using System.Collections;
using System.Data.SqlClient;

namespace HengDaBll.Dao
{
    public class FormMainDao
    {
        /// <summary>
        /// 获取最大单号
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOfOddNum ( )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT MAX(SHD001) SHD001 FROM HDSHD" );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        /// <summary>
        /// 删除一单记录
        /// </summary>
        /// <param name="oddNum">单号</param>
        /// <returns></returns>
        public bool DeleteAll ( string oddNum )
        {
            ArrayList SQLString = new ArrayList( );
            StringBuilder strSql = new StringBuilder( );
            strSql.AppendFormat( "DELETE FROM HDSHD WHERE SHD001='{0}'" ,oddNum );
            SQLString.Add( strSql.ToString( ) );
            strSql = new StringBuilder( );
            strSql.AppendFormat( "DELETE FROM HDSHE WHERE SHE001='{0}'" ,oddNum );
            SQLString.Add( strSql.ToString( ) );
            strSql = new StringBuilder( );
            strSql.AppendFormat( "DELETE FROM HDSHF WHERE SHF001='{0}'" ,oddNum );
            SQLString.Add( strSql.ToString( ) );

            return SqlHelper.ExecuteSqlTran( SQLString );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOfChoise (  )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT DEA002,DEA003,DEA960,QAA001,QAA001 QAA002 FROM TPADEA A INNER JOIN SGMQAA B ON A.DEA001=B.QAA001" );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="oddNum">单号</param>
        /// <returns></returns>
        public DataTable GetDataTableOfOne ( string oddNum )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT *,SHE004+SHE005 DE FROM HDSHE" );
            strSql.Append( " WHERE SHE001=@SHE001" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHE001",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = oddNum;

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) ,parameter );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="oddNum">单号</param>
        /// <returns></returns>
        public DataTable GetDataTableOfTwo ( string oddNum )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT * FROM HDSHF" );
            strSql.Append( " WHERE SHF001=@SHF001" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHF001",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = oddNum;

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) ,parameter );
        }

        /// <summary>
        /// 是否存在此单号
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public bool Exists ( string oddNum )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT COUNT(1) FROM HDSHD" );

            return SqlHelper.Exists( strSql.ToString( ) );
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="tableOne">单身一</param>
        /// <param name="tableTwo">单身二</param>
        /// <param name="_modelHeader">单头</param>
        /// <returns></returns>
        public bool Save ( DataTable tableOne ,DataTable tableTwo ,HengDaEntity.FormMainHeader _modelHeader )
        {
            using ( SqlConnection conn = new SqlConnection( SqlHelper.connstr ) )
            {
                conn.Open( );
                SqlCommand cmd = new SqlCommand( );
                cmd.Connection = conn;
                SqlTransaction tran = conn.BeginTransaction( );
                cmd.Transaction = tran;
                try
                {
                    ArrayList SQLString = new ArrayList( );
                    StringBuilder strSql = new StringBuilder( );
                    strSql.Append( "SELECT COUNT(1) FROM HDSHD WHERE SHD001=@SHD001" );
                    SqlParameter[] paramete = {
                        new SqlParameter("@SHD001",SqlDbType.NVarChar,20)
                    };
                    paramete[0].Value = _modelHeader.SHD001;
                    if ( SqlHelper.Exists( strSql.ToString( ) ,paramete ) == true )
                        UpdateMain( cmd ,_modelHeader ,strSql ,tran ,conn );
                    else
                        AddMain( cmd ,_modelHeader ,strSql ,tran ,conn );
                    DataTable tableChoisOne;
                    if ( tableOne != null && tableOne.Rows.Count > 0 )
                    {
                        HengDaEntity.FormMainOne _modelOne = new HengDaEntity.FormMainOne( );
                        _modelOne.SHE001 = /*tableOne.Rows[0]["SHE001"].ToString( );*/_modelHeader.SHD001;
                        tableChoisOne = SqlHelper.ExecuteDataTable( "SELECT SHE002,SHE003 FROM HDSHE WHERE SHE001='" + _modelOne.SHE001 + "'" );
                        for ( int i = 0 ; i < tableOne.Rows.Count ; i++ )
                        {
                            _modelOne.SHE002 = tableOne.Rows[i]["SHE002"].ToString( );
                            _modelOne.SHE003 = tableOne.Rows[i]["SHE003"].ToString( );
                            _modelOne.SHE004 = tableOne.Rows[i]["SHE004"].ToString( );
                            _modelOne.SHE005 = tableOne.Rows[i]["SHE005"].ToString( );
                            _modelOne.SHE006 = tableOne.Rows[i]["SHE006"].ToString( );
                            _modelOne.SHE007 = string.IsNullOrEmpty( tableOne.Rows[i]["SHE007"].ToString( ) ) == true ? 0 : Convert.ToInt32( tableOne.Rows[i]["SHE007"].ToString( ) );
                            _modelOne.SHE008 = string.IsNullOrEmpty( tableOne.Rows[i]["SHE008"].ToString( ) ) == true ? 0 : Convert.ToDecimal( tableOne.Rows[i]["SHE008"].ToString( ) );
                            _modelOne.SHE009 = tableOne.Rows[i]["SHE009"].ToString( );

                            if ( !string.IsNullOrEmpty( _modelOne.SHE004 ) && !string.IsNullOrEmpty( _modelOne.SHE005 ) )
                            {
                                if ( tableChoisOne.Select( "SHE002='" + _modelOne.SHE002 + "' AND SHE003='" + _modelOne.SHE003 + "'" ).Length > 0 )
                                    UpdateOne( cmd ,_modelOne ,strSql ,tran ,conn );
                                else
                                    AddOne( cmd ,_modelOne ,strSql ,tran ,conn );
                            }
                        }

                        if ( tableChoisOne != null && tableChoisOne.Rows.Count > 0 )
                        {
                            for ( int k = 0 ; k < tableChoisOne.Rows.Count ; k++ )
                            {
                                _modelOne.SHE002 = tableChoisOne.Rows[k]["SHE002"].ToString( );
                                _modelOne.SHE003 = tableChoisOne.Rows[k]["SHE003"].ToString( );
                                if ( tableOne.Select( "SHE001='" + _modelOne.SHE001 + "' AND SHE002='" + _modelOne.SHE002 + "' AND SHE003='" + _modelOne.SHE003 + "'" ).Length < 1 )
                                    DeleteOne( cmd ,_modelOne ,strSql ,tran ,conn );
                            }
                        }

                    }

                    if ( tableTwo != null && tableTwo.Rows.Count > 0 )
                    {
                        HengDaEntity.FormMainTwo _modelTwo = new HengDaEntity.FormMainTwo( );
                        _modelTwo.SHF001 =/* tableTwo.Rows[0]["SHF001"].ToString( )*/_modelHeader.SHD001;
                        tableChoisOne = SqlHelper.ExecuteDataTable( "SELECT SHF002,SHF003 FROM HDSHF WHERE SHF001='" + _modelTwo.SHF001 + "'" );
                        for ( int i = 0 ; i < tableTwo.Rows.Count ; i++ )
                        {
                            _modelTwo.SHF002 = tableTwo.Rows[i]["SHF002"].ToString( );
                            _modelTwo.SHF003 = tableTwo.Rows[i]["SHF003"].ToString( );
                            _modelTwo.SHF004 = string.IsNullOrEmpty( tableTwo.Rows[i]["SHF004"].ToString( ) ) == true ? 0 : Convert.ToInt32( tableTwo.Rows[i]["SHF004"].ToString( ) );
                            _modelTwo.SHF005 = string.IsNullOrEmpty( tableTwo.Rows[i]["SHF005"].ToString( ) ) == true ? 0 : Convert.ToDecimal( tableTwo.Rows[i]["SHF005"].ToString( ) );
                            _modelTwo.SHF006 = string.IsNullOrEmpty( tableTwo.Rows[i]["SHF006"].ToString( ) ) == true ? 0 : Convert.ToInt32( tableTwo.Rows[i]["SHF006"].ToString( ) );
                            _modelTwo.SHF007 = tableTwo.Rows[i]["SHF007"].ToString( );
                            _modelTwo.SHF008 = tableTwo.Rows[i]["SHF008"].ToString( );
                            if ( !string.IsNullOrEmpty( _modelTwo.SHF007 ) )
                            {
                                if ( tableChoisOne.Select( "SHF002='" + _modelTwo.SHF002 + "' AND SHF003='" + _modelTwo.SHF003 + "'" ).Length > 0 )
                                    UpdateTwo( cmd ,_modelTwo ,strSql ,tran ,conn );
                                else
                                    AddTwo( cmd ,_modelTwo ,strSql ,tran ,conn );
                            }
                        }

                        if ( tableChoisOne != null && tableChoisOne.Rows.Count > 0 )
                        {
                            for ( int k = 0 ; k < tableChoisOne.Rows.Count ; k++ )
                            {
                                _modelTwo.SHF002 = tableChoisOne.Rows[k]["SHF002"].ToString( );
                                _modelTwo.SHF003 = tableChoisOne.Rows[k]["SHF003"].ToString( );
                                if ( tableTwo.Select( "SHF001='" + _modelTwo.SHF001 + "' AND SHF002='" + _modelTwo.SHF002 + "' AND SHF003='" + _modelTwo.SHF003 + "'" ).Length < 1 )
                                    DeleteTwo( cmd ,_modelTwo ,strSql ,tran ,conn );
                            }
                        }
                    }

                    tran.Commit( );
                    return true;
                }
                catch {
                    tran.Rollback( );
                    return false;
                }
                finally
                {
                    cmd.Dispose( );
                    conn.Close( );
                }
            }
        }
        
        void UpdateMain ( SqlCommand cmd ,HengDaEntity.FormMainHeader _modelHeader ,StringBuilder strSql ,SqlTransaction tran ,SqlConnection conn )
        {
            strSql = new StringBuilder( );
            strSql.Append( "UPDATE HDSHD SET " );
            strSql.Append( "SHD002=@SHD002," );
            strSql.Append( "SHD003=@SHD003," );
            strSql.Append( "SHD004=@SHD004," );
            strSql.Append( "SHD005=@SHD005," );
            strSql.Append( "SHD006=@SHD006," );
            strSql.Append( "SHD007=@SHD007," );
            strSql.Append( "SHD008=@SHD008" );
            strSql.Append( " WHERE SHD001=@SHD001" );
            SqlParameter[] parameter = {
                        new SqlParameter("@SHD001",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD002",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD003",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD004",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD005",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD006",SqlDbType.DateTime),
                        new SqlParameter("@SHD007",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD008",SqlDbType.NVarChar,20)
                    };
            parameter[0].Value = _modelHeader.SHD001;
            parameter[1].Value = _modelHeader.SHD002;
            parameter[2].Value = _modelHeader.SHD003;
            parameter[3].Value = _modelHeader.SHD004;
            parameter[4].Value = _modelHeader.SHD005;
            parameter[5].Value = _modelHeader.SHD006;
            parameter[6].Value = _modelHeader.SHD007;
            parameter[7].Value = _modelHeader.SHD008;

            cmd.Parameters.Clear( );
            SqlHelper.PrepareCommand( cmd ,conn ,tran ,strSql.ToString( ) ,parameter );
            cmd.CommandText = strSql.ToString( );
            cmd.ExecuteNonQuery( );
        }
        void AddMain ( SqlCommand cmd ,HengDaEntity.FormMainHeader _modelHeader ,StringBuilder strSql ,SqlTransaction tran ,SqlConnection conn )
        {
            strSql = new StringBuilder( );
            strSql.Append( "INSERT INTO HDSHD (" );
            strSql.Append( "SHD001,SHD002,SHD003,SHD004,SHD005,SHD006,SHD007,SHD008)" );
            strSql.Append( " VALUES (" );
            strSql.Append( "@SHD001,@SHD002,@SHD003,@SHD004,@SHD005,@SHD006,@SHD007,@SHD008)" );
            SqlParameter[] parameter = {
                        new SqlParameter("@SHD001",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD002",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD003",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD004",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD005",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD006",SqlDbType.DateTime),
                        new SqlParameter("@SHD007",SqlDbType.NVarChar,20),
                        new SqlParameter("@SHD008",SqlDbType.NVarChar,20)
                    };
            parameter[0].Value = _modelHeader.SHD001;
            parameter[1].Value = _modelHeader.SHD002;
            parameter[2].Value = _modelHeader.SHD003;
            parameter[3].Value = _modelHeader.SHD004;
            parameter[4].Value = _modelHeader.SHD005;
            parameter[5].Value = _modelHeader.SHD006;
            parameter[6].Value = _modelHeader.SHD007;
            parameter[7].Value = _modelHeader.SHD008;

            cmd.Parameters.Clear( );
            SqlHelper.PrepareCommand( cmd ,conn ,tran ,strSql.ToString( ) ,parameter );
            cmd.CommandText = strSql.ToString( );
            cmd.ExecuteNonQuery( );
        }
        void UpdateOne ( SqlCommand cmd ,HengDaEntity.FormMainOne _modelOne ,StringBuilder strSql ,SqlTransaction tran ,SqlConnection conn )
        {
            strSql = new StringBuilder( );
            strSql.Append( "UPDATE HDSHE SET " );
            strSql.Append( "SHE004=@SHE004," );
            strSql.Append( "SHE005=@SHE005," );
            strSql.Append( "SHE006=@SHE006," );
            strSql.Append( "SHE007=@SHE007," );
            strSql.Append( "SHE008=@SHE008," );
            strSql.Append( "SHE009=@SHE009" );
            strSql.Append( " WHERE SHE001=@SHE001" );
            strSql.Append( " AND SHE002=@SHE002" );
            strSql.Append( " AND SHE003=@SHE003" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHE001",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE002",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE003",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE004",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE005",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE006",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE007",SqlDbType.Int),
                new SqlParameter("@SHE008",SqlDbType.Decimal,6),
                new SqlParameter("@SHE009",SqlDbType.NVarChar,255)
            };
            parameter[0].Value = _modelOne.SHE001;
            parameter[1].Value = _modelOne.SHE002;
            parameter[2].Value = _modelOne.SHE003;
            parameter[3].Value = _modelOne.SHE004;
            parameter[4].Value = _modelOne.SHE005;
            parameter[5].Value = _modelOne.SHE006;
            parameter[6].Value = _modelOne.SHE007;
            parameter[7].Value = _modelOne.SHE008;
            parameter[8].Value = _modelOne.SHE009;

            cmd.Parameters.Clear( );
            SqlHelper.PrepareCommand( cmd ,conn ,tran ,strSql.ToString( ) ,parameter );
            cmd.CommandText = strSql.ToString( );
            cmd.ExecuteNonQuery( );
        }
        void AddOne ( SqlCommand cmd ,HengDaEntity.FormMainOne _modelOne ,StringBuilder strSql ,SqlTransaction tran ,SqlConnection conn )
        {
            strSql = new StringBuilder( );
            strSql.Append( "INSERT INTO  HDSHE (" );
            strSql.Append( "SHE001,SHE002,SHE003,SHE004,SHE005,SHE006,SHE007,SHE008,SHE009)" );
            strSql.Append( " VALUES (" );
            strSql.Append( "@SHE001,@SHE002,@SHE003,@SHE004,@SHE005,@SHE006,@SHE007,@SHE008,@SHE009)" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHE001",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE002",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE003",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE004",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE005",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE006",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE007",SqlDbType.Int),
                new SqlParameter("@SHE008",SqlDbType.Decimal,6),
                new SqlParameter("@SHE009",SqlDbType.NVarChar,255)
            };
            parameter[0].Value = _modelOne.SHE001;
            parameter[1].Value = _modelOne.SHE002;
            parameter[2].Value = _modelOne.SHE003;
            parameter[3].Value = _modelOne.SHE004;
            parameter[4].Value = _modelOne.SHE005;
            parameter[5].Value = _modelOne.SHE006;
            parameter[6].Value = _modelOne.SHE007;
            parameter[7].Value = _modelOne.SHE008;
            parameter[8].Value = _modelOne.SHE009;

            cmd.Parameters.Clear( );
            SqlHelper.PrepareCommand( cmd ,conn ,tran ,strSql.ToString( ) ,parameter );
            cmd.CommandText = strSql.ToString( );
            cmd.ExecuteNonQuery( );
        }
        void DeleteOne ( SqlCommand cmd ,HengDaEntity.FormMainOne _modelOne ,StringBuilder strSql ,SqlTransaction tran ,SqlConnection conn )
        {
            strSql = new StringBuilder( );
            strSql.Append( "DELETE FROM HDSHE" );
            strSql.Append( " WHERE SHE001=@SHE001" );
            strSql.Append( " AND SHE002=@SHE002" );
            strSql.Append( " AND SHE003=@SHE003" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHE001",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE002",SqlDbType.NVarChar,20),
                new SqlParameter("@SHE003",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = _modelOne.SHE001;
            parameter[1].Value = _modelOne.SHE002;
            parameter[2].Value = _modelOne.SHE003;

            cmd.Parameters.Clear( );
            SqlHelper.PrepareCommand( cmd ,conn ,tran ,strSql.ToString( ) ,parameter );
            cmd.CommandText = strSql.ToString( );
            cmd.ExecuteNonQuery( );
        }
        void UpdateTwo ( SqlCommand cmd ,HengDaEntity.FormMainTwo _modelTwo ,StringBuilder strSql ,SqlTransaction tran ,SqlConnection conn )
        {
            strSql = new StringBuilder( );
            strSql.Append( "UPDATE HDSHF SET " );
            strSql.Append( "SHF004=@SHF004," );
            strSql.Append( "SHF005=@SHF005," );
            strSql.Append( "SHF006=@SHF006," );
            strSql.Append( "SHF007=@SHF007," );
            strSql.Append( "SHF008=@SHF008" );
            strSql.Append( " WHERE SHF001=@SHF001" );
            strSql.Append( " AND SHF002=@SHF002" );
            strSql.Append( " AND SHF003=@SHF003" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHF001",SqlDbType.NVarChar,20),
                new SqlParameter("@SHF002",SqlDbType.NVarChar,20),
                new SqlParameter("@SHF003",SqlDbType.NVarChar,20),
                new SqlParameter("@SHF004",SqlDbType.Int),
                new SqlParameter("@SHF005",SqlDbType.Decimal,6),
                new SqlParameter("@SHF006",SqlDbType.Int),
                new SqlParameter("@SHF007",SqlDbType.NVarChar,20),
                new SqlParameter("@SHF008",SqlDbType.NVarChar,255)
            };
            parameter[0].Value = _modelTwo.SHF001;
            parameter[1].Value = _modelTwo.SHF002;
            parameter[2].Value = _modelTwo.SHF003;
            parameter[3].Value = _modelTwo.SHF004;
            parameter[4].Value = _modelTwo.SHF005;
            parameter[5].Value = _modelTwo.SHF006;
            parameter[6].Value = _modelTwo.SHF007;
            parameter[7].Value = _modelTwo.SHF008;

            cmd.Parameters.Clear( );
            SqlHelper.PrepareCommand( cmd ,conn ,tran ,strSql.ToString( ) ,parameter );
            cmd.CommandText = strSql.ToString( );
            cmd.ExecuteNonQuery( );
        }
        void AddTwo ( SqlCommand cmd ,HengDaEntity.FormMainTwo _modelTwo ,StringBuilder strSql ,SqlTransaction tran ,SqlConnection conn )
        {
            strSql = new StringBuilder( );
            strSql.Append( "INSERT INTO  HDSHF (" );
            strSql.Append( "SHF001,SHF002,SHF003,SHF004,SHF005,SHF006,SHF007,SHF008)" );
            strSql.Append( " VALUES (" );
            strSql.Append( "@SHF001,@SHF002,@SHF003,@SHF004,@SHF005,@SHF006,@SHF007,@SHF008)" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHF001",SqlDbType.NVarChar,20),
                new SqlParameter("@SHF002",SqlDbType.NVarChar,20),
                new SqlParameter("@SHF003",SqlDbType.NVarChar,20),
                new SqlParameter("@SHF004",SqlDbType.Int),
                new SqlParameter("@SHF005",SqlDbType.Decimal,6),
                new SqlParameter("@SHF006",SqlDbType.Int),
                new SqlParameter("@SHF007",SqlDbType.NVarChar,20),
                new SqlParameter("@SHF008",SqlDbType.NVarChar,255)
            };
            parameter[0].Value = _modelTwo.SHF001;
            parameter[1].Value = _modelTwo.SHF002;
            parameter[2].Value = _modelTwo.SHF003;
            parameter[3].Value = _modelTwo.SHF004;
            parameter[4].Value = _modelTwo.SHF005;
            parameter[5].Value = _modelTwo.SHF006;
            parameter[6].Value = _modelTwo.SHF007;
            parameter[7].Value = _modelTwo.SHF008;

            cmd.Parameters.Clear( );
            SqlHelper.PrepareCommand( cmd ,conn ,tran ,strSql.ToString( ) ,parameter );
            cmd.CommandText = strSql.ToString( );
            cmd.ExecuteNonQuery( );
        }
        void DeleteTwo ( SqlCommand cmd ,HengDaEntity.FormMainTwo _modelTwo ,StringBuilder strSql ,SqlTransaction tran ,SqlConnection conn )
        {
            strSql = new StringBuilder( );
            strSql.Append( "DELETE FROM HDSHF" );
            strSql.Append( " WHERE SHF001=@SHF001" );
            strSql.Append( " AND SHF002=@SHF002" );
            strSql.Append( " AND SHF003=@SHF003" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHF001",SqlDbType.NVarChar,20),
                new SqlParameter("@SHF002",SqlDbType.NVarChar,20),
                new SqlParameter("@SHF003",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = _modelTwo.SHF001;
            parameter[1].Value = _modelTwo.SHF002;
            parameter[2].Value = _modelTwo.SHF003;

            cmd.Parameters.Clear( );
            SqlHelper.PrepareCommand( cmd ,conn ,tran ,strSql.ToString( ) ,parameter );
            cmd.CommandText = strSql.ToString( );
            cmd.ExecuteNonQuery( );
        }

        /// <summary>
        /// 写单号
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public bool AddOfOdd ( string oddNum )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "INSERT INTO HDSHG (" );
            strSql.Append( "SHG001)" );
            strSql.Append( " VALUES (" );
            strSql.Append( "@SHG001)" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHG001",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = oddNum;

            int row = SqlHelper.ExecuteNonQuery( strSql.ToString( ) ,parameter );
            if ( row > 0 )
                return true;
            else
                return false;
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOnly ( )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT DISTINCT SHD001,SHD003,SHD004,SHD005,SHD006,SHD009 FROM HDSHD" );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOnlys ( )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT DISTINCT DFA001,DFA002 FROM HDSHD A LEFT JOIN TPADFA B ON SHD002=DFA001" );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        public DataTable GetDataTableOnlyes ( )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT DFA001,DFA002 FROM TPADFA" );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        /// <summary>
        /// 获取总记录数
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetCount ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT COUNT(1) FROM  HDSHD" );

            Object obj = SqlHelper.GetSingle( strSql.ToString( ) );
            if ( obj == null )
                return 0;
            else
                return Convert.ToInt32( obj );
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public DataTable GetDataTableByChange ( string strWhere ,int startIndex ,int endIndex )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT DISTINCT SHD001,DFA002,SHD003,SHD004,SHD005,SHD006,SHD009 FROM (" );
            strSql.Append( "SELECT ROW_NUMBER() OVER (" );
            strSql.Append( "ORDER BY T.SHD001 DESC" );
            strSql.Append( ") AS Row,T.* FROM HDSHD T" );
            strSql.Append( ") TT LEFT JOIN TPADFA B ON TT.SHD002=B.DFA001" );
            strSql.AppendFormat( " WHERE TT.Row BETWEEN {0} AND {1}" ,startIndex ,endIndex );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public HengDaEntity.FormMainHeader GetDataTable ( string oddNum )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT SHD001,SHD002,SHD003,SHD004,SHD005,SHD006,SHD007,SHD008,SHD009 FROM HDSHD" );
            strSql.Append( " WHERE SHD001=@SHD001" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHD001",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = oddNum;

            DataTable da = SqlHelper.ExecuteDataTable( strSql.ToString( ) ,parameter );
            if ( da != null && da.Rows.Count > 0 )
                return GetModel( da.Rows[0] );
            else
                return null;
        }

        public HengDaEntity.FormMainHeader GetModel ( DataRow row )
        {
            HengDaEntity.FormMainHeader _model = new HengDaEntity.FormMainHeader( );

            if ( row != null )
            {
                if ( row["SHD001"] != null && row["SHD001"].ToString( ) != "" )
                    _model.SHD001 = row["SHD001"].ToString( );
                if ( row["SHD002"] != null && row["SHD002"].ToString( ) != "" )
                    _model.SHD002 = row["SHD002"].ToString( );
                if ( row["SHD003"] != null && row["SHD003"].ToString( ) != "" )
                    _model.SHD003 = row["SHD003"].ToString( );
                if ( row["SHD004"] != null && row["SHD004"].ToString( ) != "" )
                    _model.SHD004 = row["SHD004"].ToString( );
                if ( row["SHD005"] != null && row["SHD005"].ToString( ) != "" )
                    _model.SHD005 = row["SHD005"].ToString( );
                if ( row["SHD006"] != null && row["SHD006"].ToString( ) != "" )
                    _model.SHD006 = DateTime.Parse( row["SHD006"].ToString( ) );
                if ( row["SHD007"] != null && row["SHD007"].ToString( ) != "" )
                    _model.SHD007 = row["SHD007"].ToString( );
                if ( row["SHD008"] != null && row["SHD008"].ToString( ) != "" )
                    _model.SHD008 = row["SHD008"].ToString( );
                if ( row["SHD009"] != null && row["SHD009"].ToString( ) != "" )
                    _model.SHD009 = row["SHD009"].ToString( );
            }

            return _model;
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable GetDataTableL ( string num )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.AppendFormat( "SELECT DFA002 FROM TPADFA WHERE DFA001='{0}'" ,num );


            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        /// <summary>
        /// 更改审核状态
        /// </summary>
        /// <param name="state"></param>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public bool UpdateOfExamin ( string state ,string oddNum )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "UPDATE HDSHD SET SHD009=@SHD009" );
            strSql.Append( " WHERE SHD001=@SHD001" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHD009",SqlDbType.NChar,10),
                new SqlParameter("@SHD001",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = state;
            parameter[1].Value = oddNum;

            int row = SqlHelper.ExecuteNonQuery( strSql.ToString( ) ,parameter );
            if ( row > 0 )
                return true;
            else
                return false;
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strList"></param>
        /// <returns></returns>
        public DataTable GetDataTableOfTwos ( string str )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT SHF007,MAX(SHF004) SHF004,SHF005,SHF006 FROM (SELECT (SELECT DEA002 FROM TPADEA WHERE DEA001=QAA001 AND" );
            strSql.Append( " DEA002=@DEA002 ) SH,(SELECT DEA002 FROM TPADEA WHERE DEA001=QAB003) SHF007,CONVERT(INT,MAX(QAB005)) SHF004,QAB960 SHF006,QAB961 SHF005 FROM  SGMQAA A LEFT JOIN SGMQAB B ON A.QAA001=B.QAB001 WHERE QAB005 IS NOT NULL GROUP BY QAB960,QAB961,QAA001,QAB003" );
            strSql.Append( " ) A WHERE SH IS NOT NULL GROUP BY SHF007,SHF005,SHF006" );
            SqlParameter[] parameter = {
                new SqlParameter("@DEA002",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = str;

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) ,parameter );
        }

        public DataTable GetDataTableOfTwoes ( string str )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT SHF007,MAX(SHF004) SHF004,SHF005,SHF006 FROM (SELECT (SELECT DEA002 FROM TPADEA WHERE DEA001=QAA001 AND" );
            strSql.Append( " DEA002 IN ("+str+") ) SH,(SELECT DEA002 FROM TPADEA WHERE DEA001=QAB003) SHF007,CONVERT(INT,MAX(QAB005)) SHF004,QAB960 SHF005,QAB961 SHF006 FROM  SGMQAA A LEFT JOIN SGMQAB B ON A.QAA001=B.QAB001 WHERE QAB005 IS NOT NULL GROUP BY QAB960,QAB961,QAA001,QAB003" );
            strSql.Append( " ) A WHERE SH IS NOT NULL GROUP BY SHF007,SHF005,SHF006" );

            return SqlHelper.ExecuteDataTable( strSql.ToString( )  );
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public DataTable GetDataTablePrintOne ( string oddNum )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT SHD001,DFA002,SHD003,SHD004,SHD005,CONVERT(VARCHAR(20),SHD006,102) SHD006,SHD007,SHD008 FROM HDSHD A LEFT JOIN TPADFA B ON A.SHD002=B.DFA001" );
            strSql.Append( " WHERE SHD001=@SHD001" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHD001",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = oddNum;

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) ,parameter );
        }

        public DataTable GetDataTablePrintTwo ( string oddNum )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT SHE001,SHE002,SHE003,SHE004,SHE005,SHE006,SHE007,SHE008,SHE007*SHE008 SHE,SHE009 FROM HDSHE" );
            strSql.Append( " WHERE SHE001=@SHE001" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHE001",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = oddNum;

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) ,parameter );
        }

        public DataTable GetDataTablePrintTre ( string oddNum )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT SHF001,SHF002,SHF003,SHF004,SHF005,SHF006,SHF007,SHF008 FROM HDSHF" );
            strSql.Append( " WHERE SHF001=@SHF001" );
            SqlParameter[] parameter = {
                new SqlParameter("@SHF001",SqlDbType.NVarChar,20)
            };
            parameter[0].Value = oddNum;

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) ,parameter );
        }
    }
}
