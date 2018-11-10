using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringEncrypt;

namespace HengDaSponge
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main ( )
        {
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            if ( new Encrypt ( ) . registerYesOrNo ( ) == false )
                Application . Run ( new RegistrationCode . RegisterForm ( ) );
            else
                Application . Run( new FormMain( ) );
        }
    }
}
