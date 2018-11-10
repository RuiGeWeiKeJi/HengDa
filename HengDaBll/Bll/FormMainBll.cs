using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HengDaBll.Bll
{
    public class FormMainBll
    {
        Dao.FormMainDao _dao = new Dao.FormMainDao( );

        /// <summary>
        /// 获取最大单号
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOfOddNum ( )
        {
            return _dao.GetDataTableOfOddNum( );
        }

        /// <summary>
        /// 删除一单记录
        /// </summary>
        /// <param name="oddNum">单号</param>
        /// <returns></returns>
        public bool DeleteAll ( string oddNum )
        {
            return _dao.DeleteAll( oddNum );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOfChoise (  )
        {
            return _dao.GetDataTableOfChoise(  );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="oddNum">单号</param>
        /// <returns></returns>
        public DataTable GetDataTableOfOne ( string oddNum )
        {
            return _dao.GetDataTableOfOne( oddNum );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="oddNum">单号</param>
        /// <returns></returns>
        public DataTable GetDataTableOfTwo ( string oddNum )
        {
            return _dao.GetDataTableOfTwo( oddNum );
        }

        /// <summary>
        /// 是否存在此单号
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public bool Exists ( string oddNum )
        {
            return _dao.Exists( oddNum );
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
            return _dao.Save( tableOne ,tableTwo ,_modelHeader );
        }

        /// <summary>
        /// 写单号
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public bool AddOfOdd ( string oddNum )
        {
            return _dao.AddOfOdd( oddNum );
        }


        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOnly ( )
        {
            return _dao.GetDataTableOnly( );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableOnlys ( )
        {
            return _dao.GetDataTableOnlys( );
        }

        public DataTable GetDataTableOnlyes ( )
        {
            return _dao.GetDataTableOnlyes( );
        }

        /// <summary>
        /// 获取总记录数
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetCount ( string strWhere )
        {
            return _dao.GetCount( strWhere );
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
            return _dao.GetDataTableByChange( strWhere ,startIndex ,endIndex );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public HengDaEntity.FormMainHeader GetDataTable ( string oddNum )
        {
            return _dao.GetDataTable( oddNum );
        }


        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public DataTable GetDataTableL ( string num )
        {
            return _dao.GetDataTableL( num );
        }

        /// <summary>
        /// 更改审核状态
        /// </summary>
        /// <param name="state"></param>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public bool UpdateOfExamin ( string state ,string oddNum )
        {
            return _dao.UpdateOfExamin( state ,oddNum );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strList"></param>
        /// <returns></returns>
        public DataTable GetDataTableOfTwos ( string str )
        {
            return _dao.GetDataTableOfTwos( str );
        }
        public DataTable GetDataTableOfTwoes ( string str )
        {
            return _dao.GetDataTableOfTwoes( str );
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public DataTable GetDataTablePrintOne ( string oddNum )
        {
            return _dao.GetDataTablePrintOne( oddNum );
        }

        public DataTable GetDataTablePrintTwo ( string oddNum )
        {
            return _dao.GetDataTablePrintTwo( oddNum );
        }

        public DataTable GetDataTablePrintTre ( string oddNum )
        {
            return _dao.GetDataTablePrintTre( oddNum );
        }
    }
}
