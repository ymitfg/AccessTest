using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessTest
{
    class SQLTestDB
    {
        //SELECT文
        public string Sql_Select(string serch)
        {
            string sql = "";

            sql += "SELECT EMP_NO AS 顧客番号,";
            sql += " C.L_NAME AS 氏,";
            sql += " C.F_NAME AS 名,";
            sql += " C.L_NAME_KANA + ' ' + C.F_NAME_KANA AS フリガナ,";
            sql += " A.CITY + A.KU AS 住所,";
            sql += " O.ORG_NAME AS 会社名,";
            sql += " AD.CITY + AD.KU  AS 会社住所,";
            sql += " D.DEP_NAME AS 所属課名";
            sql += " FROM  (((MST_CLIENT C";
            sql += " LEFT OUTER JOIN MST_ADR A";
            sql += " ON (C.ADR_CODE = A.ADR_CODE))";
            sql += " LEFT OUTER JOIN MST_ORG O";
            sql += " ON (C.ORG_CODE = O.ORG_CODE))";
            sql += " LEFT OUTER JOIN MST_ADR AD";
            sql += " ON (C.ORG_CODE = AD.ADR_CODE))";
            sql += " LEFT OUTER JOIN MST_DEP D";
            sql += " ON (C.DEP_CODE = D.DEP_CODE)";
            sql += " WHERE C.L_NAME_KANA LIKE '%" + serch + "%'";

            return sql;
        }
    }
}
