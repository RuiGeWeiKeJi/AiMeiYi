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
            strSql . Append ( "SELECT DKA001,DKA002 FROM TPADKA WHERE DKA008 LIKE '0000%' ORDER BY DKA001 " );//DKA001 NOT LIKE '@%' AND

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        public DataTable getTableForDetail ( string num )
        {
            StringBuilder strSql = new StringBuilder ( );
            //strSql . AppendFormat ( "SELECT HDA961,CASE WHEN HBB006-HBB024=0 THEN '已采买' ELSE '未采'+CONVERT(VARCHAR,CONVERT(FLOAT,HBB006-HBB024))+'数量' END HBB,CASE WHEN HDB019='T' THEN HDA960 ELSE '' END HDA960,CASE WHEN HDB019='T' THEN DGA002 ELSE '' END DGA002,CASE WHEN HDB019='T' THEN CONVERT(DECIMAL(11,2),HDA041) ELSE 0 END HDA041,CASE WHEN HDB019='T' THEN HDB010 ELSE '' END HDB010,HDA961,HDB960,HDB001,HDB002,HBA006 FROM DCSHBA A INNER JOIN DCSHBB B ON A.HBA001=B.HBB001 INNER JOIN DCSHDB C ON B.HBB001=C.HDB014 AND B.HBB002=C.HDB015 INNER JOIN DCSHDA D ON C.HDB001=D.HDA001 INNER JOIN TPADGA E ON D.HDA004=E.DGA001 WHERE HBB009 = 'T' AND HBA006='{0}'" ,num );

            strSql . AppendFormat ( "WITH CET AS (SELECT HDB001,HDB002,HDA961,CONVERT(FLOAT,SUM(ISNULL(HDB006,0))-SUM(ISNULL(HDB980,0))) HBB,HDA960,DGA002,CONVERT(FLOAT,HDA041) HDA041,HDB960 FROM DCSHBA A INNER JOIN DCSHBB B ON A.HBA001=B.HBB001 INNER JOIN DCSHDB C ON B.HBB001=C.HDB014 AND B.HBB002=C.HDB015 INNER JOIN DCSHDA D ON C.HDB001=D.HDA001 INNER JOIN TPADGA E ON D.HDA004=E.DGA001 WHERE HDB019 = 'T' AND HBA006='{0}' AND HDA021='T' GROUP BY HDA961,HDA960,DGA002,HDA041,HDB960,HDB001,HDB002) SELECT HDB001,HDB002,HDA961,HDA960,DGA002,HDA041,HDB960,CASE WHEN HBB=0 THEN '已采买' WHEN HBB>0 THEN '未采'+CONVERT(NVARCHAR(20),HBB)+'数量' ELSE '' END HBB FROM CET" ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        public DataTable tableOne ( string num )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "WITH CET AS (SELECT CONVERT(FLOAT,SUM(ISNULL(HDB006,0))-SUM(ISNULL(HDB980,0))) X, CONVERT(FLOAT,SUM(ISNULL(HDB006,0))-SUM(ISNULL(HDB018,0))) Y,CONVERT(FLOAT,CONVERT(DECIMAL(11,2),SUM(HDB033))) Z FROM DCSHDA A INNER JOIN DCSHDB B ON A.HDA001=B.HDB001 INNER JOIN TPADKA C ON A.HDA009=C.DKA001 INNER JOIN TPADEA D ON B.HDB003=D.DEA001 INNER JOIN DCSHBB E ON E.HBB001=B.HDB014 AND E.HBB002=B.HDB015 INNER JOIN DCSHBA F ON E.HBB001=F.HBA001 WHERE DEA009='P' AND HBA006='{0}') SELECT CASE WHEN X=0 THEN '已采买' WHEN X>0 THEN '未采'+CONVERT(NVARCHAR,X)+'数量' ELSE '' END X,CASE WHEN Y=0 THEN '已到货' WHEN Y>0 THEN '未到'+CONVERT(NVARCHAR,Y)+'数量' ELSE '' END Y,CASE WHEN Z IS NOT NULL AND Z!='' THEN Z ELSE NULL END Z FROM CET " ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        public DataTable tableTwo ( string num )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "WITH CET AS (SELECT CONVERT(FLOAT,SUM(ISNULL(HDB006,0))-SUM(ISNULL(HDB980,0))) X,CONVERT(FLOAT,SUM(ISNULL(HDB006,0))-SUM(ISNULL(HDB018,0))) Y,CONVERT(FLOAT,CONVERT(DECIMAL(11,2),SUM(HDB033))) Z FROM DCSHDA A INNER JOIN DCSHDB B ON A.HDA001=B.HDB001 INNER JOIN TPADKA C ON A.HDA009=C.DKA001 INNER JOIN TPADEA D ON B.HDB003=D.DEA001 INNER JOIN DCSHBB E ON E.HBB001=B.HDB014 AND E.HBB002=B.HDB015 INNER JOIN DCSHBA F ON E.HBB001=F.HBA001 WHERE DEA009='S' AND HBA006='{0}')  SELECT CASE WHEN X=0 THEN '已采买' WHEN X>0 THEN '未采'+CONVERT(NVARCHAR,X)+'数量' ELSE '' END X,CASE WHEN Y=0 THEN '已到货' WHEN Y>0 THEN '未到'+CONVERT(NVARCHAR,Y)+'数量' ELSE '' END Y,CASE WHEN Z IS NOT NULL AND Z!='' THEN Z ELSE NULL END Z FROM CET ;" ,num );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        public DataTable tableTre ( string num )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT CONVERT(FLOAT,CONVERT(DECIMAL(11,2),SUM(HDA041))) X FROM DCSHDA A  INNER JOIN DCSHDB B ON A.HDA001=B.HDB001 INNER JOIN TPADKA C ON A.HDA009=C.DKA001 INNER JOIN DCSHBB E ON E.HBB001=B.HDB014 AND E.HBB002=B.HDB015 INNER JOIN DCSHBA F ON E.HBB001=F.HBA001 WHERE HBA006='{0}' " ,num );

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
