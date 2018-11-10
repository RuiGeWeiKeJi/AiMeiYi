using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Collections;

namespace ProjectMamagerBll . Dao
{
    public class MainDao
    {
        public DataTable getTableForMain ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DKA001,DKA002 FROM TPADKA WHERE DKA001 NOT LIKE '@%' ORDER BY DKA001 " );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        public DataTable getTableForDetail ( string num )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT HBB004,CASE WHEN HBB006-HBB024=0 THEN '已采买' ELSE '未采'+CONVERT(VARCHAR,CONVERT(FLOAT,HBB006-HBB024))+'数量' END HBB,HDA960,CASE WHEN HDB019='T' THEN DGA002 ELSE '' END DGA002,CASE WHEN HDB019='T' THEN CONVERT(DECIMAL(11,2),HDA041) ELSE 0 END HDA041,CASE WHEN HDB019='T' THEN HDB010 ELSE '' END HDB010,HDA961,HDB960,HDB001,HDB002,HBA006 FROM DCSHBA A INNER JOIN DCSHBB B ON A.HBA001=B.HBB001 INNER JOIN DCSHDB C ON B.HBB001=C.HDB014 AND B.HBB002=C.HDB015 INNER JOIN DCSHDA D ON C.HDB001=D.HDA001 INNER JOIN TPADGA E ON D.HDA004=E.DGA001 WHERE HBB009 = 'T' AND HBA006='{0}'" ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        public bool save ( DataTable table )
        {
            Hashtable SQLString = new Hashtable ( );
            string oddNum, num, content;
            foreach ( DataRow row in table . Rows )
            {
                oddNum = row [ "HDB001" ] . ToString ( );
                num = row [ "HDB002" ] . ToString ( );
                content = row [ "HDB960" ] . ToString ( );
                save ( SQLString ,oddNum ,num ,content );
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        void save ( Hashtable SQLString ,string oddNum,string num,string content)
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "UPDATE DCSHDB SET HDB960='{0}' WHERE HDB001='{1}' AND HDB002='{2}'" ,content ,oddNum ,num );

            SQLString . Add ( strSql ,null );
        }

    }
}
