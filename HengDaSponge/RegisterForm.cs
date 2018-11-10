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
using System.Management;
using System.IO;
using StringEncrypt;

namespace RegistrationCode
{
    public partial class RegisterForm : Form
    {
        public RegisterForm ( )
        {
            InitializeComponent( );
        }

        private void Form2_Load ( object sender ,EventArgs e )
        {
            DataTable dk = SqlHelper.ExecuteDataTable( "select distinct net_address from master.dbo.sysprocesses where program_name like 'SQLAgent%' and hostname=SERVERPROPERTY('MachineName') and net_address<>'000000000000'" );
            if ( dk != null && dk.Rows.Count > 0 )
                textBox1.Text = dk.Rows[0]["net_address"].ToString( );
        }

        int y = 0;
        //rgw_register
        private void button1_Click ( object sender ,EventArgs e )
        {
            if ( string.IsNullOrEmpty( textBox2.Text ) )
            {
                MessageBox.Show( "注册码不可为空" );
                return;
            }
            try
            {
                if ( textBox2.Text != new Encrypt( ).ToEncrypt( "8899" ,textBox1.Text ) )
                {
                    MessageBox.Show( "注册失败,请重新注册" );
                    return;
                }
                else
                {
                    bool result = SqlHelper.Exists( "SELECT COUNT(*) FROM master..sysobjects WHERE name='rgw_register'" );
                    if ( result == true )
                    {
                        DataTable dt = SqlHelper.ExecuteDataTable( "SELECT Regisnum FROM master.dbo.rgw_register" );
                        if ( dt != null && dt.Rows.Count > 0 )
                        {
                            if ( !string.IsNullOrEmpty( dt.Rows[0]["Regisnum"].ToString( ) ) )
                            {
                                y = SqlHelper.ExecuteNonQuery( "UPDATE [master].[dbo].[rgw_register]  SET Regisnum='" + textBox2.Text + "'" );
                                if ( y > 0 )
                                {
                                    MessageBox.Show( "注册成功,欢迎使用" );
                                    StartMainAppExe( "FormMain" );
                                    this.Close( );
                                }
                                else
                                {
                                    MessageBox.Show( "注册失败,请重新注册" );
                                    return;
                                }

                            }
                            else
                            {
                                y = SqlHelper.ExecuteNonQuery( "INSERT INTO [master].[dbo].[rgw_register] (Regisnum) VALUES ('" + textBox2.Text + "')" );
                                if ( y > 0 )
                                {
                                    MessageBox.Show( "注册成功,欢迎使用" );
                                    StartMainAppExe( "FormMain" );
                                    this.Close( );
                                }
                                else
                                {
                                    MessageBox.Show( "注册失败,请重新注册" );
                                    return;
                                }
                            }
                        }
                        else
                        {
                            y = SqlHelper.ExecuteNonQuery( "INSERT INTO [master].[dbo].[rgw_register] (Regisnum) VALUES ('" + textBox2.Text + "')" );
                            if ( y > 0 )
                            {
                                MessageBox.Show( "注册成功,欢迎使用" );
                                StartMainAppExe( "FormMain" );
                                this.Close( );
                            }
                            else
                            {
                                MessageBox.Show( "注册失败,请重新注册" );
                                return;
                            }
                        }
                    }
                    else
                    {
                        StringBuilder strSql = new StringBuilder( );
                        strSql.Append( "CREATE TABLE [master].[dbo].[rgw_register]([MACnum] [nvarchar](200) NULL,[Regisnum] [nvarchar](200) NOT NULL,) ON [PRIMARY]" );
                        int x = SqlHelper.ExecuteNonQuery( strSql.ToString( ) );
                        if ( x == -1 )
                        {
                            y = SqlHelper.ExecuteNonQuery( "INSERT INTO [master].[dbo].[rgw_register] (Regisnum) VALUES ('" + textBox2.Text + "')" );
                            if ( y > 0 )
                            {
                                MessageBox.Show( "注册成功,欢迎使用" );
                                StartMainAppExe( "FormMain" );
                                this.Close( );
                            }
                            else
                            {
                                MessageBox.Show( "注册失败,请重新注册" );
                                return;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show( "注册失败,请重试" );
                return;
            }         
        }
        private void button2_Click ( object sender ,EventArgs e )
        {
            this.Close( );
        }

        /// <summary>
        /// 开启主程序
        /// </summary>
        public void StartMainAppExe ( string appname )
        {
            string path = Application.StartupPath + "\\" + appname;
            bool sx = CheckFileExist( path );
            if ( CheckFileExist( path ) )
            {
                //System.Diagnostics.Process.Start(path);
                StartUpExe( path );
            }
            Application.Exit( );
        }

        /// <summary>
        /// 检测文件是否存在
        /// </summary>
        /// <returns></returns>
        protected bool CheckFileExist ( string path )
        {
            return File.Exists( path );
        }

        /// <summary>
        /// 以管理员权限运行程序
        /// </summary>
        /// <param name="path"></param>
        protected void StartUpExe ( string path )
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo( );
            startInfo.FileName = path;
            if ( Environment.OSVersion.Platform == PlatformID.Win32NT &&
                   Environment.OSVersion.Version.Major > 5 &&
                   Environment.OSVersion.Version.Minor > 0 )
            {//当操作系统是win7以上版本时，运行下面语句
                startInfo.Verb = "runas"; //以管理员权限运行
            }
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            System.Diagnostics.Process.Start( startInfo );
        }
    }
}
