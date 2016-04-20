using System.Data;
using System.Data.SqlClient;

namespace DBForward {
    public class SqlAccess {
        //SqlConnection conn;
        //SqlCommand cmd;
        string connStr = "User ID=ykuneifdnmlehabf;Password=uj2QZZqC4MdVHmVjJsTWfqJ6REDascimUoeeRbGhhtJEpyFuQrH6pohdG58uvpj2;Initial Catalog=db3802566bb9f043c2a561a5ec009027fe;Server=3802566b-b9f0-43c2-a561-a5ec009027fe.sqlserver.sequelizer.com";
        /*
        public SqlAccess() {
            conn = new SqlConnection();
            conn.ConnectionString = connStr;
        }

        public void open() {
            if(conn.State == ConnectionState.Closed) {
                conn.Open();
            }
        }

        public void close() {
            if(conn.State != ConnectionState.Closed) {
                conn.Close();
            }
        }

        private SqlConnection GetConn() {
            this.open();
            return conn;
        }*/

        public DataTable ExecuteDataTable(string sql, CommandType commandType) {
            return ExecuteDataTable(sql, commandType, null);
        }

        public DataTable ExecuteDataTable(string sql) {
            return ExecuteDataTable(sql, CommandType.Text, null);
        }

        /// <summary>  
        /// 执行一个查询，并返回查询结果
        /// </summary>  
        /// <param name="sql">要执行的sql语句</param>  
        /// <param name="commandtype">要执行查询语句的类型，如存储过程或者sql文本命令</param>  
        /// <param name="parameters">Transact-SQL语句或者存储过程参数数组</param>  
        /// <returns></returns>  
        public DataTable ExecuteDataTable(string sql, CommandType commandtype, SqlParameter[] parameters) {
            DataTable data = new DataTable(); //实例化datatable，用于装载查询结果集  
            using(SqlConnection con = new SqlConnection(connStr)) {
                using(SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.CommandType = commandtype;//设置command的commandType为指定的Commandtype  
                    //如果同时传入了参数，则添加这些参数  
                    if(parameters != null) {
                        foreach(SqlParameter parameter in parameters) {
                            cmd.Parameters.Add(parameter);
                        }
                    }

                    //通过包含查询sql的sqlcommand实例来实例化sqldataadapter  
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);//填充datatable  
                }
            }
            return data;
        }

        public int ExecuteNonQuery(string sql) {
            return ExecuteNonQuery(sql, CommandType.Text, null);
        }

        public int ExecuteNonQuery(string sql, CommandType commandType) {
            return ExecuteNonQuery(sql, commandType, null);
        }

        /// <summary>  
        /// 对数据库进行增删改的操作  
        /// </summary>  
        /// <param name="sql">要执行的sql语句</param>  
        /// <param name="commandType">要执行的查询语句类型，如存储过程或者sql文本命令</param>  
        /// <param name="parameters">Transact-SQL语句或者存储过程的参数数组</param>  
        /// <returns></returns>  
        public int ExecuteNonQuery(string sql, CommandType commandType, SqlParameter[] parameters) {
            int count = 0;
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = commandType;
            if(parameters != null) {
                foreach(SqlParameter parameter in parameters) {
                    cmd.Parameters.Add(parameter);
                }
            }

            con.Open();
            count = cmd.ExecuteNonQuery();
            con.Close();
            return count;
        }

        public void sortByRowNumber(string sql) {
            sortByRowNumber(sql, CommandType.Text, null);
        }

        public void sortByRowNumber(string sql, CommandType commandtype) {
            sortByRowNumber(sql, commandtype, null);
        }

        /// <summary>
        /// 关卡排名
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        public void sortByRowNumber(string sql, CommandType commandtype, SqlParameter[] parameters) {
            using(SqlConnection con = new SqlConnection(connStr)) {
                using(SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.CommandType = commandtype;
                    if(parameters != null) {
                        foreach(SqlParameter parameter in parameters) {
                            cmd.Parameters.Add(parameter);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>  
        /// 返回当前连接的数据库中所有用户创建的数据库  
        /// </summary>  
        /// <returns></returns>  
        public DataTable GetTables() {
            DataTable table = null;
            using(SqlConnection con = new SqlConnection(connStr)) {
                con.Open();
                table = con.GetSchema("Tables");
            }
            return table;
        }
    }
}