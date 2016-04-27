using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBForward {
    public partial class index : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            //string sqlStr1 = "INSERT INTO Account (name, password, level) VALUES ('carpton', '123456', 0)";
            //string sqlStr2 = "INSERT INTO Account (name, password, level) VALUES (2, 'user1', '654321', 2)";
            //string sqlStr3 = "INSERT INTO Billboard (name, mission) VALUES ('carpton', 12)";
            //string sqlStr4 = "INSERT INTO Billboard (name, mission) VALUES ('user1', 3)";
            //string sqlStr5 = "if exists(select * from Account where A='A1' and B='B1') update t set c=100 where A='A1' and B='B1' else insert into t (A,B,C) Values('A1','B1',100)";
            //string sqlStr6 = "select row_number() over(order by mission desc) as rank,* from Billboard";
            //SqlAccess sa = new SqlAccess();
            //sa.ExecuteNonQuery(sqlStr1);
            //sa.ExecuteNonQuery(sqlStr2);
            //sa.ExecuteNonQuery(sqlStr3);
            //sa.ExecuteNonQuery(sqlStr4);
            //sa.sortByRowNumber(sqlStr6);
        }
    }
}