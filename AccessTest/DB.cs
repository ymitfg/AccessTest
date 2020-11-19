using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Resources;
using System.Data.Odbc;

namespace AccessTest
{
    class DB : SQLTestDB
    {

        public string serch = "ミヤノ";

        public DataTable SelectData()
        {
            //インスタンス生成
            var dt = new DataTable();
            var builder = new OleDbConnectionStringBuilder();

            //Accessプロバイダーを設定
            builder.Provider = DB_Resource.Provider;
            //Accessファイルへのパスを設定
            builder.DataSource = DB_Resource.Data_Source;

            using (var con = new OleDbConnection(builder.ConnectionString))
            {
                con.Open();

                using (var cmd = new OleDbCommand(Sql_Select(serch), con))
                {
                    using (var adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

    }

}
